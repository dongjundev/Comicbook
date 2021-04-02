namespace WindowsFormsApplication1
{
    partial class 회원가입
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter4 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter5 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter6 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter7 = new Oracle.DataAccess.Client.OracleParameter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "암호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "이메일";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(123, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(123, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼엑스포", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(253, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "중복체크";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("휴먼엑스포", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(253, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "가입하기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORARA;USER ID=A5293460;password=qew164712486";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "aa";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "bb";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "cc";
            oracleParameter4.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = "dd";
            oracleParameter5.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter5.ParameterName = "ee";
            oracleParameter6.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter6.ParameterName = "ff";
            oracleParameter7.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int16;
            oracleParameter7.ParameterName = "gg";
            this.oracleCommand1.Parameters.Add(oracleParameter1);
            this.oracleCommand1.Parameters.Add(oracleParameter2);
            this.oracleCommand1.Parameters.Add(oracleParameter3);
            this.oracleCommand1.Parameters.Add(oracleParameter4);
            this.oracleCommand1.Parameters.Add(oracleParameter5);
            this.oracleCommand1.Parameters.Add(oracleParameter6);
            this.oracleCommand1.Parameters.Add(oracleParameter7);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "* 모든항목을 기입해주세요.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("휴먼엑스포", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 285);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            // 
            // 회원가입
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "회원가입";
            this.Text = "회원가입";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}