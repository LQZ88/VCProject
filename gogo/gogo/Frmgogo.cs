using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gogo
{
    public partial class Frmgogo : Form
    {
        public Frmgogo()
        {
           InitializeComponent();
        }

        bool play = true;
        private void btnleft_MouseClick(object sender, MouseEventArgs e)
        {
            if (play)
            {
                this.tmrBottom.Interval = 1;
                this.tmrBottom.Enabled = true;
                this.WindowState = FormWindowState.Normal;
                this.tmrtop.Interval = 1;
                this.tmrtop.Enabled = true;
                this.WindowState = FormWindowState.Normal;
                this.tmrtop1.Interval = 1;
                this.tmrtop1.Enabled = true;
                this.WindowState = FormWindowState.Normal;
                play = false;
            }
            else
            {
                this.tmrBottom.Stop();
                this.tmrtop.Stop();
                this.tmrtop1.Stop();
                play = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltop.Top = lbltop.Top - 3;
            if (lbltop.Bottom < 0)
            {
                lbltop.Top = this.Width;
            }
        }

        private void Frmgogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            tmrBottom.Stop();
            tmrtop.Stop();
            tmrtop1.Stop();
            Frmplay ds = new Frmplay();
            ds.Show();
            this.Hide();
        }

        private void tmrtop1_Tick(object sender, EventArgs e)
        {
            lbltop1.Top = lbltop1.Top - 3;
            if (lbltop1.Bottom < 0)
            {
                lbltop1.Top = this.Width;
            }
        }

        private void tmrBottom_Tick(object sender, EventArgs e)
        {
            lblBottom.Top = lblBottom.Top - 2;
            if (lblBottom.Bottom < 0)
            {
                lblBottom.Top = this.Width;
            }
        }

        private void Frmgogo_Activated(object sender, EventArgs e)
        {
            Frmplay d = new Frmplay();
            d.Hide();
            d.Close();
        }
    }
}
