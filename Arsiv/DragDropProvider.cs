using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv
{
    public class DragDropProvider
    {
        Image draggedImage;
        PictureEdit edit;
        public string file_name = String.Empty;
        //"Resim Dosyaları (*.jpg, *.jpeg, *.bmp , *.emf , *.exif , *.gif , *.icon , *.png , *.tiff , *.wmf) | *.jpg; *.jpeg; *.bmp; *.emf; *.exif; *.gif; *.icon; *.png; *.tiff; *.wmf";
        public string extension = "jpg;jpeg;bmp;emf;exif;gif;icon;png;tiff;wmf";

        [DllImport("GdiPlus.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int GdipCreateBitmapFromGdiDib(IntPtr pBIH, IntPtr pPix, out IntPtr pBitmap);

        public DragDropProvider(PictureEdit edit)
        {
            this.edit = edit;
            edit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
        }

        public void EnableDragDrop()
        {
            edit.AllowDrop = true;
            edit.DragEnter += OnDragEnter;
            edit.DragDrop += OnDragDrop;
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            SetDragDropEffects(e);
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                edit.Image = draggedImage;
                draggedImage = null;
            }
        }

        private void SetDragDropEffects(DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileName != null)
            {
                try
                {
                    FileInfo fi = new FileInfo(fileName[0]);
                    string extend = fi.Extension.ToUpper();
                    bool IsExtension = false;
                    foreach (string item in extension.ToUpper().Split(';'))
                    {
                        if (!extend.Contains(item))
                        {
                            IsExtension = true;
                        }
                        else
                        {
                            IsExtension = false;
                            break;
                        }
                    }
                    if (IsExtension)
                        return;
                    FileStream fs = new FileStream(fileName[0], FileMode.Open,
                        FileAccess.Read, FileShare.ReadWrite);
                    int uzunluk = Convert.ToInt32(fs.Length);
                    byte[] content = new byte[uzunluk];
                    fs.Read(content, 0, uzunluk);
                    fs.Flush();
                    fs.Close();


                    MemoryStream stream = new MemoryStream(content, true);
                    draggedImage = Image.FromStream(stream);
                    e.Effect = DragDropEffects.Copy;
                    file_name = fileName[0];
                }
                catch
                {
                    draggedImage = null;
                }
            }
        }

        public Bitmap BitmapFromDIB(IntPtr pDIB)
        {

            IntPtr pPix = GetPixelInfo(pDIB);
            MethodInfo mi = typeof(Bitmap).GetMethod("FromGDIplus",
                            BindingFlags.Static | BindingFlags.NonPublic);
            if (mi == null) return null;
            IntPtr pBmp = IntPtr.Zero;
            int status = GdipCreateBitmapFromGdiDib(pDIB, pPix, out pBmp);
            if ((status == 0) && (pBmp != IntPtr.Zero))
                return (Bitmap)mi.Invoke(null, new object[] { pBmp });
            else
                return null;
        }


        private IntPtr GetPixelInfo(IntPtr bmpPtr)
        {
            BITMAPINFOHEADER bmi = (BITMAPINFOHEADER)Marshal.PtrToStructure(bmpPtr, typeof(BITMAPINFOHEADER));
            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = (uint)(((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight);
            int p = (int)bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount; p = (p * 4) + (int)bmi.biSize + (int)bmpPtr;
            return (IntPtr)p;
        }

        public void DisableDragDrop()
        {
            edit.DragEnter -= OnDragEnter;
            edit.DragDrop -= OnDragDrop;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;

        public void Init()
        {
            biSize = (uint)Marshal.SizeOf(this);
        }
    }
}

