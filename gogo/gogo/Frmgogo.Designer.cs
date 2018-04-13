namespace gogo
{
    partial class Frmgogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmgogo));
            this.tmrBottom = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.lbltop = new System.Windows.Forms.Label();
            this.tmrtop = new System.Windows.Forms.Timer(this.components);
            this.btnmusic = new System.Windows.Forms.Button();
            this.lbltop1 = new System.Windows.Forms.Label();
            this.tmrtop1 = new System.Windows.Forms.Timer(this.components);
            this.lblBottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrBottom
            // 
            this.tmrBottom.Tick += new System.EventHandler(this.tmrBottom_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("新宋体", 12F);
            this.btnstart.Location = new System.Drawing.Point(1, 344);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(103, 35);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "开始/暂停";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnleft_MouseClick);
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltop.Location = new System.Drawing.Point(12, 343);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(55, 46);
            this.lbltop.TabIndex = 3;
            this.lbltop.Text = "︽";
            // 
            // tmrtop
            // 
            this.tmrtop.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnmusic
            // 
            this.btnmusic.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmusic.Location = new System.Drawing.Point(228, 344);
            this.btnmusic.Name = "btnmusic";
            this.btnmusic.Size = new System.Drawing.Size(75, 35);
            this.btnmusic.TabIndex = 4;
            this.btnmusic.Text = "音乐";
            this.btnmusic.UseVisualStyleBackColor = true;
            this.btnmusic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lbltop1
            // 
            this.lbltop1.AutoSize = true;
            this.lbltop1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltop1.Location = new System.Drawing.Point(241, 344);
            this.lbltop1.Name = "lbltop1";
            this.lbltop1.Size = new System.Drawing.Size(55, 46);
            this.lbltop1.TabIndex = 5;
            this.lbltop1.Text = "︽";
            // 
            // tmrtop1
            // 
            this.tmrtop1.Tick += new System.EventHandler(this.tmrtop1_Tick);
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblBottom.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBottom.Location = new System.Drawing.Point(134, 344);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(55, 46);
            this.lblBottom.TabIndex = 6;
            this.lblBottom.Text = "︽";
            // 
            // Frmgogo
            // 
            this.AcceptButton = this.btnstart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::gogo.Properties.Resources._110__29_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(308, 390);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.btnmusic);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lbltop1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmgogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运 动";
            this.Activated += new System.EventHandler(this.Frmgogo_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmgogo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBottom;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Timer tmrtop;
        private System.Windows.Forms.Button btnmusic;
        private System.Windows.Forms.Label lbltop1;
        private System.Windows.Forms.Timer tmrtop1;
        private System.Windows.Forms.Label lblBottom;
    }
}

