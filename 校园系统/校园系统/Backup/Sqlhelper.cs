using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School
{
    class Sqlhelper
    {
        public static SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection("server=.;database=SchoolRun;Integrated Security=true");
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库未连接", "温馨提示" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
            return con;
        }
        public static DataTable select(string strsql)
        {
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet db = new DataSet();
            try
            {
                con.Open();
                sda.Fill(db);
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return db.Tables[0];
        }

        public static bool insert(string strsql)
        {
            bool flag = false;
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                if (com.ExecuteNonQuery() > 0)
                    flag = true;
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return flag;
        }

        public static bool update(string strsql)
        {
            bool flag = false;
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                if (com.ExecuteNonQuery() > 0)
                    flag = true;
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return flag;
        }

        public static bool delete(string strsql)
        {
            bool flag = false;
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                if (com.ExecuteNonQuery() > 0)
                    flag = true;
            }
            catch (Exception) { }
            finally
            {
                con.Close();
            }
            return flag;
        }
        public static void getValue(string strsql, ComboBox cboBox)
        {
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                //创建一个数据读取器
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())//只进读取
                {
                    cboBox.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch(Exception) { }
            finally
            {
                con.Close();
            }
        }
        public static bool is_exists(string sql)
        {
            bool flag = false;
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int rel = (int)cmd.ExecuteScalar();
                con.Close();
                if (rel > 0)
                    flag = true;
                else
                    flag = false;
            }
            catch (Exception) { }
            return flag;
        }
    }
}