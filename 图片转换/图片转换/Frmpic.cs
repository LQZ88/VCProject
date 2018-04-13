using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace 图片转换
{
    public partial class Frmpic : Form
    {
        private Bitmap bitpic;
        private int width0;
        private int height0;
        public Frmpic()
        {
            InitializeComponent();
            bitpic = null;
            width0 = picimg.Size.Width;
            height0 = picimg.Size.Height;
            cbopic.SelectedIndex = 0;
            cbopic.Hide();
        }

        private void Frmpic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }

        private void tsmpicxuze_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openpic = new OpenFileDialog();
            Openpic.Filter = "GIF图片|*.gif|JPG图片|*.jpg|PNG图片|*.png|BMP图片|*.bmp|TIF图片|*.tif";
            string filter = Openpic.Filter;
            Openpic.Title = "打开图象文件";
            Openpic.ShowHelp = true;
            if (Openpic.ShowDialog() == DialogResult.OK)
            {
                string strFileName = Openpic.FileName;
                bitpic = new Bitmap(strFileName);
                if (bitpic.Width > bitpic.Height)
                {
                    picimg.Width = width0;
                    picimg.Height = (int)((double)bitpic.Height / width0 / bitpic.Width);
                }
                else
                {
                    picimg.Height = height0;
                    picimg.Width = (int)((double)bitpic.Width / height0 / bitpic.Height);
                }
                picimg.Image= bitpic;
                tsmizhpic.Enabled = true;
            }
        }
        private void tsmizhpic_Click(object sender, EventArgs e)
        {
            SaveFileDialog sever = new SaveFileDialog();
            sever.Title = "转化为";
            sever.OverwritePrompt = true;
            sever.CheckPathExists = true;
            sever.Filter = "GIF格式|*.gif|JPG格式|*.jpg|PNG格式|*.png|BMP格式|*.bmp|TIF格式|*.tif";
            sever.ShowHelp = true;
            if (sever.ShowDialog() == DialogResult.OK)
            {
                string strFileName = sever.FileName;
                try
                {
                    switch (cbopic.Text)
                    {
                        case "BMP格式": bitpic.Save(strFileName, ImageFormat.Bmp);
                            break;
                        case "JPG格式": bitpic.Save(strFileName, ImageFormat.Jpeg);
                            break;
                        case "GIF格式": bitpic.Save(strFileName, ImageFormat.Gif);
                            break;
                        case "TIF格式": bitpic.Save(strFileName, ImageFormat.Tiff);
                            break;
                        case "PNG格式": bitpic.Save(strFileName, ImageFormat.Png);
                            break;
                    }
                    picimg.Image = null;
                    bitpic = null;
                    MessageBox.Show("转换成功！");
                }
                catch (Exception es)
                {
                    picimg.Image = null;
                    bitpic = null;
                    MessageBox.Show(this, "保存图像文件时发生错误！" + es.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsmpicclose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

    }
}
