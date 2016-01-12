using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibleProject.Classes.Text;
using MySql.Data.MySqlClient;

namespace BibleProject.Classes.Database
{
    internal class DatabaseConnection
    {

        private static int MySqlTableLength { get; set; }
        private static int SqlServerTableLength { get; set; }

        static Forms.frm_MainWindow mw;

        // MySQL
        public static void Open(Forms.frm_MainWindow _mw, string server, string database, string username, string password)
        {
            mw = _mw;
            using (MySqlConnection con = new MySqlConnection("Server="+server+";Database="+database+";Uid="+username+";Pwd="+password+";"))
            {
                CheckIfMySqlTableExists(con, database);
                if (MySqlTableLength == 0)
                {
                    InsertIntoMySqlDatabase(con);
                }
            }
        }

        // SQL Server
        public static void Open(Forms.frm_MainWindow _mw, string connectionString)
        {
            mw = _mw;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                CheckIfSqlServerTableExists(con);
                if (SqlServerTableLength == 0)
                {
                    InsertIntoSqlServerDatabase(con);
                }
            }
        }
        

        // MySql
        private static void CheckIfMySqlTableExists(MySqlConnection con, string dbName)
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand(Queries.MySql.CheckIfTableExists()))
            {
                cmd.Connection = con;

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r.GetString(0).Length > 0)
                    {
                        SqlServerTableLength = r.GetString(0).Length;
                    }
                }

                r.Close();

                if (MySqlTableLength == 0)
                {
                    cmd.CommandText = Queries.MySql.GetTableCreationString();
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        // Sql Server
        private static void CheckIfSqlServerTableExists(SqlConnection con)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(Queries.SqlServer.CheckIfTableExists()))
            {
                cmd.Connection = con;
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    if (r.GetString(0).Length > 0)
                    {
                        SqlServerTableLength = r.GetString(0).Length;
                    }
                }

                r.Close();
                
                if (SqlServerTableLength == 0)
                {
                    cmd.CommandText = Queries.SqlServer.GetTableCreationString();
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        // MySql
        private static void InsertIntoMySqlDatabase(MySqlConnection con)
        {
            con.Open();
            foreach (var fc in MemoryStorage.FullDataCollection[0].BibleCollection)
            {
                using (MySqlCommand cmd = new MySqlCommand(Queries.MySql.GetDataInsertionString()))
                {
                    cmd.Connection = con;
                    cmd.CommandTimeout = 999999;
                    cmd.Parameters.AddWithValue("Book", TextConverters.GetFullBookNameFromId(fc.CurrentBook));
                    cmd.Parameters.AddWithValue("Chapter", fc.Chapter);
                    cmd.Parameters.AddWithValue("Verse", fc.Verse);
                    cmd.Parameters.AddWithValue("Word", fc.Word);
                    cmd.ExecuteNonQuery();
                    mw.SetProgressBar();
                }
            }
            con.Close();
        }

        // Sql Server
        private static void InsertIntoSqlServerDatabase(SqlConnection con)
        {
            con.Open();
            foreach (var fc in MemoryStorage.FullDataCollection[0].BibleCollection)
            {
                using (SqlCommand cmd = new SqlCommand(Queries.SqlServer.GetDataInsertionString()))
                {
                    cmd.Connection = con;
                    cmd.CommandTimeout = 999999;
                    cmd.Parameters.AddWithValue("Book", TextConverters.GetFullBookNameFromId(fc.CurrentBook));
                    cmd.Parameters.AddWithValue("Chapter", fc.Chapter);
                    cmd.Parameters.AddWithValue("Verse", fc.Verse);
                    cmd.Parameters.AddWithValue("Word", fc.Word);
                    cmd.ExecuteNonQuery();
                    mw.SetProgressBar();
                }
            }
            con.Close();
        }
    }
}
