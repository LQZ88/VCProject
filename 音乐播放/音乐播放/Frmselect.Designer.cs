namespace 音乐播放
{
    partial class Frmselect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmselect));
            this.txtselect = new System.Windows.Forms.TextBox();
            this.gbname = new System.Windows.Forms.GroupBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.gbselectname = new System.Windows.Forms.GroupBox();
            this.gbname.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtselect
            // 
            this.txtselect.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Bold);
            this.txtselect.Location = new System.Drawing.Point(12, 28);
            this.txtselect.Name = "txtselect";
            this.txtselect.Size = new System.Drawing.Size(189, 30);
            this.txtselect.TabIndex = 0;
            this.txtselect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbname
            // 
            this.gbname.Controls.Add(this.gbselectname);
            this.gbname.Controls.Add(this.btnselect);
            this.gbname.Controls.Add(this.txtselect);
            this.gbname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbname.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbname.Location = new System.Drawing.Point(0, 0);
            this.gbname.Name = "gbname";
            this.gbname.Size = new System.Drawing.Size(334, 74);
            this.gbname.TabIndex = 1;
            this.gbname.TabStop = false;
            this.gbname.Text = "请输入关键词";
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(252, 27);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(74, 28);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "搜索";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // gbselectname
            // 
            this.gbselectname.Location = new System.Drawing.Point(0, 83);
            this.gbselectname.Name = "gbselectname";
            this.gbselectname.Size = new System.Drawing.Size(334, 500);
            this.gbselectname.TabIndex = 2;
            this.gbselectname.TabStop = false;
            this.gbselectname.Text = "搜索结果";
            // 
            // Frmselect
            // 
            this.AcceptButton = this.btnselect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 74);
            this.Controls.Add(this.gbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmselect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搜索";
            this.gbname.ResumeLayout(false);
            this.gbname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtselect;
        private System.Windows.Forms.GroupBox gbname;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.GroupBox gbselectname;
    }
}