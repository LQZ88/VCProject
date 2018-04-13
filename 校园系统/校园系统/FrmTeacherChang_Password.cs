using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class FrmTeacherChang_Password : Form
    {
        public FrmTeacherChang_Password()
        {
            InitializeComponent();
        }

        private void FrmTeacherChang_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTreturn_Click(object sender, EventArgs e)
        {
            FrmLoginteacher c = new FrmLoginteacher();
            c.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtT_nane.Clear();
            txtoldpwd.Clear();
            txtnewpwd.Clear();
            txtnewpwdok.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtT_nane.Text == "")
            {
                MessageBox.Show("请输入姓名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtT_nane.Focus();
                return;
            }
            if (txtoldpwd.Text == "")
            {
                MessageBox.Show("请输入原密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtoldpwd.Focus();
                return;
            }
            if (txtnewpwd.Text == "")
            {
                MessageBox.Show("请输入新密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtnewpwd.Focus();
                return;
            }
            if (txtnewpwdok.Text == "")
            {
                MessageBox.Show("请再输入一次密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtnewpwdok.Focus();
                return;
            }
            string sql = "select COUNT(*) from Teacher where T_Name='" + txtT_nane.Text + "'";
            if (!Sqlhelper.is_exists(sql))//为假 说明用户名错误
            {
                MessageBox.Show("姓名错误,请重新输入", "温馨提示");
                txtT_nane.Clear();
                txtoldpwd.Clear();
                txtnewpwd.Clear();
                txtnewpwdok.Clear();
                txtT_nane.Focus();
                return;
            }
            string sqld = "select COUNT(*) from Teacher where T_Pwd='" + txtoldpwd.Text + "'";
            if (!Sqlhelper.is_exists(sqld))//为假 说明密码错误
            {
                MessageBox.Show("密码错误,请重新输入", "温馨提示");
                txtoldpwd.Clear();
                txtnewpwd.Clear();
                txtnewpwdok.Clear();
                txtoldpwd.Focus();
                return;
            }
            string update = "Update Teacher set T_Pwd='" + txtnewpwdok.Text + "' where T_Name ='" + txtT_nane.Text + "'";
            try
            {
                Sqlhelper.update(update);
                DialogResult dm = MessageBox.Show("修改成功,点击确定返回登录", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dm == DialogResult.OK)
                {
                    FrmLoginteacher d = new FrmLoginteacher();
                    d.Show();
                    this.Hide();
                }
            }
            catch (Exception) { }
        }
    }
}