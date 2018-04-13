namespace 商城
{
    partial class FrmCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.ctxCom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnCusCancle = new System.Windows.Forms.Button();
            this.btnReFil = new System.Windows.Forms.Button();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.TMRtl = new System.Windows.Forms.Timer(this.components);
            this.ctxCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxCom
            // 
            this.ctxCom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuy});
            this.ctxCom.Name = "ctxCom";
            this.ctxCom.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiBuy
            // 
            this.tsmiBuy.Name = "tsmiBuy";
            this.tsmiBuy.Size = new System.Drawing.Size(100, 22);
            this.tsmiBuy.Text = "购买";
            this.tsmiBuy.Click += new System.EventHandler(this.tsmiBuy_Click);
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Location = new System.Drawing.Point(0, 42);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.RowTemplate.Height = 23;
            this.dgvCommodity.Size = new System.Drawing.Size(733, 339);
            this.dgvCommodity.TabIndex = 10;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(9, 15);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(65, 12);
            this.lblCat.TabIndex = 6;
            this.lblCat.Text = "按类别查询";
            // 
            // btnCusCancle
            // 
            this.btnCusCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCusCancle.Location = new System.Drawing.Point(647, 389);
            this.btnCusCancle.Name = "btnCusCancle";
            this.btnCusCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCusCancle.TabIndex = 9;
            this.btnCusCancle.Text = "退出";
            this.btnCusCancle.UseVisualStyleBackColor = true;
            this.btnCusCancle.Click += new System.EventHandler(this.btnCusCancle_Click);
            // 
            // btnReFil
            // 
            this.btnReFil.Location = new System.Drawing.Point(298, 9);
            this.btnReFil.Name = "btnReFil";
            this.btnReFil.Size = new System.Drawing.Size(75, 23);
            this.btnReFil.TabIndex = 8;
            this.btnReFil.Text = "查询";
            this.btnReFil.UseVisualStyleBackColor = true;
            this.btnReFil.Click += new System.EventHandler(this.btnReFil_Click);
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(129, 12);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(121, 20);
            this.cboCat.TabIndex = 7;
            // 
            // TMRtl
            // 
            this.TMRtl.Enabled = true;
            this.TMRtl.Tick += new System.EventHandler(this.TMRtl_Tick);
            // 
            // FrmCustomer
            // 
            this.AcceptButton = this.btnReFil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCusCancle;
            this.ClientSize = new System.Drawing.Size(734, 424);
            this.ContextMenuStrip = this.ctxCom;
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.btnReFil);
            this.Controls.Add(this.dgvCommodity);
            this.Controls.Add(this.btnCusCancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户！ 你好····";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomer_FormClosing);
            this.LocationChanged += new System.EventHandler(this.FrmCustomer_LocationChanged);
            this.ctxCom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxCom;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuy;
        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnCusCancle;
        private System.Windows.Forms.Button btnReFil;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.Timer TMRtl;
    }
}