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
    public partial class FrmController : Form
    {
        public FrmController()
        {
            InitializeComponent();
        }

        private void tsmiCopyright_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版权所有： 小泽IT国际！", "提 示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("研发部门： 小泽IT !", "提 示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsmiNewcom_Click(object sender, EventArgs e)
        {
            FrmRunCommodity f = new FrmRunCommodity();
            f.Show();
            this.Hide();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Hide();
        }

        private void tsmiCusOrder_Click(object sender, EventArgs e)
        {
            string strsql = "Select OrderID 订单号,CusID 客户编号,ComID 商品编号,OrAmount 购买数量,PayMoney 支付金额 from Orderlist";
            try
            {
                DataTable dt = Sqlhelper.select(strsql);
                dgvController.DataSource = dt;
            }
            catch (Exception) { }
        }

        private void tsCominfo_Click(object sender, EventArgs e)
        {
            string straql = "select ComID 商品编号,ComName 商品名称,Comprice 商品价格,Amount 商品数量,ComPicture 商品样图,CatName 商品类别 from commodity as com inner join commodiy_cate as ca on com.CatID=ca.CatID;";
            try
            {
                DataTable dt = Sqlhelper.select(straql);
                dgvController.DataSource = dt;
            }
            catch (Exception) { }
        }

        private void tsCusinfo_Click(object sender, EventArgs e)
        {
            string strsql = "select CusID 客户编号,CusName 客户姓名,CusSex 性别,Email 邮件,TelephoneNO 电话,Address 地址 from customers";
            try
            {
                DataTable dt = Sqlhelper.select(strsql);
                dgvController.DataSource = dt;
            }
            catch (Exception) { }
        }

        private void tsUpdatecom_Click(object sender, EventArgs e)
        {
            FrmRunCommodity f = new FrmRunCommodity();
            f.Show();
            this.Hide();
        }

        private void tsDeletecom_Click(object sender, EventArgs e)
        {
            FrmRunCommodity f = new FrmRunCommodity();
            f.Show();
            this.Hide();
        }
    }
}
