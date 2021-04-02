using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class 로그인 : Form
    {
        public static string ID;
        public 로그인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID = null;
            string PW = null;
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select m_id from Member where m_id = " + "'" + textBox1.Text + "'";
            try
            {
                ID = oracleCommand1.ExecuteScalar().ToString();
                oracleCommand2.CommandText = "select m_password from (select * from Member where m_id = "+"'"+ID+"'"+") where m_password = " + "'" + textBox2.Text + "'";
                PW = oracleCommand2.ExecuteScalar().ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("아이디가 없거나 비밀번호가 틀렸습니다.");
            }
            if ((ID != null) && (PW != null))
            {
                this.Hide();
                this.Close();
                Form form = new 회원();
                form.ShowDialog();

            }
            oracleConnection1.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new 회원가입();
            form.ShowDialog();
        }
    }
}
