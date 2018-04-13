namespace 音乐
{
    partial class Frmclos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclos));
            this.gbclos = new System.Windows.Forms.GroupBox();
            this.lblclos = new System.Windows.Forms.Label();
            this.rdocloss = new System.Windows.Forms.RadioButton();
            this.rdoclos = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.btncanle = new System.Windows.Forms.Button();
            this.gbclos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbclos
            // 
            this.gbclos.Controls.Add(this.btncanle);
            this.gbclos.Controls.Add(this.btnok);
            this.gbclos.Controls.Add(this.rdoclos);
            this.gbclos.Controls.Add(this.rdocloss);
            this.gbclos.Controls.Add(this.lblclos);
            this.gbclos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbclos.Location = new System.Drawing.Point(0, 0);
            this.gbclos.Name = "gbclos";
            this.gbclos.Size = new System.Drawing.Size(284, 162);
            this.gbclos.TabIndex = 0;
            this.gbclos.TabStop = false;
            // 
            // lblclos
            // 
            this.lblclos.AutoSize = true;
            this.lblclos.Font = new System.Drawing.Font("新宋体", 10F);
            this.lblclos.Location = new System.Drawing.Point(29, 19);
            this.lblclos.Name = "lblclos";
            this.lblclos.Size = new System.Drawing.Size(182, 14);
            this.lblclos.TabIndex = 0;
            this.lblclos.Text = "你点击了关闭按钮，你是想:";
            // 
            // rdocloss
            // 
            this.rdocloss.AutoSize = true;
            this.rdocloss.Location = new System.Drawing.Point(43, 53);
            this.rdocloss.Name = "rdocloss";
            this.rdocloss.Size = new System.Drawing.Size(193, 18);
            this.rdocloss.TabIndex = 1;
            this.rdocloss.TabStop = true;
            this.rdocloss.Text = "最小化到托盘,不退出程序.";
            this.rdocloss.UseVisualStyleBackColor = true;
            // 
            // rdoclos
            // 
            this.rdoclos.AutoSize = true;
            this.rdoclos.Location = new System.Drawing.Point(43, 87);
            this.rdoclos.Name = "rdoclos";
            this.rdoclos.Size = new System.Drawing.Size(88, 18);
            this.rdoclos.TabIndex = 2;
            this.rdoclos.TabStop = true;
            this.rdoclos.Text = "退出程序.";
            this.rdoclos.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(43, 127);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(57, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncanle
            // 
            this.btncanle.Location = new System.Drawing.Point(172, 127);
            this.btncanle.Name = "btncanle";
            this.btncanle.Size = new System.Drawing.Size(57, 23);
            this.btncanle.TabIndex = 5;
            this.btncanle.Text = "取消";
            this.btncanle.UseVisualStyleBackColor = true;
            this.btncanle.Click += new System.EventHandler(this.btncanle_Click);
            // 
            // Frmclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.gbclos);
            this.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmclos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关闭提示";
            this.gbclos.ResumeLayout(false);
            this.gbclos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbclos;
        private System.Windows.Forms.RadioButton rdoclos;
        private System.Windows.Forms.RadioButton rdocloss;
        private System.Windows.Forms.Label lblclos;
        private System.Windows.Forms.Button btncanle;
        private System.Windows.Forms.Button btnok;
    }
}