using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Linq; 

namespace Arsiv.DbConfig
{
    public partial class frmDbBaglanti : XtraForm
    {
        public frmDbBaglanti()
        {
            InitializeComponent(); 
        }
     
        public string baglanti = String.Empty;
        bool IsFirst = true;
        public bool IsDirty = false;
        private void DbBaglantiAyar_Load(object sender, EventArgs e)
        { 
            BaglantiOku();
           //fnYetkiler();
        }
      
        private void BaglantiOku()
        { 
            try
            {
                if (ConfigurationManager.AppSettings["Server"].ToString() != String.Empty || ConfigurationManager.AppSettings["Database"].ToString() != String.Empty
                    || ConfigurationManager.AppSettings["User"].ToString() != String.Empty || ConfigurationManager.AppSettings["Password"].ToString() != String.Empty)
                {
                    txtServer.Text = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Server"].ToString());
                    txtVeritabani.Text = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Database"].ToString());
                    txtKullanici.Text = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["User"].ToString());
                    txtSifre.Text = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Password"].ToString());
                    txtPort.Text = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Port"].ToString());
                    chkPort.Checked = bool.Parse(clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["DinamikPort"].ToString()));
                    IsFirst = false;
                }
            }
            catch (Exception ex)
            {
                
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void btnKaydetKapat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServer.Text.TrimEnd() == String.Empty || txtSifre.Text.TrimEnd() == String.Empty
                    || txtPort.Text.TrimEnd() == String.Empty || txtServer.Text.TrimEnd() == String.Empty || txtKullanici.Text.TrimEnd() == String.Empty)
                {
                    XtraMessageBox.Show("Alanları Doldurunuz!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SqlConnectionStringBuilder constr = new SqlConnectionStringBuilder();
                constr.DataSource = txtServer.Text + (chkPort.Checked == true ? "" : "," + txtPort.Text);
                constr.InitialCatalog = txtVeritabani.Text;
                constr.Password = txtSifre.Text;
                constr.UserID = txtKullanici.Text;

                SqlConnection sqlcon = new SqlConnection(constr.ConnectionString);
                sqlcon.Open();
                sqlcon.Close();

                baglanti = constr.ConnectionString;
                

                Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                config.AppSettings.Settings["Server"].Value = clsEncryptionHelper.Encrypt(txtServer.Text);
                config.AppSettings.Settings["Database"].Value = clsEncryptionHelper.Encrypt(txtVeritabani.Text);
                config.AppSettings.Settings["User"].Value = clsEncryptionHelper.Encrypt(txtKullanici.Text);
                config.AppSettings.Settings["Password"].Value = clsEncryptionHelper.Encrypt(txtSifre.Text);
                config.AppSettings.Settings["Port"].Value = clsEncryptionHelper.Encrypt(txtPort.Text);
                config.AppSettings.Settings["DinamikPort"].Value = clsEncryptionHelper.Encrypt(chkPort.Checked.ToString());
                //config.AppSettings.Settings["Program"].Value = clsEncryptionHelper.Encrypt(Assembly.GetExecutingAssembly().GetName().Name);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                clsGenel.Baglanti = constr.ConnectionString;
                clsGenel.Server = txtServer.Text;
                clsGenel.VtBilgi = txtVeritabani.Text;
                IsDirty = true;
                XtraMessageBox.Show(("Bağlantı başarılı,Ayarlar Kaydedildi!"), ("Uyarı"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ("Hata"), MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKullanici_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
