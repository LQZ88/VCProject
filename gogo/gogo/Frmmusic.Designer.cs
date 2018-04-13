namespace gogo
{
    partial class Frmmusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmusic));
            this.axmusicmv = new AxWMPLib.AxWindowsMediaPlayer();
            this.openF = new System.Windows.Forms.OpenFileDialog();
            this.grbmusic = new System.Windows.Forms.GroupBox();
            this.lvmusic = new System.Windows.Forms.ListView();
            this.cmstplay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiplays = new System.Windows.Forms.ToolStripMenuItem();
            this.mamusic = new System.Windows.Forms.MenuStrip();
            this.tsmiinsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiback = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiclose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiskin = new System.Windows.Forms.ToolStripMenuItem();
            this.skinss = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.axmusicmv)).BeginInit();
            this.grbmusic.SuspendLayout();
            this.cmstplay.SuspendLayout();
            this.mamusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // axmusicmv
            // 
            this.axmusicmv.Dock = System.Windows.Forms.DockStyle.Left;
            this.axmusicmv.Enabled = true;
            this.axmusicmv.Location = new System.Drawing.Point(0, 0);
            this.axmusicmv.Name = "axmusicmv";
            this.axmusicmv.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axmusicmv.OcxState")));
            this.axmusicmv.Size = new System.Drawing.Size(587, 539);
            this.axmusicmv.TabIndex = 3;
            // 
            // openF
            // 
            this.openF.FileName = "openFileDialog1";
            // 
            // grbmusic
            // 
            this.grbmusic.Controls.Add(this.lvmusic);
            this.grbmusic.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbmusic.Location = new System.Drawing.Point(590, 0);
            this.grbmusic.Name = "grbmusic";
            this.grbmusic.Size = new System.Drawing.Size(200, 539);
            this.grbmusic.TabIndex = 9;
            this.grbmusic.TabStop = false;
            this.grbmusic.Text = "列表";
            // 
            // lvmusic
            // 
            this.lvmusic.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvmusic.ContextMenuStrip = this.cmstplay;
            this.lvmusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvmusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvmusic.Font = new System.Drawing.Font("华文楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lvmusic.Location = new System.Drawing.Point(3, 19);
            this.lvmusic.Name = "lvmusic";
            this.lvmusic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvmusic.Size = new System.Drawing.Size(194, 517);
            this.lvmusic.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvmusic.TabIndex = 0;
            this.lvmusic.UseCompatibleStateImageBehavior = false;
            this.lvmusic.View = System.Windows.Forms.View.SmallIcon;
            // 
            // cmstplay
            // 
            this.cmstplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiplays});
            this.cmstplay.Name = "cmstplay";
            this.cmstplay.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmstplay.Size = new System.Drawing.Size(128, 28);
            // 
            // tsmiplays
            // 
            this.tsmiplays.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiplays.Font = new System.Drawing.Font("楷体", 15F);
            this.tsmiplays.Image = global::gogo.Properties.Resources._1000__12_;
            this.tsmiplays.ImageTransparentColor = System.Drawing.Color.Gray;
            this.tsmiplays.Name = "tsmiplays";
            this.tsmiplays.Size = new System.Drawing.Size(127, 24);
            this.tsmiplays.Text = "播 放";
            this.tsmiplays.Click += new System.EventHandler(this.tsmiplays_Click);
            // 
            // mamusic
            // 
            this.mamusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mamusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiinsert,
            this.tsmiback,
            this.tsmiclose,
            this.tsmiskin});
            this.mamusic.Location = new System.Drawing.Point(0, 539);
            this.mamusic.Name = "mamusic";
            this.mamusic.Size = new System.Drawing.Size(790, 29);
            this.mamusic.TabIndex = 10;
            this.mamusic.Text = "menuStrip1";
            // 
            // tsmiinsert
            // 
            this.tsmiinsert.Font = new System.Drawing.Font("新宋体", 15F);
            this.tsmiinsert.Image = global::gogo.Properties.Resources._20_;
            this.tsmiinsert.Name = "tsmiinsert";
            this.tsmiinsert.Size = new System.Drawing.Size(87, 25);
            this.tsmiinsert.Text = "添 加";
            this.tsmiinsert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsmiinsert_MouseDown);
            // 
            // tsmiback
            // 
            this.tsmiback.Font = new System.Drawing.Font("新宋体", 15F);
            this.tsmiback.Image = global::gogo.Properties.Resources._26755_1240194118BEK6;
            this.tsmiback.Name = "tsmiback";
            this.tsmiback.Size = new System.Drawing.Size(87, 25);
            this.tsmiback.Text = "返 回";
            this.tsmiback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsmiback_MouseDown);
            // 
            // tsmiclose
            // 
            this.tsmiclose.Font = new System.Drawing.Font("新宋体", 15F);
            this.tsmiclose.Image = global::gogo.Properties.Resources._110__29_;
            this.tsmiclose.Name = "tsmiclose";
            this.tsmiclose.Size = new System.Drawing.Size(87, 25);
            this.tsmiclose.Text = "关 闭";
            this.tsmiclose.Click += new System.EventHandler(this.tsmiclose_Click);
            // 
            // tsmiskin
            // 
            this.tsmiskin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiskin.BackColor = System.Drawing.Color.Silver;
            this.tsmiskin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tsmiskin.Image = global::gogo.Properties.Resources._11_;
            this.tsmiskin.Name = "tsmiskin";
            this.tsmiskin.Size = new System.Drawing.Size(75, 25);
            this.tsmiskin.Text = "皮 肤";
            this.tsmiskin.Click += new System.EventHandler(this.tsmiskin_Click);
            // 
            // skinss
            // 
            this.skinss.SerialNumber = "";
            this.skinss.SkinFile = null;
            // 
            // Frmmusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.grbmusic);
            this.Controls.Add(this.axmusicmv);
            this.Controls.Add(this.mamusic);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mamusic;
            this.MaximizeBox = false;
            this.Name = "Frmmusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐播放";
            this.Shown += new System.EventHandler(this.Frmmusic_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmmusic_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axmusicmv)).EndInit();
            this.grbmusic.ResumeLayout(false);
            this.cmstplay.ResumeLayout(false);
            this.mamusic.ResumeLayout(false);
            this.mamusic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axmusicmv;
        private System.Windows.Forms.OpenFileDialog openF;
        private System.Windows.Forms.GroupBox grbmusic;
        private System.Windows.Forms.MenuStrip mamusic;
        private System.Windows.Forms.ToolStripMenuItem tsmiinsert;
        private System.Windows.Forms.ListView lvmusic;
        private System.Windows.Forms.ToolStripMenuItem tsmiback;
        private System.Windows.Forms.ToolStripMenuItem tsmiclose;
        private System.Windows.Forms.ContextMenuStrip cmstplay;
        private System.Windows.Forms.ToolStripMenuItem tsmiplays;
        private System.Windows.Forms.ToolStripMenuItem tsmiskin;
        private Sunisoft.IrisSkin.SkinEngine skinss;
    }
}