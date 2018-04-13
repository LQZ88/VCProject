using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace 音乐播放
{
    public partial class FrmMusic : Form
    {
        System.Media.SoundPlayer StartPlay = new System.Media.SoundPlayer();
        string[] MusicMVPath = new string[1000];
        int MusicMVCount = 0;  
        public FrmMusic()
        {
            InitializeComponent();
        }
              
        private OpenFileDialog openFileDialog()
        {
            throw new NotImplementedException();
        }

        private void FrmMusic_Shown(object sender, EventArgs e)
        {
            AXMusicMV.BeginInit();
            AXMusicMV.settings.autoStart = true;
            AXMusicMV.settings.setMode("shuffle", false);
            AXMusicMV.settings.enableErrorDialogs = true;
            AXMusicMV.settings.balance = 0;
            AXMusicMV.settings.mute = false;
            AXMusicMV.settings.volume = 50;
            if (File.Exists("Music"))
            {
                StreamReader reader = new StreamReader("Music");
                try
                {
                    while (reader.Peek() != -1)
                    {
                        string filepath = reader.ReadLine();
                        if (File.Exists(filepath))
                        {
                            MusicMVPath[MusicMVCount++] = filepath;
                            string filename = Path.GetFileName(filepath).Split('.')[0];
                            LVMusicMVName.Items.Add(filename);
                            AXMusicMV.currentPlaylist.insertItem(AXMusicMV.currentPlaylist.count, AXMusicMV.newMedia(filepath));
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("播放列表为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void FrmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartPlay.Stop();
            AXMusicMV.Ctlcontrols.stop();
            AXMusicMV.close(); //关闭播放器
            Application.Exit();
        }

        private void tsmiinsert_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OPmusicMv = new OpenFileDialog();
                OPmusicMv.Title = "添加列表";
                OPmusicMv.Multiselect = true;
                OPmusicMv.Filter = "MP3歌曲|*.MP3|MP4视频|*.MP4";
                if (OPmusicMv.ShowDialog() == DialogResult.OK)
                {
                    string[] filepath = OPmusicMv.FileNames;
                    foreach (string MusicMV in filepath)
                    {
                            string filename = Path.GetFileName(MusicMV);
                            LVMusicMVName.Items.Add(filename);
                            MusicMVPath[MusicMVCount++] = MusicMV;
                            AXMusicMV.currentPlaylist.insertItem(AXMusicMV.currentPlaylist.count, AXMusicMV.newMedia(MusicMV));
                            Application.DoEvents();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                StreamWriter writer = new StreamWriter("Music", false, Encoding.Unicode);
                for (int i = 0; i <= MusicMVCount - 1; i++)
                {
                    if (MusicMVPath[i] != string.Empty)
                    {
                        writer.WriteLine(MusicMVPath[i]);
                    }
                }
                writer.Close();
            }
            catch (Exception) { }
        }

        private void tsmidelete_Click(object sender, EventArgs e)
        {
            try
            {
                LVMusicMVName.Items.Clear();
                File.Delete("Music");
                AXMusicMV.currentPlaylist.clear();
                MessageBox.Show("清空成功！","温馨提示");
            }
            catch (Exception) { }
        }

        private void tsmiplay_Click(object sender, EventArgs e)
        {
            if (LVMusicMVName.SelectedItems.Count > 0 && LVMusicMVName.FocusedItem.Index >= 0)
            {
                try
                {
                    StartPlay.Stop();
                    AXMusicMV.Ctlcontrols.playItem(AXMusicMV.currentPlaylist.get_Item(LVMusicMVName.FocusedItem.Index));
                }
                catch (Exception)
                {
                    MessageBox.Show("播放失败！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("列表为空？","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void tmsiplayS_Click(object sender, EventArgs e)
        {
            AXMusicMV.settings.setMode("loop", true);
            AXMusicMV.settings.setMode("shuffle", false);
        }

        private void tsmiplayQ_Click(object sender, EventArgs e)
        {
            AXMusicMV.settings.setMode("shuffle", true);
            AXMusicMV.settings.setMode("loop", false);
        }

        private void tsmiselect_Click(object sender, EventArgs e)
        {
            Frmselect select = new Frmselect();
            select.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.Width == 850)
            { 
                this.Width=1030;
                lblMusicMV.Text="<<";
            }
            else
            {
                this.Width=850;
                lblMusicMV.Text = ">>";
            }
        }
        internal AnchorStyles StopDock = AnchorStyles.None; 
        private void tmrTL_Tick(object sender, EventArgs e)
        { //如果鼠标在窗体上，则根据停靠位置显示整个窗体 
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

        private void nomusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void tsmiclos_Click(object sender, EventArgs e)
        {
            StartPlay.Stop();
            AXMusicMV.Ctlcontrols.stop();
            AXMusicMV.close(); //关闭播放器
            Application.Exit();
        }

        private void tsmihide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        bool pl = true;
        private void tsmiplayt_Click(object sender, EventArgs e)
        {
            if (pl)
            {
                AXMusicMV.close();
                pl = false;
            }
            else
            {
                AXMusicMV.Ctlcontrols.play();
                pl = true;
            }
        }
    }
}
