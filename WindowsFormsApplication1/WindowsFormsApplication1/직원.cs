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
    public partial class 직원 : Form
    {
        string ID = 직원로그인.ID;
        public 직원()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.MEMBER' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.mEMBERTableAdapter.Fill(this.dataSet1.MEMBER);
            // TODO: 이 코드는 데이터를 'dataSet2.VIEW_LATEFEE3' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_LATEFEE3TableAdapter.Fill(this.dataSet2.VIEW_LATEFEE3);
            // TODO: 이 코드는 데이터를 'dataSet2.VIEW_LATEFEE2' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.lOCATIONTableAdapter.Fill(this.dataSet2.LOCATION);
            // TODO: 이 코드는 데이터를 'dataSet2.LATEFEE' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTTableAdapter.Fill(this.dataSet1.RENT);
            // TODO: 이 코드는 데이터를 'dataSet1.OWNBOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
            // TODO: 이 코드는 데이터를 'dataSet1.OWNBOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.

            rENTBindingSource.Filter = "r_isreturn = " + 0;
            oWNBOOKBindingSource.Filter = "o_isrent = " + 0+ " and o_isreserve = " +0;
        }

        private void button1_Click(object sender, EventArgs e)      //대여
        {
            oracleConnection1.Open();
            oracleCommand5.CommandText = "select m_grade from member where m_id = '" + textBox3.Text + "'";
            int m_grade = Convert.ToInt16(oracleCommand5.ExecuteScalar());

            if (textBox3.Text == "")
            {
                MessageBox.Show("회원 ID를 입력하세요.");
            }
            else if (m_grade == -1)
            {
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() != "C")
                    MessageBox.Show("블랙리스트는 c등급 책만 빌릴 수 있습니다.");
                else
                {
                    oracleCommand2.CommandText = "select SYSDATE from DUAL";
                    DateTime current_time = Convert.ToDateTime(oracleCommand2.ExecuteScalar());

                    oracleCommand1.CommandText = "insert into Rent values(:aa, :bb, :cc, :dd, :ee, :ff, :gg, :hh)";
                    oracleCommand1.Parameters["aa"].Value = textBox3.Text;      //m_id
                    oracleCommand1.Parameters["bb"].Value = textBox2.Text;      //o_id
                    oracleCommand1.Parameters["cc"].Value = current_time;       //rentdate
                    oracleCommand1.Parameters["dd"].Value = textBox1.Text;      //b_name
                    oracleCommand1.Parameters["ee"].Value = current_time.AddDays(7);        //deadline
                    oracleCommand1.Parameters["ff"].Value = 0;      //isreturn
                    oracleCommand1.Parameters["gg"].Value = 0;      //isextend
                    oracleCommand1.Parameters["hh"].Value = ID;     //r_staff
                    oracleCommand1.ExecuteNonQuery();

                    oracleCommand3.CommandText = "select b_fee from book where b_name = '" + textBox1.Text + "'";
                    string fee = oracleCommand3.ExecuteScalar().ToString();

                    oracleCommand4.CommandText = "update ownbook set o_isrent = " + 1 + " where o_id = '" + textBox2.Text + "'";
                    oracleCommand4.ExecuteNonQuery();

                    this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
                    this.rENTTableAdapter.Fill(this.dataSet1.RENT);

                    MessageBox.Show(fee + " 원");
                }
            }
            else
            {
                oracleCommand2.CommandText = "select SYSDATE from DUAL";
                DateTime current_time = Convert.ToDateTime(oracleCommand2.ExecuteScalar());

                oracleCommand1.CommandText = "insert into Rent values(:aa, :bb, :cc, :dd, :ee, :ff, :gg, :hh)";
                oracleCommand1.Parameters["aa"].Value = textBox3.Text;      //m_id
                oracleCommand1.Parameters["bb"].Value = textBox2.Text;      //o_id
                oracleCommand1.Parameters["cc"].Value = current_time;       //rentdate
                oracleCommand1.Parameters["dd"].Value = textBox1.Text;      //b_name
                oracleCommand1.Parameters["ee"].Value = current_time.AddDays(7);        //deadline
                oracleCommand1.Parameters["ff"].Value = 0;      //isreturn
                oracleCommand1.Parameters["gg"].Value = 0;      //isextend
                oracleCommand1.Parameters["hh"].Value = ID;     //r_staff
                oracleCommand1.ExecuteNonQuery();

                oracleCommand3.CommandText = "select b_fee from book where b_name = '" + textBox1.Text + "'";
                string fee = oracleCommand3.ExecuteScalar().ToString();

                oracleCommand4.CommandText = "update ownbook set o_isrent = " + 1 + " where o_id = '" + textBox2.Text + "'";
                oracleCommand4.ExecuteNonQuery();

                this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
                this.rENTTableAdapter.Fill(this.dataSet1.RENT);

                MessageBox.Show(fee + " 원");
            }
          
            oracleConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)      //반납
        {
                string b_name = dataGridView2.CurrentRow.Cells[3].Value.ToString();     //b_name
                string o_id = dataGridView2.CurrentRow.Cells[1].Value.ToString();       //o_id
                DateTime ndt = DateTime.Now;        //현재시간
                TimeSpan difdt = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[4].Value) - ndt;     //deadline - 현재시간
                int dif = difdt.Days;       //연체일

                oracleConnection1.Open();    
                
                oracleCommand4.CommandText = "select b_latefee from book where b_name = '"+b_name+"'";      
                if (dif < 0) 
                {
                    MessageBox.Show("연체료 "+Convert.ToInt16(oracleCommand4.ExecuteScalar())*-dif+" 원");      //연체했으면 연체로 부과
                }
                
                oracleCommand2.CommandText = "update ownbook set o_isrent = " + 0 + " where o_id = '" + o_id + "'";
                oracleCommand3.CommandText = "update rent set r_isreturn = " + 1 + " where o_id = '" + o_id + "'";
                oracleCommand2.ExecuteNonQuery();
                oracleCommand3.ExecuteNonQuery();
                
                this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
                this.rENTTableAdapter.Fill(this.dataSet1.RENT);
                
                oracleConnection1.Close();
                MessageBox.Show("반납 완료!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)      //대여,반납 검색
        {
            if (oWNBOOKBindingSource.Filter != "o_isrent = " + 0 + " and o_isreserve = " + 0)
            {
                rENTBindingSource.Filter = "r_isreturn = " + 0;
                oWNBOOKBindingSource.Filter = "o_isrent = " + 0 + " and o_isreserve = " + 0;
                button3.Text = "검색";
                textBox4.Text = "";
            }
            else
            {
                oWNBOOKBindingSource.Filter = "b_name like " + "'%" + textBox4.Text + "%' and o_isrent = " + 0 + " and o_isreserve = " + 0;
                rENTBindingSource.Filter = "b_name like " + "'%" + textBox4.Text + "%' and r_isreturn = " + 0;
                button3.Text = "초기화";
            }
        }

        private void button4_Click(object sender, EventArgs e)      //재고위치 검색
        {
            if (lOCATIONBindingSource.Filter != null)
            {
                lOCATIONBindingSource.RemoveFilter();
                button4.Text = "검색";
            }
            else
            {
                lOCATIONBindingSource.Filter = "b_name like " + "'%" + textBox5.Text + "%'";
                button4.Text = "초기화";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //oracleConnection1.Open();
            //oracleCommand2.CommandText="select
            Form form = new 메일보내기();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)      //검색
        {
            if (mEMBERBindingSource.Filter != null)
            {
                mEMBERBindingSource.RemoveFilter();
                button6.Text = "검색";
                textBox6.Text = "";
            }
            else
            {
                try
                {
                    switch (comboBox1.Text)
                    {
                        case "회원 ID":
                            mEMBERBindingSource.Filter = "m_id like '%" + textBox6.Text + "%'";
                            break;
                        case "회원 이름":
                            mEMBERBindingSource.Filter = "m_name like '%" + textBox6.Text + "%'";
                            break;
                    }
                    button6.Text = "초기화";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)      //저장
        {
            try
            {
                this.mEMBERBindingSource.EndEdit();
                int ret = this.mEMBERTableAdapter.Update(this.dataSet1.MEMBER);
                if (ret > 0)
                    MessageBox.Show("업데이트 성공", "저장성공", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("업데이트 할 것이 없습니다.", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ea)
            {
                MessageBox.Show("업데이트 실패" + ea, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {

                    string text = e.Value.ToString();
                    switch (e.Value.ToString())
                    {
                        case "0":
                            e.Value = "일반회원";
                            break;
                        case "1":
                            e.Value = "직원";
                            break;
                        case "2":
                            e.Value = "매니저";
                            break;
                        case "-1":
                            e.Value = "블랙리스트";
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.SelectionForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

    }
}
