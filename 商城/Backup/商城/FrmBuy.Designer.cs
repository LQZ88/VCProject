namespace 商城
{
    partial class FrmBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuy));
            this.txtBuyshifu = new System.Windows.Forms.TextBox();
            this.txtBuyyingfu = new System.Windows.Forms.TextBox();
            this.txtBuyAmount = new System.Windows.Forms.TextBox();
            this.txtBuyComprice = new System.Windows.Forms.TextBox();
            this.txtBuyComname = new System.Windows.Forms.TextBox();
            this.txtBuyComid = new System.Windows.Forms.TextBox();
            this.txtBuyCusid = new System.Windows.Forms.TextBox();
            this.cboBuycomcat = new System.Windows.Forms.ComboBox();
            this.lblBuyshifu = new System.Windows.Forms.Label();
            this.lblBuyyingfu = new System.Windows.Forms.Label();
            this.lblBuyAmount = new System.Windows.Forms.Label();
            this.lblBuyComprice = new System.Windows.Forms.Label();
            this.lblBuyComname = new System.Windows.Forms.Label();
            this.lblBuyComid = new System.Windows.Forms.Label();
            this.lblBuyCusid = new System.Windows.Forms.Label();
            this.lblBuycomcat = new System.Windows.Forms.Label();
            this.btnBuyCancel = new System.Windows.Forms.Button();
            this.btnBuyOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuyshifu
            // 
            this.txtBuyshifu.Location = new System.Drawing.Point(162, 271);
            this.txtBuyshifu.Name = "txtBuyshifu";
            this.txtBuyshifu.Size = new System.Drawing.Size(134, 21);
            this.txtBuyshifu.TabIndex = 54;
            // 
            // txtBuyyingfu
            // 
            this.txtBuyyingfu.Location = new System.Drawing.Point(162, 236);
            this.txtBuyyingfu.Name = "txtBuyyingfu";
            this.txtBuyyingfu.ReadOnly = true;
            this.txtBuyyingfu.Size = new System.Drawing.Size(134, 21);
            this.txtBuyyingfu.TabIndex = 53;
            // 
            // txtBuyAmount
            // 
            this.txtBuyAmount.Location = new System.Drawing.Point(162, 202);
            this.txtBuyAmount.Name = "txtBuyAmount";
            this.txtBuyAmount.Size = new System.Drawing.Size(134, 21);
            this.txtBuyAmount.TabIndex = 52;
            this.txtBuyAmount.TextChanged += new System.EventHandler(this.txtBuyAmount_TextChanged);
            this.txtBuyAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuyAmount_KeyDown);
            this.txtBuyAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyAmount_KeyPress);
            // 
            // txtBuyComprice
            // 
            this.txtBuyComprice.Location = new System.Drawing.Point(162, 168);
            this.txtBuyComprice.Name = "txtBuyComprice";
            this.txtBuyComprice.ReadOnly = true;
            this.txtBuyComprice.Size = new System.Drawing.Size(134, 21);
            this.txtBuyComprice.TabIndex = 51;
            // 
            // txtBuyComname
            // 
            this.txtBuyComname.Location = new System.Drawing.Point(162, 129);
            this.txtBuyComname.Name = "txtBuyComname";
            this.txtBuyComname.ReadOnly = true;
            this.txtBuyComname.Size = new System.Drawing.Size(134, 21);
            this.txtBuyComname.TabIndex = 50;
            // 
            // txtBuyComid
            // 
            this.txtBuyComid.Location = new System.Drawing.Point(162, 94);
            this.txtBuyComid.Name = "txtBuyComid";
            this.txtBuyComid.Size = new System.Drawing.Size(134, 21);
            this.txtBuyComid.TabIndex = 49;
            this.txtBuyComid.TextChanged += new System.EventHandler(this.txtBuyComid_TextChanged);
            // 
            // txtBuyCusid
            // 
            this.txtBuyCusid.Location = new System.Drawing.Point(162, 64);
            this.txtBuyCusid.Name = "txtBuyCusid";
            this.txtBuyCusid.Size = new System.Drawing.Size(134, 21);
            this.txtBuyCusid.TabIndex = 48;
            // 
            // cboBuycomcat
            // 
            this.cboBuycomcat.FormattingEnabled = true;
            this.cboBuycomcat.Location = new System.Drawing.Point(132, 25);
            this.cboBuycomcat.Name = "cboBuycomcat";
            this.cboBuycomcat.Size = new System.Drawing.Size(130, 20);
            this.cboBuycomcat.TabIndex = 47;
            // 
            // lblBuyshifu
            // 
            this.lblBuyshifu.AutoSize = true;
            this.lblBuyshifu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyshifu.Location = new System.Drawing.Point(60, 270);
            this.lblBuyshifu.Name = "lblBuyshifu";
            this.lblBuyshifu.Size = new System.Drawing.Size(80, 16);
            this.lblBuyshifu.TabIndex = 46;
            this.lblBuyshifu.Text = "实付金额:";
            // 
            // lblBuyyingfu
            // 
            this.lblBuyyingfu.AutoSize = true;
            this.lblBuyyingfu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyyingfu.Location = new System.Drawing.Point(60, 235);
            this.lblBuyyingfu.Name = "lblBuyyingfu";
            this.lblBuyyingfu.Size = new System.Drawing.Size(80, 16);
            this.lblBuyyingfu.TabIndex = 45;
            this.lblBuyyingfu.Text = "应付金额:";
            // 
            // lblBuyAmount
            // 
            this.lblBuyAmount.AutoSize = true;
            this.lblBuyAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyAmount.Location = new System.Drawing.Point(60, 201);
            this.lblBuyAmount.Name = "lblBuyAmount";
            this.lblBuyAmount.Size = new System.Drawing.Size(80, 16);
            this.lblBuyAmount.TabIndex = 44;
            this.lblBuyAmount.Text = "商品数量:";
            // 
            // lblBuyComprice
            // 
            this.lblBuyComprice.AutoSize = true;
            this.lblBuyComprice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyComprice.Location = new System.Drawing.Point(60, 167);
            this.lblBuyComprice.Name = "lblBuyComprice";
            this.lblBuyComprice.Size = new System.Drawing.Size(80, 16);
            this.lblBuyComprice.TabIndex = 43;
            this.lblBuyComprice.Text = "商品价格:";
            // 
            // lblBuyComname
            // 
            this.lblBuyComname.AutoSize = true;
            this.lblBuyComname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyComname.Location = new System.Drawing.Point(60, 128);
            this.lblBuyComname.Name = "lblBuyComname";
            this.lblBuyComname.Size = new System.Drawing.Size(80, 16);
            this.lblBuyComname.TabIndex = 42;
            this.lblBuyComname.Text = "商品名称:";
            // 
            // lblBuyComid
            // 
            this.lblBuyComid.AutoSize = true;
            this.lblBuyComid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyComid.Location = new System.Drawing.Point(60, 93);
            this.lblBuyComid.Name = "lblBuyComid";
            this.lblBuyComid.Size = new System.Drawing.Size(80, 16);
            this.lblBuyComid.TabIndex = 41;
            this.lblBuyComid.Text = "商品编号:";
            // 
            // lblBuyCusid
            // 
            this.lblBuyCusid.AutoSize = true;
            this.lblBuyCusid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuyCusid.Location = new System.Drawing.Point(60, 63);
            this.lblBuyCusid.Name = "lblBuyCusid";
            this.lblBuyCusid.Size = new System.Drawing.Size(80, 16);
            this.lblBuyCusid.TabIndex = 40;
            this.lblBuyCusid.Text = "用户  ID:";
            // 
            // lblBuycomcat
            // 
            this.lblBuycomcat.AutoSize = true;
            this.lblBuycomcat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuycomcat.Location = new System.Drawing.Point(36, 29);
            this.lblBuycomcat.Name = "lblBuycomcat";
            this.lblBuycomcat.Size = new System.Drawing.Size(80, 16);
            this.lblBuycomcat.TabIndex = 39;
            this.lblBuycomcat.Text = "商品类别:";
            // 
            // btnBuyCancel
            // 
            this.btnBuyCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuyCancel.Location = new System.Drawing.Point(238, 335);
            this.btnBuyCancel.Name = "btnBuyCancel";
            this.btnBuyCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBuyCancel.TabIndex = 38;
            this.btnBuyCancel.Text = "返 回";
            this.btnBuyCancel.UseVisualStyleBackColor = true;
            this.btnBuyCancel.Click += new System.EventHandler(this.btnBuyCancel_Click);
            // 
            // btnBuyOk
            // 
            this.btnBuyOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBuyOk.Location = new System.Drawing.Point(58, 335);
            this.btnBuyOk.Name = "btnBuyOk";
            this.btnBuyOk.Size = new System.Drawing.Size(75, 23);
            this.btnBuyOk.TabIndex = 37;
            this.btnBuyOk.Text = "确 定";
            this.btnBuyOk.UseVisualStyleBackColor = true;
            this.btnBuyOk.Click += new System.EventHandler(this.btnBuyOk_Click);
            // 
            // FrmBuy
            // 
            this.AcceptButton = this.btnBuyOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBuyCancel;
            this.ClientSize = new System.Drawing.Size(354, 382);
            this.Controls.Add(this.txtBuyshifu);
            this.Controls.Add(this.txtBuyyingfu);
            this.Controls.Add(this.txtBuyAmount);
            this.Controls.Add(this.txtBuyComprice);
            this.Controls.Add(this.txtBuyComname);
            this.Controls.Add(this.txtBuyComid);
            this.Controls.Add(this.txtBuyCusid);
            this.Controls.Add(this.cboBuycomcat);
            this.Controls.Add(this.lblBuyshifu);
            this.Controls.Add(this.lblBuyyingfu);
            this.Controls.Add(this.lblBuyAmount);
            this.Controls.Add(this.lblBuyComprice);
            this.Controls.Add(this.lblBuyComname);
            this.Controls.Add(this.lblBuyComid);
            this.Controls.Add(this.lblBuyCusid);
            this.Controls.Add(this.lblBuycomcat);
            this.Controls.Add(this.btnBuyCancel);
            this.Controls.Add(this.btnBuyOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下单!";
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuyshifu;
        private System.Windows.Forms.TextBox txtBuyyingfu;
        private System.Windows.Forms.TextBox txtBuyAmount;
        private System.Windows.Forms.TextBox txtBuyComprice;
        private System.Windows.Forms.TextBox txtBuyComname;
        private System.Windows.Forms.TextBox txtBuyComid;
        private System.Windows.Forms.TextBox txtBuyCusid;
        private System.Windows.Forms.ComboBox cboBuycomcat;
        private System.Windows.Forms.Label lblBuyshifu;
        private System.Windows.Forms.Label lblBuyyingfu;
        private System.Windows.Forms.Label lblBuyAmount;
        private System.Windows.Forms.Label lblBuyComprice;
        private System.Windows.Forms.Label lblBuyComname;
        private System.Windows.Forms.Label lblBuyComid;
        private System.Windows.Forms.Label lblBuyCusid;
        private System.Windows.Forms.Label lblBuycomcat;
        private System.Windows.Forms.Button btnBuyCancel;
        private System.Windows.Forms.Button btnBuyOk;
    }
}