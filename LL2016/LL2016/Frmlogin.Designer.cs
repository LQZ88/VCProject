namespace LL2016
{
    partial class Frmlogin
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
            this.lblstuid = new System.Windows.Forms.Label();
            this.lblstupwd = new System.Windows.Forms.Label();
            this.txtstuid = new System.Windows.Forms.TextBox();
            this.txtstupwd = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstuid
            // 
            this.lblstuid.AutoSize = true;
            this.lblstuid.Location = new System.Drawing.Point(33, 59);
            this.lblstuid.Name = "lblstuid";
            this.lblstuid.Size = new System.Drawing.Size(35, 12);
            this.lblstuid.TabIndex = 0;
            this.lblstuid.Text = "账号:";
            // 
            // lblstupwd
            // 
            this.lblstupwd.AutoSize = true;
            this.lblstupwd.Location = new System.Drawing.Point(33, 128);
            this.lblstupwd.Name = "lblstupwd";
            this.lblstupwd.Size = new System.Drawing.Size(35, 12);
            this.lblstupwd.TabIndex = 1;
            this.lblstupwd.Text = "密码:";
            // 
            // txtstuid
            // 
            this.txtstuid.Location = new System.Drawing.Point(95, 56);
            this.txtstuid.Name = "txtstuid";
            this.txtstuid.Size = new System.Drawing.Size(153, 21);
            this.txtstuid.TabIndex = 0;
            this.txtstuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtstupwd
            // 
            this.txtstupwd.Location = new System.Drawing.Point(95, 125);
            this.txtstupwd.Name = "txtstupwd";
            this.txtstupwd.PasswordChar = '*';
            this.txtstupwd.Size = new System.Drawing.Size(153, 21);
            this.txtstupwd.TabIndex = 1;
            this.txtstupwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(35, 212);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "取 消";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(196, 212);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "登 录";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Frmlogin
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(331, 292);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtstupwd);
            this.Controls.Add(this.txtstuid);
            this.Controls.Add(this.lblstupwd);
            this.Controls.Add(this.lblstuid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmlogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstuid;
        private System.Windows.Forms.Label lblstupwd;
        private System.Windows.Forms.TextBox txtstuid;
        private System.Windows.Forms.TextBox txtstupwd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnok;
    }
}