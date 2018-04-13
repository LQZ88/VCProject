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
    public partial class FrmStudentChange_Password : Form
    {
        public FrmStudentChange_Password()
        {
            InitializeComponent();
        }

        private void FrmStudentChange_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buTreturn_Click(object sender, EventArgs e)
        {

            FrmLoginstudent d = new FrmLoginstudent();
            d.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtS_ID.Clear();
            txtS_oldPwd.Clear();
            txtS_newPWd.Clear();
            txtS_newPwdok.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请输入学号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_ID.Focus();
                return;
            }
            if (txtS_oldPwd.Text == "")
            {
                MessageBox.Show("请输入原密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_oldPwd.Focus();
                return;
            }
            if (txtS_newPWd.Text == "")
            {
                MessageBox.Show("请输入新密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_newPWd.Focus();
                return;
            }
            if (txtS_newPwdok.Text == "")
            {
                MessageBox.Show("请再输入一次密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_newPwdok.Focus();
                return;
            }
            //判断用户是否存在
            string sql = "select COUNT(*) from Student where S_ID='" + txtS_ID.Text + "'";
            if (!Sqlhelper.is_exists(sql))//为假 说明用户名错误
            {
                MessageBox.Show("学号不存在,请重新输入", "温馨提示");
                txtS_ID.Clear();
                txtS_oldPwd.Clear();
                txtS_newPWd.Clear();
                txtS_newPwdok.Clear();
                txtS_ID.Focus();
                return;
            }
            string sqlm = "select COUNT(*) from Student where S_Pwd='" + txtS_oldPwd.Text + "'";
            if (!Sqlhelper.is_exists(sqlm))//为假 说明密码错误
            {
                MessageBox.Show("原密码错误,请重新输入", "温馨提示");
                txtS_oldPwd.Clear();
                txtS_newPWd.Clear();
                txtS_newPwdok.Clear();
                txtS_oldPwd.Focus();
                return;
            }
            string sqlUp = "update Student set S_Pwd='" + txtS_newPwdok.Text + "' where S_ID='" + txtS_ID.Text + "'";
            try
            {
                Sqlhelper.update(sqlUp);
                MessageBox.Show("修改成功", "温馨提示");
                txtS_ID.Clear();
                txtS_oldPwd.Clear();
                txtS_newPWd.Clear();
                txtS_newPwdok.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
