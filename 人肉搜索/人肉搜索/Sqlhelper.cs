using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 人肉搜索
{
    class Sqlhelper
    {
        public static SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection("server=.;database=SELECTPOPLE;Integrated Security=true");
            try
            {
                con.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("数据未连接","");
            }
            con.Close();
            return con;
        }
        public static DataTable select(string strsql)
        {
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds);
            }
            catch (Exception) { }
            con.Close();
            return ds.Tables[0];
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
                con.Close();
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
                con.Close();
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
                con.Close();
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
            catch (Exception) { }
            con.Close();
        }
    }
}
