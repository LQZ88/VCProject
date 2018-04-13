using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 商城
{
    public partial class Frmchangepassword : Form
    {
        public Frmchangepassword()
        {
            InitializeComponent();
        }

        private void btnchangeOk_Click(object sender, EventArgs e)
        {
            if (txtChangeCusid.Text == "")
            {
                MessageBox.Show("请填写账号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChangeCusid.Focus();
                return;
            }
            if (txtyuanpwd.Text == "")
            {
                MessageBox.Show("请输入密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtyuanpwd.Focus();
                return;
            }
            if (txtnewpwd.Text == "")
            {
                MessageBox.Show("请输入新密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnewpwd.Focus();
                return;
            }
            if (txtnewpwdagain.Text == "")
            {
                MessageBox.Show("请确认密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnewpwdagain.Focus();
                return;
            }
            string strsql = "update customers SET CusPassword='" + txtnewpwd.Text + "'where CusPassword='" + txtyuanpwd.Text + "'";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                if (txtnewpwd.Text == txtnewpwdagain.Text)
                {
                    MessageBox.Show("修改成功 ！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("两次密码不一致，重新输入", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnewpwd.Clear();
                    txtnewpwdagain.Clear();
                    txtnewpwd.Focus();
                }
            }
            catch (Exception) { }
            con.Close();
        }

        private void btnchangeCancel_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Hide();
        }

        private void Frmchangepassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
