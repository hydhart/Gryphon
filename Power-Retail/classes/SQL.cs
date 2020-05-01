using System;
using System.Data;
using System.Data.SqlClient;


namespace PowerRetail.classes
{
    
    public static class SQL
    {
        private static SqlConnection conn = null;

        public static bool IsConnected()
        {
            return Connect();
        }

        private static bool Connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = null;
                ReadConfig(ref builder);
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private static bool Connect(ref SqlConnection conn)
        {
            try
            {
                SqlConnectionStringBuilder builder = null;
                ReadConfig(ref builder);
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private static void ReadConfig(ref SqlConnectionStringBuilder builder)
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQL2017";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "Sql2012#";      // update me
            builder.InitialCatalog = "Power Retail 0.1";
        }

        public static SqlDataReader ExecCommand(string query)
        {
            SqlConnection conn = null;
            try
            {
                if (Connect(ref conn))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;

                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        
        public static bool CloseConnection()
        {
            try
            {
                if(conn.State == ConnectionState.Open)
                    conn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
