using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace DAL
{
  public class DBMysql
    {
        private static MySqlConnection  _connection;
      /// <summary>
      /// ��ȡ���ݿ�������
      /// </summary>
        private static MySqlConnection Connection
        {
            get
            {
               //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                string connectionString = "server=localhost;user id=root; password=root; database=system; pooling=false";
                //server=222.222.222.222;port=3306;uid=user;pwd=;database=basename;Զ�����ӵ�
                //string connectionString = "Data Source=202.192.72.22;Initial Catalog=wwj;Persist Security Info=True;User ID=wwj;Password=wwj123";
                if (_connection == null)
                {
                    _connection = new MySqlConnection(connectionString);
                    _connection.Open();
                }
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                if (_connection.State == ConnectionState.Broken)
                {
                    _connection.Close();
                    _connection.Open();
                }
                return _connection;
            }
        }
      /// <summary>
      /// ��ȡ������
      /// </summary>
      /// <param name="sql"></param>
      /// <returns></returns>
        public static MySqlDataReader GetDataRead(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            MySqlDataReader read = command.ExecuteReader();
            return read;
        }
        public static int NoSelect(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            int row = command.ExecuteNonQuery();
            return row;
        }
        public static DataTable GetDataTable(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(command);
            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// ִ��sql��䣬����һ��һ�С���
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns></returns>
        public static string GetScalar(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            return command.ExecuteScalar().ToString();
        }
    }
}