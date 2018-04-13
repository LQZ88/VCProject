using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 商城
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLblzhuce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddCustomer f = new FrmAddCustomer();
            f.Show();
            this.Hide();
            Application.DoEvents();
        }

        private void linklblchangepwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmchangepassword f = new Frmchangepassword();
            f.Show();
            this.Hide();
            Application.DoEvents();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (txtLoginid.Text == "")
            {
                MessageBox.Show("账号不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginid.Focus();
                return;
            }
            if (txtloginPwd.Text == "")
            {
                MessageBox.Show("请输入密码！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtloginPwd.Focus();
                return;
            }
            if (cboBoxLoginType.Text == "")
            {
                MessageBox.Show("请选择登录类型", "提温馨示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBoxLoginType.Focus();
                return;
            }
            if (cboBoxLoginType.Text == "管理员")
            {
                string strsql = "select ConID,ConPassword from controllers where ConID='" + txtLoginid.Text + "'and ConPassword='" + txtloginPwd.Text + "'";
                SqlConnection con = Sqlhelper.getCon();
                SqlCommand com = new SqlCommand(strsql, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        FrmController f = new FrmController();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("亲，你没有管理员权限", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { }
                con.Close();
            }
            if (cboBoxLoginType.Text == "客户")
            {
                string strsql = "select CusId,CusPassword from customers where CusId='" + txtLoginid.Text + "'and CusPassword='" + txtloginPwd.Text + "'";
                SqlConnection con = Sqlhelper.getCon();
                SqlCommand com = new SqlCommand(strsql, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {
                        FrmCustomer f = new FrmCustomer();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("对不起，没有你的信息，请注册后登录！", "提 示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { }
                con.Close();
            }
        }

        private void bttnonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
                return;
        }

        #region 停靠悬浮
        internal AnchorStyles StopDock = AnchorStyles.None; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果鼠标在窗体上，则根据停靠位置显示整个窗体 
            if (this.Bounds.Contains(Cursor.Position))
            {
                switch (this.StopDock)
                {
                    case AnchorStyles.Top: this.Location = new Point(this.Location.X, 0);
                        break;
                    case AnchorStyles.Bottom:
                        this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Height); break;
                    case AnchorStyles.Left:
                        this.Location = new Point(0, this.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y); break;
                }
            }
            else //如果鼠标离开窗体，则根据停靠位置隐藏窗体，但须留出部分窗体边缘以便鼠标选中窗体
            {
                switch
                 (this.StopDock)
                {
                    case AnchorStyles.Top: this.Location = new Point(this.Location.X, (this.Height - 3) * (-1));
                        break;
                    case AnchorStyles.Bottom: this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - 5);
                        break;
                    case AnchorStyles.Left: this.Location = new Point((-1) * (this.Width - 3), this.Location.Y);
                        break;
                    case AnchorStyles.Right: this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 2, this.Location.Y);
                        break;
                }
            }
        }
         #endregion 

      private void FrmLogin_LocationChanged(object sender, EventArgs e)
      {
          if (this.Top <= 0)
          {
              this.StopDock = AnchorStyles.Top;
          }
          else if (this.Bottom >= Screen.PrimaryScreen.Bounds.Height)
          {
              this.StopDock = AnchorStyles.Bottom;
          }
          else if (this.Left <= 0)
          {
              this.StopDock = AnchorStyles.Left;
          }
          else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)
          {
              this.StopDock = AnchorStyles.Right;
          }
          else
          {
              this.StopDock = AnchorStyles.None;
          }
      }
      bool skinss = true;
      private void lblskin_MouseDown(object sender, MouseEventArgs e)
      {
          if (skinss)
          {
              skins.SkinFile = "Emerald.ssk";
              skinss = false;
          }
          else
          {
              skins.SkinFile = "enskin.ssk";
              skinss = true;
          }
      }

      private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
      {
          Application.DoEvents();
          Application.Exit();
      }
    }
}
