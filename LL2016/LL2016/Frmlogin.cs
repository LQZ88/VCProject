using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace LL2016
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        public int stu_id;
        public string stu_name;
        public int stu_age;
        public int stu_pwd;
        private void Frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtstuid.Text.Trim() == "") 
            {
                txtstuid.Focus();
                return;
            }
            if (txtstupwd.Text.Trim() == "")
            {
                txtstupwd.Focus();
                return;
            }
            OracleConnection conn =OrcalConn.getConn();
            OracleCommand comm = new OracleCommand("select Wid ,Wpassword from WQQ where Wid='" + txtstuid.Text + "'and Wpassword='" + txtstupwd.Text + "'", conn);
            try
            {
                conn.Open();
                OracleDataReader sdr = comm.ExecuteReader();
                if (sdr.Read())
                {
                    Frmselect ss = new Frmselect();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("对不起，没有你的信息，请注册后登录！", "提 示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
            conn.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Application.DoEvents();
                Application.Exit();
            }
            else
                return;
        }
    }
}
