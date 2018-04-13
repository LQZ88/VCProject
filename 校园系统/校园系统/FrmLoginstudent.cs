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
    public partial class FrmLoginstudent : Form
    {
        public FrmLoginstudent()
        {
            InitializeComponent();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (txtLoginID.Text == "")
            {
                MessageBox.Show("请输入学号!");
                txtLoginID.Focus();
                return;
            }
            if (txtLoginPwd.Text == "")
            {
                MessageBox.Show("请输入密码！");
                txtLoginPwd.Focus();
                return;
            }
            string sql = "select COUNT(*) from Student where S_ID='" + txtLoginID.Text + "'";
            if (!Sqlhelper.is_exists(sql))//为假 说明用户名错误
            {
                MessageBox.Show("学号错误请查证后登录", "友情提示");
                txtLoginID.Clear();
                txtLoginPwd.Clear();
                txtLoginID.Focus();
                return;
            }
            string sqm = "select COUNT(*) from Student where S_ID='" + txtLoginID.Text + "' and S_pwd='" + txtLoginPwd.Text + "'";
            if (!Sqlhelper.is_exists(sqm))//为假 说明密码错误
            {
                MessageBox.Show("密码错误请查证后登录", "友情提示");
                txtLoginPwd.Clear();
                txtLoginPwd.Focus();
                return;
            }
            string strsql = "select COUNT(*) from Student where S_ID='" + txtLoginID.Text + "'and S_pwd='" + txtLoginPwd.Text + "'";
            if (Sqlhelper.is_exists(strsql))
            {
                FrmStudents f = new FrmStudents();
                f.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmSchool f = new FrmSchool();
            f.Show();
            this.Hide();
        }
        private void FrmLoginstudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lkblpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStudentChange_Password f = new FrmStudentChange_Password();
            f.Show();
            this.Hide();
        }
     }
}
