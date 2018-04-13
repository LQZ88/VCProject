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
    public partial class FrmSchool : Form
    {
        public FrmSchool()
        {
            InitializeComponent();
        }

        private void btngoto_Click(object sender, EventArgs e)
        {
            if (rdostudent.Checked == false && rdoteacher.Checked == false && rdomaster.Checked == false)
            {
                DialogResult smd = MessageBox.Show("！请选择您的身份···", "★友情提示★", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (smd == DialogResult.Yes)
                {
                    rdostudent.Checked = true;
                }
            }
            else
            {
                string mtc = "";
                if (rdostudent.Checked)
                {
                    mtc += "学 生";
                    MessageBox.Show("正在进入学生登录界面┅┅", "☆友情链接☆");
                    FrmLoginstudent f = new FrmLoginstudent();
                    f.Show();
                    this.Hide();
                }
                if (rdoteacher.Checked)
                {
                    mtc += "教 师";
                    MessageBox.Show("正在进入教师登录界面┅┅", "☆友情链接☆");
                    FrmLoginteacher f = new FrmLoginteacher();
                    f.Show();
                    this.Hide();
                }
                if (rdomaster.Checked)
                {
                    mtc += "管理员";
                    MessageBox.Show("正在进入管理员登录界面┅┅", "☆友情链接☆");
                    FrmLoginmaster f = new FrmLoginmaster();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void btngoover_Click(object sender, EventArgs e)
        {
            DialogResult ms= MessageBox.Show("确认退出吗？", "☆温馨提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (ms == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FrmSchool_Shown(object sender, EventArgs e)
        {
            DialogResult sc = MessageBox.Show("欢迎使用校园系统\n这里将给你提供方便快捷的功能.", "校园提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (sc == DialogResult.OK)
            {
                new FrmSchool();
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmSchool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
