namespace 商城
{
    partial class FrmController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmController));
            this.dgvController = new System.Windows.Forms.DataGridView();
            this.tsDeletecom = new System.Windows.Forms.ToolStripLabel();
            this.tsmiNewcom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsCominfo = new System.Windows.Forms.ToolStripLabel();
            this.tsCusinfo = new System.Windows.Forms.ToolStripLabel();
            this.tsUpdatecom = new System.Windows.Forms.ToolStripLabel();
            this.tsmiCusOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComrun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyright = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvController)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvController
            // 
            this.dgvController.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvController.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvController.Location = new System.Drawing.Point(0, 28);
            this.dgvController.Name = "dgvController";
            this.dgvController.RowTemplate.Height = 23;
            this.dgvController.Size = new System.Drawing.Size(810, 445);
            this.dgvController.TabIndex = 6;
            // 
            // tsDeletecom
            // 
            this.tsDeletecom.Image = global::商城.Properties.Resources._200__6_;
            this.tsDeletecom.Name = "tsDeletecom";
            this.tsDeletecom.Size = new System.Drawing.Size(96, 22);
            this.tsDeletecom.Text = "删除商品信息";
            this.tsDeletecom.Click += new System.EventHandler(this.tsDeletecom_Click);
            // 
            // tsmiNewcom
            // 
            this.tsmiNewcom.Name = "tsmiNewcom";
            this.tsmiNewcom.Size = new System.Drawing.Size(148, 22);
            this.tsmiNewcom.Text = "新增商品";
            this.tsmiNewcom.Click += new System.EventHandler(this.tsmiNewcom_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCominfo,
            this.tsCusinfo,
            this.tsUpdatecom,
            this.tsDeletecom});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(810, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsCominfo
            // 
            this.tsCominfo.Image = global::商城.Properties.Resources._110__3_;
            this.tsCominfo.Name = "tsCominfo";
            this.tsCominfo.Size = new System.Drawing.Size(72, 22);
            this.tsCominfo.Text = "商品列表";
            this.tsCominfo.Click += new System.EventHandler(this.tsCominfo_Click);
            // 
            // tsCusinfo
            // 
            this.tsCusinfo.Image = global::商城.Properties.Resources._1000__1_;
            this.tsCusinfo.Name = "tsCusinfo";
            this.tsCusinfo.Size = new System.Drawing.Size(72, 22);
            this.tsCusinfo.Text = "客户列表";
            this.tsCusinfo.Click += new System.EventHandler(this.tsCusinfo_Click);
            // 
            // tsUpdatecom
            // 
            this.tsUpdatecom.Image = global::商城.Properties.Resources._200__13_;
            this.tsUpdatecom.Name = "tsUpdatecom";
            this.tsUpdatecom.Size = new System.Drawing.Size(96, 22);
            this.tsUpdatecom.Text = "修改商品信息";
            this.tsUpdatecom.Click += new System.EventHandler(this.tsUpdatecom_Click);
            // 
            // tsmiCusOrder
            // 
            this.tsmiCusOrder.Name = "tsmiCusOrder";
            this.tsmiCusOrder.Size = new System.Drawing.Size(148, 22);
            this.tsmiCusOrder.Text = "客户订单查询";
            this.tsmiCusOrder.Click += new System.EventHandler(this.tsmiCusOrder_Click);
            // 
            // tsmiComrun
            // 
            this.tsmiComrun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewcom,
            this.tsmiCusOrder,
            this.tsmiExit});
            this.tsmiComrun.Name = "tsmiComrun";
            this.tsmiComrun.Size = new System.Drawing.Size(68, 21);
            this.tsmiComrun.Text = "商品管理";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiCopyright
            // 
            this.tsmiCopyright.Name = "tsmiCopyright";
            this.tsmiCopyright.Size = new System.Drawing.Size(68, 21);
            this.tsmiCopyright.Text = "版权所有";
            this.tsmiCopyright.Click += new System.EventHandler(this.tsmiCopyright_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(124, 22);
            this.tsmiAbout.Text = "关于系统";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiComrun,
            this.tsmiHelp,
            this.tsmiCopyright});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 498);
            this.Controls.Add(this.dgvController);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管 理！";
            ((System.ComponentModel.ISupportInitialize)(this.dgvController)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvController;
        private System.Windows.Forms.ToolStripLabel tsCusinfo;
        private System.Windows.Forms.ToolStripLabel tsCominfo;
        private System.Windows.Forms.ToolStripLabel tsDeletecom;
        private System.Windows.Forms.ToolStripLabel tsUpdatecom;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewcom;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCusOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiComrun;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyright;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}