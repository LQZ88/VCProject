using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School
{
    public partial class FrmMaster : Form
    {
        SqlConnection con = Sqlhelper.getCon();
        SqlDataAdapter da = null;
        SqlCommandBuilder sb = null;
        DataSet ds = new DataSet();
        public FrmMaster()
        {
            InitializeComponent();
        }

        private void FrmMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMaster_Load(object sender, EventArgs e)
        {
            Sqlhelper.getValue("select S_grade from S_do", cbogreaddo);
            Sqlhelper.getValue("select S_grade from Student_grade", cbodogread);
            Sqlhelper.getValue("select S_Class from S_dos", cboclassdo);
            Sqlhelper.getValue("select T_Position from Teacher_cate", cboT_Position);
        }

        private void btnteachetIDUS_Click(object sender, EventArgs e)
        {
            string stm = "select T_ID 编号, T_Name 姓名,T_Pwd 密码,T_Sex 性别,T_Age 年龄,T_Address 地址,T_TelephoneNO 电话,T_Position 职位,T_Amount 教龄,T_other 其它 from Teacher";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(stm);
            }
            catch (Exception) { }
        }

        private void btnstudentIDUS_Click(object sender, EventArgs e)
        {
            string std = "select S_ID 学号,S_Name 姓名,S_Pwd 密码,S_grade 所在年级,S_Class 班级,S_Sex 性别,S_Age 年龄,S_Address 家庭住址,S_TelephoneNO 电话,S_other 其它 from Student";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(std);
            }
            catch (Exception) { }
        }

        private void btngreadIDUS_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string sad = "select S_IDD 节次, S_grade 年级,S_Class 班级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus";
            da = new SqlDataAdapter(sad, con);
            try
            {
                da.Fill(ds, "t1");
                dgvgreadcontent.DataSource = ds.Tables["t1"];
            }
            catch (Exception) { }
        }

        private void tdinsert_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                sb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["t1"]);
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                    MessageBox.Show("添加成功");
                else
                    MessageBox.Show("添加失败");
            }
        }

        private void tddelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            string deleter = "\n";
            for (int a = 0; a < this.dgvgreadcontent.Rows.Count; a++)
            {
                row = this.dgvgreadcontent.Rows[a];
                if (row.Selected)
                {
                    deleter = deleter + "delete from Syllabus where S_IDD='" + row.Cells[0].Value.ToString() + "'\n";
                }
            }
            DialogResult asd = MessageBox.Show("你确定要删除该列课表吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asd == DialogResult.Yes)
            {
                try
                {
                    Sqlhelper.delete(deleter);
                }
                catch (Exception) { }
                DialogResult ms = MessageBox.Show("你已成功删除一列课表", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (ms == DialogResult.OK)
                {
                    string sad = "select S_IDD 节次, S_grade 年级,S_Class 班级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus";
                    try
                    {
                        dgvgreadcontent.DataSource = Sqlhelper.select(sad);
                    }
                    catch (Exception) { }
                }
            }
        }

        private void txtT_ID_TextChanged(object sender, EventArgs e)
        {
            string mmsd = "select T_Name,T_Pwd,T_Sex,T_Age,T_Address,T_TelephoneNO,T_Position,T_Amount,T_other from Teacher where T_ID='" + txtT_ID.Text + "'";
            SqlConnection cn = Sqlhelper.getCon();
            SqlCommand cm = new SqlCommand(mmsd, cn);
            try
            {
                cn.Open();
                SqlDataReader sdm = cm.ExecuteReader();
                if (sdm.Read())
                {
                    txtT_Name.Text = sdm[0].ToString();
                    txtT_Pwd.Text = sdm[1].ToString();
                    string sex = sdm[2].ToString();
                    if (sex == sdm[2].ToString())
                        rdoman.Checked = true;
                    else
                        rdomen.Checked = true;
                    txtT_Age.Text = sdm[3].ToString();
                    txtT_Address.Text = sdm[4].ToString();
                    txtT_TelephoneNO.Text = sdm[5].ToString();
                    cboT_Position.Text = sdm[6].ToString();
                    txtT_Amount.Text = sdm[7].ToString();
                    txtT_other.Text = sdm[8].ToString();
                }
                sdm.Close();
            }
            catch (Exception) { }
            finally
            {
                cn.Close();
            }
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            string M = "";
            if (rdoman.Checked == true)
            {
                M += "男";
            }
            else
            {
                M += "女";
            }
            if (txtT_ID.Text == "")
            {
                MessageBox.Show("请输入教师编号！", "友情提示");
                txtT_ID.Focus();
                return;
            }
            if (txtT_Name.Text == "")
            {
                MessageBox.Show("请输入教师姓名！", "友情提示");
                txtT_Name.Focus();
                return;
            }
            if (txtT_Pwd.Text == "")
            {
                MessageBox.Show("请输入教师密码！", "友情提示");
                txtT_Pwd.Focus();
                return;
            }
            if (txtT_Age.Text == "")
            {
                MessageBox.Show("请输入教师年龄！", "友情提示");
                txtT_Age.Focus();
                return;
            }
            if (cboT_Position.Text == "")
            {
                MessageBox.Show("请选择教师职位！", "友情提示");
                cboT_Position.Focus();
                return;
            }
            if (txtT_Address.Text == "")
            {
                MessageBox.Show("请输入教师家庭住址！", "友情提示");
                txtT_Address.Focus();
                return;
            }
            if (txtT_TelephoneNO.Text == "")
            {
                MessageBox.Show("请输入教师电话！", "友情提示");
                txtT_TelephoneNO.Focus();
                return;
            }
            if (txtT_Amount.Text == "")
            {
                MessageBox.Show("请输入教师教龄！", "友情提示");
                txtT_Amount.Focus();
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("请核对信息，确定要添加？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool flag = false;
                    string stmd = "insert into Teacher(T_ID,T_Name,T_Pwd,T_Sex,T_Age,T_Address,T_TelephoneNO,T_Position,T_Amount,T_other) values('" + txtT_ID.Text + "','" + txtT_Name.Text + "','" + txtT_Pwd.Text + "','" + M + "','" + txtT_Age.Text + "','" + txtT_Address.Text + "','" + txtT_TelephoneNO.Text + "','" + cboT_Position.Text + "','" + txtT_Amount.Text + "','" + txtT_other.Text + "')";
                    try
                    {
                        Sqlhelper.insert(stmd);
                        flag = true;
                    }
                    catch (Exception)
                    {
                        flag = true;
                    }
                    finally
                    {
                        if (flag)
                        {
                            MessageBox.Show("你已成功添加！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtT_ID.Clear();
                            txtT_Name.Clear();
                            txtT_Pwd.Clear();
                            txtT_Age.Clear();
                            txtT_Address.Clear();
                            txtT_Amount.Clear();
                            txtT_TelephoneNO.Clear();
                            txtT_other.Clear();
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
        }

        private void btnupdata_Click_1(object sender, EventArgs e)
        {
            string M = "";
            if (rdoman.Checked == true)
            {
                M += "男";
            }
            else
            {
                M += "女";
            }
            if (txtT_ID.Text == "")
            {
                MessageBox.Show("请输入你要修改的教师编号！", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtT_ID.Focus();
                return;
            }
            else
            {
                bool flag = false;
                string updete = "update Teacher set T_Name='" + txtT_Name.Text + "', T_Pwd='" + txtT_Pwd.Text + "',T_Sex='" + M + "',T_Age='" + txtT_Age.Text + "',T_Address='" + txtT_Address.Text + "',T_TelephoneNO='" + txtT_TelephoneNO.Text + "',T_Position='" + cboT_Position.Text + "',T_Amount='" + txtT_Amount.Text + "',T_other='" + txtT_other.Text + "' where T_ID='" + txtT_ID.Text + "'";
                try
                {
                    Sqlhelper.update(updete);
                    flag = true;
                }
                catch (Exception)
                {
                    flag = true;
                }
                finally
                {
                    if (flag)
                    {
                        MessageBox.Show("修改成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtT_ID.Clear();
                        txtT_Name.Clear();
                        txtT_Pwd.Clear();
                        txtT_Age.Clear();
                        txtT_Address.Clear();
                        txtT_TelephoneNO.Clear();
                        txtT_Amount.Clear();
                        txtT_other.Clear();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnselectgread_Click(object sender, EventArgs e)
        {
            string selectgred = "select S_grade 年级 from Student_grade";
            try
            {
                dgvselectgread.DataSource = Sqlhelper.select(selectgred);
            }
            catch (Exception) { }
        }

        private void btngreadinsert_Click(object sender, EventArgs e)
        {
            if (txtgreadinsert.Text == "")
            {
                MessageBox.Show("请输入年级！", "温馨提示");
                txtgreadinsert.Focus();
                return;
            }
            string insert = "insert into Student_grade(S_grade)values('" + txtgreadinsert.Text + "')";
            try
            {
                Sqlhelper.insert(insert);
                if (MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtgreadinsert.Clear();
                    string selectgred = "select S_grade 年级 from Student_grade";
                    dgvselectgread.DataSource = Sqlhelper.select(selectgred);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btngreaddelete_Click(object sender, EventArgs e)
        {
            if (txtgreaddelete.Text == "")
            {
                MessageBox.Show("请输入要删除的年级", "温馨提示");
                txtgreaddelete.Focus();
                return;
            }
            string delet = "delete from Student_grade where S_grade='" + txtgreaddelete.Text + "'";
            try
            {
                MessageBox.Show("你确定要删除该年级", "友情提示");
                Sqlhelper.delete(delet);
                if (DialogResult.Yes == MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    txtgreaddelete.Clear();
                    string selectgred = "select S_grade 年级 from Student_grade";
                    dgvselectgread.DataSource = Sqlhelper.select(selectgred);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btnselectclass_Click(object sender, EventArgs e)
        {
            string selectgred = "select S_Class 班级 from Student_class";
            try
            {
                dgvselectclass.DataSource = Sqlhelper.select(selectgred);
            }
            catch (Exception) { }
        }

        private void btnclassinsert_Click(object sender, EventArgs e)
        {
            if (txtclassinsert.Text == "")
            {
                MessageBox.Show("请输入班级！", "温馨提示");
                txtclassinsert.Focus();
                return;
            }
            string insert = "insert into Student_class(S_Class)values('" + txtclassinsert.Text + "')";
            try
            {
                Sqlhelper.insert(insert);
            }
            catch (Exception) { }
            if (MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtclassinsert.Clear();
                string selectgred = "select S_Class 班级 from Student_class";
                try
                {
                    dgvselectclass.DataSource = Sqlhelper.select(selectgred);
                }
                catch (Exception) { }
            }
        }

        private void btnclassdelete_Click(object sender, EventArgs e)
        {
            if (txtclassdelete.Text == "")
            {
                MessageBox.Show("请输入要删除的班级", "温馨提示");
                txtclassdelete.Focus();
                return;
            }
            string delet = "delete from Student_class where S_Class='" + txtclassdelete.Text + "'";
            try
            {
                MessageBox.Show("你确定要删除该班级", "友情提示");
                Sqlhelper.delete(delet);
                if (DialogResult.Yes == MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                {
                    txtclassdelete.Clear();
                    string selectgred = "select S_Class 班级 from Student_class";
                    dgvselectclass.DataSource = Sqlhelper.select(selectgred);
                }
            }
            catch (Exception) { }
        }

        private void tsmiback_Click_1(object sender, EventArgs e)
        {
            FrmSchool s = new FrmSchool();
            s.Show();
            this.Hide();
        }

        private void tsmiclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string sele = "select S_DO FROM S_do";
            SqlConnection cn = Sqlhelper.getCon();
            SqlCommand cm = new SqlCommand(sele, cn);
            try
            {
                cn.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                if (sdr.Read())
                {
                    txtgreads.Text = sdr[0].ToString();
                }
                sdr.Close();
                cn.Close();
            }
            catch (Exception) { }
            string selet = "select S_DO FROM S_dos";
            SqlConnection con = Sqlhelper.getCon();
            SqlCommand com = new SqlCommand(selet, con);
            try
            {
                con.Open();
                SqlDataReader sd = com.ExecuteReader();
                if (sd.Read())
                {
                    txtclassdo.Text = sd[0].ToString();
                }
                sd.Close();
                con.Close();
            }
            catch (Exception) { }
            string selea = "select T_DO FROM T_do";
            SqlConnection can = Sqlhelper.getCon();
            SqlCommand cam = new SqlCommand(selea, can);
            try
            {
                can.Open();
                SqlDataReader sdra = cam.ExecuteReader();
                if (sdra.Read())
                {
                    txtteacherdo.Text = sdra[0].ToString();
                }
                sdra.Close();
                can.Close();
            }
            catch (Exception) { }
        }

        private void btnselectdo_Click(object sender, EventArgs e)
        {
            string selec = "select S_grade,S_DO from S_do where S_grade='" + cbogreaddo.Text + "'";
            SqlConnection cn = Sqlhelper.getCon();
            SqlCommand cm = new SqlCommand(selec, cn);
            try
            {
                cn.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                if (sdr.Read())
                {
                    txtdo.Text = sdr[1].ToString();
                }
                sdr.Close();
                cn.Close();
            }
            catch (Exception) { }
        }

        private void btnselectds_Click(object sender, EventArgs e)
        {
            string selec = "select S_Class,S_do from S_dos where S_Class='" + cboclassdo.Text + "'";
            SqlConnection cn = Sqlhelper.getCon();
            SqlCommand cm = new SqlCommand(selec, cn);
            try
            {
                cn.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                if (sdr.Read())
                {
                    txtdo.Text = sdr[1].ToString();
                }
                sdr.Close();
                cn.Close();
            }
            catch (Exception) { }
        }

        private void btninsertdo_Click(object sender, EventArgs e)
        {
            if (cbodogread.Text == "")
            {
                MessageBox.Show("请选择发布年级", "温馨提示");
                cbodogread.Focus();
                return;
            }
            if (txtteachergreaddos.Text == "")
            {
                MessageBox.Show("请输入要发布的信息", "温馨提示");
                txtteachergreaddos.Focus();
                return;
            }
            string insert = "insert into S_do(S_grade,S_DO)values('" + cbodogread.Text + "','" + txtteachergreaddos.Text + "') ";
            try
            {
                Sqlhelper.insert(insert);
            }
            catch (Exception) { }
            MessageBox.Show("发布成功", "友情提示");
            cbodogread.Items.Clear();
            txtteachergreaddos.Clear();
            cbogreaddo.Items.Clear();
            cbodogread.Items.Clear();
            cboclassdo.Items.Clear();
            cboT_Position.Items.Clear();
            FrmMaster_Load(sender, e);
        }

        private void btndodelete_Click(object sender, EventArgs e)
        {
            if (cbodogread.Text == "")
            {
                MessageBox.Show("请选择删除年级", "温馨提示");
                cbodogread.Focus();
                return;
            }
            string inserts = "delete from S_do where S_grade='" + cbodogread.Text + "'";
            try
            {
                Sqlhelper.delete(inserts);
            }
            catch (Exception) { }
            MessageBox.Show("删除成功", "友情提示");
            cbodogread.Items.Clear();
            txtteachergreaddos.Clear();
            cbogreaddo.Items.Clear();
            cbodogread.Items.Clear();
            cboclassdo.Items.Clear();
            cboT_Position.Items.Clear();
            FrmMaster_Load(sender, e);
        }

        private void btnteacherdo_Click(object sender, EventArgs e)
        {
            string inset = "insert into T_do(T_DO)values('" + txtteachergreaddos.Text + "')";
            try
            {
                Sqlhelper.insert(inset);
            }
            catch (Exception) { }
            MessageBox.Show("发布成功", "友情提示");
            txtteachergreaddos.Clear();
            cbodogread.Items.Clear();
            cbogreaddo.Items.Clear();
            cbodogread.Items.Clear();
            cboclassdo.Items.Clear();
            cboT_Position.Items.Clear();
            FrmMaster_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除教师动态吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "truncate table T_DO";
                try
                {
                    Sqlhelper.delete(delete);
                }
                catch (Exception) { }
                MessageBox.Show("删除成功","温馨提示");
            }
            }
    }
}