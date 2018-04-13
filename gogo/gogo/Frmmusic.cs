using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace gogo
{
    public partial class Frmmusic : Form
    {
        System.Media.SoundPlayer start = new System.Media.SoundPlayer();
        string[] musicPath = new string[1000];
        int musicCount = 0;
        public Frmmusic()
        {
            InitializeComponent();
        }
        
        private OpenFileDialog openFileDialog()
        {
            throw new NotImplementedException();
        }

        private void Frmmusic_Shown(object sender, EventArgs e)
        {
            axmusicmv.BeginInit();
            axmusicmv.settings.autoStart = false;
            axmusicmv.settings.setMode("shuffle", false);
            axmusicmv.settings.enableErrorDialogs = true;
            axmusicmv.settings.balance = 0;
            axmusicmv.settings.mute = false;
            axmusicmv.settings.volume = 50;
            if (File.Exists("Music.txt"))
            {
                StreamReader reader = new StreamReader("Music.txt");
                try
                {
                    while (reader.Peek() != -1)
                    {
                        string filepath = reader.ReadLine();
                        if (File.Exists(filepath))
                        {
                            musicPath[musicCount++] = filepath;
                            string filename = Path.GetFileName(filepath).Split('.')[0];
                            lvmusic.Items.Add(filename);
                            axmusicmv.currentPlaylist.insertItem(axmusicmv.currentPlaylist.count, axmusicmv.newMedia(filepath));
                        }
                    }
                }
                catch (Exception)
                {
                    start.Load();
                    MessageBox.Show("加载播放列表失败或者列表为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void Frmmusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Stop();
            axmusicmv.Ctlcontrols.stop();
            axmusicmv.close(); //关闭播放器
            Application.Exit();
        }

        private void tsmiinsert_MouseDown(object sender, MouseEventArgs e)
        {
            if (openF.ShowDialog() == DialogResult.OK)//添加单曲
            {
                string filepath = openF.FileName;
                string filename = Path.GetFileName(filepath);
                lvmusic.Items.Add(filename);
                musicPath[musicCount++] = filepath;
                axmusicmv.currentPlaylist.insertItem(axmusicmv.currentPlaylist.count, axmusicmv.newMedia(filepath));
            }
            StreamWriter writer = new StreamWriter("Music.txt", false, Encoding.Unicode); //保存播放列表
            for (int i = 0; i <= musicCount - 1; i++)
            {
                if (musicPath[i] != string.Empty)
                {
                    writer.WriteLine(musicPath[i]);
                }
            }
            writer.Close();
        }

        private void tsmiback_MouseDown(object sender, MouseEventArgs e)
        {
            Frmgogo s = new Frmgogo();
            s.Show();
            this.Hide();
            start.Stop();
            axmusicmv.Ctlcontrols.stop();
            axmusicmv.close(); //关闭播放器
            Application.Exit();
        }

        private void tsmiclose_Click(object sender, EventArgs e)
        {
            start.Stop();
            axmusicmv.Ctlcontrols.stop();
            axmusicmv.close(); //关闭播放器
            Application.Exit();
        }

        private void tsmiplays_Click(object sender, EventArgs e)
        {
                if (lvmusic.Items.Count > 0 && lvmusic.InsertionMark.Index>=0)
                {
                    start.Stop();
                    axmusicmv.Ctlcontrols.playItem(axmusicmv.currentPlaylist.get_Item(lvmusic.FocusedItem.Index));
                }
        }
        bool skin = true;
        private void tsmiskin_Click(object sender, EventArgs e)
        {
            if (skin)
            {
                skinss.SkinFile = "EmeraldColor2.ssk";
                skin = false;
            }
            else
            {
                skinss.SkinFile = "Emerald.ssk";
                skin = true;
            }   
        }
    }
}