using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsiv
{
    public class Sql_Servis
  
        {

            public int Insert(string connection, string query, Dictionary<string, object> param = null, CommandType? commandType = null)
            {
                int sonuc = 0;
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    using (SqlCommand sqlcom = new SqlCommand(query, db))
                    {
                        if (commandType != null)
                            sqlcom.CommandType = commandType.Value;
                        if (param != null)
                            foreach (KeyValuePair<string, object> item in param)
                            {
                                sqlcom.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        sonuc = int.Parse(sqlcom.ExecuteScalar().ToString());
                    }
                }
                return sonuc;
            }

            public bool Delete(string connection, string query, Dictionary<string, object> param = null, CommandType? commandType = null)
            {
                bool sonuc = false;
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    using (SqlCommand sqlcom = new SqlCommand(query, db))
                    {
                        if (commandType != null)
                            sqlcom.CommandType = commandType.Value;
                        if (param != null)
                            foreach (KeyValuePair<string, object> item in param)
                            {
                                sqlcom.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        sonuc = sqlcom.ExecuteNonQuery() > 0 ? true : false;
                    }
                }
                return sonuc;
            }

            public int Update(string connection, string query, Dictionary<string, object> param = null, CommandType? commandType = null)
            {
                int sonuc = 0;
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    using (SqlCommand sqlcom = new SqlCommand(query, db))
                    {
                        if (commandType != null)
                            sqlcom.CommandType = commandType.Value;
                        if (param != null)
                            foreach (KeyValuePair<string, object> item in param)
                            {
                                sqlcom.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        sonuc = sqlcom.ExecuteNonQuery();
                    }
                }
                return sonuc;
            }
            public object SelectScalar(string connection, string query, Dictionary<string, object> param = null, CommandType? commandType = null)
            {
                object sonuc = 0;
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    using (SqlCommand sqlcom = new SqlCommand(query, db))
                    {
                        if (commandType != null)
                            sqlcom.CommandType = commandType.Value;
                        if (param != null)
                            foreach (KeyValuePair<string, object> item in param)
                            {
                                sqlcom.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        sonuc = sqlcom.ExecuteScalar();
                    }
                }
                return sonuc;
            }
            public DataTable SelectTable(string connection, string query, Dictionary<string, object> param = null, CommandType? commandType = null)
            {
                DataTable table = new DataTable();
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    using (SqlCommand sqlcom = new SqlCommand(query, db))
                    {
                        if (commandType != null)
                            sqlcom.CommandType = commandType.Value;
                        if (param != null)
                            foreach (KeyValuePair<string, object> item in param)
                            {
                                sqlcom.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        SqlDataReader reader = sqlcom.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                    }
                }
                return table;
            }
        }
    }
   