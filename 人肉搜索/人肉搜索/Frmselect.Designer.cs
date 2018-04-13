namespace 人肉搜索
{
    partial class Frmlogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.cbodiqu = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonselect = new System.Windows.Forms.Button();
            this.dgvpoert = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmirun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlclose = new System.Windows.Forms.ToolStripMenuItem();
            this.pgto = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpoert)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字：";
            // 
            // cbodiqu
            // 
            this.cbodiqu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbodiqu.FormattingEnabled = true;
            this.cbodiqu.Location = new System.Drawing.Point(430, 13);
            this.cbodiqu.Name = "cbodiqu";
            this.cbodiqu.Size = new System.Drawing.Size(129, 24);
            this.cbodiqu.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(133, 14);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(120, 23);
            this.txtname.TabIndex = 1;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(307, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "所在城市：";
            // 
            // buttonselect
            // 
            this.buttonselect.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonselect.Location = new System.Drawing.Point(587, 12);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(82, 32);
            this.buttonselect.TabIndex = 3;
            this.buttonselect.Text = "搜 索";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dgvpoert
            // 
            this.dgvpoert.BackgroundColor = System.Drawing.Color.White;
            this.dgvpoert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpoert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpoert.Location = new System.Drawing.Point(0, 50);
            this.dgvpoert.Name = "dgvpoert";
            this.dgvpoert.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpoert.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpoert.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvpoert.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpoert.RowTemplate.Height = 23;
            this.dgvpoert.Size = new System.Drawing.Size(829, 353);
            this.dgvpoert.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmirun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 403);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 32);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmirun
            // 
            this.tsmirun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlclose});
            this.tsmirun.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.tsmirun.Name = "tsmirun";
            this.tsmirun.Size = new System.Drawing.Size(58, 28);
            this.tsmirun.Text = "设置";
            // 
            // tsmlclose
            // 
            this.tsmlclose.Name = "tsmlclose";
            this.tsmlclose.Size = new System.Drawing.Size(116, 28);
            this.tsmlclose.Text = "退出";
            this.tsmlclose.Click += new System.EventHandler(this.tsmlclose_Click);
            // 
            // pgto
            // 
            this.pgto.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pgto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pgto.Location = new System.Drawing.Point(703, 403);
            this.pgto.Name = "pgto";
            this.pgto.Size = new System.Drawing.Size(126, 32);
            this.pgto.TabIndex = 14;
            this.pgto.Value = 99;
            // 
            // Frmlogin
            // 
            this.AcceptButton = this.buttonselect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 435);
            this.Controls.Add(this.pgto);
            this.Controls.Add(this.dgvpoert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbodiqu);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搜索";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmlogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpoert)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbodiqu;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.DataGridView dgvpoert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmirun;
        private System.Windows.Forms.ToolStripMenuItem tsmlclose;
        private System.Windows.Forms.ProgressBar pgto;
    }
}

