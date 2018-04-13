using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace School
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       private void tsmiback_Click(object sender, EventArgs e)
        {
            FrmSchool c = new FrmSchool();
            c.Show();
            this.Hide();
        }
       private void tsmiclose_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("确定要退出吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
               Application.Exit();
       }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎登录学生界面┅┅┅┅");
            Sqlhelper.getValue("select T_Name from Teacher",cboteachers);
            Sqlhelper.getValue("select S_Class from Student_class", cboclassreport);
            Sqlhelper.getValue("select S_Class from Student_class", cboclassgread);
            Sqlhelper.getValue("select S_Name from Student", cbostudents);
            Sqlhelper.getValue("select S_Class from S_dos", cboclassdo);
            Sqlhelper.getValue("select S_grade from Student_grade", cbogreadreport);
            Sqlhelper.getValue("select S_grade from Student_grade",cbogreadgread);
            Sqlhelper.getValue("select S_grade from S_do", cbogreaddo);         
        }

        private void btngreadreport_Click(object sender, EventArgs e)
        {
            if (cbogreadreport.Text == "")
            {
                MessageBox.Show("年级不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbogreadreport.Focus();
                return;
            }
            string strm = "select S_ID 学号,S_Name 姓名,S_grade 年级, S_Chinese 语文,S_Math 数学,S_English 英语,S_Geography 地理,S_Political 政治,S_History 历史,S_Physics 物理,S_Chemistry 化学,S_Biology 生物,S_Science 科学,S_P_E 体育,S_IT 计算机,S_Economics 艺术,S_Music 音乐,S_Chinese+S_Math+S_English+S_Geography+S_Political+S_History+S_Physics+S_Chemistry+S_Biology+S_Science+S_P_E+S_IT+S_Economics+S_Music as 总分 from Stugrades where S_grade='" + cbogreadreport.Text + "'ORDER BY 总分 DESC";
            try
            {
                dgvCGreport.DataSource = Sqlhelper.select(strm);
            }
            catch (Exception) { }
        }

        private void btnclassreport_Click(object sender, EventArgs e)
        {
            if (cboclassreport.Text == "")
            {
                MessageBox.Show("班级不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboclassreport.Focus();
                return;
            }
            string strm = "select S_ID 学号,S_Name 姓名,S_Class 班级,S_Chinese 语文,S_Math 数学,S_English 英语,S_Geography 地理,S_Political 政治,S_History 历史,S_Physics 物理,S_Chemistry 化学,S_Biology 生物,S_Science 科学,S_P_E 体育,S_IT 计算机,S_Economics 艺术,S_Music 音乐,S_Chinese+S_Math+S_English+S_Geography+S_Political+S_History+S_Physics+S_Chemistry+S_Biology+S_Science+S_P_E+S_IT+S_Economics+S_Music as 总分 from Stugrades where S_Class='" + cboclassreport.Text + "'ORDER BY 总分 DESC";
            try
            {
                dgvCGreport.DataSource = Sqlhelper.select(strm);
            }
            catch (Exception) { }
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            if (cboteachers.Text == "")
            {
                MessageBox.Show("教师姓名不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboteachers.Focus();
                return;
            }
            string strb = "select T_Name 姓名,T_Sex 性别,T_Age 年龄,T_Address 家庭地址,T_TelephoneNO 电话,T_Position 职位,T_Amount 教龄,T_other 其它 from Teacher where T_Name='" + cboteachers.Text + "'";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(strb);
            }
            catch (Exception) { }
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            if (cbostudents.Text == "")
            {
                MessageBox.Show("学生姓名不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbostudents.Focus();
                return;
            }
            string strb = "select S_ID 学号,S_Name 姓名,S_grade 所在年级,S_Class 班级,S_Sex 性别,S_Age 年龄,S_Address 家庭住址,S_TelephoneNO 电话,S_other 其它 from Student where S_Name='" + cbostudents.Text + "'";
            try
            {
                dgvTScontent.DataSource = Sqlhelper.select(strb);
            }
            catch (Exception) { }
        }

        private void btngreadgread_Click(object sender, EventArgs e)
        {
            if (cbogreadgread.Text == "")
            {
                MessageBox.Show("年级不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbogreadgread.Focus();
                return;
            }
            string strp = "select S_IDD 节次, S_grade 年级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus where S_grade='" + cbogreadgread.Text + "'";
            try
            {
                dgvGCcontent.DataSource = Sqlhelper.select(strp);
            }
            catch (Exception) { }
        }

        private void btnclassgread_Click(object sender, EventArgs e)
        {
            if (cboclassgread.Text == "")
            {
                MessageBox.Show("班级不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cboclassgread.Focus();
                return;
            }
            string strd = "select S_IDD 节次,S_class 班级, S_monday 星期一, S_tuesday 星期二,S_wednesday 星期三,S_thursday 星期四,S_friday 星期五,S_saturday 星期六,S_sunday 星期日 from Syllabus where S_class='" + cboclassgread.Text + "'";
            try
            {
                dgvGCcontent.DataSource = Sqlhelper.select(strd);
            }
            catch (Exception) { }
        }

        private void btngreaddo_Click(object sender, EventArgs e)
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

        private void btnclassdo_Click(object sender, EventArgs e)
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
    }
}