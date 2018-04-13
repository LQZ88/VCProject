namespace School
{
    partial class FrmLoginstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginstudent));
            this.lblName = new System.Windows.Forms.Label();
            this.lblLoginpwd = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lkblpassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("华文行楷", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(68, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(249, 59);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "学生登录";
            // 
            // lblLoginpwd
            // 
            this.lblLoginpwd.AutoSize = true;
            this.lblLoginpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginpwd.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginpwd.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginpwd.Location = new System.Drawing.Point(63, 186);
            this.lblLoginpwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginpwd.Name = "lblLoginpwd";
            this.lblLoginpwd.Size = new System.Drawing.Size(121, 30);
            this.lblLoginpwd.TabIndex = 27;
            this.lblLoginpwd.Text = "密   码：";
            // 
            // txtLoginID
            // 
            this.txtLoginID.AcceptsTab = true;
            this.txtLoginID.BackColor = System.Drawing.Color.White;
            this.txtLoginID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginID.Location = new System.Drawing.Point(228, 108);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(210, 30);
            this.txtLoginID.TabIndex = 34;
            this.txtLoginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginID.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginID.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginID.Location = new System.Drawing.Point(62, 108);
            this.lblLoginID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(121, 30);
            this.lblLoginID.TabIndex = 38;
            this.lblLoginID.Text = "学   号：";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.AcceptsTab = true;
            this.txtLoginPwd.BackColor = System.Drawing.Color.White;
            this.txtLoginPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginPwd.Location = new System.Drawing.Point(228, 186);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '●';
            this.txtLoginPwd.Size = new System.Drawing.Size(210, 30);
            this.txtLoginPwd.TabIndex = 40;
            this.txtLoginPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.Location = new System.Drawing.Point(67, 263);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 65);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "进入";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(338, 263);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 65);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lkblpassword
            // 
            this.lkblpassword.AutoSize = true;
            this.lkblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lkblpassword.Font = new System.Drawing.Font("宋体", 18F);
            this.lkblpassword.Location = new System.Drawing.Point(483, 192);
            this.lkblpassword.Name = "lkblpassword";
            this.lkblpassword.Size = new System.Drawing.Size(106, 24);
            this.lkblpassword.TabIndex = 43;
            this.lkblpassword.TabStop = true;
            this.lkblpassword.Text = "修改密码";
            this.lkblpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkblpassword_LinkClicked);
            // 
            // FrmLoginstudent
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(625, 380);
            this.Controls.Add(this.lkblpassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.lblLoginID);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLoginpwd);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLoginstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLoginpwd;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lkblpassword;
    }
}