using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Arsiv
{
   public class Yetkiler
    {
        public bool okuma(DataTable table)
        {
            bool okuma = false;
            okuma = bool.Parse(table.Rows[0]["okuma"].ToString());
            return okuma;
        }
        public bool ekleme(DataTable table, int i)
        {
            bool ekleme = bool.Parse(table.Rows[i]["ekleme"].ToString());
            return ekleme;
        }

        public bool silme(DataTable table,int i)
        {
            bool silme = bool.Parse(table.Rows[i]["silme"].ToString());
            return silme;
        }
        public bool guncelleme(DataTable table, int i)
        {
            bool guncelleme = bool.Parse(table.Rows[i]["guncelleme"].ToString());
            return guncelleme;
        }
    }
}
