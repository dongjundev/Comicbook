namespace WindowsFormsApplication1
{
    partial class 회원
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
            this.components = new System.ComponentModel.Container();
            Oracle.DataAccess.Client.OracleParameter oracleParameter8 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter9 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter10 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter11 = new Oracle.DataAccess.Client.OracleParameter();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oISRENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oISRESERVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKOWNBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPUBLICHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAUTHORITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLATEFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDEADLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.DataAccess.Client.OracleCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bNAMEDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGENREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAUTHORITYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPAGEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFEEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLATEFEEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDEADLINEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOCATIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.bNAMEDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.rENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oracleCommand4 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleDataAdapter1 = new Oracle.DataAccess.Client.OracleDataAdapter();
            this.oWNBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.BOOKTableAdapter();
            this.oWNBOOKTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.OWNBOOKTableAdapter();
            this.rENTTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.RENTTableAdapter();
            this.rESERVETableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.RESERVETableAdapter();
            this.dataSet2 = new WindowsFormsApplication1.DataSet2();
            this.rANKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rANKINGTableAdapter = new WindowsFormsApplication1.DataSet2TableAdapters.RANKINGTableAdapter();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNAMEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDEADLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rISRETURNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rISEXTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKOWNBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rANKINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "책 정보";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(524, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "예약 신청";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNAMEDataGridViewTextBoxColumn1,
            this.oIDDataGridViewTextBoxColumn,
            this.oISRENTDataGridViewTextBoxColumn,
            this.oISRESERVEDataGridViewTextBoxColumn,
            this.oSTATUSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bOOKOWNBOOKBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(6, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(547, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // bNAMEDataGridViewTextBoxColumn1
            // 
            this.bNAMEDataGridViewTextBoxColumn1.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn1.HeaderText = "이름";
            this.bNAMEDataGridViewTextBoxColumn1.Name = "bNAMEDataGridViewTextBoxColumn1";
            this.bNAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "번호";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oISRENTDataGridViewTextBoxColumn
            // 
            this.oISRENTDataGridViewTextBoxColumn.DataPropertyName = "O_ISRENT";
            this.oISRENTDataGridViewTextBoxColumn.FalseValue = "0";
            this.oISRENTDataGridViewTextBoxColumn.HeaderText = "대여 여부";
            this.oISRENTDataGridViewTextBoxColumn.Name = "oISRENTDataGridViewTextBoxColumn";
            this.oISRENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.oISRENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oISRENTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oISRENTDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // oISRESERVEDataGridViewTextBoxColumn
            // 
            this.oISRESERVEDataGridViewTextBoxColumn.DataPropertyName = "O_ISRESERVE";
            this.oISRESERVEDataGridViewTextBoxColumn.FalseValue = "0";
            this.oISRESERVEDataGridViewTextBoxColumn.HeaderText = "예약 여부";
            this.oISRESERVEDataGridViewTextBoxColumn.Name = "oISRESERVEDataGridViewTextBoxColumn";
            this.oISRESERVEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oISRESERVEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oISRESERVEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oISRESERVEDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // oSTATUSDataGridViewTextBoxColumn
            // 
            this.oSTATUSDataGridViewTextBoxColumn.DataPropertyName = "O_STATUS";
            this.oSTATUSDataGridViewTextBoxColumn.HeaderText = "상태";
            this.oSTATUSDataGridViewTextBoxColumn.Name = "oSTATUSDataGridViewTextBoxColumn";
            this.oSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKOWNBOOKBindingSource
            // 
            this.bOOKOWNBOOKBindingSource.DataMember = "BOOK_OWNBOOK";
            this.bOOKOWNBOOKBindingSource.DataSource = this.bOOKBindingSource;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(733, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 51);
            this.button5.TabIndex = 2;
            this.button5.Text = "도서 랭킹 보기";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNAMEDataGridViewTextBoxColumn,
            this.bGENREDataGridViewTextBoxColumn,
            this.bPUBLICHERDataGridViewTextBoxColumn,
            this.bAUTHORITYDataGridViewTextBoxColumn,
            this.bPAGEDataGridViewTextBoxColumn,
            this.bFEEDataGridViewTextBoxColumn,
            this.bLATEFEEDataGridViewTextBoxColumn,
            this.bDEADLINEDataGridViewTextBoxColumn,
            this.bLOCATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(6, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(933, 213);
            this.dataGridView1.TabIndex = 4;
            // 
            // bNAMEDataGridViewTextBoxColumn
            // 
            this.bNAMEDataGridViewTextBoxColumn.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.HeaderText = "이름";
            this.bNAMEDataGridViewTextBoxColumn.Name = "bNAMEDataGridViewTextBoxColumn";
            this.bNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bGENREDataGridViewTextBoxColumn
            // 
            this.bGENREDataGridViewTextBoxColumn.DataPropertyName = "B_GENRE";
            this.bGENREDataGridViewTextBoxColumn.HeaderText = "장르";
            this.bGENREDataGridViewTextBoxColumn.Name = "bGENREDataGridViewTextBoxColumn";
            this.bGENREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bPUBLICHERDataGridViewTextBoxColumn
            // 
            this.bPUBLICHERDataGridViewTextBoxColumn.DataPropertyName = "B_PUBLICHER";
            this.bPUBLICHERDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.bPUBLICHERDataGridViewTextBoxColumn.Name = "bPUBLICHERDataGridViewTextBoxColumn";
            this.bPUBLICHERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAUTHORITYDataGridViewTextBoxColumn
            // 
            this.bAUTHORITYDataGridViewTextBoxColumn.DataPropertyName = "B_AUTHORITY";
            this.bAUTHORITYDataGridViewTextBoxColumn.HeaderText = "저자";
            this.bAUTHORITYDataGridViewTextBoxColumn.Name = "bAUTHORITYDataGridViewTextBoxColumn";
            this.bAUTHORITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bPAGEDataGridViewTextBoxColumn
            // 
            this.bPAGEDataGridViewTextBoxColumn.DataPropertyName = "B_PAGE";
            this.bPAGEDataGridViewTextBoxColumn.HeaderText = "페이지";
            this.bPAGEDataGridViewTextBoxColumn.Name = "bPAGEDataGridViewTextBoxColumn";
            this.bPAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bFEEDataGridViewTextBoxColumn
            // 
            this.bFEEDataGridViewTextBoxColumn.DataPropertyName = "B_FEE";
            this.bFEEDataGridViewTextBoxColumn.HeaderText = "요금";
            this.bFEEDataGridViewTextBoxColumn.Name = "bFEEDataGridViewTextBoxColumn";
            this.bFEEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLATEFEEDataGridViewTextBoxColumn
            // 
            this.bLATEFEEDataGridViewTextBoxColumn.DataPropertyName = "B_LATEFEE";
            this.bLATEFEEDataGridViewTextBoxColumn.HeaderText = "연체료";
            this.bLATEFEEDataGridViewTextBoxColumn.Name = "bLATEFEEDataGridViewTextBoxColumn";
            this.bLATEFEEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDEADLINEDataGridViewTextBoxColumn
            // 
            this.bDEADLINEDataGridViewTextBoxColumn.DataPropertyName = "B_DEADLINE";
            this.bDEADLINEDataGridViewTextBoxColumn.HeaderText = "반납일";
            this.bDEADLINEDataGridViewTextBoxColumn.Name = "bDEADLINEDataGridViewTextBoxColumn";
            this.bDEADLINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLOCATIONDataGridViewTextBoxColumn
            // 
            this.bLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "B_LOCATION";
            this.bLOCATIONDataGridViewTextBoxColumn.HeaderText = "위치";
            this.bLOCATIONDataGridViewTextBoxColumn.Name = "bLOCATIONDataGridViewTextBoxColumn";
            this.bLOCATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(305, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("휴먼편지체", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(178, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 1;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORARA;USER ID=A5293460;password=qew164712486";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            oracleParameter8.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter8.ParameterName = "aa";
            oracleParameter9.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter9.ParameterName = "bb";
            oracleParameter10.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter10.ParameterName = "cc";
            this.oracleCommand1.Parameters.Add(oracleParameter8);
            this.oracleCommand1.Parameters.Add(oracleParameter9);
            this.oracleCommand1.Parameters.Add(oracleParameter10);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            this.oracleCommand3.Transaction = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 498);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "도서 현황";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "후기";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(312, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "후기 작성";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 415);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "책 정보";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(439, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 194);
            this.listBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(6, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 194);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNAMEDataGridViewTextBoxColumn3,
            this.bGENREDataGridViewTextBoxColumn1,
            this.bAUTHORITYDataGridViewTextBoxColumn1,
            this.bPAGEDataGridViewTextBoxColumn1,
            this.bFEEDataGridViewTextBoxColumn1,
            this.bLATEFEEDataGridViewTextBoxColumn1,
            this.bDEADLINEDataGridViewTextBoxColumn1,
            this.bLOCATIONDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.bOOKBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 20);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(862, 178);
            this.dataGridView4.TabIndex = 0;
            // 
            // bNAMEDataGridViewTextBoxColumn3
            // 
            this.bNAMEDataGridViewTextBoxColumn3.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn3.HeaderText = "이름";
            this.bNAMEDataGridViewTextBoxColumn3.Name = "bNAMEDataGridViewTextBoxColumn3";
            this.bNAMEDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bGENREDataGridViewTextBoxColumn1
            // 
            this.bGENREDataGridViewTextBoxColumn1.DataPropertyName = "B_GENRE";
            this.bGENREDataGridViewTextBoxColumn1.HeaderText = "장르";
            this.bGENREDataGridViewTextBoxColumn1.Name = "bGENREDataGridViewTextBoxColumn1";
            this.bGENREDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bAUTHORITYDataGridViewTextBoxColumn1
            // 
            this.bAUTHORITYDataGridViewTextBoxColumn1.DataPropertyName = "B_AUTHORITY";
            this.bAUTHORITYDataGridViewTextBoxColumn1.HeaderText = "저자";
            this.bAUTHORITYDataGridViewTextBoxColumn1.Name = "bAUTHORITYDataGridViewTextBoxColumn1";
            this.bAUTHORITYDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bPAGEDataGridViewTextBoxColumn1
            // 
            this.bPAGEDataGridViewTextBoxColumn1.DataPropertyName = "B_PAGE";
            this.bPAGEDataGridViewTextBoxColumn1.HeaderText = "페이지";
            this.bPAGEDataGridViewTextBoxColumn1.Name = "bPAGEDataGridViewTextBoxColumn1";
            this.bPAGEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bFEEDataGridViewTextBoxColumn1
            // 
            this.bFEEDataGridViewTextBoxColumn1.DataPropertyName = "B_FEE";
            this.bFEEDataGridViewTextBoxColumn1.HeaderText = "대여 요금";
            this.bFEEDataGridViewTextBoxColumn1.Name = "bFEEDataGridViewTextBoxColumn1";
            this.bFEEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bLATEFEEDataGridViewTextBoxColumn1
            // 
            this.bLATEFEEDataGridViewTextBoxColumn1.DataPropertyName = "B_LATEFEE";
            this.bLATEFEEDataGridViewTextBoxColumn1.HeaderText = "연체료";
            this.bLATEFEEDataGridViewTextBoxColumn1.Name = "bLATEFEEDataGridViewTextBoxColumn1";
            this.bLATEFEEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bDEADLINEDataGridViewTextBoxColumn1
            // 
            this.bDEADLINEDataGridViewTextBoxColumn1.DataPropertyName = "B_DEADLINE";
            this.bDEADLINEDataGridViewTextBoxColumn1.HeaderText = "반납일";
            this.bDEADLINEDataGridViewTextBoxColumn1.Name = "bDEADLINEDataGridViewTextBoxColumn1";
            this.bDEADLINEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bLOCATIONDataGridViewTextBoxColumn1
            // 
            this.bLOCATIONDataGridViewTextBoxColumn1.DataPropertyName = "B_LOCATION";
            this.bLOCATIONDataGridViewTextBoxColumn1.HeaderText = "위치";
            this.bLOCATIONDataGridViewTextBoxColumn1.Name = "bLOCATIONDataGridViewTextBoxColumn1";
            this.bLOCATIONDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(790, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "후기 보기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(955, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "마이페이지";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(546, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 35);
            this.button7.TabIndex = 3;
            this.button7.Text = "예약 취소";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNAMEDataGridViewTextBoxColumn4,
            this.oIDDataGridViewTextBoxColumn2});
            this.dataGridView5.DataSource = this.rESERVEBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(17, 211);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(301, 170);
            this.dataGridView5.TabIndex = 2;
            // 
            // bNAMEDataGridViewTextBoxColumn4
            // 
            this.bNAMEDataGridViewTextBoxColumn4.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn4.HeaderText = "책 이름";
            this.bNAMEDataGridViewTextBoxColumn4.Name = "bNAMEDataGridViewTextBoxColumn4";
            this.bNAMEDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // oIDDataGridViewTextBoxColumn2
            // 
            this.oIDDataGridViewTextBoxColumn2.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn2.HeaderText = "회원 ID";
            this.oIDDataGridViewTextBoxColumn2.Name = "oIDDataGridViewTextBoxColumn2";
            this.oIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rESERVEBindingSource
            // 
            this.rESERVEBindingSource.DataMember = "RESERVE";
            this.rESERVEBindingSource.DataSource = this.dataSet1;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(788, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 35);
            this.button6.TabIndex = 1;
            this.button6.Text = "연장 신청";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn1,
            this.bNAMEDataGridViewTextBoxColumn2,
            this.rDEADLINEDataGridViewTextBoxColumn,
            this.rISRETURNDataGridViewTextBoxColumn,
            this.rISEXTENDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.rENTBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(17, 29);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(747, 148);
            this.dataGridView3.TabIndex = 0;
            // 
            // rENTBindingSource
            // 
            this.rENTBindingSource.DataMember = "RENT";
            this.rENTBindingSource.DataSource = this.dataSet1;
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "aa";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "bb";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "cc";
            oracleParameter11.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Date;
            oracleParameter11.ParameterName = "dd";
            this.oracleCommand4.Parameters.Add(oracleParameter1);
            this.oracleCommand4.Parameters.Add(oracleParameter2);
            this.oracleCommand4.Parameters.Add(oracleParameter3);
            this.oracleCommand4.Parameters.Add(oracleParameter11);
            this.oracleCommand4.Transaction = null;
            // 
            // oWNBOOKBindingSource
            // 
            this.oWNBOOKBindingSource.DataMember = "OWNBOOK";
            this.oWNBOOKBindingSource.DataSource = this.dataSet1;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // oWNBOOKTableAdapter
            // 
            this.oWNBOOKTableAdapter.ClearBeforeFill = true;
            // 
            // rENTTableAdapter
            // 
            this.rENTTableAdapter.ClearBeforeFill = true;
            // 
            // rESERVETableAdapter
            // 
            this.rESERVETableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rANKINGBindingSource
            // 
            this.rANKINGBindingSource.DataMember = "RANKING";
            this.rANKINGBindingSource.DataSource = this.dataSet2;
            // 
            // rANKINGTableAdapter
            // 
            this.rANKINGTableAdapter.ClearBeforeFill = true;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "M_ID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "회원 ID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIDDataGridViewTextBoxColumn1
            // 
            this.oIDDataGridViewTextBoxColumn1.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn1.HeaderText = "책 ID";
            this.oIDDataGridViewTextBoxColumn1.Name = "oIDDataGridViewTextBoxColumn1";
            this.oIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bNAMEDataGridViewTextBoxColumn2
            // 
            this.bNAMEDataGridViewTextBoxColumn2.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn2.HeaderText = "책 이름";
            this.bNAMEDataGridViewTextBoxColumn2.Name = "bNAMEDataGridViewTextBoxColumn2";
            this.bNAMEDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rDEADLINEDataGridViewTextBoxColumn
            // 
            this.rDEADLINEDataGridViewTextBoxColumn.DataPropertyName = "R_DEADLINE";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.rDEADLINEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rDEADLINEDataGridViewTextBoxColumn.HeaderText = "반납일";
            this.rDEADLINEDataGridViewTextBoxColumn.Name = "rDEADLINEDataGridViewTextBoxColumn";
            this.rDEADLINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rISRETURNDataGridViewTextBoxColumn
            // 
            this.rISRETURNDataGridViewTextBoxColumn.DataPropertyName = "R_ISRETURN";
            this.rISRETURNDataGridViewTextBoxColumn.FalseValue = "0";
            this.rISRETURNDataGridViewTextBoxColumn.HeaderText = "반납여부";
            this.rISRETURNDataGridViewTextBoxColumn.Name = "rISRETURNDataGridViewTextBoxColumn";
            this.rISRETURNDataGridViewTextBoxColumn.ReadOnly = true;
            this.rISRETURNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rISRETURNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rISRETURNDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // rISEXTENDDataGridViewTextBoxColumn
            // 
            this.rISEXTENDDataGridViewTextBoxColumn.DataPropertyName = "R_ISEXTEND";
            this.rISEXTENDDataGridViewTextBoxColumn.FalseValue = "0";
            this.rISEXTENDDataGridViewTextBoxColumn.HeaderText = "연장여부";
            this.rISEXTENDDataGridViewTextBoxColumn.Name = "rISEXTENDDataGridViewTextBoxColumn";
            this.rISEXTENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rISEXTENDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rISEXTENDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rISEXTENDDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // 회원
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "회원";
            this.Text = "회원";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKOWNBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rANKINGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn bNMAEDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private DataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rANKINGBindingSource;
        private DataSet2TableAdapters.RANKINGTableAdapter rANKINGTableAdapter;
        private System.Windows.Forms.BindingSource oWNBOOKBindingSource;
        private DataSet1TableAdapters.OWNBOOKTableAdapter oWNBOOKTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource rENTBindingSource;
        private DataSet1TableAdapters.RENTTableAdapter rENTTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bOOKOWNBOOKBindingSource;
        private Oracle.DataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource rESERVEBindingSource;
        private DataSet1TableAdapters.RESERVETableAdapter rESERVETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oISRENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oISRESERVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPUBLICHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAUTHORITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLATEFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDEADLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGENREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAUTHORITYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPAGEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFEEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLATEFEEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDEADLINEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOCATIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDEADLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rISRETURNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rISEXTENDDataGridViewTextBoxColumn;

    }
}