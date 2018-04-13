using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace 游戏管理
{
    public partial class FrmGame : Form
    {
        public int id;
        public string name;
        public string type;
        public string gms;
        public int shoru;
        public FrmGame()
        {
            InitializeComponent();
        }
        public static SqlConnection getConn()//连接字符串
        {
            SqlConnection con = new SqlConnection("server=192.168.1.155;database=db_test;uid=sa;pwd=123");
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
        public static MySqlConnection getConnection()
        {
                //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                string connectionString = "server=localhost;user id=root; password=root; database=db_test; pooling=false";
                //server=222.222.222.222;port=3306;uid=user;pwd=;database=basename;远程连接的
                //string connectionString = "Data Source=202.192.72.22;Initial Catalog=wwj;Persist Security Info=True;User ID=wwj;Password=wwj123";
                MySqlConnection con = new MySqlConnection(connectionString);
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
        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FrmGame_Shown(object sender, EventArgs e)
        {
            dgvgame.Columns.Clear();
            string sql = "select id 'ID',gamename '游戏名',gametype '游戏类别',jiamengshang '加盟商',shoru '收入' from gameinfo";
            if (txtName.Text.Trim() != null && txtName.Text.Length>0)
            {
                string wh = sql.Substring(sql.Length-2, 2);
                if (wh.IndexOf("%") > 0)
                {
                    sql += " and";
                }
                else {
                    sql += " where";
                }
                sql += " gamename like '%" + txtName.Text.Trim() + "%'";
            }
            else if (txtType.Text.Trim() != null && txtType.Text.Length > 0)
            {
                string wh = sql.Substring(sql.Length - 2, 2);
                if (wh.IndexOf("%") > 0)
                {
                    sql += " and";
                }
                else
                {
                    sql += " where";
                }
                sql += " gametype like '%" + txtType.Text.Trim() + "%'";
            }
            else if (txtGMS.Text.Trim() != null && txtGMS.Text.Length > 0)
            {
                string wh = sql.Substring(sql.Length - 2, 2);
                if (wh.IndexOf("%") > 0)
                {
                    sql += " and";
                }
                else
                {
                    sql += " where";
                }
                sql += " jiamengshang like '%" + txtGMS.Text.Trim() + "%'";
            }
            MySqlConnection con = getConnection();
            MySqlCommand command = new MySqlCommand(sql, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(command);
            /*
            SqlConnection con = getConn();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);//数据适配器对象
            */
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dgvgame.DataSource = ds.Tables[0];
            DataGridViewLinkColumn btnModify = new DataGridViewLinkColumn();
            btnModify.HeaderText = "编辑";
            btnModify.Text = "编辑";
            btnModify.UseColumnTextForLinkValue = true;
            dgvgame.Columns.Add(btnModify);

            DataGridViewLinkColumn btnDel = new DataGridViewLinkColumn();
            btnDel.HeaderText = "删除";
            btnDel.Text = "删除";
            btnDel.UseColumnTextForLinkValue = true;
            dgvgame.Columns.Add(btnDel);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FrmGame_Shown(sender, e);
        }
        private void btnrload_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtType.Clear();
            txtGMS.Clear();
            txtShoru.Value = 0;
        }
        private void dgvgame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = (int)dgvgame.Rows[e.RowIndex].Cells[0].Value;//获取id
                string name = dgvgame.Rows[e.RowIndex].Cells[1].Value.ToString();//获取游戏名称
                string type = dgvgame.Rows[e.RowIndex].Cells[2].Value.ToString();//获取游戏类别
                string gms = dgvgame.Rows[e.RowIndex].Cells[3].Value.ToString();//获取游戏加盟商
                int shoru = (int)dgvgame.Rows[e.RowIndex].Cells[4].Value;//获取游戏收入
                //MessageBox.Show("编辑"+dgvGameInfo.Rows[e.RowIndex].Cells[0].Value);
                this.id = id;
                this.name = name;
                this.type = type;
                this.gms = gms;
                this.shoru = shoru;
                txtName.Text = this.name;
                txtType.Text = this.type;
                txtGMS.Text = this.gms;
                txtShoru.Value = this.shoru;
            }
            else if (e.ColumnIndex == 6)
            {
                // MessageBox.Show("删除" + dgvGameInfo.Rows[e.RowIndex].Cells[0].Value);
                int id = (int)dgvgame.Rows[e.RowIndex].Cells[0].Value;
                MySqlConnection con = getConnection();
                MySqlCommand cmd = new MySqlCommand("delete from gameinfo where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                /*
                SqlCommand cmd = new SqlCommand("delete from gameinfo where id=@id", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                */
                if (i == 1)
                {
                    MessageBox.Show("删除成功");
                    FrmGame_Shown(sender, e);//再次执行窗体的加载事件(方法)
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == ""||txtType.Text.Trim()==""||txtGMS.Text.Trim()=="")
            {
                MessageBox.Show("请完善信息","提示");
                return;
            }
            string sql = "insert into gameinfo(gamename,gametype,jiamengshang,shoru) values (@name,@type,@gms,@shoru)";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@type", txtType.Text.Trim());
            cmd.Parameters.AddWithValue("@gms", txtGMS.Text.Trim());
            cmd.Parameters.AddWithValue("@shoru", txtShoru.Text.Trim());
            /*
            SqlConnection con = getConn();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.Trim();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = txtType.Text.Trim();
            cmd.Parameters.Add("@gms", SqlDbType.VarChar).Value = txtGMS.Text.Trim();
            cmd.Parameters.Add("@shoru", SqlDbType.VarChar).Value=10000;
            */
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("添加成功");
                txtName.Clear();
                txtType.Clear();
                txtGMS.Clear();
                txtShoru.Value = 0;
                FrmGame_Shown(sender, e);
            }
            else
                MessageBox.Show("添加失败");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "update gameinfo set gamename=@name,gametype=@type,jiamengshang=@gms,shoru=@shoru where id=@id";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@type", txtType.Text.Trim());
            cmd.Parameters.AddWithValue("@gms", txtGMS.Text.Trim());
            cmd.Parameters.AddWithValue("@shoru", txtShoru.Text.Trim());
            cmd.Parameters.AddWithValue("@id", this.id);
            /*
            SqlConnection con = getConn();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.Trim();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = txtType.Text.Trim();
            cmd.Parameters.Add("@gms", SqlDbType.VarChar).Value = txtGMS.Text.Trim();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
            */
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("修改成功");
                txtName.Clear();
                txtType.Clear();
                txtGMS.Clear();
                txtShoru.Value = 0;
                FrmGame_Shown(sender, e);
            }
            else
                MessageBox.Show("修改失败");
        }

        private void times_Tick(object sender, EventArgs e)
        {
            FrmGame_Shown(sender, e);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txttime.Text.Trim() == "")
            {
                txttime.Focus();
                return;
            }
            times.Stop();
            int T=Int32.Parse(txttime.Text.Trim());
            int Time = T * 1000;
            times.Interval = Time;
            MessageBox.Show("设置成功","提示");
            times.Start();
        }

    }
}
