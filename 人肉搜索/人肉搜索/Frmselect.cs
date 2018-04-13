using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 人肉搜索
{
    public partial class Frmlogin : Form
    {
        
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sqlhelper.getValue("select Addres from Addres", cbodiqu);           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("关键字不能为空", "提 示", MessageBoxButtons.OK);
                txtname.Focus();
                return;
            }
            if (cbodiqu.Text == "")
            {
                MessageBox.Show("请选择省份", "提 示", MessageBoxButtons.OK);
                cbodiqu.Focus();
                return;
            }
            string strsql = "select Name 姓名,Sex 性别,Age 年龄,Addres 所在城市,TelephoneNo 电话,Biesday 生日,Happy 爱好 from Poples where Addres='" + cbodiqu.Text + "'and Name LIKE '%" + txtname.Text + "%'";
            try
            {
                dgvpoert.DataSource = Sqlhelper.select(strsql);
            }
            catch (Exception) { }
        }

        private void Frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsmlclose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出此系统吗?", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
                return;
        }
    } 
}
