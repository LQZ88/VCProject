namespace 商城
{
    partial class Frmchangepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmchangepassword));
            this.txtnewpwdagain = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.txtyuanpwd = new System.Windows.Forms.TextBox();
            this.btnchangeCancel = new System.Windows.Forms.Button();
            this.btnchangeOk = new System.Windows.Forms.Button();
            this.txtChangeCusid = new System.Windows.Forms.TextBox();
            this.lblnewpwdagain = new System.Windows.Forms.Label();
            this.lblnewpwd = new System.Windows.Forms.Label();
            this.lblyuanPwd = new System.Windows.Forms.Label();
            this.lblChangeCusid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnewpwdagain
            // 
            this.txtnewpwdagain.Location = new System.Drawing.Point(161, 160);
            this.txtnewpwdagain.Name = "txtnewpwdagain";
            this.txtnewpwdagain.PasswordChar = '*';
            this.txtnewpwdagain.Size = new System.Drawing.Size(172, 21);
            this.txtnewpwdagain.TabIndex = 19;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(161, 116);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.PasswordChar = '*';
            this.txtnewpwd.Size = new System.Drawing.Size(172, 21);
            this.txtnewpwd.TabIndex = 18;
            // 
            // txtyuanpwd
            // 
            this.txtyuanpwd.Location = new System.Drawing.Point(161, 77);
            this.txtyuanpwd.Name = "txtyuanpwd";
            this.txtyuanpwd.PasswordChar = '*';
            this.txtyuanpwd.Size = new System.Drawing.Size(172, 21);
            this.txtyuanpwd.TabIndex = 17;
            // 
            // btnchangeCancel
            // 
            this.btnchangeCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnchangeCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnchangeCancel.Location = new System.Drawing.Point(279, 204);
            this.btnchangeCancel.Name = "btnchangeCancel";
            this.btnchangeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnchangeCancel.TabIndex = 16;
            this.btnchangeCancel.Text = "取 消";
            this.btnchangeCancel.UseVisualStyleBackColor = true;
            this.btnchangeCancel.Click += new System.EventHandler(this.btnchangeCancel_Click);
            // 
            // btnchangeOk
            // 
            this.btnchangeOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnchangeOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnchangeOk.Location = new System.Drawing.Point(75, 204);
            this.btnchangeOk.Name = "btnchangeOk";
            this.btnchangeOk.Size = new System.Drawing.Size(75, 23);
            this.btnchangeOk.TabIndex = 15;
            this.btnchangeOk.Text = "确 定";
            this.btnchangeOk.UseVisualStyleBackColor = true;
            this.btnchangeOk.Click += new System.EventHandler(this.btnchangeOk_Click);
            // 
            // txtChangeCusid
            // 
            this.txtChangeCusid.Location = new System.Drawing.Point(161, 36);
            this.txtChangeCusid.Name = "txtChangeCusid";
            this.txtChangeCusid.Size = new System.Drawing.Size(172, 21);
            this.txtChangeCusid.TabIndex = 14;
            // 
            // lblnewpwdagain
            // 
            this.lblnewpwdagain.AutoSize = true;
            this.lblnewpwdagain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblnewpwdagain.Location = new System.Drawing.Point(40, 159);
            this.lblnewpwdagain.Name = "lblnewpwdagain";
            this.lblnewpwdagain.Size = new System.Drawing.Size(96, 16);
            this.lblnewpwdagain.TabIndex = 13;
            this.lblnewpwdagain.Text = "确认新密码:";
            // 
            // lblnewpwd
            // 
            this.lblnewpwd.AutoSize = true;
            this.lblnewpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblnewpwd.Location = new System.Drawing.Point(72, 115);
            this.lblnewpwd.Name = "lblnewpwd";
            this.lblnewpwd.Size = new System.Drawing.Size(64, 16);
            this.lblnewpwd.TabIndex = 12;
            this.lblnewpwd.Text = "新密码:";
            // 
            // lblyuanPwd
            // 
            this.lblyuanPwd.AutoSize = true;
            this.lblyuanPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyuanPwd.Location = new System.Drawing.Point(72, 76);
            this.lblyuanPwd.Name = "lblyuanPwd";
            this.lblyuanPwd.Size = new System.Drawing.Size(64, 16);
            this.lblyuanPwd.TabIndex = 11;
            this.lblyuanPwd.Text = "原密码:";
            // 
            // lblChangeCusid
            // 
            this.lblChangeCusid.AutoSize = true;
            this.lblChangeCusid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChangeCusid.Location = new System.Drawing.Point(72, 35);
            this.lblChangeCusid.Name = "lblChangeCusid";
            this.lblChangeCusid.Size = new System.Drawing.Size(64, 16);
            this.lblChangeCusid.TabIndex = 10;
            this.lblChangeCusid.Text = "用户ID:";
            // 
            // Frmchangepassword
            // 
            this.AcceptButton = this.btnchangeOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnchangeCancel;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.txtnewpwdagain);
            this.Controls.Add(this.txtnewpwd);
            this.Controls.Add(this.txtyuanpwd);
            this.Controls.Add(this.btnchangeCancel);
            this.Controls.Add(this.btnchangeOk);
            this.Controls.Add(this.txtChangeCusid);
            this.Controls.Add(this.lblnewpwdagain);
            this.Controls.Add(this.lblnewpwd);
            this.Controls.Add(this.lblyuanPwd);
            this.Controls.Add(this.lblChangeCusid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmchangepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码！";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmchangepassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnewpwdagain;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.TextBox txtyuanpwd;
        private System.Windows.Forms.Button btnchangeCancel;
        private System.Windows.Forms.Button btnchangeOk;
        private System.Windows.Forms.TextBox txtChangeCusid;
        private System.Windows.Forms.Label lblnewpwdagain;
        private System.Windows.Forms.Label lblnewpwd;
        private System.Windows.Forms.Label lblyuanPwd;
        private System.Windows.Forms.Label lblChangeCusid;
    }
}