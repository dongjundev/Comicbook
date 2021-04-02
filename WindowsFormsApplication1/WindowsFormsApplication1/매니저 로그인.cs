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
    public partial class 매니저_로그인 : Form
    {
        public 매니저_로그인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select m_password from Member where m_id = 'manager' AND m_grade = " + 2;

            if (oracleCommand1.ExecuteScalar().ToString() == textBox1.Text)
            {
                this.Close();
                this.Hide();
                Form form = new 매니저();
                form.ShowDialog();

            }
            else
                MessageBox.Show("비밀번호가 틀렸습니다.");
            oracleConnection1.Close();
        }
    }
}
