namespace WindowsFormsApplication1
{
    partial class 랭킹
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rANKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication1.DataSet2();
            this.rANKINGTableAdapter = new WindowsFormsApplication1.DataSet2TableAdapters.RANKINGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rANKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNAMEDataGridViewTextBoxColumn,
            this.bCOUNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rANKINGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(244, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // bNAMEDataGridViewTextBoxColumn
            // 
            this.bNAMEDataGridViewTextBoxColumn.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.HeaderText = "책 이름";
            this.bNAMEDataGridViewTextBoxColumn.Name = "bNAMEDataGridViewTextBoxColumn";
            // 
            // bCOUNTDataGridViewTextBoxColumn
            // 
            this.bCOUNTDataGridViewTextBoxColumn.DataPropertyName = "B_COUNT";
            this.bCOUNTDataGridViewTextBoxColumn.HeaderText = "대여 횟수";
            this.bCOUNTDataGridViewTextBoxColumn.Name = "bCOUNTDataGridViewTextBoxColumn";
            // 
            // rANKINGBindingSource
            // 
            this.rANKINGBindingSource.DataMember = "RANKING";
            this.rANKINGBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rANKINGTableAdapter
            // 
            this.rANKINGTableAdapter.ClearBeforeFill = true;
            // 
            // 랭킹
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 442);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "랭킹";
            this.Text = "랭킹";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rANKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rANKINGBindingSource;
        private DataSet2TableAdapters.RANKINGTableAdapter rANKINGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCOUNTDataGridViewTextBoxColumn;
    }
}