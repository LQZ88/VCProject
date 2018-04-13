namespace 商城
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.linklblchangepwd = new System.Windows.Forms.LinkLabel();
            this.linkLblzhuce = new System.Windows.Forms.LinkLabel();
            this.txtloginPwd = new System.Windows.Forms.TextBox();
            this.txtLoginid = new System.Windows.Forms.TextBox();
            this.cboBoxLoginType = new System.Windows.Forms.ComboBox();
            this.bttnonCancel = new System.Windows.Forms.Button();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.lblLoginpwd = new System.Windows.Forms.Label();
            this.lblLonginid = new System.Windows.Forms.Label();
            this.skins = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tmrTL = new System.Windows.Forms.Timer(this.components);
            this.lblskin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklblchangepwd
            // 
            this.linklblchangepwd.AutoSize = true;
            this.linklblchangepwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linklblchangepwd.LinkColor = System.Drawing.Color.Red;
            this.linklblchangepwd.Location = new System.Drawing.Point(297, 81);
            this.linklblchangepwd.Name = "linklblchangepwd";
            this.linklblchangepwd.Size = new System.Drawing.Size(72, 16);
            this.linklblchangepwd.TabIndex = 6;
            this.linklblchangepwd.TabStop = true;
            this.linklblchangepwd.Text = "修改密码";
            this.linklblchangepwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblchangepwd_LinkClicked);
            // 
            // linkLblzhuce
            // 
            this.linkLblzhuce.AutoSize = true;
            this.linkLblzhuce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLblzhuce.Location = new System.Drawing.Point(297, 45);
            this.linkLblzhuce.Name = "linkLblzhuce";
            this.linkLblzhuce.Size = new System.Drawing.Size(72, 16);
            this.linkLblzhuce.TabIndex = 5;
            this.linkLblzhuce.TabStop = true;
            this.linkLblzhuce.Text = "注    册";
            this.linkLblzhuce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblzhuce_LinkClicked);
            // 
            // txtloginPwd
            // 
            this.txtloginPwd.Location = new System.Drawing.Point(125, 81);
            this.txtloginPwd.Name = "txtloginPwd";
            this.txtloginPwd.PasswordChar = '*';
            this.txtloginPwd.Size = new System.Drawing.Size(137, 21);
            this.txtloginPwd.TabIndex = 1;
            // 
            // txtLoginid
            // 
            this.txtLoginid.Location = new System.Drawing.Point(125, 45);
            this.txtLoginid.Name = "txtLoginid";
            this.txtLoginid.Size = new System.Drawing.Size(137, 21);
            this.txtLoginid.TabIndex = 0;
            // 
            // cboBoxLoginType
            // 
            this.cboBoxLoginType.FormattingEnabled = true;
            this.cboBoxLoginType.Items.AddRange(new object[] {
            "管理员",
            "客户"});
            this.cboBoxLoginType.Location = new System.Drawing.Point(125, 127);
            this.cboBoxLoginType.Name = "cboBoxLoginType";
            this.cboBoxLoginType.Size = new System.Drawing.Size(137, 20);
            this.cboBoxLoginType.TabIndex = 2;
            // 
            // bttnonCancel
            // 
            this.bttnonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnonCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttnonCancel.Location = new System.Drawing.Point(237, 195);
            this.bttnonCancel.Name = "bttnonCancel";
            this.bttnonCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnonCancel.TabIndex = 4;
            this.bttnonCancel.Text = "退 出";
            this.bttnonCancel.UseVisualStyleBackColor = true;
            this.bttnonCancel.Click += new System.EventHandler(this.bttnonCancel_Click);
            // 
            // lblLoginType
            // 
            this.lblLoginType.AutoSize = true;
            this.lblLoginType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginType.Location = new System.Drawing.Point(25, 126);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoginType.Size = new System.Drawing.Size(80, 16);
            this.lblLoginType.TabIndex = 9;
            this.lblLoginType.Text = "账号类型:";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOk.Location = new System.Drawing.Point(47, 195);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "登 录";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // lblLoginpwd
            // 
            this.lblLoginpwd.AutoSize = true;
            this.lblLoginpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginpwd.Location = new System.Drawing.Point(25, 86);
            this.lblLoginpwd.Name = "lblLoginpwd";
            this.lblLoginpwd.Size = new System.Drawing.Size(80, 16);
            this.lblLoginpwd.TabIndex = 8;
            this.lblLoginpwd.Text = "密    码:";
            // 
            // lblLonginid
            // 
            this.lblLonginid.AutoSize = true;
            this.lblLonginid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLonginid.Location = new System.Drawing.Point(25, 50);
            this.lblLonginid.Name = "lblLonginid";
            this.lblLonginid.Size = new System.Drawing.Size(80, 16);
            this.lblLonginid.TabIndex = 7;
            this.lblLonginid.Text = "账    号:";
            // 
            // skins
            // 
            this.skins.SerialNumber = "";
            this.skins.SkinFile = null;
            this.skins.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skins.SkinStreamMain")));
            // 
            // tmrTL
            // 
            this.tmrTL.Enabled = true;
            this.tmrTL.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblskin
            // 
            this.lblskin.AutoSize = true;
            this.lblskin.BackColor = System.Drawing.Color.Transparent;
            this.lblskin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblskin.Font = new System.Drawing.Font("宋体", 12F);
            this.lblskin.Location = new System.Drawing.Point(3, 4);
            this.lblskin.Name = "lblskin";
            this.lblskin.Size = new System.Drawing.Size(40, 16);
            this.lblskin.TabIndex = 10;
            this.lblskin.Text = "皮肤";
            this.lblskin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblskin_MouseDown);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttnonCancel;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.lblskin);
            this.Controls.Add(this.linklblchangepwd);
            this.Controls.Add(this.linkLblzhuce);
            this.Controls.Add(this.txtloginPwd);
            this.Controls.Add(this.txtLoginid);
            this.Controls.Add(this.cboBoxLoginType);
            this.Controls.Add(this.lblLoginType);
            this.Controls.Add(this.bttnonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.lblLoginpwd);
            this.Controls.Add(this.lblLonginid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FrmLogin_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblchangepwd;
        private System.Windows.Forms.LinkLabel linkLblzhuce;
        private System.Windows.Forms.TextBox txtloginPwd;
        private System.Windows.Forms.TextBox txtLoginid;
        private System.Windows.Forms.ComboBox cboBoxLoginType;
        private System.Windows.Forms.Button bttnonCancel;
        private System.Windows.Forms.Label lblLoginType;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label lblLoginpwd;
        private System.Windows.Forms.Label lblLonginid;
        private Sunisoft.IrisSkin.SkinEngine skins;
        private System.Windows.Forms.Timer tmrTL;
        private System.Windows.Forms.Label lblskin;
    }
}

