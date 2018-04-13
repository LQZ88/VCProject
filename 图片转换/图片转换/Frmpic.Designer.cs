namespace 图片转换
{
    partial class Frmpic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpic));
            this.picimg = new System.Windows.Forms.PictureBox();
            this.cbopic = new System.Windows.Forms.ComboBox();
            this.mspicall = new System.Windows.Forms.MenuStrip();
            this.tsmpic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpicxuze = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpicclose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpicgeshi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmizhpic = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.mspicall.SuspendLayout();
            this.SuspendLayout();
            // 
            // picimg
            // 
            this.picimg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picimg.Location = new System.Drawing.Point(0, 24);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(440, 390);
            this.picimg.TabIndex = 1;
            this.picimg.TabStop = false;
            // 
            // cbopic
            // 
            this.cbopic.BackColor = System.Drawing.Color.White;
            this.cbopic.FormattingEnabled = true;
            this.cbopic.Items.AddRange(new object[] {
            "GIF格式",
            "JPG格式",
            "PNG格式",
            "BMP格式",
            "TIF格式"});
            this.cbopic.Location = new System.Drawing.Point(382, 0);
            this.cbopic.Name = "cbopic";
            this.cbopic.Size = new System.Drawing.Size(58, 24);
            this.cbopic.TabIndex = 2;
            // 
            // mspicall
            // 
            this.mspicall.BackColor = System.Drawing.SystemColors.Control;
            this.mspicall.Font = new System.Drawing.Font("宋体", 12F);
            this.mspicall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmpic,
            this.tsmpicgeshi});
            this.mspicall.Location = new System.Drawing.Point(0, 0);
            this.mspicall.Name = "mspicall";
            this.mspicall.Size = new System.Drawing.Size(440, 24);
            this.mspicall.TabIndex = 0;
            this.mspicall.Text = "menuStrip1";
            // 
            // tsmpic
            // 
            this.tsmpic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmpicxuze,
            this.tsmpicclose});
            this.tsmpic.Name = "tsmpic";
            this.tsmpic.Size = new System.Drawing.Size(52, 20);
            this.tsmpic.Text = "文件";
            // 
            // tsmpicxuze
            // 
            this.tsmpicxuze.Name = "tsmpicxuze";
            this.tsmpicxuze.Size = new System.Drawing.Size(140, 22);
            this.tsmpicxuze.Text = "查看图片";
            this.tsmpicxuze.Click += new System.EventHandler(this.tsmpicxuze_Click);
            // 
            // tsmpicclose
            // 
            this.tsmpicclose.Name = "tsmpicclose";
            this.tsmpicclose.Size = new System.Drawing.Size(140, 22);
            this.tsmpicclose.Text = "关闭程序";
            this.tsmpicclose.Click += new System.EventHandler(this.tsmpicclose_Click);
            // 
            // tsmpicgeshi
            // 
            this.tsmpicgeshi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmizhpic});
            this.tsmpicgeshi.Name = "tsmpicgeshi";
            this.tsmpicgeshi.Size = new System.Drawing.Size(52, 20);
            this.tsmpicgeshi.Text = "编辑";
            // 
            // tsmizhpic
            // 
            this.tsmizhpic.Name = "tsmizhpic";
            this.tsmizhpic.Size = new System.Drawing.Size(140, 22);
            this.tsmizhpic.Text = "转换图片";
            this.tsmizhpic.Click += new System.EventHandler(this.tsmizhpic_Click);
            // 
            // Frmpic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 414);
            this.Controls.Add(this.mspicall);
            this.Controls.Add(this.picimg);
            this.Controls.Add(this.cbopic);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspicall;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frmpic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转换";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmpic_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.mspicall.ResumeLayout(false);
            this.mspicall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.ComboBox cbopic;
        private System.Windows.Forms.MenuStrip mspicall;
        private System.Windows.Forms.ToolStripMenuItem tsmpic;
        private System.Windows.Forms.ToolStripMenuItem tsmpicxuze;
        private System.Windows.Forms.ToolStripMenuItem tsmpicclose;
        private System.Windows.Forms.ToolStripMenuItem tsmpicgeshi;
        private System.Windows.Forms.ToolStripMenuItem tsmizhpic;
    }
}