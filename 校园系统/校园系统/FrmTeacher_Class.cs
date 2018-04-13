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
    public partial class FrmTeacher_Class : Form
    {
        public FrmTeacher_Class()
        {
            InitializeComponent();
        }

        private void FrmTeacher_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTeacher_Class_Load(object sender, EventArgs e)
        {
            Sqlhelper.getValue("select S_Class from Student_class ", cboS_Class);
            try
            {
                cboS_Class.SelectedIndex = 0;
            }
            catch (Exception) { }
            Sqlhelper.getValue("select S_Class from Student_class ", cboclassgread);
            Sqlhelper.getValue("select S_Class from Student_class", cbossclass);
            Sqlhelper.getValue("select S_Class from S_dos", cboclassdo);
            Sqlhelper.getValue("select S_Class from Student_class", cbodoclass);
            Sqlhelper.getValue("select S_grade from Student_grade", cboS_grade);
            try
            {
                cboS_grade.SelectedIndex = 0;
            }
            catch (Exception) { }
            Sqlhelper.getValue("select S_grade from Student_grade", cbogreadgread);
            Sqlhelper.getValue("select S_grade from S_do", cbogreaddo);        
            Sqlhelper.getValue("select T_Name from Teacher", cboteachercontent);            
            Sqlhelper.getValue("select S_Name from Student", cboS_Name);
        }

        private void btnselectgread_Click(object sender, EventArgs e)
        {
            if (cbossclass.Text == "")
            {
                MessageBox.Show("请选择年级","温馨提示");
                cbossclass.Focus();
                return;
            }
            string sql = "select S_ID 学号,S_Name 姓名,S_Class 班级, S_Chinese 语文,S_Math 数学,S_English 英语,S_Geography 地理,S_Political 政治,S_History 历史,S_Physics 物理,S_Chemistry 化学,S_Biology 生物,S_Science 科学,S_P_E 体育,S_IT 信息技术,S_Economics 经济学,S_Music 音乐,S_Chinese+S_Math+S_English+S_Geography+S_Political+S_History+S_Physics+S_Chemistry+S_Biology+S_Science+S_P_E+S_IT+S_Economics+S_Music as 总分 from Stugrades where S_Class='" + cbossclass.Text + "' ORDER BY 总分 DESC";
            try
            {
                dgvScontent.DataSource = Sqlhelper.select(sql);
            }
            catch (Exception) { }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请填写学生学号！", "☆温馨提示★");
                txtS_ID.Focus();
                return;
            }
            if (txtS_Name.Text == "")
            {
                MessageBox.Show("请填写学生姓名！", "☆温馨提示★");
                txtS_Name.Focus();
                return;
            }
            if (txtS_Pwd.Text == "")
            {
                MessageBox.Show("请填写学生密码！", "☆温馨提示★");
                txtS_Pwd.Focus();
                return;
            }
            if (cboS_grade.Text == "")
            {
                MessageBox.Show("请选择学生年级！", "☆温馨提示★");
                cboS_grade.Focus();
                return;
            }
            if (cboS_Class.Text == "")
            {
                MessageBox.Show("请选择学生班级！", "☆温馨提示★");
                cboS_Class.Focus();
                return;
            }
            if (txtS_Sex.Text == "")
            {
                MessageBox.Show("请填写学生性别！", "☆温馨提示★");
                txtS_Sex.Focus();
                return;
            }
            if (txtS_Age.Text == "")
            {
                MessageBox.Show("请填写学生年龄！", "☆温馨提示★");
                txtS_Age.Focus();
                return;
            }
            if (txtS_Address.Text == "")
            {
                MessageBox.Show("请填写学生家庭地址！", "☆温馨提示★");
                txtS_Address.Focus();
                return;
            }
            if (txtS_TelephoneNO.Text == "")
            {
                MessageBox.Show("请填写学生联系电话！", "☆温馨提示★");
                txtS_TelephoneNO.Focus();
                return;
            }
            else
            {
                string stdm = "insert into Student( S_ID,S_Name,S_Pwd,S_grade,S_Class,S_Sex,S_Age,S_Address,S_TelephoneNO,S_other) values('" + txtS_ID.Text + "','" + txtS_Name.Text + "','" + txtS_Pwd.Text + "','" + cboS_grade.Text + "','" + cboS_Class.Text + "','" + txtS_Sex.Text + "','" + txtS_Age.Text + "','" + txtS_Address.Text + "','" + txtS_TelephoneNO.Text + "','" + txtS_other.Text + "')";
                string stds = "insert into Stugrades(S_ID,S_Name,S_grade,S_Class)values('" + txtS_ID.Text + "','" + txtS_Name.Text + "','" + cboS_grade.Text + "','" + cboS_Class.Text + "')";
                    try
                    {
                        if (MessageBox.Show("请确认要学生的信息.", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Sqlhelper.insert(stdm);
                        Sqlhelper.insert(stds);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("添加失败请重新添加", "☆温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtS_ID.Clear();
                        txtS_Name.Clear();
                        txtS_Pwd.Clear();
                        txtS_Sex.Clear();
                        txtS_Age.Clear();
                        txtS_Address.Clear();
                        txtS_TelephoneNO.Clear();
                        txtS_other.Clear();
                        txtS_ID.Focus();
                    }
                    finally
                    {
                        MessageBox.Show("你已成功添加学生信息", "☆温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                txtS_ID.Clear();
                txtS_Name.Clear();
                txtS_Pwd.Clear();
                txtS_Sex.Clear();
                txtS_Age.Clear();
                txtS_Address.Clear();
                txtS_TelephoneNO.Clear();
                txtS_other.Clear();
            }
            cboS_Name.Items.Clear();
            cboS_Class.Items.Clear();
            cbossclass.Items.Clear();
            cboS_grade.Items.Clear();
            cbogreaddo.Items.Clear();
            cbogreadgread.Items.Clear();
            cboclassgread.Items.Clear();
            cboteachercontent.Items.Clear();
            cboclassdo.Items.Clear(); 
            cbogreaddo.Items.Clear();
            FrmTeacher_Class_Load(sender, e);
        }

        private void btnupdata_Click_1(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请输入要修改的学生学号！", "☆温馨提示", MessageBoxButtons.OK);
                txtS_ID.Focus();
                return;
            }
            else
            {
                string strsql = "update Student SET S_Name='" + txtS_Name.Text + "',S_Pwd='" + txtS_Pwd.Text + "',S_grade='" + cbogreadgread.Text + "',S_Class='" + cboclassgread.Text + "',S_Sex='" + txtS_Sex.Text + "',S_Age='" + txtS_Age.Text + "',S_Address='" + txtS_Address.Text + "',S_TelephoneNO='" + txtS_TelephoneNO.Text + "',S_other='" + txtS_other.Text + "' where S_ID='" + txtS_ID.Text + "'";
                string strsm = "update Stugrades set S_Name='" + txtS_Name.Text + "',S_grade='" + cbogreadgread.Text + "',S_Class='" + cboclassgread.Text + "' where S_ID='" + txtS_ID.Text + "'";
                try
                {
                    if (MessageBox.Show("你确定要修改该学生信息吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Sqlhelper.update(strsql);
                    Sqlhelper.update(strsm);
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtS_ID.Focus();
                }
                finally
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtS_ID.Clear();
                    txtS_Name.Clear();
                    txtS_Pwd.Clear();
                    txtS_Sex.Clear();
                    txtS_Age.Clear();
                    txtS_Address.Clear();
                    txtS_TelephoneNO.Clear();
                    txtS_other.Clear();
                }
                cboS_Name.Items.Clear();
                cboS_Class.Items.Clear();
                cbossclass.Items.Clear();
                cboS_grade.Items.Clear();
                cbogreaddo.Items.Clear();
                cbogreadgread.Items.Clear();
                cboclassgread.Items.Clear();
                cboclassdo.Items.Clear();
                cbogreaddo.Items.Clear();
                cboteachercontent.Items.Clear();
                FrmTeacher_Class_Load(sender, e);
            }
        }


        private void btndelet_Click(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请输入要删除的学生学号！", "☆温馨提示", MessageBoxButtons.OK);
                txtS_ID.Focus();
                return;
            }
            else
            {
                string sdm = "delete from Student where S_ID='" + txtS_ID.Text + "'";
                string sdms = "delete from Stugrades where S_ID='" + txtS_ID.Text + "'";
                try
                {
                    if (MessageBox.Show("你确定要删除该学生\n的所有信息吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Sqlhelper.delete(sdm);
                        Sqlhelper.delete(sdms);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("删除错误", "☆温馨提示★", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtS_ID.Focus();
                }
                finally
                {
                    MessageBox.Show("你已成功删除该学生信息", "☆温馨提示★", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                txtS_ID.Clear();
                txtS_Name.Clear();
                txtS_Pwd.Clear();
                txtS_Sex.Clear();
                txtS_Age.Clear();
                txtS_Address.Clear();
                txtS_TelephoneNO.Clear();
                txtS_other.Clear();
            }
            cboS_Name.Items.Clear();
            cboS_Class.Items.Clear();
            cbossclass.Items.Clear();
            cboS_grade.Items.Clear();
            cbogreaddo.Items.Clear();
            cbogreadgread.Items.Clear();
            cboclassgread.Items.Clear();
            cboclassdo.Items.Clear();
            cbogreaddo.Items.Clear();
            cboteachercontent.Items.Clear();
            FrmTeacher_Class_Load(sender, e);
        }
        private void txtS_ID_TextChanged(object sender, EventArgs e)
        {
            string sm = "select S_Name,S_Pwd,S_grade,S_Class,S_Sex,S_Age,S_Address,S_TelephoneNO,S_other from Student where S_ID='" + txtS_ID.Text + "'";
            SqlConnection cn = Sqlhelper.getCon();
            SqlCommand cm = new SqlCommand(sm, cn);
            try
            {
                cn.Open();
                SqlDataReader sd = cm.ExecuteReader();
                if (sd.Read())
                {
                    txtS_Name.Text = sd[0].ToString();
                    txtS_Pwd.Text = sd[1].ToString();
                    cbogreadgread.Text= sd[2].ToString();
                    cboclassgread.Text = sd[3].ToString();
                    txtS_Sex.Text = sd[4].ToString();
                    txtS_Age.Text = sd[5].ToString();
                    txtS_Address.Text = sd[6].ToString();
                    txtS_TelephoneNO.Text = sd[7].ToString();
                    txtS_other.Text = sd[8].ToString();
                }
                sd.Close();
            }
            catch (Exception) { }
            finally
            {
                cn.Close();
            }
        }

        private void tmsiclos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmsiback_Click(object sender, EventArgs e)
        {
            FrmSchool d = new FrmSchool();
            d.Show();
            this.Hide();
        }

        private void btnstudentInsert_Click(object sender, EventArgs e)
        {
            FrmStugrades d = new FrmStugrades();
            d.Show();
            this.Hide();
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

        private void btngreaddo_MouseClick(object sender, MouseEventArgs e)
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

        private void btnclassdo_MouseDown(object sender, MouseEventArgs e)
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
            if (cbodoclass.Text == "")
            {
                MessageBox.Show("请选择班级", "温馨提示");
                cbodoclass.Focus();
                return;
            }
            if (txtclassdos.Text == "")
            {
                MessageBox.Show("请输入要发布的信息","温馨提示");
                txtclassdos.Focus();
                return;
            }
            string inserts = "insert into S_dos(S_Class,S_DO) values('" + cbodoclass.Text + "','" + txtclassdos.Text + "')";
            try
            {
                Sqlhelper.insert(inserts);
            }
            catch (Exception)
            {
                MessageBox.Show("发表失败", "温馨提示");
                return;
            }
            finally 
            {
                MessageBox.Show("发表成功","友情提示");
                txtclassdos.Clear();
                cboS_Name.Items.Clear();
                cboS_Class.Items.Clear();
                cbossclass.Items.Clear();
                cboS_grade.Items.Clear();
                cbogreaddo.Items.Clear();
                cbogreadgread.Items.Clear();
                cboclassgread.Items.Clear();
                cboclassdo.Items.Clear();
                cbogreaddo.Items.Clear();
                cboteachercontent.Items.Clear();
                FrmTeacher_Class_Load(sender, e);
            }
        }

        private void btndodelete_Click(object sender, EventArgs e)
        {
            if (cbodoclass.Text == "")
            {
                MessageBox.Show("请选择删除班级", "温馨提示");
                cbodoclass.Focus();
                return;
            }
            string inserts = "delete from S_dos where S_Class='" + cbodoclass.Text + "'";
            try
            {
                Sqlhelper.delete(inserts);
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败", "温馨提示");
                return;
            }
            finally
            {
                MessageBox.Show("删除成功", "友情提示");
            }
        }

        private void btncboS_Name_Click(object sender, EventArgs e)
        {
            if (cboS_Name.Text == "")
            {
                MessageBox.Show("请选择学生姓名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboS_Name.Focus();
                return;
            }
            string str = "select S_ID 学号,S_Name 姓名,S_Pwd 密码,S_grade 所在年级,S_Class 班级,S_Sex 性别,S_Age 年龄,S_Address 家庭住址,S_TelephoneNO 电话,S_other 其它 from Student where S_Name='" + cboS_Name.Text + "'";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(str);
            }
            catch (Exception) { }
        }

        private void btnteachercontent_Click(object sender, EventArgs e)
        {
            if (cboteachercontent.Text == "")
            {
                MessageBox.Show("请选择教师姓名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboteachercontent.Focus();
                return;
            }
            string strm = "select T_Name 姓名,T_Sex 性别,T_Age 年龄,T_Address 家庭地址,T_TelephoneNO 电话,T_Position 职位,T_Amount 教龄,T_other 其它 from Teacher where T_Name='" + cboteachercontent.Text + "'";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(strm);
            }
            catch (Exception) { }
        }

        private void btngreadgread_Click(object sender, EventArgs e)
        {
            if (cbogreadgread.Text == "")
            {
                MessageBox.Show("请选择年级", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbogreadgread.Focus();
                return;
            }
            string strd = "select S_IDD 节次, S_grade 年级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus where S_grade='" + cbogreadgread.Text + "'";
            try
            {
                dgvgreadcontent.DataSource = Sqlhelper.select(strd);
            }
            catch (Exception) { }
        }

        private void btnclassgread_Click(object sender, EventArgs e)
        {
            if (cboclassgread.Text == "")
            {
                MessageBox.Show("请选择班级", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboclassgread.Focus();
                return;
            }
            string strb = "select S_IDD 节次,S_class 班级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus where S_class='" + cboclassgread.Text + "'";
            try
            {
                dgvgreadcontent.DataSource = Sqlhelper.select(strb);
            }
            catch (Exception) { }
        }
    }
}
