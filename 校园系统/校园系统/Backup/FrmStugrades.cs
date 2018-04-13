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
    public partial class FrmStugrades : Form
    {
        public FrmStugrades()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmTeacher_Class d = new FrmTeacher_Class();
            d.Show();
            this.Hide();
        }

        private void FrmStugrades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtS_ID_TextChanged(object sender, EventArgs e)
        {
            string selet = " select S_Name,S_grade,S_Class,S_Chinese,S_Math,S_English,S_Geography,S_Political,S_History,S_Physics,S_Chemistry,S_Biology,S_Science,S_P_E,S_IT,S_Economics,S_Music from Stugrades where S_ID='" + txtS_ID.Text + "'";
            SqlConnection cs = Sqlhelper.getCon();
            SqlCommand sm = new SqlCommand(selet, cs);
            try
            {
                cs.Open();
                SqlDataReader sd = sm.ExecuteReader();
                if (sd.Read())
                {
                    txtS_Name.Text = sd[0].ToString();
                    txtS_grade.Text = sd[1].ToString();
                    txtS_Class.Text = sd[2].ToString();
                    txtS_Chinese.Text = sd[3].ToString();
                    txtS_Math.Text = sd[4].ToString();
                    txtS_English.Text = sd[5].ToString();
                    txtS_Geography.Text = sd[6].ToString();
                    txtS_Political.Text = sd[7].ToString();
                    txtS_History.Text = sd[8].ToString();
                    txtS_Physics.Text = sd[9].ToString();
                    txtS_Chemistry.Text = sd[10].ToString();
                    txtS_Biology.Text = sd[11].ToString();
                    txtS_Science.Text = sd[12].ToString();
                    txtS_P_E.Text = sd[13].ToString();
                    txtS_IT.Text = sd[14].ToString();
                    txtS_Economics.Text = sd[15].ToString();
                    txtS_Music.Text = sd[16].ToString();
                }
                sd.Close();
                cs.Close();
            }
            catch (Exception) { }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请输入学号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_ID.Focus();
                return;
            }
            string gotost = "update Stugrades set S_Chinese='" + txtS_Chinese.Text + "',S_Math='" + txtS_Math.Text + "',S_English='" + txtS_English.Text + "',S_Geography='" + txtS_Geography.Text + "',S_Political='" + txtS_Political.Text + "',S_History='" + txtS_History.Text + "',S_Physics='" + txtS_Physics.Text + "',S_Chemistry='" + txtS_Chemistry.Text + "',S_Biology='" + txtS_Biology.Text + "',S_Science='" + txtS_Science.Text + "',S_P_E='" + txtS_P_E.Text + "',S_IT='" + txtS_IT.Text + "',S_Economics='" + txtS_Economics.Text + "',S_Music='" + txtS_Music.Text + "' where S_ID='" + txtS_ID.Text + "'";
            try
            {
                Sqlhelper.update(gotost);
            }
            catch (Exception)
            {
                MessageBox.Show("发布失败", "温馨提示");
                txtS_Name.Clear();
                txtS_grade.Clear();
                txtS_Class.Clear();
                txtS_Chinese.Clear();
                txtS_Math.Clear();
                txtS_English.Clear();
                txtS_Geography.Clear();
                txtS_Political.Clear();
                txtS_History.Clear();
                txtS_Physics.Clear();
                txtS_Chemistry.Clear();
                txtS_Biology.Clear();
                txtS_Science.Clear();
                txtS_P_E.Clear();
                txtS_IT.Clear();
                txtS_Economics.Clear();
                txtS_Music.Clear();
                txtS_ID.Clear();
                txtS_ID.Focus();

            }
            MessageBox.Show("发布成功", "温馨提示");
            txtS_Name.Clear();
            txtS_grade.Clear();
            txtS_Class.Clear();
            txtS_Chinese.Clear();
            txtS_Math.Clear();
            txtS_English.Clear();
            txtS_Geography.Clear();
            txtS_Political.Clear();
            txtS_History.Clear();
            txtS_Physics.Clear();
            txtS_Chemistry.Clear();
            txtS_Biology.Clear();
            txtS_Science.Clear();
            txtS_P_E.Clear();
            txtS_IT.Clear();
            txtS_Economics.Clear();
            txtS_Music.Clear();
            txtS_ID.Clear();
            txtS_ID.Focus();
        }

        private void btnupdete_Click(object sender, EventArgs e)
        {
            if (txtS_ID.Text == "")
            {
                MessageBox.Show("请输入学号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtS_ID.Focus();
                return;
            }
            string gotost = "update Stugrades set S_Chinese='" + txtS_Chinese.Text + "',S_Math='" + txtS_Math.Text + "',S_English='" + txtS_English.Text + "',S_Geography='" + txtS_Geography.Text + "',S_Political='" + txtS_Political.Text + "',S_History='" + txtS_History.Text + "',S_Physics='" + txtS_Physics.Text + "',S_Chemistry='" + txtS_Chemistry.Text + "',S_Biology='" + txtS_Biology.Text + "',S_Science='" + txtS_Science.Text + "',S_P_E='" + txtS_P_E.Text + "',S_IT='" + txtS_IT.Text + "',S_Economics='" + txtS_Economics.Text + "',S_Music='" + txtS_Music.Text + "' where S_ID='" + txtS_ID.Text + "'";
            try
            {
                Sqlhelper.update(gotost);
            }
            catch (Exception)
            {
                MessageBox.Show("修改失败", "温馨提示");
                txtS_Name.Clear();
                txtS_grade.Clear();
                txtS_Class.Clear();
                txtS_Chinese.Clear();
                txtS_Math.Clear();
                txtS_English.Clear();
                txtS_Geography.Clear();
                txtS_Political.Clear();
                txtS_History.Clear();
                txtS_Physics.Clear();
                txtS_Chemistry.Clear();
                txtS_Biology.Clear();
                txtS_Science.Clear();
                txtS_P_E.Clear();
                txtS_IT.Clear();
                txtS_Economics.Clear();
                txtS_Music.Clear();
                txtS_ID.Clear();
                txtS_ID.Focus();

            }
            MessageBox.Show("修改成功", "温馨提示");
            txtS_Name.Clear();
            txtS_grade.Clear();
            txtS_Class.Clear();
            txtS_Chinese.Clear();
            txtS_Math.Clear();
            txtS_English.Clear();
            txtS_Geography.Clear();
            txtS_Political.Clear();
            txtS_History.Clear();
            txtS_Physics.Clear();
            txtS_Chemistry.Clear();
            txtS_Biology.Clear();
            txtS_Science.Clear();
            txtS_P_E.Clear();
            txtS_IT.Clear();
            txtS_Economics.Clear();
            txtS_Music.Clear();
            txtS_ID.Clear();
            txtS_ID.Focus();
        }
    }
}
