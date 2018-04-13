using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School
{
    public partial class FrmLoginmaster : Form
    {
        public FrmLoginmaster()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLoginID.Text == "")
            {
                MessageBox.Show("请输入账号!", "☆", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtLoginID.Focus();
                return;
            }
            if (txtLoginPwd.Text == "")
            {
                MessageBox.Show("请输入密码！", "☆", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtLoginPwd.Focus();
                return;
            }
            string sql = "select COUNT(*) from Master where M_ID='" + txtLoginID.Text + "'";
            if (!Sqlhelper.is_exists(sql))//为假 说明用户名错误
            {
                MessageBox.Show("账号错误请查证后登录", "友情提示");
                txtLoginID.Clear();
                txtLoginPwd.Clear();
                txtLoginID.Focus();
                return;
            }
            string sqm = "select COUNT(*) from Master where M_ID='" + txtLoginID.Text + "'and M_Pwd='" + txtLoginPwd.Text + "'";
            if (!Sqlhelper.is_exists(sqm))//为假 说明密码错误
            {
                MessageBox.Show("密码错误请查证后登录", "友情提示");
                txtLoginPwd.Clear();
                txtLoginPwd.Focus();
                return;
            }
            string strsql = "select COUNT(*) from Master where M_ID='" + txtLoginID.Text + "' and M_Pwd='" + txtLoginPwd.Text + "'";
            if (Sqlhelper.is_exists(strsql))
            {
                FrmMaster d = new FrmMaster();
                d.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmSchool f = new FrmSchool();
            f.Show();
            this.Hide();
        }

        private void FrmLoginmaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
