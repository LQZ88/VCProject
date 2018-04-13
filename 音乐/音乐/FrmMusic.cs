using System;
using WMPLib;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.Media;
using System.Drawing;
using System.Data.Common;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml;

namespace 音乐
{
    public partial class FrmMusic : Form
    {
        System.Media.SoundPlayer StartPlay = new System.Media.SoundPlayer();
        string[] MusicPath = new string[1000];
        int MusicCount = 0;
        public FrmMusic()
        {
            InitializeComponent();
        }

        private void FrmMusic_Shown(object sender, EventArgs e)
        {
            Axmusic.BeginInit();
            Axmusic.settings.autoStart = true;
            Axmusic.settings.setMode("shuffle", false);
            Axmusic.settings.enableErrorDialogs = true;
            Axmusic.settings.balance = 0;
            Axmusic.settings.mute = false;
            Axmusic.settings.volume = 30;
            if (File.Exists("music"))
            {
                StreamReader reader = new StreamReader("music");
                try
                {
                    while (reader.Peek() != -1)
                    {
                        string filepath = reader.ReadLine();
                        if (File.Exists(filepath))
                        {
                            MusicPath[MusicCount++] = filepath;
                            string filename = Path.GetFileName(filepath).Split('.')[0];
                            lvmusic.Items.Add(filename);
                            Axmusic.currentPlaylist.insertItem(Axmusic.currentPlaylist.count, Axmusic.newMedia(filepath));
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("列表为空");
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OPmusic = new OpenFileDialog();
                OPmusic.Title = "添加歌曲";
                OPmusic.FileName = "";
                OPmusic.Multiselect = true;
                OPmusic.Filter = "MP3歌曲|*.MP3";
                if (OPmusic.ShowDialog() == DialogResult.OK)
                {
                    string[] filepath = OPmusic.FileNames;
                    foreach (string Music in filepath)
                    {
                        if (Path.GetExtension(Music) == ".mp3")
                        {
                            string filename = Path.GetFileName(Music);
                            lvmusic.Items.Add(filename);
                            MusicPath[MusicCount++] = Music;
                            Axmusic.currentPlaylist.insertItem(Axmusic.currentPlaylist.count, Axmusic.newMedia(Music));
                            Application.DoEvents();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                StreamWriter writer = new StreamWriter("music", false, Encoding.Unicode);
                for (int i = 0; i <= MusicCount - 1; i++)
                {
                    if (MusicPath[i] != string.Empty)
                    {
                        writer.WriteLine(MusicPath[i]);
                    }
                }
                writer.Close();
            }
            catch (Exception) { }
        }

        private void tsmiplay_Click(object sender, EventArgs e)
        {
            if (lvmusic.SelectedItems.Count > 0 && lvmusic.FocusedItem.Index >= 0)
            {
                try
                {
                    StartPlay.Stop();
                    Axmusic.Ctlcontrols.playItem(Axmusic.currentPlaylist.get_Item(lvmusic.FocusedItem.Index));
                    lblmusicname.Text = lvmusic.FocusedItem.Text;
                    this.tmrleft.Interval = 40;
                    this.tmrleft.Enabled = true;
                    this.WindowState = FormWindowState.Normal;
                }
                catch (Exception)
                {
                    MessageBox.Show("播放失败！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("列表为空\n请选择歌曲", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tmrleft_Tick(object sender, EventArgs e)
        {
            try
            {
                lblmusicname.Left = lblmusicname.Left - 1;
                if (lblmusicname.Left <= 80)
                {
                    lblmusicname.Left = this.Width;
                }
            }
            catch (Exception) { }
        }

        private void tsmimusicS_Click(object sender, EventArgs e)
        {
            Axmusic.settings.setMode("loop",true);
        }

        private void tsmiplayQ_Click(object sender, EventArgs e)
        {
            Axmusic.settings.setMode("shuffle",false);
        }
        bool skin = true;
        private void lblskin_Click(object sender, EventArgs e)
        {
            try
            {
                if (skin)
                {
                    skinplay.SkinFile = "skin.ssk";
                    skin = false;
                }
                else
                {
                    skinplay.SkinFile = "skins.ssk";
                    skin = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("换肤失败");
            }
        }

        private void tsmiopname_Click(object sender, EventArgs e)
        {
            if (lvmusic.Items.Count>0)
            {
                try
                {
                    OpenFileDialog OPmusicname = new OpenFileDialog();
                    OPmusicname.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("路径错误!","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("列表为空","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StartPlay.Stop();
                Axmusic.Ctlcontrols.stop();
                Axmusic.currentPlaylist.clear();
                Application.DoEvents();
                Application.Exit();
            }
            catch (Exception) { }
            
        }
        #region 停靠悬浮
        internal AnchorStyles StopDock = AnchorStyles.None; 
        private void tmrtl_Tick(object sender, EventArgs e)
        {//如果鼠标在窗体上，则根据停靠位置显示整个窗体 
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
        private void FrmMusic_LocationChanged(object sender, EventArgs e)
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

        private void tsmiclos_Click(object sender, EventArgs e)
        {
            Frmclos ds = new Frmclos();
            ds.Show();
        }

        private void ntfmusicioc_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void tsmimusicplayT_Click(object sender, EventArgs e)
        {
            if (lvmusic.SelectedItems.Count > 0 && lvmusic.FocusedItem.Index >= 0)
            {
                try
                {
                    StartPlay.Stop();
                    Axmusic.Ctlcontrols.playItem(Axmusic.currentPlaylist.get_Item(lvmusic.FocusedItem.Index));
                    lblmusicname.Text = lvmusic.FocusedItem.Text;
                    this.tmrleft.Interval = 40;
                    this.tmrleft.Enabled = true;
                    this.WindowState = FormWindowState.Normal;
                }
                catch (Exception)
                {
                    MessageBox.Show("播放失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("列表为空\n请选择歌曲.", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsmimusicplayt_Click_1(object sender, EventArgs e)
        {
            Axmusic.close();
        }

        private void tsmidelete_Click(object sender, EventArgs e)
        {
            try
            {
                lvmusic.Items.Clear();
                File.Delete("music");
                Axmusic.currentPlaylist.clear();
                lblmusicname.Text = "";
                tmrleft.Stop();
                MessageBox.Show("清空成功！");
            }
            catch (Exception) { }
        }
    }
}
