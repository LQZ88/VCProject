namespace 商城
{
    partial class FrmRunCommodity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRunCommodity));
            this.tpAdcom = new System.Windows.Forms.TabPage();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.cboComcat = new System.Windows.Forms.ComboBox();
            this.btnAddCancle = new System.Windows.Forms.Button();
            this.btnAddOk = new System.Windows.Forms.Button();
            this.btnAddCopicture = new System.Windows.Forms.Button();
            this.txtAddComamount = new System.Windows.Forms.TextBox();
            this.txtAddComprice = new System.Windows.Forms.TextBox();
            this.txtAddComname = new System.Windows.Forms.TextBox();
            this.txtAddComid = new System.Windows.Forms.TextBox();
            this.lblAddComamount = new System.Windows.Forms.Label();
            this.lblAddComprice = new System.Windows.Forms.Label();
            this.lblAddComname = new System.Windows.Forms.Label();
            this.lblAddComid = new System.Windows.Forms.Label();
            this.lblIncomcatid = new System.Windows.Forms.Label();
            this.cboUpComcat = new System.Windows.Forms.ComboBox();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            this.cboDeComcat = new System.Windows.Forms.ComboBox();
            this.btnDeCancle = new System.Windows.Forms.Button();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            this.tpUdatecom = new System.Windows.Forms.TabPage();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpOk = new System.Windows.Forms.Button();
            this.btnUppicture = new System.Windows.Forms.Button();
            this.txtUpAmount = new System.Windows.Forms.TextBox();
            this.txtUpComprice = new System.Windows.Forms.TextBox();
            this.txtUpComname = new System.Windows.Forms.TextBox();
            this.txtUpComid = new System.Windows.Forms.TextBox();
            this.lblUpAmount = new System.Windows.Forms.Label();
            this.lblUpComprice = new System.Windows.Forms.Label();
            this.lblUpComname = new System.Windows.Forms.Label();
            this.lblUpComid = new System.Windows.Forms.Label();
            this.lblUpComcat = new System.Windows.Forms.Label();
            this.txtDeAmount = new System.Windows.Forms.TextBox();
            this.txtDeComprice = new System.Windows.Forms.TextBox();
            this.btnDeOk = new System.Windows.Forms.Button();
            this.tpDeletecom = new System.Windows.Forms.TabPage();
            this.txtDeComName = new System.Windows.Forms.TextBox();
            this.txtDeComID = new System.Windows.Forms.TextBox();
            this.lblDeAmount = new System.Windows.Forms.Label();
            this.lblDeComprice = new System.Windows.Forms.Label();
            this.lblDeComname = new System.Windows.Forms.Label();
            this.lblDeComID = new System.Windows.Forms.Label();
            this.lblDecomcatid = new System.Windows.Forms.Label();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tmrTL = new System.Windows.Forms.Timer(this.components);
            this.tpAdcom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            this.tpUdatecom.SuspendLayout();
            this.tpDeletecom.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAdcom
            // 
            this.tpAdcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpAdcom.Controls.Add(this.picBoxAdd);
            this.tpAdcom.Controls.Add(this.cboComcat);
            this.tpAdcom.Controls.Add(this.btnAddCancle);
            this.tpAdcom.Controls.Add(this.btnAddOk);
            this.tpAdcom.Controls.Add(this.btnAddCopicture);
            this.tpAdcom.Controls.Add(this.txtAddComamount);
            this.tpAdcom.Controls.Add(this.txtAddComprice);
            this.tpAdcom.Controls.Add(this.txtAddComname);
            this.tpAdcom.Controls.Add(this.txtAddComid);
            this.tpAdcom.Controls.Add(this.lblAddComamount);
            this.tpAdcom.Controls.Add(this.lblAddComprice);
            this.tpAdcom.Controls.Add(this.lblAddComname);
            this.tpAdcom.Controls.Add(this.lblAddComid);
            this.tpAdcom.Controls.Add(this.lblIncomcatid);
            this.tpAdcom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpAdcom.Location = new System.Drawing.Point(4, 22);
            this.tpAdcom.Name = "tpAdcom";
            this.tpAdcom.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdcom.Size = new System.Drawing.Size(770, 444);
            this.tpAdcom.TabIndex = 0;
            this.tpAdcom.Text = "新增商品";
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.BackColor = System.Drawing.Color.DarkGray;
            this.picBoxAdd.Location = new System.Drawing.Point(165, 100);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(138, 141);
            this.picBoxAdd.TabIndex = 13;
            this.picBoxAdd.TabStop = false;
            // 
            // cboComcat
            // 
            this.cboComcat.FormattingEnabled = true;
            this.cboComcat.Location = new System.Drawing.Point(165, 25);
            this.cboComcat.Name = "cboComcat";
            this.cboComcat.Size = new System.Drawing.Size(138, 24);
            this.cboComcat.TabIndex = 12;
            // 
            // btnAddCancle
            // 
            this.btnAddCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCancle.Location = new System.Drawing.Point(625, 335);
            this.btnAddCancle.Name = "btnAddCancle";
            this.btnAddCancle.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancle.TabIndex = 11;
            this.btnAddCancle.Text = "取 消";
            this.btnAddCancle.UseVisualStyleBackColor = true;
            this.btnAddCancle.Click += new System.EventHandler(this.btnAddCancle_Click);
            // 
            // btnAddOk
            // 
            this.btnAddOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddOk.Location = new System.Drawing.Point(444, 335);
            this.btnAddOk.Name = "btnAddOk";
            this.btnAddOk.Size = new System.Drawing.Size(75, 23);
            this.btnAddOk.TabIndex = 10;
            this.btnAddOk.Text = "确 定";
            this.btnAddOk.UseVisualStyleBackColor = true;
            this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
            // 
            // btnAddCopicture
            // 
            this.btnAddCopicture.Location = new System.Drawing.Point(165, 335);
            this.btnAddCopicture.Name = "btnAddCopicture";
            this.btnAddCopicture.Size = new System.Drawing.Size(75, 23);
            this.btnAddCopicture.TabIndex = 9;
            this.btnAddCopicture.Text = "选 择";
            this.btnAddCopicture.UseVisualStyleBackColor = true;
            this.btnAddCopicture.Click += new System.EventHandler(this.btnAddCopicture_Click);
            // 
            // txtAddComamount
            // 
            this.txtAddComamount.Location = new System.Drawing.Point(535, 215);
            this.txtAddComamount.Name = "txtAddComamount";
            this.txtAddComamount.Size = new System.Drawing.Size(191, 26);
            this.txtAddComamount.TabIndex = 8;
            // 
            // txtAddComprice
            // 
            this.txtAddComprice.Location = new System.Drawing.Point(535, 149);
            this.txtAddComprice.Name = "txtAddComprice";
            this.txtAddComprice.Size = new System.Drawing.Size(191, 26);
            this.txtAddComprice.TabIndex = 7;
            // 
            // txtAddComname
            // 
            this.txtAddComname.Location = new System.Drawing.Point(535, 84);
            this.txtAddComname.Name = "txtAddComname";
            this.txtAddComname.Size = new System.Drawing.Size(191, 26);
            this.txtAddComname.TabIndex = 6;
            // 
            // txtAddComid
            // 
            this.txtAddComid.Location = new System.Drawing.Point(535, 25);
            this.txtAddComid.Name = "txtAddComid";
            this.txtAddComid.Size = new System.Drawing.Size(191, 26);
            this.txtAddComid.TabIndex = 5;
            // 
            // lblAddComamount
            // 
            this.lblAddComamount.AutoSize = true;
            this.lblAddComamount.Location = new System.Drawing.Point(420, 218);
            this.lblAddComamount.Name = "lblAddComamount";
            this.lblAddComamount.Size = new System.Drawing.Size(80, 16);
            this.lblAddComamount.TabIndex = 4;
            this.lblAddComamount.Text = "商品数量:";
            // 
            // lblAddComprice
            // 
            this.lblAddComprice.AutoSize = true;
            this.lblAddComprice.Location = new System.Drawing.Point(420, 152);
            this.lblAddComprice.Name = "lblAddComprice";
            this.lblAddComprice.Size = new System.Drawing.Size(80, 16);
            this.lblAddComprice.TabIndex = 3;
            this.lblAddComprice.Text = "商品价格:";
            // 
            // lblAddComname
            // 
            this.lblAddComname.AutoSize = true;
            this.lblAddComname.Location = new System.Drawing.Point(420, 87);
            this.lblAddComname.Name = "lblAddComname";
            this.lblAddComname.Size = new System.Drawing.Size(80, 16);
            this.lblAddComname.TabIndex = 2;
            this.lblAddComname.Text = "商品名称:";
            // 
            // lblAddComid
            // 
            this.lblAddComid.AutoSize = true;
            this.lblAddComid.Location = new System.Drawing.Point(420, 28);
            this.lblAddComid.Name = "lblAddComid";
            this.lblAddComid.Size = new System.Drawing.Size(80, 16);
            this.lblAddComid.TabIndex = 1;
            this.lblAddComid.Text = "商品编号:";
            // 
            // lblIncomcatid
            // 
            this.lblIncomcatid.AutoSize = true;
            this.lblIncomcatid.Location = new System.Drawing.Point(57, 28);
            this.lblIncomcatid.Name = "lblIncomcatid";
            this.lblIncomcatid.Size = new System.Drawing.Size(80, 16);
            this.lblIncomcatid.TabIndex = 0;
            this.lblIncomcatid.Text = "商品类别:";
            // 
            // cboUpComcat
            // 
            this.cboUpComcat.FormattingEnabled = true;
            this.cboUpComcat.Location = new System.Drawing.Point(159, 56);
            this.cboUpComcat.Name = "cboUpComcat";
            this.cboUpComcat.Size = new System.Drawing.Size(138, 24);
            this.cboUpComcat.TabIndex = 26;
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.Location = new System.Drawing.Point(159, 131);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(138, 141);
            this.picBoxDelete.TabIndex = 27;
            this.picBoxDelete.TabStop = false;
            // 
            // cboDeComcat
            // 
            this.cboDeComcat.FormattingEnabled = true;
            this.cboDeComcat.Location = new System.Drawing.Point(159, 56);
            this.cboDeComcat.Name = "cboDeComcat";
            this.cboDeComcat.Size = new System.Drawing.Size(138, 20);
            this.cboDeComcat.TabIndex = 26;
            // 
            // btnDeCancle
            // 
            this.btnDeCancle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeCancle.Location = new System.Drawing.Point(619, 366);
            this.btnDeCancle.Name = "btnDeCancle";
            this.btnDeCancle.Size = new System.Drawing.Size(75, 23);
            this.btnDeCancle.TabIndex = 25;
            this.btnDeCancle.Text = "取 消";
            this.btnDeCancle.UseVisualStyleBackColor = true;
            this.btnDeCancle.Click += new System.EventHandler(this.btnDeCancle_Click);
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.Location = new System.Drawing.Point(159, 131);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(138, 141);
            this.picBoxUpdate.TabIndex = 27;
            this.picBoxUpdate.TabStop = false;
            // 
            // tpUdatecom
            // 
            this.tpUdatecom.BackColor = System.Drawing.Color.Silver;
            this.tpUdatecom.Controls.Add(this.picBoxUpdate);
            this.tpUdatecom.Controls.Add(this.cboUpComcat);
            this.tpUdatecom.Controls.Add(this.btnCancle);
            this.tpUdatecom.Controls.Add(this.btnUpOk);
            this.tpUdatecom.Controls.Add(this.btnUppicture);
            this.tpUdatecom.Controls.Add(this.txtUpAmount);
            this.tpUdatecom.Controls.Add(this.txtUpComprice);
            this.tpUdatecom.Controls.Add(this.txtUpComname);
            this.tpUdatecom.Controls.Add(this.txtUpComid);
            this.tpUdatecom.Controls.Add(this.lblUpAmount);
            this.tpUdatecom.Controls.Add(this.lblUpComprice);
            this.tpUdatecom.Controls.Add(this.lblUpComname);
            this.tpUdatecom.Controls.Add(this.lblUpComid);
            this.tpUdatecom.Controls.Add(this.lblUpComcat);
            this.tpUdatecom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpUdatecom.Location = new System.Drawing.Point(4, 22);
            this.tpUdatecom.Name = "tpUdatecom";
            this.tpUdatecom.Padding = new System.Windows.Forms.Padding(3);
            this.tpUdatecom.Size = new System.Drawing.Size(770, 444);
            this.tpUdatecom.TabIndex = 2;
            this.tpUdatecom.Text = "修改商品信息";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(619, 366);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 25;
            this.btnCancle.Text = "取 消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpOk
            // 
            this.btnUpOk.Location = new System.Drawing.Point(438, 366);
            this.btnUpOk.Name = "btnUpOk";
            this.btnUpOk.Size = new System.Drawing.Size(75, 23);
            this.btnUpOk.TabIndex = 24;
            this.btnUpOk.Text = "确 定";
            this.btnUpOk.UseVisualStyleBackColor = true;
            this.btnUpOk.Click += new System.EventHandler(this.btnUpOk_Click);
            // 
            // btnUppicture
            // 
            this.btnUppicture.Location = new System.Drawing.Point(159, 366);
            this.btnUppicture.Name = "btnUppicture";
            this.btnUppicture.Size = new System.Drawing.Size(75, 23);
            this.btnUppicture.TabIndex = 23;
            this.btnUppicture.Text = "选 择";
            this.btnUppicture.UseVisualStyleBackColor = true;
            this.btnUppicture.Click += new System.EventHandler(this.btnUppicture_Click);
            // 
            // txtUpAmount
            // 
            this.txtUpAmount.Location = new System.Drawing.Point(529, 246);
            this.txtUpAmount.Name = "txtUpAmount";
            this.txtUpAmount.Size = new System.Drawing.Size(191, 26);
            this.txtUpAmount.TabIndex = 22;
            // 
            // txtUpComprice
            // 
            this.txtUpComprice.Location = new System.Drawing.Point(529, 180);
            this.txtUpComprice.Name = "txtUpComprice";
            this.txtUpComprice.Size = new System.Drawing.Size(191, 26);
            this.txtUpComprice.TabIndex = 21;
            // 
            // txtUpComname
            // 
            this.txtUpComname.Location = new System.Drawing.Point(529, 115);
            this.txtUpComname.Name = "txtUpComname";
            this.txtUpComname.Size = new System.Drawing.Size(191, 26);
            this.txtUpComname.TabIndex = 20;
            // 
            // txtUpComid
            // 
            this.txtUpComid.Location = new System.Drawing.Point(529, 56);
            this.txtUpComid.Name = "txtUpComid";
            this.txtUpComid.Size = new System.Drawing.Size(191, 26);
            this.txtUpComid.TabIndex = 19;
            this.txtUpComid.TextChanged += new System.EventHandler(this.txtUpComid_TextChanged);
            // 
            // lblUpAmount
            // 
            this.lblUpAmount.AutoSize = true;
            this.lblUpAmount.Location = new System.Drawing.Point(414, 249);
            this.lblUpAmount.Name = "lblUpAmount";
            this.lblUpAmount.Size = new System.Drawing.Size(80, 16);
            this.lblUpAmount.TabIndex = 18;
            this.lblUpAmount.Text = "商品数量:";
            // 
            // lblUpComprice
            // 
            this.lblUpComprice.AutoSize = true;
            this.lblUpComprice.Location = new System.Drawing.Point(414, 183);
            this.lblUpComprice.Name = "lblUpComprice";
            this.lblUpComprice.Size = new System.Drawing.Size(80, 16);
            this.lblUpComprice.TabIndex = 17;
            this.lblUpComprice.Text = "商品价格:";
            // 
            // lblUpComname
            // 
            this.lblUpComname.AutoSize = true;
            this.lblUpComname.Location = new System.Drawing.Point(414, 118);
            this.lblUpComname.Name = "lblUpComname";
            this.lblUpComname.Size = new System.Drawing.Size(80, 16);
            this.lblUpComname.TabIndex = 16;
            this.lblUpComname.Text = "商品名称:";
            // 
            // lblUpComid
            // 
            this.lblUpComid.AutoSize = true;
            this.lblUpComid.Location = new System.Drawing.Point(414, 59);
            this.lblUpComid.Name = "lblUpComid";
            this.lblUpComid.Size = new System.Drawing.Size(80, 16);
            this.lblUpComid.TabIndex = 15;
            this.lblUpComid.Text = "商品编号:";
            // 
            // lblUpComcat
            // 
            this.lblUpComcat.AutoSize = true;
            this.lblUpComcat.Location = new System.Drawing.Point(51, 59);
            this.lblUpComcat.Name = "lblUpComcat";
            this.lblUpComcat.Size = new System.Drawing.Size(80, 16);
            this.lblUpComcat.TabIndex = 14;
            this.lblUpComcat.Text = "商品类别:";
            // 
            // txtDeAmount
            // 
            this.txtDeAmount.Location = new System.Drawing.Point(529, 246);
            this.txtDeAmount.Name = "txtDeAmount";
            this.txtDeAmount.ReadOnly = true;
            this.txtDeAmount.Size = new System.Drawing.Size(191, 21);
            this.txtDeAmount.TabIndex = 22;
            // 
            // txtDeComprice
            // 
            this.txtDeComprice.Location = new System.Drawing.Point(529, 180);
            this.txtDeComprice.Name = "txtDeComprice";
            this.txtDeComprice.ReadOnly = true;
            this.txtDeComprice.Size = new System.Drawing.Size(191, 21);
            this.txtDeComprice.TabIndex = 21;
            // 
            // btnDeOk
            // 
            this.btnDeOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeOk.Location = new System.Drawing.Point(438, 366);
            this.btnDeOk.Name = "btnDeOk";
            this.btnDeOk.Size = new System.Drawing.Size(75, 23);
            this.btnDeOk.TabIndex = 24;
            this.btnDeOk.Text = "确 定";
            this.btnDeOk.UseVisualStyleBackColor = true;
            this.btnDeOk.Click += new System.EventHandler(this.btnDeOk_Click);
            // 
            // tpDeletecom
            // 
            this.tpDeletecom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpDeletecom.Controls.Add(this.picBoxDelete);
            this.tpDeletecom.Controls.Add(this.cboDeComcat);
            this.tpDeletecom.Controls.Add(this.btnDeCancle);
            this.tpDeletecom.Controls.Add(this.btnDeOk);
            this.tpDeletecom.Controls.Add(this.txtDeAmount);
            this.tpDeletecom.Controls.Add(this.txtDeComprice);
            this.tpDeletecom.Controls.Add(this.txtDeComName);
            this.tpDeletecom.Controls.Add(this.txtDeComID);
            this.tpDeletecom.Controls.Add(this.lblDeAmount);
            this.tpDeletecom.Controls.Add(this.lblDeComprice);
            this.tpDeletecom.Controls.Add(this.lblDeComname);
            this.tpDeletecom.Controls.Add(this.lblDeComID);
            this.tpDeletecom.Controls.Add(this.lblDecomcatid);
            this.tpDeletecom.Location = new System.Drawing.Point(4, 22);
            this.tpDeletecom.Name = "tpDeletecom";
            this.tpDeletecom.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeletecom.Size = new System.Drawing.Size(770, 444);
            this.tpDeletecom.TabIndex = 1;
            this.tpDeletecom.Text = "商品下架";
            // 
            // txtDeComName
            // 
            this.txtDeComName.Location = new System.Drawing.Point(529, 115);
            this.txtDeComName.Name = "txtDeComName";
            this.txtDeComName.ReadOnly = true;
            this.txtDeComName.Size = new System.Drawing.Size(191, 21);
            this.txtDeComName.TabIndex = 20;
            // 
            // txtDeComID
            // 
            this.txtDeComID.Location = new System.Drawing.Point(529, 56);
            this.txtDeComID.Name = "txtDeComID";
            this.txtDeComID.Size = new System.Drawing.Size(191, 21);
            this.txtDeComID.TabIndex = 19;
            this.txtDeComID.TextChanged += new System.EventHandler(this.txtDeComID_TextChanged);
            // 
            // lblDeAmount
            // 
            this.lblDeAmount.AutoSize = true;
            this.lblDeAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeAmount.Location = new System.Drawing.Point(414, 249);
            this.lblDeAmount.Name = "lblDeAmount";
            this.lblDeAmount.Size = new System.Drawing.Size(80, 16);
            this.lblDeAmount.TabIndex = 18;
            this.lblDeAmount.Text = "商品数量:";
            // 
            // lblDeComprice
            // 
            this.lblDeComprice.AutoSize = true;
            this.lblDeComprice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeComprice.Location = new System.Drawing.Point(414, 183);
            this.lblDeComprice.Name = "lblDeComprice";
            this.lblDeComprice.Size = new System.Drawing.Size(80, 16);
            this.lblDeComprice.TabIndex = 17;
            this.lblDeComprice.Text = "商品价格:";
            // 
            // lblDeComname
            // 
            this.lblDeComname.AutoSize = true;
            this.lblDeComname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeComname.Location = new System.Drawing.Point(414, 118);
            this.lblDeComname.Name = "lblDeComname";
            this.lblDeComname.Size = new System.Drawing.Size(80, 16);
            this.lblDeComname.TabIndex = 16;
            this.lblDeComname.Text = "商品名称:";
            // 
            // lblDeComID
            // 
            this.lblDeComID.AutoSize = true;
            this.lblDeComID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeComID.Location = new System.Drawing.Point(414, 59);
            this.lblDeComID.Name = "lblDeComID";
            this.lblDeComID.Size = new System.Drawing.Size(80, 16);
            this.lblDeComID.TabIndex = 15;
            this.lblDeComID.Text = "商品编号:";
            // 
            // lblDecomcatid
            // 
            this.lblDecomcatid.AutoSize = true;
            this.lblDecomcatid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDecomcatid.Location = new System.Drawing.Point(51, 59);
            this.lblDecomcatid.Name = "lblDecomcatid";
            this.lblDecomcatid.Size = new System.Drawing.Size(80, 16);
            this.lblDecomcatid.TabIndex = 14;
            this.lblDecomcatid.Text = "商品类别:";
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tpAdcom);
            this.TabPage.Controls.Add(this.tpDeletecom);
            this.TabPage.Controls.Add(this.tpUdatecom);
            this.TabPage.Location = new System.Drawing.Point(3, -4);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(778, 470);
            this.TabPage.TabIndex = 1;
            // 
            // tmrTL
            // 
            this.tmrTL.Enabled = true;
            this.tmrTL.Tick += new System.EventHandler(this.tmrTL_Tick);
            // 
            // FrmRunCommodity
            // 
            this.AcceptButton = this.btnAddOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnAddCancle;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.TabPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRunCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品管理！";
            this.Load += new System.EventHandler(this.FrmRunCommodity_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRunCommodity_FormClosing);
            this.LocationChanged += new System.EventHandler(this.FrmRunCommodity_LocationChanged);
            this.tpAdcom.ResumeLayout(false);
            this.tpAdcom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            this.tpUdatecom.ResumeLayout(false);
            this.tpUdatecom.PerformLayout();
            this.tpDeletecom.ResumeLayout(false);
            this.tpDeletecom.PerformLayout();
            this.TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAdcom;
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.ComboBox cboComcat;
        private System.Windows.Forms.Button btnAddCancle;
        private System.Windows.Forms.Button btnAddOk;
        private System.Windows.Forms.Button btnAddCopicture;
        private System.Windows.Forms.TextBox txtAddComamount;
        private System.Windows.Forms.TextBox txtAddComprice;
        private System.Windows.Forms.TextBox txtAddComname;
        private System.Windows.Forms.TextBox txtAddComid;
        private System.Windows.Forms.Label lblAddComamount;
        private System.Windows.Forms.Label lblAddComprice;
        private System.Windows.Forms.Label lblAddComname;
        private System.Windows.Forms.Label lblAddComid;
        private System.Windows.Forms.Label lblIncomcatid;
        private System.Windows.Forms.ComboBox cboUpComcat;
        private System.Windows.Forms.PictureBox picBoxDelete;
        private System.Windows.Forms.ComboBox cboDeComcat;
        private System.Windows.Forms.Button btnDeCancle;
        private System.Windows.Forms.PictureBox picBoxUpdate;
        private System.Windows.Forms.TabPage tpUdatecom;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpOk;
        private System.Windows.Forms.Button btnUppicture;
        private System.Windows.Forms.TextBox txtUpAmount;
        private System.Windows.Forms.TextBox txtUpComprice;
        private System.Windows.Forms.TextBox txtUpComname;
        private System.Windows.Forms.TextBox txtUpComid;
        private System.Windows.Forms.Label lblUpAmount;
        private System.Windows.Forms.Label lblUpComprice;
        private System.Windows.Forms.Label lblUpComname;
        private System.Windows.Forms.Label lblUpComid;
        private System.Windows.Forms.Label lblUpComcat;
        private System.Windows.Forms.TextBox txtDeAmount;
        private System.Windows.Forms.TextBox txtDeComprice;
        private System.Windows.Forms.Button btnDeOk;
        private System.Windows.Forms.TabPage tpDeletecom;
        private System.Windows.Forms.TextBox txtDeComName;
        private System.Windows.Forms.TextBox txtDeComID;
        private System.Windows.Forms.Label lblDeAmount;
        private System.Windows.Forms.Label lblDeComprice;
        private System.Windows.Forms.Label lblDeComname;
        private System.Windows.Forms.Label lblDeComID;
        private System.Windows.Forms.Label lblDecomcatid;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.Timer tmrTL;
    }
}