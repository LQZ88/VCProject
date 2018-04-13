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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnReFil_Click(object sender, EventArgs e)
        {
            string strsql = "select ComID 商品编号,ComName 商品名称,ComPrice 商品价格,Amount 商品数量,ComPicture 商品样图 from commodity as com inner join commodiy_cate as ca on com.CatID=ca.CatID and CatName='" + cboCat.Text + "'";
            try
            {
                DataTable dt = Sqlhelper.select(strsql);
                dgvCommodity.DataSource = dt;
            }
            catch (Exception) { }

        }

        private void btnCusCancle_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Hide();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            Sqlhelper.getValue("select CatName from commodiy_cate", cboCat);
            cboCat.SelectedIndex = 0;
        }

        private void tsmiBuy_Click(object sender, EventArgs e)
        {
            FrmBuy f = new FrmBuy();
            f.Show();
            Application.DoEvents();
            this.CenterToScreen();
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        internal AnchorStyles StopDock = AnchorStyles.None; 
        private void TMRtl_Tick(object sender, EventArgs e)
        {
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

        private void FrmCustomer_LocationChanged(object sender, EventArgs e)
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
    }
}
