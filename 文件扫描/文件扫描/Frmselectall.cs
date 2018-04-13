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

namespace 文件扫描
{
    public partial class Frmselectall : Form
    {
        public int totalnum = 0;//总共扫描文件数
        public int num = 1;//符合要求文件数
        public Frmselectall()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Frmselectall_Load(object sender, EventArgs e)
        {
            getDiskInfo();//获取电脑上面的所有逻辑驱动器
            cboxDisk.SelectedIndex = 0;//获取盘符
            cboxExtention.SelectedIndex = 0;
            lvResult.FullRowSelect = true;
        }

        private void getDiskInfo()
        {
            string[] disks = Directory.GetLogicalDrives();
            foreach (string disk in disks)
            {
                cboxDisk.Items.Add(disk);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(getfile);
            t.Start();
            labFilePath.Text = "总共扫描文件"+totalnum.ToString()+"个符合要求文件"+Convert.ToString(num - 1)+"个";
            /*if (btnOk.Text == "开始扫描")
            {
                t.Start();//开启线程
                btnOk.Text = "暂停扫描";
            }
            else if (btnOk .Text =="暂停扫描")
            {
                t.Suspend();//挂起线程
                btnOk.Text = "继续扫描";
            }
            else if (btnOk.Text == "继续扫描")
            {
                t.Resume();//继续挂起的线程
                btnOk.Text = "暂停扫描";
            }*/
        }

        private void getfile()
        {
            string str1 = cboxDisk.Text.Trim();
            string str2 = cboxExtention.Text.Trim();
            getFiles(str1, str2);
        }

        private void getFiles(string folder, string filter)
        {            
            DirectoryInfo dir = new DirectoryInfo(folder);
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                try
                {
                    foreach (FileInfo file in d.GetFiles("*.*", System.IO.SearchOption.AllDirectories))
                    {
                        labFilePath.Text = file.FullName;
                        totalnum.ToString();
                        if (file.Extension == filter)
                        {
                            string fileName = file.FullName;
                            string fileCreateTime = Convert.ToString(file.CreationTime);//文件创建时间
                            string fileLastAccessTime = Convert.ToString(file.LastAccessTime);//最后访问时间
                            string fileLastWriteTime = Convert.ToString(file.LastWriteTime);//最后修改时间
                            string fileLength = Convert.ToInt32(file.Length / 1024)+".KB";//文件大小                            
                            string fileIsReadOnly = Convert.ToString(file.IsReadOnly);//文件是否只读
                            string[] fileInfo = new string[]
                           {
                                num.ToString (),
                                fileName ,                                
                                fileCreateTime ,
                                fileIsReadOnly ,
                                fileLength ,
                                fileLastAccessTime ,
                                fileLastWriteTime 
                           };
                            lvResult.Items.Add(new ListViewItem(fileInfo));
                            num.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("程序出错啦，原因可能是:"+ex.Message+"\r\n按确定键继续", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    labFilePath.Text = "总共扫描文件"+totalnum.ToString()+"个,符合要求文件有"+Convert.ToString(num - 1)+"个";
                }
            }
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lvResult.SelectedItems[0].SubItems [1].Text );
            System.Diagnostics.Process.Start(lvResult.SelectedItems[0].SubItems[1].Text);
        }

        private void Frmselectall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
