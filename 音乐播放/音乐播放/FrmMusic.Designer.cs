namespace 音乐播放
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
            this.AXMusicMV = new AxWMPLib.AxWindowsMediaPlayer();
            this.gpMusicMV = new System.Windows.Forms.GroupBox();
            this.LVMusicMVName = new System.Windows.Forms.ListView();
            this.ctMusicMV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiinsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiplaySQ = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiplayS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiplayQ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiselect = new System.Windows.Forms.ToolStripMenuItem();
            this.gpMusicMVplay = new System.Windows.Forms.GroupBox();
            this.lblMusicMV = new System.Windows.Forms.Label();
            this.tmrTL = new System.Windows.Forms.Timer(this.components);
            this.nomusic = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctnclos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiplayt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiclos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmihide = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AXMusicMV)).BeginInit();
            this.gpMusicMV.SuspendLayout();
            this.ctMusicMV.SuspendLayout();
            this.gpMusicMVplay.SuspendLayout();
            this.ctnclos.SuspendLayout();
            this.SuspendLayout();
            // 
            // AXMusicMV
            // 
            this.AXMusicMV.Enabled = true;
            this.AXMusicMV.Location = new System.Drawing.Point(3, 28);
            this.AXMusicMV.Name = "AXMusicMV";
            this.AXMusicMV.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AXMusicMV.OcxState")));
            this.AXMusicMV.Size = new System.Drawing.Size(834, 537);
            this.AXMusicMV.TabIndex = 0;
            // 
            // gpMusicMV
            // 
            this.gpMusicMV.Controls.Add(this.LVMusicMVName);
            this.gpMusicMV.Location = new System.Drawing.Point(848, 0);
            this.gpMusicMV.Name = "gpMusicMV";
            this.gpMusicMV.Size = new System.Drawing.Size(170, 568);
            this.gpMusicMV.TabIndex = 11;
            this.gpMusicMV.TabStop = false;
            this.gpMusicMV.Text = "播放列表";
            // 
            // LVMusicMVName
            // 
            this.LVMusicMVName.BackColor = System.Drawing.SystemColors.Control;
            this.LVMusicMVName.ContextMenuStrip = this.ctMusicMV;
            this.LVMusicMVName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LVMusicMVName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVMusicMVName.Location = new System.Drawing.Point(3, 28);
            this.LVMusicMVName.Name = "LVMusicMVName";
            this.LVMusicMVName.Size = new System.Drawing.Size(164, 537);
            this.LVMusicMVName.TabIndex = 0;
            this.LVMusicMVName.UseCompatibleStateImageBehavior = false;
            this.LVMusicMVName.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ctMusicMV
            // 
            this.ctMusicMV.Font = new System.Drawing.Font("新宋体", 12F);
            this.ctMusicMV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiplay,
            this.tsmidelete,
            this.tsmiinsert,
            this.tsmiplaySQ,
            this.tsmiselect});
            this.ctMusicMV.Name = "ctMusicMV";
            this.ctMusicMV.Size = new System.Drawing.Size(141, 114);
            // 
            // tsmiplay
            // 
            this.tsmiplay.Name = "tsmiplay";
            this.tsmiplay.Size = new System.Drawing.Size(140, 22);
            this.tsmiplay.Text = "播放";
            this.tsmiplay.Click += new System.EventHandler(this.tsmiplay_Click);
            // 
            // tsmidelete
            // 
            this.tsmidelete.Name = "tsmidelete";
            this.tsmidelete.Size = new System.Drawing.Size(140, 22);
            this.tsmidelete.Text = "清空列表";
            this.tsmidelete.Click += new System.EventHandler(this.tsmidelete_Click);
            // 
            // tsmiinsert
            // 
            this.tsmiinsert.Name = "tsmiinsert";
            this.tsmiinsert.Size = new System.Drawing.Size(140, 22);
            this.tsmiinsert.Text = "添加列表";
            this.tsmiinsert.Click += new System.EventHandler(this.tsmiinsert_Click);
            // 
            // tsmiplaySQ
            // 
            this.tsmiplaySQ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiplayS,
            this.tsmiplayQ});
            this.tsmiplaySQ.Name = "tsmiplaySQ";
            this.tsmiplaySQ.Size = new System.Drawing.Size(140, 22);
            this.tsmiplaySQ.Text = "播放顺序";
            // 
            // tmsiplayS
            // 
            this.tmsiplayS.Name = "tmsiplayS";
            this.tmsiplayS.Size = new System.Drawing.Size(140, 22);
            this.tmsiplayS.Text = "顺序播放";
            this.tmsiplayS.Click += new System.EventHandler(this.tmsiplayS_Click);
            // 
            // tsmiplayQ
            // 
            this.tsmiplayQ.Name = "tsmiplayQ";
            this.tsmiplayQ.Size = new System.Drawing.Size(140, 22);
            this.tsmiplayQ.Text = "随机播放";
            this.tsmiplayQ.Click += new System.EventHandler(this.tsmiplayQ_Click);
            // 
            // tsmiselect
            // 
            this.tsmiselect.Name = "tsmiselect";
            this.tsmiselect.Size = new System.Drawing.Size(140, 22);
            this.tsmiselect.Text = "网络搜索";
            this.tsmiselect.Click += new System.EventHandler(this.tsmiselect_Click);
            // 
            // gpMusicMVplay
            // 
            this.gpMusicMVplay.Controls.Add(this.lblMusicMV);
            this.gpMusicMVplay.Controls.Add(this.AXMusicMV);
            this.gpMusicMVplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpMusicMVplay.Location = new System.Drawing.Point(0, 0);
            this.gpMusicMVplay.Name = "gpMusicMVplay";
            this.gpMusicMVplay.Size = new System.Drawing.Size(846, 568);
            this.gpMusicMVplay.TabIndex = 12;
            this.gpMusicMVplay.TabStop = false;
            this.gpMusicMVplay.Text = "播放";
            // 
            // lblMusicMV
            // 
            this.lblMusicMV.AutoSize = true;
            this.lblMusicMV.Location = new System.Drawing.Point(802, 540);
            this.lblMusicMV.Name = "lblMusicMV";
            this.lblMusicMV.Size = new System.Drawing.Size(36, 21);
            this.lblMusicMV.TabIndex = 1;
            this.lblMusicMV.Text = ">>";
            this.lblMusicMV.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmrTL
            // 
            this.tmrTL.Enabled = true;
            this.tmrTL.Tick += new System.EventHandler(this.tmrTL_Tick);
            // 
            // nomusic
            // 
            this.nomusic.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nomusic.ContextMenuStrip = this.ctnclos;
            this.nomusic.Icon = ((System.Drawing.Icon)(resources.GetObject("nomusic.Icon")));
            this.nomusic.Text = "泽 频";
            this.nomusic.Visible = true;
            this.nomusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nomusic_MouseDoubleClick);
            // 
            // ctnclos
            // 
            this.ctnclos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiplayt,
            this.tsmihide,
            this.tsmiclos});
            this.ctnclos.Name = "ctnclos";
            this.ctnclos.Size = new System.Drawing.Size(130, 70);
            // 
            // tsmiplayt
            // 
            this.tsmiplayt.Name = "tsmiplayt";
            this.tsmiplayt.Size = new System.Drawing.Size(129, 22);
            this.tsmiplayt.Text = "暂停/播放";
            this.tsmiplayt.Click += new System.EventHandler(this.tsmiplayt_Click);
            // 
            // tsmiclos
            // 
            this.tsmiclos.Name = "tsmiclos";
            this.tsmiclos.Size = new System.Drawing.Size(129, 22);
            this.tsmiclos.Text = "关闭程序";
            this.tsmiclos.Click += new System.EventHandler(this.tsmiclos_Click);
            // 
            // tsmihide
            // 
            this.tsmihide.Name = "tsmihide";
            this.tsmihide.Size = new System.Drawing.Size(129, 22);
            this.tsmihide.Text = "隐藏托盘";
            this.tsmihide.Click += new System.EventHandler(this.tsmihide_Click);
            // 
            // FrmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 568);
            this.Controls.Add(this.gpMusicMVplay);
            this.Controls.Add(this.gpMusicMV);
            this.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "泽 频";
            this.Shown += new System.EventHandler(this.FrmMusic_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMusic_FormClosing);
            this.LocationChanged += new System.EventHandler(this.FrmMusic_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.AXMusicMV)).EndInit();
            this.gpMusicMV.ResumeLayout(false);
            this.ctMusicMV.ResumeLayout(false);
            this.gpMusicMVplay.ResumeLayout(false);
            this.gpMusicMVplay.PerformLayout();
            this.ctnclos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer AXMusicMV;
        private System.Windows.Forms.GroupBox gpMusicMV;
        private System.Windows.Forms.ListView LVMusicMVName;
        private System.Windows.Forms.ContextMenuStrip ctMusicMV;
        private System.Windows.Forms.ToolStripMenuItem tsmiplay;
        private System.Windows.Forms.ToolStripMenuItem tsmidelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiinsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiplaySQ;
        private System.Windows.Forms.ToolStripMenuItem tmsiplayS;
        private System.Windows.Forms.ToolStripMenuItem tsmiplayQ;
        private System.Windows.Forms.GroupBox gpMusicMVplay;
        private System.Windows.Forms.ToolStripMenuItem tsmiselect;
        private System.Windows.Forms.Label lblMusicMV;
        private System.Windows.Forms.Timer tmrTL;
        private System.Windows.Forms.NotifyIcon nomusic;
        private System.Windows.Forms.ContextMenuStrip ctnclos;
        private System.Windows.Forms.ToolStripMenuItem tsmihide;
        private System.Windows.Forms.ToolStripMenuItem tsmiclos;
        private System.Windows.Forms.ToolStripMenuItem tsmiplayt;
    }
}

