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
    public partial class FrmLoginteacher : Form
    {
        public FrmLoginteacher()
        {
            InitializeComponent();
        }

        private void FrmLoginteacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FrmLoginteacher_Load(object sender, EventArgs e)
        {
            Sqlhelper.getValue("select T_Position from Teacher_cate", cboLoginposition);
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (txtLoginname.Text == "")
            {
                MessageBox.Show("请输入姓名！", "★");
                txtLoginname.Focus();
                return;
            }
            if (txtLoginpwd.Text == "")
            {
                MessageBox.Show("请输入密码!", "★");
                txtLoginpwd.Focus();
                return;
            }
            string sql = "select COUNT(*) from Teacher where T_Name='" + txtLoginname.Text + "'";
            if (!Sqlhelper.is_exists(sql))//为假 说明用户名错误
            {
                MessageBox.Show("教师姓名错误请查证后登录", "友情提示");
                txtLoginname.Clear();
                txtLoginpwd.Clear();
                txtLoginname.Focus();
                return;
            }
            string sqm = "select COUNT(*) from Teacher where T_Name='" + txtLoginname.Text + "' and T_Pwd='" + txtLoginpwd.Text + "'";
            if (!Sqlhelper.is_exists(sqm))//为假 说明密码错误
            {
                MessageBox.Show("密码错误请查证后登录", "友情提示");
                txtLoginpwd.Clear();
                txtLoginpwd.Focus();
                return;
            }
            if (cboLoginposition.Text == "班主任")
            {
                string strsql = "select T_Name,T_Pwd,T_Position from Teacher where T_Name='" + txtLoginname.Text + "'and T_Pwd='" + txtLoginpwd.Text + "' and T_Position='" + cboLoginposition.Text + "'";
                SqlConnection con = Sqlhelper.getCon();
                SqlCommand com = new SqlCommand(strsql, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("正在登录┅┅");
                        FrmTeacher_Class f = new FrmTeacher_Class();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("确定你是班主任吗？", "友情提示");
                    }
                    sdr.Close();
                }
                catch (Exception) { }                
                con.Close();
            }
            else
            {
                string strsql = "select T_Name,T_Pwd,T_Position from Teacher where T_Name='" + txtLoginname.Text + "'and T_Pwd='" + txtLoginpwd.Text + "' and T_Position='" + cboLoginposition.Text + "'";
                SqlConnection con = Sqlhelper.getCon();
                SqlCommand com = new SqlCommand(strsql, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("正在登录┅┅");
                        FrmTeachers f = new FrmTeachers();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("确定你是教师吗？", "友情提示");
                    }
                    sdr.Close();
                }
                catch (Exception) { }
                con.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FrmSchool f = new FrmSchool();
            f.Show();
            this.Hide();
        }

        private void lblpwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTeacherChang_Password d = new FrmTeacherChang_Password();
            d.Show();
            this.Hide();
        }
    }
}
