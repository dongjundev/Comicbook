namespace WindowsFormsApplication1
{
    partial class 로그인
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼엑스포", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(147, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORARA;USER ID=A5293460;password=qew164712486";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Transaction = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("휴먼엑스포", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 263);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(36, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 21);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "회원가입";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // 로그인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 283);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "로그인";
            this.Text = "회원 로그인";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}