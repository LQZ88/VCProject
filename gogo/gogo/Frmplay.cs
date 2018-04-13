using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace gogo
{
    public partial class Frmplay : Form
    {
        public Frmplay()
        {
            InitializeComponent();
        }

        private void tmrplay_Tick(object sender, EventArgs e)
        {
            if (this.axplay.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                tmrplay.Dispose();
                tmrplay.Stop();
                Frmmusic gogo = new Frmmusic();
                gogo.Show();
                this.Hide();
            }
        }

        private void Frmplay_Activated(object sender, EventArgs e)
        {
            axplay.BeginInit();
            tmrplay.Start();
            axplay.URL = "TFBOYS-雅客天天棒.mp4";
        }
    }
}
