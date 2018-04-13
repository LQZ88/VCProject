using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using WMPLib;
using System.Windows.Forms;

namespace 音乐播放
{
    public partial class Frmselect : Form
    {
        WebClient Wc = new WebClient();
        public Frmselect()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (txtselect.Text.Trim() == "")
            {
                MessageBox.Show("关键词不能为空！");
                txtselect.Focus();
                return;
            }
            if (this.Height == 110)
            {
                this.Height = 610;
                this.CenterToScreen();
            }
            else
            {
                this.Height = 110;
                this.CenterToScreen();
            }
        }
    }
}
