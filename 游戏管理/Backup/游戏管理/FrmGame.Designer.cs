namespace 游戏管理
{
    partial class FrmGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.btnok = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvgame = new System.Windows.Forms.DataGridView();
            this.btnName = new System.Windows.Forms.Button();
            this.btnGMS = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Timer(this.components);
            this.txtGMS = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGMS = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(527, 474);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(63, 25);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "刷新";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(348, 479);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(77, 14);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "每隔秒/次:";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(377, 163);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 22);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "确认修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(128, 163);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 22);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "确认添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvgame
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvgame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvgame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvgame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvgame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvgame.Location = new System.Drawing.Point(1, 200);
            this.dgvgame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvgame.Name = "dgvgame";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgame.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvgame.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgame.RowTemplate.Height = 23;
            this.dgvgame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvgame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgame.Size = new System.Drawing.Size(650, 262);
            this.dgvgame.TabIndex = 11;
            this.dgvgame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgame_CellContentClick);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(463, 11);
            this.btnName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(136, 22);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "按游戏名查询";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnGMS
            // 
            this.btnGMS.Location = new System.Drawing.Point(463, 113);
            this.btnGMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGMS.Name = "btnGMS";
            this.btnGMS.Size = new System.Drawing.Size(136, 22);
            this.btnGMS.TabIndex = 6;
            this.btnGMS.Text = "按加盟商查询";
            this.btnGMS.UseVisualStyleBackColor = true;
            this.btnGMS.Click += new System.EventHandler(this.btnGMS_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(463, 58);
            this.btnType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(136, 22);
            this.btnType.TabIndex = 4;
            this.btnType.Text = "按游戏类别查询";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // times
            // 
            this.times.Enabled = true;
            this.times.Interval = 10000;
            this.times.Tick += new System.EventHandler(this.times_Tick);
            // 
            // txtGMS
            // 
            this.txtGMS.Location = new System.Drawing.Point(138, 115);
            this.txtGMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGMS.Name = "txtGMS";
            this.txtGMS.Size = new System.Drawing.Size(287, 23);
            this.txtGMS.TabIndex = 5;
            this.txtGMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(138, 59);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(287, 23);
            this.txtType.TabIndex = 3;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGMS
            // 
            this.lblGMS.AutoSize = true;
            this.lblGMS.Location = new System.Drawing.Point(37, 119);
            this.lblGMS.Name = "lblGMS";
            this.lblGMS.Size = new System.Drawing.Size(56, 14);
            this.lblGMS.TabIndex = 0;
            this.lblGMS.Text = "加盟商:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(37, 69);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(70, 14);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "游戏类别:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "游戏名称:";
            // 
            // txttime
            // 
            this.txttime.Font = new System.Drawing.Font("宋体", 10F);
            this.txttime.Location = new System.Drawing.Point(431, 475);
            this.txttime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(70, 23);
            this.txttime.TabIndex = 12;
            this.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmGame
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(653, 511);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvgame);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnGMS);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.txtGMS);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGMS);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏管理";
            this.Shown += new System.EventHandler(this.FrmGame_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnok;
        internal System.Windows.Forms.Label lbltime;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.DataGridView dgvgame;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnGMS;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Timer times;
        private System.Windows.Forms.TextBox txtGMS;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGMS;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txttime;
    }
}

