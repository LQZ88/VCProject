using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 商城
{
    public partial class FrmRunCommodity : Form
    {
        public FrmRunCommodity()
        {
            InitializeComponent();
        }

        public string path = "";
        public void showPic()
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                this.picBoxAdd.Image = Image.FromFile(path);
                this.picBoxDelete.Image = Image.FromFile(path);
                this.picBoxUpdate.Image = Image.FromFile(path);
            }
        }

        public byte[] getIma()
        {
            FileStream fl = File.OpenRead(path);
            byte[] im = new byte[fl.Length];
            fl.Read(im, 0, im.Length);
            return im;
        }

        private void btnAddOk_Click(object sender, EventArgs e)
        {
            if (txtAddComid.Text == "")
            {
                MessageBox.Show("请填写商品编号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddComid.Focus();
                return;
            }
            if (txtAddComname.Text == "")
            {
                MessageBox.Show("请填写商品名称", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddComname.Focus();
                return;
            }
            if (txtAddComprice.Text == "")
            {
                MessageBox.Show("请填写商品价格", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddComprice.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("请核对你的商品信息，确定添加吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (picBoxAdd.Image != null)
                {
                    string strsql = "insert into commodity(ComID,CatID,ComName,ComPrice,Amount,Compicture)values('" + txtAddComid.Text + "','" + cboComcat.SelectedValue.ToString() + "','" + txtAddComname.Text + "','" + txtAddComprice.Text + "','" + txtAddComamount.Text + "',@pic)";
                    SqlConnection con = Sqlhelper.getCon();
                    SqlCommand com = new SqlCommand(strsql, con);
                    com.Parameters.Add("@pic", SqlDbType.Image).Value = getIma();
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                    }
                    catch (Exception) { }
                    con.Close();
                    MessageBox.Show("你已成功添加商品信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string strsql = "insert into commodity(ComID,CatID,ComName,ComPrice,Amount,Compicture)values('" + txtAddComid.Text + "','" + cboComcat.SelectedValue.ToString() + "','" + txtAddComname.Text + "','" + txtAddComprice.Text + "','" + txtAddComamount.Text + "')"; ;
                    try
                    {
                        Sqlhelper.insert(strsql);
                    }
                    catch (Exception) { }
                       MessageBox.Show("你已成功更新商品信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtAddComid.Clear();
                txtAddComname.Clear();
                txtAddComprice.Clear();
            }
            string strComCat = cboComcat.Text;
            string strComId = txtAddComid.Text;
            string strComname = txtAddComname.Text;
            string strComprice = txtAddComprice.Text;
            int amount = int.Parse(txtAddComamount.Text);
            string strmsg = "商品种类为：" + strComCat + "\n商品编号为：" + strComId + "\n商品名称为：" + strComname + "商品数量为：" + amount;
            MessageBox.Show(strmsg, " 你好！");
        }

        private void btnAddCopicture_Click(object sender, EventArgs e)
        {
            showPic();
        }

        private void FrmRunCommodity_Load(object sender, EventArgs e)
        {
            string strsql = "Select CatId,CatName from commodiy_cate";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            try
            {
                con.Open();
                sda.Fill(ds, "commodity_cate");
            }
            catch (Exception) { }
                con.Close();
            cboComcat.DataSource = ds.Tables[0];
            cboComcat.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cboComcat.ValueMember = ds.Tables[0].Columns[0].ToString();
            cboDeComcat.DataSource = ds.Tables[0];
            cboDeComcat.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cboDeComcat.ValueMember = ds.Tables[0].Columns[0].ToString();
            cboUpComcat.DataSource = ds.Tables[0];
            cboUpComcat.DisplayMember = ds.Tables[0].Columns[1].ToString();
            cboUpComcat.ValueMember = ds.Tables[0].Columns[0].ToString();
        }

        private void txtDeComID_TextChanged(object sender, EventArgs e)
        {
            string strsql = "Select CatID,ComName,ComPrice,Amount,Compicture from commodity where ComID='" + txtDeComID.Text + "'";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    cboDeComcat.SelectedValue = sdr[0].ToString();
                    txtDeComName.Text = sdr[1].ToString();
                    txtDeComprice.Text = sdr[2].ToString();
                    txtDeAmount.Text = sdr[3].ToString();
                }
                else
                {
                    txtDeComName.Clear();
                    txtDeComprice.Clear();
                    txtDeAmount.Clear();
                }
                sdr.Close();
            }
            catch (Exception) { }
            con.Close();
        }

        private void txtUpComid_TextChanged(object sender, EventArgs e)
        {
            string strsql = "Select CatID,ComName,ComPrice,Amount,Compicture from commodity where ComID='" + txtUpComid.Text + "'";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    cboUpComcat.SelectedValue = sdr[0].ToString();
                    txtUpComname.Text = sdr[1].ToString();
                    txtUpComprice.Text = sdr[2].ToString();
                    txtUpAmount.Text = sdr[3].ToString();
                }
                else
                {
                    txtUpComname.Clear();
                    txtUpComprice.Clear();
                    txtUpAmount.Clear();
                }
                sdr.Close();
            }
            catch (Exception) { }
            con.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            FrmController f = new FrmController();
            f.Show();
            this.Hide();
        }

        private void btnDeCancle_Click(object sender, EventArgs e)
        {
            FrmController f = new FrmController();
            f.Show();
            this.Hide();
        }

        private void btnAddCancle_Click(object sender, EventArgs e)
        {
            FrmController f = new FrmController();
            f.Show();
            this.Hide();
        }

        private void btnDeOk_Click(object sender, EventArgs e)
        {
            if (txtDeComID.Text == "")
            { 
                MessageBox.Show("请填写商品编号","温馨提示");
                txtDeComID.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("你确定下架该商品吗？", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string strsql = "delete commodity where ComID='" + txtDeComID.Text + "'";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception) { }
                con.Close();
            MessageBox.Show("该商品下架成功！", "温馨提示");
        }

        private void btnUpOk_Click(object sender, EventArgs e)
        {
            if (txtUpComid.Text == "")
            {
                MessageBox.Show("请填写新的商品编号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpComid.Focus();
                return;
            }
            if (txtUpComname.Text == "")
            {
                MessageBox.Show("请填写新的商品名称", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpComname.Focus();
                return;
            }
            if (txtUpComprice.Text == "")
            {
                MessageBox.Show("请填写新的商品价格", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpComprice.Focus();
                return;
            }
            DialogResult dr = MessageBox.Show("你确定修改该商品吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string strsql = "";
                if (path != "")
                {
                    strsql = "update commodity SET ComName='" + txtUpComname.Text + "',ComPrice='" + txtUpComprice.Text + "',Amount='" + txtUpAmount.Text + "',Compicture=@pic where ComID='" + txtUpComid.Text + "'";
                }
                else
                {
                    strsql = "update commodity SET ComName='" + txtUpComname.Text + "',ComPrice='" + txtUpComprice.Text + "',Amount='" + txtUpAmount.Text + "' where ComID='" + txtUpComid.Text + "'";
                }
                SqlConnection con = Sqlhelper.getCon();
                SqlCommand com = new SqlCommand(strsql, con);
                com.Parameters.Add("@pic", SqlDbType.Image).Value = getIma();
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception) { }
                    con.Close();
                MessageBox.Show("你已成功更改商品信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("修改错误", "温馨提示");
            }
        }

        private void btnUppicture_Click(object sender, EventArgs e)
        {
            showPic();
        }

        private void FrmRunCommodity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        internal AnchorStyles StopDock = AnchorStyles.None; 
        private void tmrTL_Tick(object sender, EventArgs e)
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

        private void FrmRunCommodity_LocationChanged(object sender, EventArgs e)
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
