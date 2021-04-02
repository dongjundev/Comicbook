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
    public partial class 랭킹 : Form
    {
        public 랭킹()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet2.RANKING' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rANKINGTableAdapter.Fill(this.dataSet2.RANKING);

        }
    }
}
