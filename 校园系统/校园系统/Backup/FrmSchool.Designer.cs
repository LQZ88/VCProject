namespace School
{
    partial class FrmSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchool));
            this.btngoto = new System.Windows.Forms.Button();
            this.rdomaster = new System.Windows.Forms.RadioButton();
            this.rdoteacher = new System.Windows.Forms.RadioButton();
            this.rdostudent = new System.Windows.Forms.RadioButton();
            this.btngoover = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.gostr = new System.Windows.Forms.GroupBox();
            this.gostr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngoto
            // 
            this.btngoto.BackColor = System.Drawing.Color.Silver;
            this.btngoto.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btngoto.Location = new System.Drawing.Point(437, 311);
            this.btngoto.Name = "btngoto";
            this.btngoto.Size = new System.Drawing.Size(92, 46);
            this.btngoto.TabIndex = 0;
            this.btngoto.Text = "进 入";
            this.btngoto.UseVisualStyleBackColor = false;
            this.btngoto.Click += new System.EventHandler(this.btngoto_Click);
            // 
            // rdomaster
            // 
            this.rdomaster.AutoSize = true;
            this.rdomaster.BackColor = System.Drawing.Color.Transparent;
            this.rdomaster.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdomaster.Location = new System.Drawing.Point(351, 71);
            this.rdomaster.Name = "rdomaster";
            this.rdomaster.Size = new System.Drawing.Size(121, 33);
            this.rdomaster.TabIndex = 2;
            this.rdomaster.TabStop = true;
            this.rdomaster.Text = "管理员";
            this.rdomaster.UseVisualStyleBackColor = false;
            // 
            // rdoteacher
            // 
            this.rdoteacher.AutoSize = true;
            this.rdoteacher.BackColor = System.Drawing.Color.Transparent;
            this.rdoteacher.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoteacher.Location = new System.Drawing.Point(189, 71);
            this.rdoteacher.Name = "rdoteacher";
            this.rdoteacher.Size = new System.Drawing.Size(107, 33);
            this.rdoteacher.TabIndex = 1;
            this.rdoteacher.TabStop = true;
            this.rdoteacher.Text = "教 师";
            this.rdoteacher.UseVisualStyleBackColor = false;
            // 
            // rdostudent
            // 
            this.rdostudent.AutoSize = true;
            this.rdostudent.BackColor = System.Drawing.Color.Transparent;
            this.rdostudent.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdostudent.Location = new System.Drawing.Point(41, 71);
            this.rdostudent.Name = "rdostudent";
            this.rdostudent.Size = new System.Drawing.Size(107, 33);
            this.rdostudent.TabIndex = 0;
            this.rdostudent.TabStop = true;
            this.rdostudent.Text = "学 生";
            this.rdostudent.UseVisualStyleBackColor = false;
            // 
            // btngoover
            // 
            this.btngoover.BackColor = System.Drawing.Color.LavenderBlush;
            this.btngoover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btngoover.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btngoover.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btngoover.Location = new System.Drawing.Point(60, 311);
            this.btngoover.Name = "btngoover";
            this.btngoover.Size = new System.Drawing.Size(93, 46);
            this.btngoover.TabIndex = 1;
            this.btngoover.Text = "退 出";
            this.btngoover.UseVisualStyleBackColor = false;
            this.btngoover.Click += new System.EventHandler(this.btngoover_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("华文楷体", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblname.Location = new System.Drawing.Point(398, 19);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(341, 72);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "校 园 系 统";
            // 
            // gostr
            // 
            this.gostr.BackColor = System.Drawing.Color.Transparent;
            this.gostr.Controls.Add(this.rdostudent);
            this.gostr.Controls.Add(this.rdomaster);
            this.gostr.Controls.Add(this.rdoteacher);
            this.gostr.Location = new System.Drawing.Point(28, 115);
            this.gostr.Name = "gostr";
            this.gostr.Size = new System.Drawing.Size(543, 177);
            this.gostr.TabIndex = 5;
            this.gostr.TabStop = false;
            this.gostr.Text = "☆请 选 择 您 的 身 份☆";
            // 
            // FrmSchool
            // 
            this.AcceptButton = this.btngoto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::School.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btngoover;
            this.ClientSize = new System.Drawing.Size(767, 368);
            this.Controls.Add(this.gostr);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btngoover);
            this.Controls.Add(this.btngoto);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WHY.L";
            this.Shown += new System.EventHandler(this.FrmSchool_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSchool_FormClosing);
            this.gostr.ResumeLayout(false);
            this.gostr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoto;
        private System.Windows.Forms.RadioButton rdomaster;
        private System.Windows.Forms.RadioButton rdoteacher;
        private System.Windows.Forms.RadioButton rdostudent;
        private System.Windows.Forms.Button btngoover;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox gostr;
    }
}

