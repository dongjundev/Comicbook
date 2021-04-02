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
    public partial class 매니저 : Form
    {
        public 매니저()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.RENT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTTableAdapter.Fill(this.dataSet1.RENT);
            // TODO: 이 코드는 데이터를 'dataSet1.MEMBER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.mEMBERTableAdapter.Fill(this.dataSet1.MEMBER);
            // TODO: 이 코드는 데이터를 'dataSet1.OWNBOOK' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.oWNBOOKTableAdapter.Fill(this.dataSet1.OWNBOOK);
            // TODO: 이 코드는 데이터를 'dataSet1.BOOK' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.bOOKTableAdapter.Fill(this.dataSet1.BOOK);
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select r_review from review where b_name = 'memo'";
            textBox5.Text = oracleCommand1.ExecuteScalar().ToString();
            oracleConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //book 삭제
        {
            try
            {
                if(MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bOOKBindingSource.RemoveCurrent();
                }
            }
            catch(System.Exception)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)      //book 추가
        {
            try
            {
                bOOKBindingSource.AddNew();
            }
            catch (System.Exception)
            {
                MessageBox.Show("행을 채워주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKBindingSource.EndEdit();
                this.bOOKOWNBOOKBindingSource.EndEdit();
                int ret = this.bOOKTableAdapter.Update(this.dataSet1.BOOK);
                int ret2 = this.oWNBOOKTableAdapter.Update(this.dataSet1.OWNBOOK);
                if (ret > 0 || ret2 > 0)
                    MessageBox.Show("업데이트 성공", "저장성공", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("업데이트 할 것이 없습니다.", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(System.Exception ea)
            {
                MessageBox.Show("업데이트 실패" + ea, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)      //book 검색
        {
            if(bOOKBindingSource.Filter != null)
            {
                bOOKBindingSource.RemoveFilter();
                button3.Text = "검색";
            }
            else
            {
                try
                {
                    switch(comboBox1.Text)
                    {
                        case "제목":
                            bOOKBindingSource.Filter = "b_name like '%" + textBox1.Text + "%'";
                            break;
                        case "장르":
                            bOOKBindingSource.Filter = "b_genre= '" + textBox1.Text + "'";
                            break;
                        case "출판사":
                            bOOKBindingSource.Filter = "b_publisher= '" + textBox1.Text + "'";
                            break;
                        case "저자":
                            bOOKBindingSource.Filter = "b_authority= '" + textBox1.Text + "'";
                            break;
                        case "요금":
                            bOOKBindingSource.Filter = "b_fee= '" + textBox1.Text + "'";
                            break;
                        case "반납일":
                            bOOKBindingSource.Filter = "b_deadline= '" + textBox1.Text + "'";
                            break;
                        case "위치":
                            bOOKBindingSource.Filter = "b_location= '" + textBox1.Text + "'";
                            break;
                    }
                    button3.Text = "초기화";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)      //ownbook 추가
        {
            try
            {
                bOOKOWNBOOKBindingSource.AddNew();
            }
            catch (System.Exception)
            {
                MessageBox.Show("행을 채워주세요");
            }
        }

        private void button7_Click(object sender, EventArgs e)      //ownbook 삭제
        {
            try
            {
                if (MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bOOKOWNBOOKBindingSource.RemoveCurrent();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)     //회원 값 변환
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

        private void button5_Click(object sender, EventArgs e)      //회원 검색
        {
            if(mEMBERBindingSource.Filter!=null)
            {
                mEMBERBindingSource.RemoveFilter();
                button5.Text = "검색";
                textBox2.Text = "";
            }
            else
            {
                try
                {
                    switch (comboBox2.Text)
                    {
                        case "이름":
                            mEMBERBindingSource.Filter = "m_name like '%" + textBox2.Text + "%'";
                            break;
                        case "휴대폰":
                            mEMBERBindingSource.Filter = "m_phone like '%" + textBox2.Text + "%'";
                            break;
                        case "메일":
                            mEMBERBindingSource.Filter = "m_email like '%" + textBox2.Text + "%'";
                            break;
                        case "등급":
                            mEMBERBindingSource.Filter = "m_grade= '" + textBox2.Text + "'";
                            break;
                        

                    }
                    button5.Text = "초기화";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)      //회원 추가
        {
            try
            {
                mEMBERBindingSource.AddNew();
            }
            catch (System.Exception)
            {
                MessageBox.Show("행을 채워주세요");
            }
        }

        private void button9_Click(object sender, EventArgs e)      //회원 삭제
        {
            try
            {
                if (MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mEMBERBindingSource.RemoveCurrent();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
        }

        private void button10_Click(object sender, EventArgs e)     // 저장
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

        private void button11_Click(object sender, EventArgs e)     //rentview 날짜로 검색
        {
            rENTBindingSource.Filter = "r_rentdate >= '" + dateTimePicker1.Value.Date + "' and r_rentdate <= '" + dateTimePicker2.Value.Date.AddDays(1) + "'";
             
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select sum(b_fee) from rent_fee where to_char(r_rentdate,'yyyy-MM-dd-') between '" + dateTimePicker1.Value.Date + "' and '" + dateTimePicker2.Value.Date.AddDays(1) + "'";
            textBox3.Text = oracleCommand1.ExecuteScalar().ToString();

            oracleConnection1.Close();
            
 
        }

        private void button13_Click(object sender, EventArgs e)     //top5 보기
        {
            if (comboBox4.Text == "주간")
            {
                chart2.Series[0].Points.Clear();
                oracleConnection1.Open();
                oracleCommand1.CommandText = "select * from ( select ownbook.b_name, count(ownbook.o_id) as cnt from rent, ownbook where rent.o_id = ownbook.o_id and rent.r_rentdate between (select sysdate-7 from dual) and (select sysdate from dual) group by ownbook.b_name order by ownbook.b_name desc) where rownum <= 5";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                while (rdr.Read())
                {
                    chart2.Series[0].Points.AddXY(rdr["b_name"], rdr["cnt"]);
                }
                rdr.Close();
                oracleConnection1.Close();
            }
            else 
            {
                chart2.Series[0].Points.Clear();
                oracleConnection1.Open();
                oracleCommand1.CommandText = "select * from ( select ownbook.b_name, count(ownbook.o_id) as cnt from rent, ownbook where rent.o_id = ownbook.o_id and rent.r_rentdate between (select sysdate-30 from dual) and (select sysdate from dual) group by ownbook.b_name order by ownbook.b_name desc) where rownum <= 5";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                while (rdr.Read())
                {
                    chart2.Series[0].Points.AddXY(rdr["b_name"], rdr["cnt"]);
                }
                rdr.Close();
                oracleConnection1.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)     //rentview 검색
        {
                switch (comboBox3.Text)
                {
                    case "책 제목" :
                        rENTBindingSource.Filter = "b_name like '%" + textBox4.Text + "%'";
                        break;
                    case "책 번호" :
                        rENTBindingSource.Filter = "o_id like '%" + textBox4.Text + "%'";
                        break;
                    case "회원 ID" :
                        rENTBindingSource.Filter = "m_id like '%" + textBox4.Text + "%'";
                        break;
                }
                textBox3.Text = "";
            }

        private void button14_Click(object sender, EventArgs e)     //초기화
        {
            rENTBindingSource.Filter = null;
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)     //요일별
        {
            chart3.Series[0].Points.Clear();
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select to_char(r_rentdate, 'day') as day, count(b_name) as num from rent_count group by to_char(r_rentdate, 'day') order by num desc";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                chart3.Series[0].Points.AddXY(rdr["day"], rdr["num"]);
            }
            rdr.Close();
            oracleConnection1.Close();
        }

        private void button16_Click(object sender, EventArgs e)     //월별
        {
            chart3.Series[0].Points.Clear();
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select to_char(r_rentdate, 'mm') as month, count(b_name) as num from rent_count group by to_char(r_rentdate, 'mm') order by num desc";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                chart3.Series[0].Points.AddXY(rdr["month"], rdr["num"]);
            }
            rdr.Close();
            oracleConnection1.Close();
        }

        private void button17_Click(object sender, EventArgs e)     //회원별
        {
            chart3.Series[0].Points.Clear();
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select m_id, num from (select m_id, count(b_name) as num from rent group by m_id order by num desc) where rownum<=5";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                chart3.Series[0].Points.AddXY(rdr["m_id"], rdr["num"]);
            }
            rdr.Close();
            oracleConnection1.Close();
        }

        private void button18_Click(object sender, EventArgs e)     // 해야할일(메모)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "update review set r_review = '" + textBox5.Text + "' where r_id = "+1;
            try
            {
                oracleCommand1.ExecuteNonQuery();
            }
            catch (Exception) { MessageBox.Show("오류"); }
            oracleConnection1.Close();
            MessageBox.Show("저장 완료");
            
        }

        private void button19_Click(object sender, EventArgs e)     //메일 보내기
        {
            Form form = new 메일보내기();
            form.ShowDialog();
        }
        }
    }
