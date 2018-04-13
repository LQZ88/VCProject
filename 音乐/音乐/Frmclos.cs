using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 音乐
{
    public partial class Frmclos : Form
    {
        public Frmclos()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (rdoclos.Checked == true)
            {
                Application.Exit();
                return;
            }
            if (rdocloss.Checked == true)
            {
                FrmMusic.ActiveForm.Close();
                FrmMusic.ActiveForm.Hide();
                this.Close();
                return;
            }
        }

        private void btncanle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
