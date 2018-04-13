namespace School
{
    partial class FrmTeachers
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
            System.Windows.Forms.DateTimePicker dtptime;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachers));
            this.tsmimrun = new System.Windows.Forms.MenuStrip();
            this.tsmiskins = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiclose = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiback = new System.Windows.Forms.ToolStripMenuItem();
            this.prmgo = new System.Windows.Forms.ProgressBar();
            this.tpteacherdo = new System.Windows.Forms.TabPage();
            this.txtclassdo = new System.Windows.Forms.TextBox();
            this.txtgreads = new System.Windows.Forms.TextBox();
            this.txtteacherdo = new System.Windows.Forms.TextBox();
            this.lblclassdos = new System.Windows.Forms.Label();
            this.lblgreaddos = new System.Windows.Forms.Label();
            this.lblteacherdo = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.tpteacherclass = new System.Windows.Forms.TabPage();
            this.btnclass = new System.Windows.Forms.Button();
            this.btngread = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.cbogread = new System.Windows.Forms.ComboBox();
            this.lbGCcontent = new System.Windows.Forms.Label();
            this.dgvGCcontent = new System.Windows.Forms.DataGridView();
            this.tpteacherpeople = new System.Windows.Forms.TabPage();
            this.btnstudentcontent = new System.Windows.Forms.Button();
            this.btnteachercontent = new System.Windows.Forms.Button();
            this.lblstudentcontent = new System.Windows.Forms.Label();
            this.lblteachercontent = new System.Windows.Forms.Label();
            this.cbostudentcontent = new System.Windows.Forms.ComboBox();
            this.cboteachercontent = new System.Windows.Forms.ComboBox();
            this.lblcontent = new System.Windows.Forms.Label();
            this.dgvcontent = new System.Windows.Forms.DataGridView();
            this.tpteachergrade = new System.Windows.Forms.TabPage();
            this.btnclassgread = new System.Windows.Forms.Button();
            this.btngreadgread = new System.Windows.Forms.Button();
            this.cbogreadgread = new System.Windows.Forms.ComboBox();
            this.cboclassgread = new System.Windows.Forms.ComboBox();
            this.lblGCgread = new System.Windows.Forms.Label();
            this.dgvGCgread = new System.Windows.Forms.DataGridView();
            this.lblgreadgread = new System.Windows.Forms.Label();
            this.lblclassgread = new System.Windows.Forms.Label();
            this.tabteacher = new System.Windows.Forms.TabControl();
            dtptime = new System.Windows.Forms.DateTimePicker();
            this.tsmimrun.SuspendLayout();
            this.tpteacherdo.SuspendLayout();
            this.tpteacherclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCcontent)).BeginInit();
            this.tpteacherpeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontent)).BeginInit();
            this.tpteachergrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCgread)).BeginInit();
            this.tabteacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtptime
            // 
            dtptime.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dtptime.Checked = false;
            dtptime.Cursor = System.Windows.Forms.Cursors.Hand;
            dtptime.Location = new System.Drawing.Point(828, 603);
            dtptime.Margin = new System.Windows.Forms.Padding(0);
            dtptime.Name = "dtptime";
            dtptime.Size = new System.Drawing.Size(120, 21);
            dtptime.TabIndex = 8;
            // 
            // tsmimrun
            // 
            this.tsmimrun.BackgroundImage = global::School.Properties.Resources._2;
            this.tsmimrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmimrun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsmimrun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiskins});
            this.tsmimrun.Location = new System.Drawing.Point(0, 599);
            this.tsmimrun.Name = "tsmimrun";
            this.tsmimrun.Size = new System.Drawing.Size(1094, 25);
            this.tsmimrun.TabIndex = 5;
            // 
            // tsmiskins
            // 
            this.tsmiskins.BackgroundImage = global::School.Properties.Resources._2;
            this.tsmiskins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiclose,
            this.tmsiback});
            this.tsmiskins.Name = "tsmiskins";
            this.tsmiskins.Size = new System.Drawing.Size(44, 21);
            this.tsmiskins.Text = "设置";
            // 
            // tmsiclose
            // 
            this.tmsiclose.BackgroundImage = global::School.Properties.Resources._2;
            this.tmsiclose.Name = "tmsiclose";
            this.tmsiclose.Size = new System.Drawing.Size(104, 22);
            this.tmsiclose.Text = "退 出";
            this.tmsiclose.Click += new System.EventHandler(this.tmsiclose_Click);
            // 
            // tmsiback
            // 
            this.tmsiback.BackgroundImage = global::School.Properties.Resources._2;
            this.tmsiback.Name = "tmsiback";
            this.tmsiback.Size = new System.Drawing.Size(104, 22);
            this.tmsiback.Text = "返 回";
            this.tmsiback.Click += new System.EventHandler(this.tmsiback_Click);
            // 
            // prmgo
            // 
            this.prmgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prmgo.Location = new System.Drawing.Point(970, 604);
            this.prmgo.Name = "prmgo";
            this.prmgo.Size = new System.Drawing.Size(124, 20);
            this.prmgo.TabIndex = 7;
            this.prmgo.Value = 80;
            // 
            // tpteacherdo
            // 
            this.tpteacherdo.BackgroundImage = global::School.Properties.Resources._2;
            this.tpteacherdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpteacherdo.Controls.Add(this.txtclassdo);
            this.tpteacherdo.Controls.Add(this.txtgreads);
            this.tpteacherdo.Controls.Add(this.txtteacherdo);
            this.tpteacherdo.Controls.Add(this.lblclassdos);
            this.tpteacherdo.Controls.Add(this.lblgreaddos);
            this.tpteacherdo.Controls.Add(this.lblteacherdo);
            this.tpteacherdo.Controls.Add(this.btnselect);
            this.tpteacherdo.Location = new System.Drawing.Point(4, 26);
            this.tpteacherdo.Name = "tpteacherdo";
            this.tpteacherdo.Size = new System.Drawing.Size(1086, 569);
            this.tpteacherdo.TabIndex = 3;
            this.tpteacherdo.Text = "最新动态";
            this.tpteacherdo.UseVisualStyleBackColor = true;
            // 
            // txtclassdo
            // 
            this.txtclassdo.BackColor = System.Drawing.Color.White;
            this.txtclassdo.Font = new System.Drawing.Font("宋体", 16F);
            this.txtclassdo.Location = new System.Drawing.Point(728, 109);
            this.txtclassdo.Multiline = true;
            this.txtclassdo.Name = "txtclassdo";
            this.txtclassdo.ReadOnly = true;
            this.txtclassdo.Size = new System.Drawing.Size(322, 456);
            this.txtclassdo.TabIndex = 52;
            this.txtclassdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtgreads
            // 
            this.txtgreads.BackColor = System.Drawing.Color.White;
            this.txtgreads.Font = new System.Drawing.Font("宋体", 16F);
            this.txtgreads.Location = new System.Drawing.Point(368, 109);
            this.txtgreads.Multiline = true;
            this.txtgreads.Name = "txtgreads";
            this.txtgreads.ReadOnly = true;
            this.txtgreads.Size = new System.Drawing.Size(354, 456);
            this.txtgreads.TabIndex = 51;
            this.txtgreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtteacherdo
            // 
            this.txtteacherdo.BackColor = System.Drawing.Color.White;
            this.txtteacherdo.Font = new System.Drawing.Font("宋体", 16F);
            this.txtteacherdo.Location = new System.Drawing.Point(37, 109);
            this.txtteacherdo.Multiline = true;
            this.txtteacherdo.Name = "txtteacherdo";
            this.txtteacherdo.ReadOnly = true;
            this.txtteacherdo.Size = new System.Drawing.Size(325, 456);
            this.txtteacherdo.TabIndex = 47;
            this.txtteacherdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblclassdos
            // 
            this.lblclassdos.AutoSize = true;
            this.lblclassdos.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblclassdos.ForeColor = System.Drawing.Color.White;
            this.lblclassdos.Location = new System.Drawing.Point(912, 81);
            this.lblclassdos.Name = "lblclassdos";
            this.lblclassdos.Size = new System.Drawing.Size(108, 25);
            this.lblclassdos.TabIndex = 50;
            this.lblclassdos.Text = "班级动态";
            // 
            // lblgreaddos
            // 
            this.lblgreaddos.AutoSize = true;
            this.lblgreaddos.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgreaddos.ForeColor = System.Drawing.Color.White;
            this.lblgreaddos.Location = new System.Drawing.Point(471, 74);
            this.lblgreaddos.Name = "lblgreaddos";
            this.lblgreaddos.Size = new System.Drawing.Size(108, 25);
            this.lblgreaddos.TabIndex = 49;
            this.lblgreaddos.Text = "年级动态";
            // 
            // lblteacherdo
            // 
            this.lblteacherdo.AutoSize = true;
            this.lblteacherdo.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblteacherdo.ForeColor = System.Drawing.Color.White;
            this.lblteacherdo.Location = new System.Drawing.Point(117, 74);
            this.lblteacherdo.Name = "lblteacherdo";
            this.lblteacherdo.Size = new System.Drawing.Size(108, 25);
            this.lblteacherdo.TabIndex = 48;
            this.lblteacherdo.Text = "教师动态";
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.White;
            this.btnselect.Font = new System.Drawing.Font("华文行楷", 20F);
            this.btnselect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnselect.Location = new System.Drawing.Point(476, 0);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(99, 42);
            this.btnselect.TabIndex = 10;
            this.btnselect.Text = "查  看";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // tpteacherclass
            // 
            this.tpteacherclass.BackgroundImage = global::School.Properties.Resources._2;
            this.tpteacherclass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpteacherclass.Controls.Add(this.btnclass);
            this.tpteacherclass.Controls.Add(this.btngread);
            this.tpteacherclass.Controls.Add(this.label2);
            this.tpteacherclass.Controls.Add(this.label1);
            this.tpteacherclass.Controls.Add(this.cboclass);
            this.tpteacherclass.Controls.Add(this.cbogread);
            this.tpteacherclass.Controls.Add(this.lbGCcontent);
            this.tpteacherclass.Controls.Add(this.dgvGCcontent);
            this.tpteacherclass.Location = new System.Drawing.Point(4, 26);
            this.tpteacherclass.Name = "tpteacherclass";
            this.tpteacherclass.Size = new System.Drawing.Size(1086, 569);
            this.tpteacherclass.TabIndex = 2;
            this.tpteacherclass.Text = "课表";
            this.tpteacherclass.UseVisualStyleBackColor = true;
            // 
            // btnclass
            // 
            this.btnclass.Font = new System.Drawing.Font("宋体", 18F);
            this.btnclass.Location = new System.Drawing.Point(934, 13);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(78, 37);
            this.btnclass.TabIndex = 38;
            this.btnclass.Text = "查 看";
            this.btnclass.UseVisualStyleBackColor = true;
            this.btnclass.Click += new System.EventHandler(this.btnclass_Click);
            // 
            // btngread
            // 
            this.btngread.Font = new System.Drawing.Font("宋体", 18F);
            this.btngread.Location = new System.Drawing.Point(313, 10);
            this.btngread.Name = "btngread";
            this.btngread.Size = new System.Drawing.Size(78, 37);
            this.btngread.TabIndex = 37;
            this.btngread.Text = "查 看";
            this.btngread.UseVisualStyleBackColor = true;
            this.btngread.Click += new System.EventHandler(this.btngread_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 23F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(637, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "班级:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 23F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "年级:";
            // 
            // cboclass
            // 
            this.cboclass.Font = new System.Drawing.Font("宋体", 21.75F);
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Location = new System.Drawing.Point(735, 12);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(172, 37);
            this.cboclass.TabIndex = 10;
            // 
            // cbogread
            // 
            this.cbogread.Font = new System.Drawing.Font("宋体", 21.75F);
            this.cbogread.FormattingEnabled = true;
            this.cbogread.Location = new System.Drawing.Point(123, 10);
            this.cbogread.Name = "cbogread";
            this.cbogread.Size = new System.Drawing.Size(164, 37);
            this.cbogread.TabIndex = 9;
            // 
            // lbGCcontent
            // 
            this.lbGCcontent.AutoSize = true;
            this.lbGCcontent.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGCcontent.ForeColor = System.Drawing.Color.LightGray;
            this.lbGCcontent.Location = new System.Drawing.Point(8, 60);
            this.lbGCcontent.Name = "lbGCcontent";
            this.lbGCcontent.Size = new System.Drawing.Size(108, 25);
            this.lbGCcontent.TabIndex = 8;
            this.lbGCcontent.Text = "课表如下";
            // 
            // dgvGCcontent
            // 
            this.dgvGCcontent.BackgroundColor = System.Drawing.Color.White;
            this.dgvGCcontent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGCcontent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGCcontent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGCcontent.Location = new System.Drawing.Point(0, 88);
            this.dgvGCcontent.Name = "dgvGCcontent";
            this.dgvGCcontent.RowTemplate.Height = 23;
            this.dgvGCcontent.Size = new System.Drawing.Size(1086, 481);
            this.dgvGCcontent.TabIndex = 7;
            // 
            // tpteacherpeople
            // 
            this.tpteacherpeople.BackgroundImage = global::School.Properties.Resources._2;
            this.tpteacherpeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpteacherpeople.Controls.Add(this.btnstudentcontent);
            this.tpteacherpeople.Controls.Add(this.btnteachercontent);
            this.tpteacherpeople.Controls.Add(this.lblstudentcontent);
            this.tpteacherpeople.Controls.Add(this.lblteachercontent);
            this.tpteacherpeople.Controls.Add(this.cbostudentcontent);
            this.tpteacherpeople.Controls.Add(this.cboteachercontent);
            this.tpteacherpeople.Controls.Add(this.lblcontent);
            this.tpteacherpeople.Controls.Add(this.dgvcontent);
            this.tpteacherpeople.Location = new System.Drawing.Point(4, 26);
            this.tpteacherpeople.Name = "tpteacherpeople";
            this.tpteacherpeople.Size = new System.Drawing.Size(1086, 569);
            this.tpteacherpeople.TabIndex = 1;
            this.tpteacherpeople.Text = "师生信息";
            this.tpteacherpeople.UseVisualStyleBackColor = true;
            // 
            // btnstudentcontent
            // 
            this.btnstudentcontent.Font = new System.Drawing.Font("宋体", 18F);
            this.btnstudentcontent.Location = new System.Drawing.Point(920, 4);
            this.btnstudentcontent.Name = "btnstudentcontent";
            this.btnstudentcontent.Size = new System.Drawing.Size(78, 37);
            this.btnstudentcontent.TabIndex = 37;
            this.btnstudentcontent.Text = "查 看";
            this.btnstudentcontent.UseVisualStyleBackColor = true;
            this.btnstudentcontent.Click += new System.EventHandler(this.btnstudentcontent_Click);
            // 
            // btnteachercontent
            // 
            this.btnteachercontent.Font = new System.Drawing.Font("宋体", 18F);
            this.btnteachercontent.Location = new System.Drawing.Point(360, 4);
            this.btnteachercontent.Name = "btnteachercontent";
            this.btnteachercontent.Size = new System.Drawing.Size(78, 37);
            this.btnteachercontent.TabIndex = 36;
            this.btnteachercontent.Text = "查 看";
            this.btnteachercontent.UseVisualStyleBackColor = true;
            this.btnteachercontent.Click += new System.EventHandler(this.btnteachercontent_Click);
            // 
            // lblstudentcontent
            // 
            this.lblstudentcontent.AutoSize = true;
            this.lblstudentcontent.Font = new System.Drawing.Font("宋体", 23F);
            this.lblstudentcontent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblstudentcontent.Location = new System.Drawing.Point(610, 9);
            this.lblstudentcontent.Name = "lblstudentcontent";
            this.lblstudentcontent.Size = new System.Drawing.Size(92, 31);
            this.lblstudentcontent.TabIndex = 14;
            this.lblstudentcontent.Text = "学生:";
            // 
            // lblteachercontent
            // 
            this.lblteachercontent.AutoSize = true;
            this.lblteachercontent.Font = new System.Drawing.Font("宋体", 23F);
            this.lblteachercontent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblteachercontent.Location = new System.Drawing.Point(26, 9);
            this.lblteachercontent.Name = "lblteachercontent";
            this.lblteachercontent.Size = new System.Drawing.Size(92, 31);
            this.lblteachercontent.TabIndex = 13;
            this.lblteachercontent.Text = "教师:";
            // 
            // cbostudentcontent
            // 
            this.cbostudentcontent.Font = new System.Drawing.Font("宋体", 21.75F);
            this.cbostudentcontent.FormattingEnabled = true;
            this.cbostudentcontent.Location = new System.Drawing.Point(723, 3);
            this.cbostudentcontent.Name = "cbostudentcontent";
            this.cbostudentcontent.Size = new System.Drawing.Size(163, 37);
            this.cbostudentcontent.TabIndex = 10;
            // 
            // cboteachercontent
            // 
            this.cboteachercontent.Font = new System.Drawing.Font("宋体", 21.75F);
            this.cboteachercontent.FormattingEnabled = true;
            this.cboteachercontent.Location = new System.Drawing.Point(141, 3);
            this.cboteachercontent.Name = "cboteachercontent";
            this.cboteachercontent.Size = new System.Drawing.Size(194, 37);
            this.cboteachercontent.TabIndex = 9;
            // 
            // lblcontent
            // 
            this.lblcontent.AutoSize = true;
            this.lblcontent.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcontent.ForeColor = System.Drawing.Color.White;
            this.lblcontent.Location = new System.Drawing.Point(3, 55);
            this.lblcontent.Name = "lblcontent";
            this.lblcontent.Size = new System.Drawing.Size(156, 25);
            this.lblcontent.TabIndex = 8;
            this.lblcontent.Text = "简介内容如下";
            // 
            // dgvcontent
            // 
            this.dgvcontent.BackgroundColor = System.Drawing.Color.White;
            this.dgvcontent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcontent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcontent.Location = new System.Drawing.Point(0, 83);
            this.dgvcontent.Name = "dgvcontent";
            this.dgvcontent.RowTemplate.Height = 23;
            this.dgvcontent.Size = new System.Drawing.Size(1086, 486);
            this.dgvcontent.TabIndex = 7;
            // 
            // tpteachergrade
            // 
            this.tpteachergrade.BackgroundImage = global::School.Properties.Resources._2;
            this.tpteachergrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpteachergrade.Controls.Add(this.btnclassgread);
            this.tpteachergrade.Controls.Add(this.btngreadgread);
            this.tpteachergrade.Controls.Add(this.cbogreadgread);
            this.tpteachergrade.Controls.Add(this.cboclassgread);
            this.tpteachergrade.Controls.Add(this.lblGCgread);
            this.tpteachergrade.Controls.Add(this.dgvGCgread);
            this.tpteachergrade.Controls.Add(this.lblgreadgread);
            this.tpteachergrade.Controls.Add(this.lblclassgread);
            this.tpteachergrade.Location = new System.Drawing.Point(4, 26);
            this.tpteachergrade.Name = "tpteachergrade";
            this.tpteachergrade.Padding = new System.Windows.Forms.Padding(3);
            this.tpteachergrade.Size = new System.Drawing.Size(1086, 569);
            this.tpteachergrade.TabIndex = 0;
            this.tpteachergrade.Text = "成绩";
            this.tpteachergrade.UseVisualStyleBackColor = true;
            // 
            // btnclassgread
            // 
            this.btnclassgread.Font = new System.Drawing.Font("宋体", 18F);
            this.btnclassgread.Location = new System.Drawing.Point(856, 10);
            this.btnclassgread.Name = "btnclassgread";
            this.btnclassgread.Size = new System.Drawing.Size(78, 37);
            this.btnclassgread.TabIndex = 36;
            this.btnclassgread.Text = "查 看";
            this.btnclassgread.UseVisualStyleBackColor = true;
            this.btnclassgread.Click += new System.EventHandler(this.btnclassgread_Click);
            // 
            // btngreadgread
            // 
            this.btngreadgread.Font = new System.Drawing.Font("宋体", 18F);
            this.btngreadgread.Location = new System.Drawing.Point(324, 9);
            this.btngreadgread.Name = "btngreadgread";
            this.btngreadgread.Size = new System.Drawing.Size(78, 37);
            this.btngreadgread.TabIndex = 35;
            this.btngreadgread.Text = "查 看";
            this.btngreadgread.UseVisualStyleBackColor = true;
            this.btngreadgread.Click += new System.EventHandler(this.btngreadgread_Click);
            // 
            // cbogreadgread
            // 
            this.cbogreadgread.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbogreadgread.FormattingEnabled = true;
            this.cbogreadgread.Location = new System.Drawing.Point(121, 9);
            this.cbogreadgread.Name = "cbogreadgread";
            this.cbogreadgread.Size = new System.Drawing.Size(172, 37);
            this.cbogreadgread.TabIndex = 8;
            // 
            // cboclassgread
            // 
            this.cboclassgread.Font = new System.Drawing.Font("宋体", 21.75F);
            this.cboclassgread.FormattingEnabled = true;
            this.cboclassgread.Location = new System.Drawing.Point(641, 9);
            this.cboclassgread.Name = "cboclassgread";
            this.cboclassgread.Size = new System.Drawing.Size(184, 37);
            this.cboclassgread.TabIndex = 7;
            // 
            // lblGCgread
            // 
            this.lblGCgread.AutoSize = true;
            this.lblGCgread.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGCgread.ForeColor = System.Drawing.Color.White;
            this.lblGCgread.Location = new System.Drawing.Point(3, 49);
            this.lblGCgread.Name = "lblGCgread";
            this.lblGCgread.Size = new System.Drawing.Size(84, 25);
            this.lblGCgread.TabIndex = 6;
            this.lblGCgread.Text = "成绩单";
            // 
            // dgvGCgread
            // 
            this.dgvGCgread.BackgroundColor = System.Drawing.Color.White;
            this.dgvGCgread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGCgread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGCgread.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGCgread.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGCgread.Location = new System.Drawing.Point(3, 77);
            this.dgvGCgread.Name = "dgvGCgread";
            this.dgvGCgread.RowTemplate.Height = 23;
            this.dgvGCgread.Size = new System.Drawing.Size(1080, 489);
            this.dgvGCgread.TabIndex = 3;
            // 
            // lblgreadgread
            // 
            this.lblgreadgread.AutoSize = true;
            this.lblgreadgread.Font = new System.Drawing.Font("宋体", 23F);
            this.lblgreadgread.ForeColor = System.Drawing.Color.White;
            this.lblgreadgread.Location = new System.Drawing.Point(23, 12);
            this.lblgreadgread.Name = "lblgreadgread";
            this.lblgreadgread.Size = new System.Drawing.Size(92, 31);
            this.lblgreadgread.TabIndex = 12;
            this.lblgreadgread.Text = "年级:";
            // 
            // lblclassgread
            // 
            this.lblclassgread.AutoSize = true;
            this.lblclassgread.Font = new System.Drawing.Font("宋体", 23F);
            this.lblclassgread.ForeColor = System.Drawing.Color.White;
            this.lblclassgread.Location = new System.Drawing.Point(543, 12);
            this.lblclassgread.Name = "lblclassgread";
            this.lblclassgread.Size = new System.Drawing.Size(92, 31);
            this.lblclassgread.TabIndex = 13;
            this.lblclassgread.Text = "班级:";
            // 
            // tabteacher
            // 
            this.tabteacher.Controls.Add(this.tpteachergrade);
            this.tabteacher.Controls.Add(this.tpteacherpeople);
            this.tabteacher.Controls.Add(this.tpteacherclass);
            this.tabteacher.Controls.Add(this.tpteacherdo);
            this.tabteacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabteacher.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabteacher.Location = new System.Drawing.Point(0, 0);
            this.tabteacher.Name = "tabteacher";
            this.tabteacher.SelectedIndex = 0;
            this.tabteacher.Size = new System.Drawing.Size(1094, 599);
            this.tabteacher.TabIndex = 4;
            // 
            // FrmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 624);
            this.Controls.Add(dtptime);
            this.Controls.Add(this.prmgo);
            this.Controls.Add(this.tabteacher);
            this.Controls.Add(this.tsmimrun);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tsmimrun;
            this.MaximizeBox = false;
            this.Name = "FrmTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教 师";
            this.Load += new System.EventHandler(this.FrmTeachers_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTeachers_FormClosing);
            this.tsmimrun.ResumeLayout(false);
            this.tsmimrun.PerformLayout();
            this.tpteacherdo.ResumeLayout(false);
            this.tpteacherdo.PerformLayout();
            this.tpteacherclass.ResumeLayout(false);
            this.tpteacherclass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCcontent)).EndInit();
            this.tpteacherpeople.ResumeLayout(false);
            this.tpteacherpeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontent)).EndInit();
            this.tpteachergrade.ResumeLayout(false);
            this.tpteachergrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCgread)).EndInit();
            this.tabteacher.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tsmimrun;
        private System.Windows.Forms.ToolStripMenuItem tsmiskins;
        private System.Windows.Forms.ToolStripMenuItem tmsiback;
        private System.Windows.Forms.ToolStripMenuItem tmsiclose;
        private System.Windows.Forms.ProgressBar prmgo;
        private System.Windows.Forms.TabPage tpteacherdo;
        private System.Windows.Forms.TextBox txtclassdo;
        private System.Windows.Forms.TextBox txtgreads;
        private System.Windows.Forms.TextBox txtteacherdo;
        private System.Windows.Forms.Label lblclassdos;
        private System.Windows.Forms.Label lblgreaddos;
        private System.Windows.Forms.Label lblteacherdo;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TabPage tpteacherclass;
        private System.Windows.Forms.Button btnclass;
        private System.Windows.Forms.Button btngread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboclass;
        private System.Windows.Forms.ComboBox cbogread;
        private System.Windows.Forms.Label lbGCcontent;
        private System.Windows.Forms.DataGridView dgvGCcontent;
        private System.Windows.Forms.TabPage tpteacherpeople;
        private System.Windows.Forms.Button btnstudentcontent;
        private System.Windows.Forms.Button btnteachercontent;
        private System.Windows.Forms.Label lblstudentcontent;
        private System.Windows.Forms.Label lblteachercontent;
        private System.Windows.Forms.ComboBox cbostudentcontent;
        private System.Windows.Forms.ComboBox cboteachercontent;
        private System.Windows.Forms.Label lblcontent;
        private System.Windows.Forms.DataGridView dgvcontent;
        private System.Windows.Forms.TabPage tpteachergrade;
        private System.Windows.Forms.Button btnclassgread;
        private System.Windows.Forms.Button btngreadgread;
        private System.Windows.Forms.ComboBox cbogreadgread;
        private System.Windows.Forms.ComboBox cboclassgread;
        private System.Windows.Forms.Label lblGCgread;
        private System.Windows.Forms.DataGridView dgvGCgread;
        private System.Windows.Forms.Label lblgreadgread;
        private System.Windows.Forms.Label lblclassgread;
        private System.Windows.Forms.TabControl tabteacher;
    }
}