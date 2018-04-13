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
    public partial class FrmBuy : Form
    {
        public FrmBuy()
        {
            InitializeComponent();
        }
        private bool nonNumberEnterd = false;

        private void txtBuyAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuyAmount_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEnterd = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEnterd = true;
                    }
                }
            }
        }

        private void txtBuyAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEnterd)
            {
                e.Handled = true;
            }
        }

        private int ValidateBuy()
        {
            if (txtBuyComid.Text == "")
            {
                MessageBox.Show("请填写购买的商品编号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else if (txtBuyAmount.Text == "" || txtBuyAmount.Text == "0")
            {
                MessageBox.Show("请填写购买的商品数量", "提温馨示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else if (txtBuyCusid.Text == "")
            {
                MessageBox.Show("请填写你的ID", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else if (txtBuyshifu.Text == "")
            {
                MessageBox.Show("请你结账，谢谢！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else if (double.Parse(txtBuyshifu.Text) < double.Parse(txtBuyyingfu.Text))
            {
                MessageBox.Show("你所缴纳款额不足", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else return 1;
        }

        private void btnBuyOk_Click(object sender, EventArgs e)
        {
            if (ValidateBuy() == 0)
                return;
            DialogResult dr = MessageBox.Show("购确定购买吗！", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string strsql = "Select CusID from Customers where CusID='" + txtBuyCusid.Text + "'";
                SqlConnection con = Sqlhelper.getCon();
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(strsql, con);
                    SqlDataReader sdr = com.ExecuteReader();
                    if (sdr.Read())
                    {

                        strsql = "insert into orderlist(CusID,ComID,OrAmount,PayMoney)values('" + txtBuyCusid.Text + "','" + txtBuyComid.Text + "','" + txtBuyAmount.Text + "','" + txtBuyshifu.Text + "')";
                        Sqlhelper.insert(strsql);
                        double yu = (double.Parse(txtBuyshifu.Text)) - (double.Parse(txtBuyyingfu.Text));
                        MessageBox.Show("购买成功，余额为：" + yu.ToString(), "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("系统没有你的信息，请注册或核对ID", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception) { }
                con.Close();
            }
        }

        private void btnBuyCancel_Click(object sender, EventArgs e)
        {
            FrmCustomer f = new FrmCustomer();
            f.Show();
            this.Hide();
            Application.DoEvents();
        }

        private void FrmBuy_Load(object sender, EventArgs e)
        {
            string straql = "select CatId,CatName from Commodiy_cate";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(straql, con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            try
            {
                con.Open();
                sda.Fill(ds, "commodiy_cate");
            }
            catch (Exception) { }
                con.Close();
            cboBuycomcat.DataSource = ds.Tables[0];
            cboBuycomcat.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cboBuycomcat.ValueMember = ds.Tables[0].Columns[0].ToString();
        }

        private void txtBuyComid_TextChanged(object sender, EventArgs e)
        {
            string strsql = "select CatID,ComName,ComPrice from commodity where ComID='"+txtBuyComid .Text+"'";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    cboBuycomcat.SelectedValue = sdr[0].ToString();
                    txtBuyComname.Text = sdr[1].ToString();
                    txtBuyComprice.Text = sdr[2].ToString();
                }
            }
            catch (Exception) { }
            con.Close();
        }
    }
}
