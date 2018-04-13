using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 商城
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string m = "";
            if (rdoMale.Checked == true)
            {
                m = "男";
            }
            else
            {
                m = "女";
            }
            if (txtCusId.Text == "")
            {
                MessageBox.Show("请填写客户代码，以方便您登陆", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusId.Focus();
                return;
            }
            if (txtCusPwd.Text == "")
            {
                MessageBox.Show("请填写客户密码,以方便您登陆", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusPwd.Focus();
                return;
            }
            if (txtCusPwdAgain.Text == "")
            {
                MessageBox.Show("请填写客户密码,以方便您登陆", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusPwdAgain.Focus();
                return;
            }
            if (txtCusName.Text == "")
            {
                MessageBox.Show("请填写客户姓名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusName.Focus();
                return;
            }
            if (txtCusPwd.Text == txtCusPwdAgain.Text)
            {
                DialogResult dr = MessageBox.Show("请你牢记你的账号和密码，确定注册！", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string strsql = "insert into customers values('" + txtCusId.Text + "','" + txtCusName.Text + "','" + txtCusPwd.Text + "','" + m + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "')";
                    try
                    {
                        Sqlhelper.insert(strsql);
                    }
                    catch (Exception) { }
                        MessageBox.Show("恭喜你注册成功，返回登录！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("两次密码不一致，请重新设定", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCusPwdAgain.Clear();
                    txtCusPwd.Clear();
                    txtCusPwd.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Hide();
        }

        private void FrmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
