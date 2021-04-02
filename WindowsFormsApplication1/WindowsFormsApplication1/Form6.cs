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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select m_password from Member where m_id = employee";

            if (oracleCommand1.ExecuteScalar().ToString() == textBox1.Text)
            {
                Form form = new Form7();
                form.ShowDialog();
            }
            else
                MessageBox.Show("비밀번호가 틀렸습니다.");
                
                            
            

        }
    }
}
