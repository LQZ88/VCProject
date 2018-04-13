namespace 文件扫描
{
    partial class Frmselectall
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
            this.cboxDisk = new System.Windows.Forms.ComboBox();
            this.cboxExtention = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblcp = new System.Windows.Forms.Label();
            this.labFilePath = new System.Windows.Forms.ListBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cboxDisk
            // 
            this.cboxDisk.FormattingEnabled = true;
            this.cboxDisk.Location = new System.Drawing.Point(145, 13);
            this.cboxDisk.Margin = new System.Windows.Forms.Padding(4);
            this.cboxDisk.Name = "cboxDisk";
            this.cboxDisk.Size = new System.Drawing.Size(78, 24);
            this.cboxDisk.TabIndex = 0;
            // 
            // cboxExtention
            // 
            this.cboxExtention.FormattingEnabled = true;
            this.cboxExtention.Items.AddRange(new object[] {
            "*.jpg",
            "*.png",
            "*.gif"});
            this.cboxExtention.Location = new System.Drawing.Point(293, 13);
            this.cboxExtention.Name = "cboxExtention";
            this.cboxExtention.Size = new System.Drawing.Size(121, 24);
            this.cboxExtention.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(482, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 34);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "开始扫描";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(90, 16);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(48, 16);
            this.lblcp.TabIndex = 6;
            this.lblcp.Text = "磁盘:";
            // 
            // labFilePath
            // 
            this.labFilePath.FormattingEnabled = true;
            this.labFilePath.ItemHeight = 16;
            this.labFilePath.Location = new System.Drawing.Point(81, 52);
            this.labFilePath.Name = "labFilePath";
            this.labFilePath.Size = new System.Drawing.Size(402, 84);
            this.labFilePath.TabIndex = 7;
            // 
            // lvResult
            // 
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvResult.Location = new System.Drawing.Point(0, 142);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(591, 240);
            this.lvResult.TabIndex = 8;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            // 
            // Frmselectall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 382);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.labFilePath);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboxExtention);
            this.Controls.Add(this.cboxDisk);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frmselectall";
            this.Text = "Frmselectall";
            this.Load += new System.EventHandler(this.Frmselectall_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmselectall_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxDisk;
        private System.Windows.Forms.ComboBox cboxExtention;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.ListBox labFilePath;
        private System.Windows.Forms.ListView lvResult;
    }
}