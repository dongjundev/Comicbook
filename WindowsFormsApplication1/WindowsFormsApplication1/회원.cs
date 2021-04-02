using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class 회원 : Form
    {
        string ID = 로그인.ID;       //회원 ID
        DateTime current_time;


        public 회원()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.OWNBOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
            // TODO: 이 코드는 데이터를 'dataSet1.RESERVE' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rESERVETableAdapter.Fill(this.dataSet1.RESERVE);
            // TODO: 이 코드는 데이터를 'dataSet1.RENT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTTableAdapter.Fill(this.dataSet1.RENT);
            // TODO: 이 코드는 데이터를 'dataSet1.OWNBOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
            // TODO: 이 코드는 데이터를 'dataSet2.RANKING' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rANKINGTableAdapter.Fill(this.dataSet2.RANKING);
            // TODO: 이 코드는 데이터를 'dataSet1.BOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.bOOKTableAdapter.Fill(this.dataSet1.BOOK);

            comboBox1.Items.AddRange(new string[] { "이름", "장르", "출판사", "저자", "요금", "위치" });

            rENTBindingSource.Filter = "m_id = " + "'" + ID + "'";

            oracleConnection1.Open();
            oracleCommand3.CommandText = "select m_grade from member where m_id= '" + ID + "'";
            int black = Convert.ToInt16(oracleCommand3.ExecuteScalar());
            oracleConnection1.Close();
            if (black == -1)
                MessageBox.Show("당신은 블랙리스트 등급입니다.");
        }

        private void button1_Click(object sender, EventArgs e)      //검색
        {
            string combo = comboBox1.SelectedItem.ToString();
            if (bOOKBindingSource.Filter != null)
            {
                bOOKBindingSource.RemoveFilter();
                button1.Text = "검색";
            }
            else
            {
                try
                {
                    switch (combo)
                    {
                        case "이름":
                            bOOKBindingSource.Filter = "b_name like '%" + textBox1.Text + "%'";
                            break;

                        case "장르":
                            bOOKBindingSource.Filter = "b_genre like '%" + textBox1.Text + "%'";
                            break;

                        case "출판사":
                            bOOKBindingSource.Filter = "b_publicher like '%" + textBox1.Text + "%'";
                            break;

                        case "저자":
                            bOOKBindingSource.Filter = "b_authority like '%" + textBox1.Text + "%'";
                            break;

                        case "요금":
                            bOOKBindingSource.Filter = "b_fee like '%" + textBox1.Text + "%'";
                            break;

                        case "위치":
                            bOOKBindingSource.Filter = "b_name like '%" + textBox1.Text + "%'";
                            break;
                    }
                    button1.Text = "초기화";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)      //랭킹
        {
            Form form = new 랭킹();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)      //후기작성
        {
            string str = this.dataGridView4.Rows[this.dataGridView4.CurrentCellAddress.Y].Cells[0].Value.ToString();
           
            oracleCommand3.CommandText = "select m_grade from member where m_id= '" + ID + "'";

            oracleConnection1.Open();
            int black = Convert.ToInt16(oracleCommand3.ExecuteScalar());
            oracleConnection1.Close();
            
            if (black == -1)
            {
                MessageBox.Show("블랙리스트 등급은 후기를 적을 수 없습니다.");
                listBox1.Items.Clear();
            }
            else
            {
                oracleConnection1.Open();
                oracleCommand1.CommandText = "insert into Review values(:aa, :bb, :cc)";
                oracleCommand2.CommandText = "select r_seq.nextval from DUAL";
                int i = Convert.ToInt32(oracleCommand2.ExecuteScalar());
                oracleCommand1.Parameters["aa"].Value = str;
                oracleCommand1.Parameters["bb"].Value = i;
                oracleCommand1.Parameters["cc"].Value = textBox2.Text;
                if (textBox2.Text == "")
                    MessageBox.Show("후기를 입력해주세요");
                else
                {
                    oracleCommand1.ExecuteNonQuery();
                    MessageBox.Show("입력완료");
                }
                textBox2.Clear();
                listBox1.Items.Clear();
                oracleConnection1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)      //예약
        {
            oracleConnection1.Open();
            oracleCommand3.CommandText = "select m_grade from member where m_id= '" + ID + "'";
            int black = Convert.ToInt16(oracleCommand3.ExecuteScalar());
            oracleConnection1.Close();
            int status = Convert.ToInt16(this.dataGridView2.CurrentRow.Cells[2].Value);     //o_status
            string str1 = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();        //o_id
            string str2 = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();       //b_name
            int str3 = Convert.ToInt16(this.dataGridView2.CurrentRow.Cells[3].Value);       //isreserve
            if (black == -1)
            {
                MessageBox.Show("블랙리스트 등급은 예약 할 수 없습니다.");
            }
            else{
            if (status == 1)
            {
                oracleConnection1.Open();
                oracleCommand2.CommandText = "select SYSDATE from DUAL";
                current_time = Convert.ToDateTime(oracleCommand2.ExecuteScalar());
                if (str3 == 1)
                {
                    MessageBox.Show("이미 예약중입니다.");
                }
                else
                {
                    oracleCommand4.CommandText = "insert into reserve values (:aa, :bb, :cc, :dd)";
                    oracleCommand4.Parameters["aa"].Value = str1;      //o_id
                    oracleCommand4.Parameters["bb"].Value = ID;      //m_id
                    oracleCommand4.Parameters["cc"].Value = str2;      //b_name
                    oracleCommand4.Parameters["dd"].Value = current_time;      //reservedate
                    oracleCommand4.ExecuteNonQuery();
                    oracleCommand3.CommandText = "update ownbook set o_isreserve = 1 where o_id = " + "'" + str1 + "'";
                    oracleCommand3.ExecuteNonQuery();
                    oWNBOOKTableAdapter.Update(dataSet1);
                    this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
                    this.rESERVETableAdapter.Fill(this.dataSet1.RESERVE);

                    MessageBox.Show("예약완료!");
                }
                oracleConnection1.Close();
            }
            else
                MessageBox.Show("대여 할 수 있습니다.");
        }
        }

        private void button4_Click(object sender, EventArgs e)  //후기보기
        {
            listBox1.Items.Clear();
            oracleConnection1.Open();
            string str = this.dataGridView4.CurrentRow.Cells[0].Value.ToString();
            oracleCommand2.CommandText = "select r_review from review where b_name = '" + str + "'";
            try 
            { 
                OracleDataReader rdr = oracleCommand2.ExecuteReader();
                while (rdr.Read())
                {
                   listBox1.Items.Add(rdr["r_review"].ToString());
                }
                rdr.Close();
            }
            catch (SystemException)
            {
                MessageBox.Show("작성된 후기가 없습니다.");
            }
     
            oracleConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)      //연장신청
        {
            int isreturn = Convert.ToInt16(this.dataGridView3.CurrentRow.Cells[5].Value);   //반납여부
            int isextend = Convert.ToInt16(this.dataGridView3.CurrentRow.Cells[6].Value);   //연장여부

            if (isreturn == 1)
            {
                MessageBox.Show("이미 반납했습니다.");
            }
            else
            {
                if (isextend == 1)
                {
                    MessageBox.Show("이미 연장했습니다.");
                }
                else
                {
                    oracleConnection1.Open();
                    string b_id = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();

                    DateTime addrentdate = Convert.ToDateTime(this.dataGridView3.CurrentRow.Cells[4].Value).AddDays(7);
                    
                    this.dataGridView3.CurrentRow.Cells[4].Value = addrentdate;
                    this.dataGridView3.CurrentRow.Cells[6].Value = 1;
                    rENTBindingSource.EndEdit();
                    
                    int r = rENTTableAdapter.Update(this.dataSet1.RENT);
                    if (r > 0)
                        MessageBox.Show("완료");
                  
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)      //예약취소
        {
            string o_id = this.dataGridView5.CurrentRow.Cells[1].Value.ToString();
            rESERVEBindingSource.RemoveCurrent();
            oracleConnection1.Open();
            oracleCommand2.CommandText = "update ownbook set o_isreserve=0 where o_id = " + "'" + o_id + "'";
            oracleCommand2.ExecuteNonQuery();
            oracleConnection1.Close();
            MessageBox.Show("예약취소됬습니다");
            rESERVETableAdapter.Update(this.dataSet1);
            this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
            //dataGridView2.Refresh();
        }
      }
}
