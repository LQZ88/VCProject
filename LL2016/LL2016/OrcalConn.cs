using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Collections.Generic;

namespace LL2016
{
    class OrcalConn
    {
        public static OracleConnection getConn()//连接字符串
        {
            OracleConnection con = new OracleConnection(@"Data source=orcl;user ID=jack;Password=java");
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据连接失败", "温馨提示");
            }
            finally
            {
                con.Close();
            }
            return con;
        }
        public static bool Insert(int s_id,string s_name,int s_age,string s_pwd) //添加
        {
            bool flag = false;
            OracleConnection conn = getConn();
            string sqlinsert = "inserrt into student(stuid,stuname,stuage,stupwd)values(:s_id,:s_name,:s_age,:s_pwd)";
            OracleCommand cmd = new OracleCommand(sqlinsert,conn);
            OracleParameter panid = new OracleParameter(":stuid",s_id);
            cmd.Parameters.Add(panid);
            OracleParameter panname = new OracleParameter(":stuname", s_name);
            cmd.Parameters.Add(panname);
            OracleParameter panage = new OracleParameter(":stuage", s_age);
            cmd.Parameters.Add(panage);
            OracleParameter panpwd = new OracleParameter(":stupwd", s_pwd);
            cmd.Parameters.Add(panpwd);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return flag;
        }
        public int update(string s_name, int s_age, string s_pwd, int s_id)//修改
        {
            OracleConnection con = getConn();
            string sqlupdate = "update student set stuname=:s_name,stuage=:s_age,stupwd=:s_pwd where stuid=:s_id";
            OracleCommand cmd = new OracleCommand(sqlupdate,con);
            OracleParameter panname = new OracleParameter(":stuname", s_name);
            cmd.Parameters.Add(panname);
            OracleParameter panage = new OracleParameter(":stuage", s_age);
            cmd.Parameters.Add(panage);
            OracleParameter panpwd = new OracleParameter(":stupwd", s_pwd);
            cmd.Parameters.Add(panpwd);
            OracleParameter panid = new OracleParameter(":stuid", s_id);
            cmd.Parameters.Add(panid);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }
        public static bool delete(string sqldelete,string Wid) //删除
        {
            bool flag = false;
            OracleConnection conn = getConn();
            OracleCommand cmd = new OracleCommand(sqldelete,conn);
            OracleParameter pendelete = new OracleParameter(":stuid", Wid);
            cmd.Parameters.Add(pendelete);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return flag;
        }
        public static DataTable select(string strsql)//查询
        {
            OracleConnection conn = getConn();
            OracleCommand cmd = new OracleCommand(strsql, conn);
            OracleDataAdapter od = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            od.Fill(ds);
            DataTable dt = ds.Tables[0];
            conn.Close();
            cmd.Dispose();
            return dt;
        }
        public bool Login(String wid, String wpassword)//登录
        {
            bool flag = false;
            OracleParameter[] par = { new OracleParameter("Wid", OracleType.VarChar, 20), new OracleParameter("Wpassword", OracleType.VarChar, 20), new OracleParameter() };
            return flag;
        }
    }
}
