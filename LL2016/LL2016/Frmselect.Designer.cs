namespace LL2016
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
            this.btnselect = new System.Windows.Forms.Button();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtWid = new System.Windows.Forms.TextBox();
            this.lblWid = new System.Windows.Forms.Label();
            this.lblWpassword = new System.Windows.Forms.Label();
            this.txtWpasseord = new System.Windows.Forms.TextBox();
            this.lblWname = new System.Windows.Forms.Label();
            this.txtWname = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.lbbWadress = new System.Windows.Forms.Label();
            this.nuWage = new System.Windows.Forms.NumericUpDown();
            this.cboWadress = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(584, 10);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "查 询";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // dgvstudent
            // 
            this.dgvstudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvstudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvstudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvstudent.Location = new System.Drawing.Point(0, 112);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowTemplate.Height = 23;
            this.dgvstudent.Size = new System.Drawing.Size(671, 342);
            this.dgvstudent.TabIndex = 1;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(363, 57);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 2;
            this.btninsert.Text = "添 加";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(478, 57);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "修 改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(584, 57);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "删 除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtWid
            // 
            this.txtWid.Location = new System.Drawing.Point(64, 12);
            this.txtWid.Name = "txtWid";
            this.txtWid.Size = new System.Drawing.Size(100, 21);
            this.txtWid.TabIndex = 5;
            this.txtWid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWid
            // 
            this.lblWid.AutoSize = true;
            this.lblWid.Location = new System.Drawing.Point(23, 15);
            this.lblWid.Name = "lblWid";
            this.lblWid.Size = new System.Drawing.Size(35, 12);
            this.lblWid.TabIndex = 6;
            this.lblWid.Text = "名称:";
            // 
            // lblWpassword
            // 
            this.lblWpassword.AutoSize = true;
            this.lblWpassword.Location = new System.Drawing.Point(197, 15);
            this.lblWpassword.Name = "lblWpassword";
            this.lblWpassword.Size = new System.Drawing.Size(35, 12);
            this.lblWpassword.TabIndex = 8;
            this.lblWpassword.Text = "密码:";
            // 
            // txtWpasseord
            // 
            this.txtWpasseord.Location = new System.Drawing.Point(238, 12);
            this.txtWpasseord.Name = "txtWpasseord";
            this.txtWpasseord.Size = new System.Drawing.Size(100, 21);
            this.txtWpasseord.TabIndex = 7;
            this.txtWpasseord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWname
            // 
            this.lblWname.AutoSize = true;
            this.lblWname.Location = new System.Drawing.Point(380, 15);
            this.lblWname.Name = "lblWname";
            this.lblWname.Size = new System.Drawing.Size(35, 12);
            this.lblWname.TabIndex = 10;
            this.lblWname.Text = "姓名:";
            // 
            // txtWname
            // 
            this.txtWname.Location = new System.Drawing.Point(421, 12);
            this.txtWname.Name = "txtWname";
            this.txtWname.Size = new System.Drawing.Size(100, 21);
            this.txtWname.TabIndex = 9;
            this.txtWname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(23, 62);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(35, 12);
            this.lblWage.TabIndex = 12;
            this.lblWage.Text = "年龄:";
            // 
            // lbbWadress
            // 
            this.lbbWadress.AutoSize = true;
            this.lbbWadress.Location = new System.Drawing.Point(197, 62);
            this.lbbWadress.Name = "lbbWadress";
            this.lbbWadress.Size = new System.Drawing.Size(35, 12);
            this.lbbWadress.TabIndex = 14;
            this.lbbWadress.Text = "住址:";
            // 
            // nuWage
            // 
            this.nuWage.Location = new System.Drawing.Point(64, 60);
            this.nuWage.Name = "nuWage";
            this.nuWage.Size = new System.Drawing.Size(100, 21);
            this.nuWage.TabIndex = 16;
            this.nuWage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuWage.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cboWadress
            // 
            this.cboWadress.FormattingEnabled = true;
            this.cboWadress.Location = new System.Drawing.Point(238, 59);
            this.cboWadress.Name = "cboWadress";
            this.cboWadress.Size = new System.Drawing.Size(100, 20);
            this.cboWadress.TabIndex = 17;
            // 
            // Frmselect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 454);
            this.Controls.Add(this.cboWadress);
            this.Controls.Add(this.nuWage);
            this.Controls.Add(this.lbbWadress);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblWname);
            this.Controls.Add(this.txtWname);
            this.Controls.Add(this.lblWpassword);
            this.Controls.Add(this.txtWpasseord);
            this.Controls.Add(this.lblWid);
            this.Controls.Add(this.txtWid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.btnselect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frmselect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmselect_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtWid;
        private System.Windows.Forms.Label lblWid;
        private System.Windows.Forms.Label lblWpassword;
        private System.Windows.Forms.TextBox txtWpasseord;
        private System.Windows.Forms.Label lblWname;
        private System.Windows.Forms.TextBox txtWname;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lbbWadress;
        private System.Windows.Forms.NumericUpDown nuWage;
        private System.Windows.Forms.ComboBox cboWadress;
    }
}