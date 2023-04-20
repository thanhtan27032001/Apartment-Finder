using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class DataProvider
    {
        private static DataProvider? instance;
        private string connectionStr = "Data Source=THANHTAN;Initial Catalog=DangTinThueTro;User ID=sa;Pwd=123456;";

        public static DataProvider Instance {
            get { 
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            } 
            private set => instance = value;
        }

        public DataProvider() { }
        public DataTable ExecuteQuerry(string query, object[]? parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string str in listPara)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameter[i]);
                            i++;
                        }
                    }
                }
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuerry(string query, object[]? parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string str in listPara)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameter[i]);
                            i++;
                        }
                    }
                }
                connection.Open();
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[]? parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string str in listPara)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameter[i]);
                            i++;
                        }
                    }
                }
                connection.Open();
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
