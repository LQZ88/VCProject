namespace School
{
    partial class FrmLoginmaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginmaster));
            this.lblLoginmaster = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.lblLoginpwd = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginmaster
            // 
            this.lblLoginmaster.AutoSize = true;
            this.lblLoginmaster.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginmaster.Font = new System.Drawing.Font("华文行楷", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginmaster.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginmaster.Location = new System.Drawing.Point(99, 23);
            this.lblLoginmaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginmaster.Name = "lblLoginmaster";
            this.lblLoginmaster.Size = new System.Drawing.Size(193, 59);
            this.lblLoginmaster.TabIndex = 32;
            this.lblLoginmaster.Text = "管理员";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(428, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 65);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.Location = new System.Drawing.Point(67, 272);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 65);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "进入";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.AcceptsTab = true;
            this.txtLoginPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginPwd.Location = new System.Drawing.Point(244, 199);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(210, 30);
            this.txtLoginPwd.TabIndex = 29;
            this.txtLoginPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginpwd
            // 
            this.lblLoginpwd.AutoSize = true;
            this.lblLoginpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginpwd.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginpwd.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginpwd.Location = new System.Drawing.Point(72, 196);
            this.lblLoginpwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginpwd.Name = "lblLoginpwd";
            this.lblLoginpwd.Size = new System.Drawing.Size(128, 30);
            this.lblLoginpwd.TabIndex = 28;
            this.lblLoginpwd.Text = "密    码：";
            // 
            // txtLoginID
            // 
            this.txtLoginID.AcceptsTab = true;
            this.txtLoginID.BackColor = System.Drawing.Color.White;
            this.txtLoginID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginID.Location = new System.Drawing.Point(244, 118);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(210, 30);
            this.txtLoginID.TabIndex = 27;
            this.txtLoginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginID.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginID.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginID.Location = new System.Drawing.Point(73, 118);
            this.lblLoginID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(128, 30);
            this.lblLoginID.TabIndex = 26;
            this.lblLoginID.Text = "账    号：";
            // 
            // FrmLoginmaster
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(625, 380);
            this.Controls.Add(this.lblLoginmaster);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.lblLoginpwd);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.lblLoginID);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLoginmaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginmaster;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label lblLoginpwd;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Label lblLoginID;
    }
}