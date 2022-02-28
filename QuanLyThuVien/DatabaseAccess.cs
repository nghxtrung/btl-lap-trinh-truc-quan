using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class DatabaseAccess
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        private SqlConnection sqlConnect = null;

        public void openConnect()
        {
            sqlConnect = new SqlConnection(connectionString);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        public void closeConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        public void updateData(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand();
            openConnect();
            sqlCommand.Connection = sqlConnect;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            closeConnect();
            sqlCommand.Dispose();
        }

        public void updateDataWithImage(string sql, string parameter, byte[] imageArray)
        {
            SqlCommand sqlCommand = new SqlCommand();
            openConnect();
            sqlCommand.Connection = sqlConnect;
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.AddWithValue(parameter, imageArray);
            sqlCommand.ExecuteNonQuery();
            closeConnect();
            sqlCommand.Dispose();
        }

        public DataTable dataReader(string sql)
        {
            DataTable dataResult = new DataTable();
            openConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlConnect);
            sqlData.Fill(dataResult);
            sqlData.Dispose();
            closeConnect();
            return dataResult;
        }
    }
}
