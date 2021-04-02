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
    public partial class 회원가입 : Form
    {
        bool re=false;
        public 회원가입()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oracleCommand1.CommandText = "insert into Member values(:aa, :bb, :cc, :dd, :ee, :ff, :gg)";
            oracleCommand1.Parameters["aa"].Value = textBox1.Text;      //id
            oracleCommand1.Parameters["bb"].Value = textBox2.Text;      //pw
            oracleCommand1.Parameters["cc"].Value = textBox3.Text;      //name
            oracleCommand1.Parameters["dd"].Value = textBox4.Text;      //phone
            oracleCommand1.Parameters["ee"].Value = textBox5.Text;      //email
            oracleCommand1.Parameters["ff"].Value = "0";                //latefee
            oracleCommand1.Parameters["gg"].Value = 0;                  //grade
            
            if (re == true)
            {
                try
                {
                    oracleConnection1.Open();
                    oracleCommand1.ExecuteNonQuery();
                    MessageBox.Show("회원가입 완료!");
                    oracleConnection1.Close();
                    this.Close();
                }
                catch (SystemException)
                {
                    MessageBox.Show("항목을 다 기입해주세요.");
                }
            }
            else
                MessageBox.Show("아이디 중복체크 해주세요");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = null;
            oracleConnection1.Open();
            oracleCommand2.CommandText = "select m_id from Member where m_id = " + "'" + textBox1.Text + "'";
            try
            {
                str = oracleCommand2.ExecuteScalar().ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("사용가능합니다.");
                re = true;
            }
            if (str != null)
            {
                MessageBox.Show("중복아이디 입니다.");
            }
            oracleConnection1.Close();
        }
    }
}
