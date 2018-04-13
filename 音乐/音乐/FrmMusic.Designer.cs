namespace 音乐
{
    partial class FrmMusic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusic));
            this.pnmusicname = new System.Windows.Forms.Panel();
            this.picmusic = new System.Windows.Forms.PictureBox();
            this.lblmusicname = new System.Windows.Forms.Label();
            this.Axmusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnmusic = new System.Windows.Forms.Panel();
            this.lvmusic = new System.Windows.Forms.ListView();
            this.ctnmusic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimusicplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimusicS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiplayQ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiopname = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrleft = new System.Windows.Forms.Timer(this.components);
            this.skinplay = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tmrtl = new System.Windows.Forms.Timer(this.components);
            this.ntfmusicioc = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctnmusicrun = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmimusicplays = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimusicplayt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiclos = new System.Windows.Forms.ToolStripMenuItem();
            this.btninsert = new System.Windows.Forms.Button();
            this.pnmusicrun = new System.Windows.Forms.Panel();
            this.lblskin = new System.Windows.Forms.Label();
            this.pnmusicname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Axmusic)).BeginInit();
            this.pnmusic.SuspendLayout();
            this.ctnmusic.SuspendLayout();
            this.ctnmusicrun.SuspendLayout();
            this.pnmusicrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmusicname
            // 
            this.pnmusicname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnmusicname.Controls.Add(this.picmusic);
            this.pnmusicname.Controls.Add(this.lblmusicname);
            this.pnmusicname.Controls.Add(this.Axmusic);
            this.pnmusicname.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnmusicname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmusicname.Location = new System.Drawing.Point(0, 0);
            this.pnmusicname.Name = "pnmusicname";
            this.pnmusicname.Size = new System.Drawing.Size(290, 118);
            this.pnmusicname.TabIndex = 0;
            // 
            // picmusic
            // 
            this.picmusic.Image = global::音乐.Properties.Resources.music;
            this.picmusic.Location = new System.Drawing.Point(3, 3);
            this.picmusic.Name = "picmusic";
            this.picmusic.Size = new System.Drawing.Size(72, 64);
            this.picmusic.TabIndex = 3;
            this.picmusic.TabStop = false;
            // 
            // lblmusicname
            // 
            this.lblmusicname.AutoSize = true;
            this.lblmusicname.BackColor = System.Drawing.Color.Transparent;
            this.lblmusicname.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblmusicname.Location = new System.Drawing.Point(90, 34);
            this.lblmusicname.Name = "lblmusicname";
            this.lblmusicname.Size = new System.Drawing.Size(72, 16);
            this.lblmusicname.TabIndex = 2;
            this.lblmusicname.Text = "小泽音乐";
            // 
            // Axmusic
            // 
            this.Axmusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Axmusic.Enabled = true;
            this.Axmusic.Location = new System.Drawing.Point(0, 73);
            this.Axmusic.Name = "Axmusic";
            this.Axmusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Axmusic.OcxState")));
            this.Axmusic.Size = new System.Drawing.Size(290, 45);
            this.Axmusic.TabIndex = 0;
            // 
            // pnmusic
            // 
            this.pnmusic.Controls.Add(this.lvmusic);
            this.pnmusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnmusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmusic.Location = new System.Drawing.Point(0, 118);
            this.pnmusic.Name = "pnmusic";
            this.pnmusic.Size = new System.Drawing.Size(290, 445);
            this.pnmusic.TabIndex = 1;
            // 
            // lvmusic
            // 
            this.lvmusic.BackColor = System.Drawing.Color.DarkCyan;
            this.lvmusic.ContextMenuStrip = this.ctnmusic;
            this.lvmusic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvmusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvmusic.Location = new System.Drawing.Point(0, 0);
            this.lvmusic.Name = "lvmusic";
            this.lvmusic.Size = new System.Drawing.Size(290, 445);
            this.lvmusic.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvmusic.TabIndex = 0;
            this.lvmusic.UseCompatibleStateImageBehavior = false;
            this.lvmusic.View = System.Windows.Forms.View.List;
            // 
            // ctnmusic
            // 
            this.ctnmusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctnmusic.Font = new System.Drawing.Font("新宋体", 12F);
            this.ctnmusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiplay,
            this.tsmidelete,
            this.tsmimusicplay,
            this.tsmiopname});
            this.ctnmusic.Name = "ctnmusic";
            this.ctnmusic.Size = new System.Drawing.Size(173, 92);
            // 
            // tsmiplay
            // 
            this.tsmiplay.Image = global::音乐.Properties.Resources._4;
            this.tsmiplay.Name = "tsmiplay";
            this.tsmiplay.Size = new System.Drawing.Size(172, 22);
            this.tsmiplay.Text = "播放";
            this.tsmiplay.Click += new System.EventHandler(this.tsmiplay_Click);
            // 
            // tsmidelete
            // 
            this.tsmidelete.Image = global::音乐.Properties.Resources._3;
            this.tsmidelete.Name = "tsmidelete";
            this.tsmidelete.Size = new System.Drawing.Size(172, 22);
            this.tsmidelete.Text = "清空列表";
            this.tsmidelete.Click += new System.EventHandler(this.tsmidelete_Click);
            // 
            // tsmimusicplay
            // 
            this.tsmimusicplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimusicS,
            this.tsmiplayQ});
            this.tsmimusicplay.Image = global::音乐.Properties.Resources._2;
            this.tsmimusicplay.Name = "tsmimusicplay";
            this.tsmimusicplay.Size = new System.Drawing.Size(172, 22);
            this.tsmimusicplay.Text = "播放顺序";
            // 
            // tsmimusicS
            // 
            this.tsmimusicS.BackColor = System.Drawing.Color.Teal;
            this.tsmimusicS.Image = global::音乐.Properties.Resources._2;
            this.tsmimusicS.Name = "tsmimusicS";
            this.tsmimusicS.Size = new System.Drawing.Size(140, 22);
            this.tsmimusicS.Text = "顺序播放";
            this.tsmimusicS.Click += new System.EventHandler(this.tsmimusicS_Click);
            // 
            // tsmiplayQ
            // 
            this.tsmiplayQ.BackColor = System.Drawing.Color.Teal;
            this.tsmiplayQ.Image = global::音乐.Properties.Resources._2;
            this.tsmiplayQ.Name = "tsmiplayQ";
            this.tsmiplayQ.Size = new System.Drawing.Size(140, 22);
            this.tsmiplayQ.Text = "随机播放";
            this.tsmiplayQ.Click += new System.EventHandler(this.tsmiplayQ_Click);
            // 
            // tsmiopname
            // 
            this.tsmiopname.Image = global::音乐.Properties.Resources._5;
            this.tsmiopname.Name = "tsmiopname";
            this.tsmiopname.Size = new System.Drawing.Size(172, 22);
            this.tsmiopname.Text = "打开文件位置";
            this.tsmiopname.Click += new System.EventHandler(this.tsmiopname_Click);
            // 
            // tmrleft
            // 
            this.tmrleft.Tick += new System.EventHandler(this.tmrleft_Tick);
            // 
            // skinplay
            // 
            this.skinplay.SerialNumber = "";
            this.skinplay.SkinFile = null;
            // 
            // tmrtl
            // 
            this.tmrtl.Enabled = true;
            this.tmrtl.Tick += new System.EventHandler(this.tmrtl_Tick);
            // 
            // ntfmusicioc
            // 
            this.ntfmusicioc.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfmusicioc.BalloonTipText = "泽 乐";
            this.ntfmusicioc.ContextMenuStrip = this.ctnmusicrun;
            this.ntfmusicioc.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfmusicioc.Icon")));
            this.ntfmusicioc.Text = "泽 乐";
            this.ntfmusicioc.Visible = true;
            this.ntfmusicioc.DoubleClick += new System.EventHandler(this.ntfmusicioc_DoubleClick);
            // 
            // ctnmusicrun
            // 
            this.ctnmusicrun.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctnmusicrun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimusicplays,
            this.tsmimusicplayt,
            this.tsmiclos});
            this.ctnmusicrun.Name = "ctnmusicrun";
            this.ctnmusicrun.Size = new System.Drawing.Size(103, 70);
            // 
            // tsmimusicplays
            // 
            this.tsmimusicplays.Name = "tsmimusicplays";
            this.tsmimusicplays.Size = new System.Drawing.Size(102, 22);
            this.tsmimusicplays.Text = "播放";
            this.tsmimusicplays.Click += new System.EventHandler(this.tsmimusicplayT_Click);
            // 
            // tsmimusicplayt
            // 
            this.tsmimusicplayt.Name = "tsmimusicplayt";
            this.tsmimusicplayt.Size = new System.Drawing.Size(102, 22);
            this.tsmimusicplayt.Text = "暂停";
            this.tsmimusicplayt.Click += new System.EventHandler(this.tsmimusicplayt_Click_1);
            // 
            // tsmiclos
            // 
            this.tsmiclos.Name = "tsmiclos";
            this.tsmiclos.Size = new System.Drawing.Size(102, 22);
            this.tsmiclos.Text = "关闭";
            this.tsmiclos.Click += new System.EventHandler(this.tsmiclos_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btninsert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninsert.Location = new System.Drawing.Point(4, 6);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(85, 27);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "添 加";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // pnmusicrun
            // 
            this.pnmusicrun.BackgroundImage = global::音乐.Properties.Resources._1;
            this.pnmusicrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnmusicrun.Controls.Add(this.lblskin);
            this.pnmusicrun.Controls.Add(this.btninsert);
            this.pnmusicrun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnmusicrun.Location = new System.Drawing.Point(0, 531);
            this.pnmusicrun.Name = "pnmusicrun";
            this.pnmusicrun.Size = new System.Drawing.Size(290, 37);
            this.pnmusicrun.TabIndex = 2;
            // 
            // lblskin
            // 
            this.lblskin.AutoSize = true;
            this.lblskin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblskin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblskin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblskin.Location = new System.Drawing.Point(243, 14);
            this.lblskin.Name = "lblskin";
            this.lblskin.Size = new System.Drawing.Size(42, 18);
            this.lblskin.TabIndex = 1;
            this.lblskin.Text = "皮肤";
            this.lblskin.Click += new System.EventHandler(this.lblskin_Click);
            // 
            // FrmMusic
            // 
            this.AcceptButton = this.btninsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(290, 568);
            this.Controls.Add(this.pnmusicrun);
            this.Controls.Add(this.pnmusic);
            this.Controls.Add(this.pnmusicname);
            this.Font = new System.Drawing.Font("新宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "泽 乐";
            this.Shown += new System.EventHandler(this.FrmMusic_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMusic_FormClosing);
            this.LocationChanged += new System.EventHandler(this.FrmMusic_LocationChanged);
            this.pnmusicname.ResumeLayout(false);
            this.pnmusicname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Axmusic)).EndInit();
            this.pnmusic.ResumeLayout(false);
            this.ctnmusic.ResumeLayout(false);
            this.ctnmusicrun.ResumeLayout(false);
            this.pnmusicrun.ResumeLayout(false);
            this.pnmusicrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnmusicname;
        private System.Windows.Forms.Panel pnmusic;
        private System.Windows.Forms.Panel pnmusicrun;
        private AxWMPLib.AxWindowsMediaPlayer Axmusic;
        private System.Windows.Forms.Label lblmusicname;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Timer tmrleft;
        private System.Windows.Forms.ContextMenuStrip ctnmusic;
        private System.Windows.Forms.ToolStripMenuItem tsmiplay;
        private System.Windows.Forms.ToolStripMenuItem tsmidelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiopname;
        private System.Windows.Forms.ListView lvmusic;
        private System.Windows.Forms.ToolStripMenuItem tsmimusicplay;
        private System.Windows.Forms.ToolStripMenuItem tsmimusicS;
        private System.Windows.Forms.ToolStripMenuItem tsmiplayQ;
        private System.Windows.Forms.PictureBox picmusic;
        private System.Windows.Forms.Label lblskin;
        private Sunisoft.IrisSkin.SkinEngine skinplay;
        private System.Windows.Forms.Timer tmrtl;
        private System.Windows.Forms.NotifyIcon ntfmusicioc;
        private System.Windows.Forms.ContextMenuStrip ctnmusicrun;
        private System.Windows.Forms.ToolStripMenuItem tsmimusicplays;
        private System.Windows.Forms.ToolStripMenuItem tsmiclos;
        private System.Windows.Forms.ToolStripMenuItem tsmimusicplayt;
    }
}

