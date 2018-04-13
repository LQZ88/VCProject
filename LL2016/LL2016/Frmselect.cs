using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace LL2016
{
    public partial class Frmselect : Form
    {
        public Frmselect()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string sql = "select Wid as 账号,Wpassword as 密码,Wname as 姓名,Wage as 年龄,Wadress as 住址,wip as ip地址 from WQQ order by Wid";
            dgvstudent.DataSource = OrcalConn.select(sql);
        }

        private void Frmselect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtWid.Text.Trim() == "")
            {
                txtWid.Focus();
                return;
            }
            String sqldelete = "delete from WQQ whwere Wid='"+txtWid.Text.Trim()+"'";
            OrcalConn.delete(sqldelete,txtWid.Text.Trim());
        }
    }
}
