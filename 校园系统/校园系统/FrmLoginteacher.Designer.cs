namespace School
{
    partial class FrmLoginteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginteacher));
            this.txtLoginpwd = new System.Windows.Forms.TextBox();
            this.lblLoginpwd = new System.Windows.Forms.Label();
            this.txtLoginname = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLoginposition = new System.Windows.Forms.Label();
            this.cboLoginposition = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblpwd = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtLoginpwd
            // 
            this.txtLoginpwd.AcceptsTab = true;
            this.txtLoginpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginpwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLoginpwd.Location = new System.Drawing.Point(217, 157);
            this.txtLoginpwd.Name = "txtLoginpwd";
            this.txtLoginpwd.PasswordChar = '*';
            this.txtLoginpwd.Size = new System.Drawing.Size(210, 30);
            this.txtLoginpwd.TabIndex = 15;
            this.txtLoginpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginpwd
            // 
            this.lblLoginpwd.AutoSize = true;
            this.lblLoginpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginpwd.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLoginpwd.Location = new System.Drawing.Point(68, 157);
            this.lblLoginpwd.Name = "lblLoginpwd";
            this.lblLoginpwd.Size = new System.Drawing.Size(128, 30);
            this.lblLoginpwd.TabIndex = 14;
            this.lblLoginpwd.Text = "密    码：";
            // 
            // txtLoginname
            // 
            this.txtLoginname.AcceptsTab = true;
            this.txtLoginname.BackColor = System.Drawing.Color.Snow;
            this.txtLoginname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLoginname.Location = new System.Drawing.Point(217, 97);
            this.txtLoginname.Name = "txtLoginname";
            this.txtLoginname.Size = new System.Drawing.Size(210, 30);
            this.txtLoginname.TabIndex = 13;
            this.txtLoginname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLoginName.Location = new System.Drawing.Point(68, 97);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(128, 30);
            this.lblLoginName.TabIndex = 12;
            this.lblLoginName.Text = "姓    名：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("华文行楷", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Lavender;
            this.lblName.Location = new System.Drawing.Point(55, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(249, 59);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "教师登录";
            // 
            // lblLoginposition
            // 
            this.lblLoginposition.AutoSize = true;
            this.lblLoginposition.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginposition.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLoginposition.Location = new System.Drawing.Point(68, 219);
            this.lblLoginposition.Name = "lblLoginposition";
            this.lblLoginposition.Size = new System.Drawing.Size(128, 30);
            this.lblLoginposition.TabIndex = 34;
            this.lblLoginposition.Text = "类    型：";
            // 
            // cboLoginposition
            // 
            this.cboLoginposition.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboLoginposition.FormattingEnabled = true;
            this.cboLoginposition.Location = new System.Drawing.Point(217, 219);
            this.cboLoginposition.Name = "cboLoginposition";
            this.cboLoginposition.Size = new System.Drawing.Size(210, 28);
            this.cboLoginposition.TabIndex = 35;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.Location = new System.Drawing.Point(79, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 65);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "登陆";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(431, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 65);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpwd.Location = new System.Drawing.Point(465, 158);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(129, 29);
            this.lblpwd.TabIndex = 38;
            this.lblpwd.TabStop = true;
            this.lblpwd.Text = "修改密码";
            this.lblpwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblpwd_LinkClicked);
            // 
            // FrmLoginteacher
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School.Properties.Resources._6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(625, 380);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboLoginposition);
            this.Controls.Add(this.lblLoginposition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtLoginpwd);
            this.Controls.Add(this.lblLoginpwd);
            this.Controls.Add(this.txtLoginname);
            this.Controls.Add(this.lblLoginName);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLoginteacher_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoginteacher_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginpwd;
        private System.Windows.Forms.Label lblLoginpwd;
        private System.Windows.Forms.TextBox txtLoginname;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLoginposition;
        private System.Windows.Forms.ComboBox cboLoginposition;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblpwd;
    }
}