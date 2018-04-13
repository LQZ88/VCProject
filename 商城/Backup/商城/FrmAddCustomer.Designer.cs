namespace 商城
{
    partial class FrmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCustomer));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusPwdAgain = new System.Windows.Forms.TextBox();
            this.txtCusPwd = new System.Windows.Forms.TextBox();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCuspwdAgain = new System.Windows.Forms.Label();
            this.lblCuspwd = new System.Windows.Forms.Label();
            this.lblCusid = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(142, 268);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 21);
            this.txtAddress.TabIndex = 37;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 228);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 21);
            this.txtPhone.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 21);
            this.txtEmail.TabIndex = 35;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(239, 166);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 34;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(164, 168);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 33;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(142, 126);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(150, 21);
            this.txtCusName.TabIndex = 32;
            // 
            // txtCusPwdAgain
            // 
            this.txtCusPwdAgain.Location = new System.Drawing.Point(142, 91);
            this.txtCusPwdAgain.Name = "txtCusPwdAgain";
            this.txtCusPwdAgain.PasswordChar = '*';
            this.txtCusPwdAgain.Size = new System.Drawing.Size(151, 21);
            this.txtCusPwdAgain.TabIndex = 31;
            // 
            // txtCusPwd
            // 
            this.txtCusPwd.Location = new System.Drawing.Point(141, 58);
            this.txtCusPwd.Name = "txtCusPwd";
            this.txtCusPwd.Size = new System.Drawing.Size(151, 21);
            this.txtCusPwd.TabIndex = 30;
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(141, 28);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(151, 21);
            this.txtCusId.TabIndex = 29;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(57, 273);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 16);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "地  址:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblphone.Location = new System.Drawing.Point(57, 233);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(64, 16);
            this.lblphone.TabIndex = 27;
            this.lblphone.Text = "电  话:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmail.Location = new System.Drawing.Point(41, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 16);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "电子邮件:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(57, 166);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(64, 16);
            this.lblSex.TabIndex = 25;
            this.lblSex.Text = "性  别:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCusName.Location = new System.Drawing.Point(57, 131);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(64, 16);
            this.lblCusName.TabIndex = 24;
            this.lblCusName.Text = "姓  名:";
            // 
            // lblCuspwdAgain
            // 
            this.lblCuspwdAgain.AutoSize = true;
            this.lblCuspwdAgain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCuspwdAgain.Location = new System.Drawing.Point(41, 96);
            this.lblCuspwdAgain.Name = "lblCuspwdAgain";
            this.lblCuspwdAgain.Size = new System.Drawing.Size(80, 16);
            this.lblCuspwdAgain.TabIndex = 23;
            this.lblCuspwdAgain.Text = "确认密码:";
            // 
            // lblCuspwd
            // 
            this.lblCuspwd.AutoSize = true;
            this.lblCuspwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCuspwd.Location = new System.Drawing.Point(57, 63);
            this.lblCuspwd.Name = "lblCuspwd";
            this.lblCuspwd.Size = new System.Drawing.Size(64, 16);
            this.lblCuspwd.TabIndex = 22;
            this.lblCuspwd.Text = "密  码:";
            // 
            // lblCusid
            // 
            this.lblCusid.AutoSize = true;
            this.lblCusid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCusid.Location = new System.Drawing.Point(57, 33);
            this.lblCusid.Name = "lblCusid";
            this.lblCusid.Size = new System.Drawing.Size(64, 16);
            this.lblCusid.TabIndex = 21;
            this.lblCusid.Text = "用户ID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(239, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "返 回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(59, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(354, 382);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusPwdAgain);
            this.Controls.Add(this.txtCusPwd);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lblCuspwdAgain);
            this.Controls.Add(this.lblCuspwd);
            this.Controls.Add(this.lblCusid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注 册！";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCustomer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusPwdAgain;
        private System.Windows.Forms.TextBox txtCusPwd;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCuspwdAgain;
        private System.Windows.Forms.Label lblCuspwd;
        private System.Windows.Forms.Label lblCusid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}