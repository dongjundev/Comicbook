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
    public partial class 전체로그인 : Form
    {
        public 전체로그인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new 로그인();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new 직원로그인();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new 매니저_로그인();
            form.ShowDialog();
        }
    }
}
