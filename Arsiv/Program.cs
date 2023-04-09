using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (ConfigurationManager.AppSettings["Server"].ToString() != String.Empty || ConfigurationManager.AppSettings["Database"].ToString() != String.Empty
                         || ConfigurationManager.AppSettings["User"].ToString() != String.Empty || ConfigurationManager.AppSettings["Password"].ToString() != String.Empty)
            {
                string server = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Server"].ToString());
                string veritabani = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Database"].ToString());
                string kullanici = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["User"].ToString());
                string sifre = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Password"].ToString());
                string port = clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["Port"].ToString());
                bool dinamik = String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DinamikPort"].ToString()) ? false : bool.Parse(clsEncryptionHelper.Decrypt(ConfigurationManager.AppSettings["DinamikPort"].ToString()));
                SqlConnectionStringBuilder constr = new SqlConnectionStringBuilder();
                constr.DataSource = server + (dinamik == true ? "" : "," + port);
                constr.InitialCatalog = veritabani;
                constr.Password = sifre;
                constr.UserID = kullanici;
                constr.ConnectTimeout = 120;

                clsGenel.Server = server;
                clsGenel.VtBilgi = veritabani;
                clsGenel.Baglanti = constr.ConnectionString;

                Login login = new Login();
                login.ShowDialog();

                if (login.IsLogged)
                {
                    Application.Run(new Anasayfa());
                }
                else
                    Application.Exit();
            }
            else
            {
                DbConfig.frmDbBaglanti dbform = new DbConfig.frmDbBaglanti();
                dbform.ShowDialog();
                if (dbform.baglanti == string.Empty)
                {
                    Application.Exit();
                }
                else
                    Application.Restart();
            } } 
        
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
           }
        
    }
}
