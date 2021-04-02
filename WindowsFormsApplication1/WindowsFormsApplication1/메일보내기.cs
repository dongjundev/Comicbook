using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Net.Mail;
//using System.Net;

namespace WindowsFormsApplication1
{
    public partial class 메일보내기 : Form
    {
        Mail mail = new Mail("yh02195@gmail.com");
        public 메일보내기()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toAddress = this.textBox1.Text;
            string subject = this.textBox2.Text;
            string body = this.textBox3.Text;
            if (toAddress == "")
            {
                MessageBox.Show("받을 메일을 입력해 주세요.");
            }
            if (subject == "")
            {
                MessageBox.Show("메일 제목을 입력해 주세요.");
            }
            if (body == "")
            {
                MessageBox.Show("메일 내용을 입력해 주세요.");
            }
            mail.SetToAddress(toAddress);
            MessageBox.Show(mail.SendEmail(subject, body));
        }
    }
}
