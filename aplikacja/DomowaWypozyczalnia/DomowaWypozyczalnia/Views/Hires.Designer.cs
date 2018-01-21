namespace DomowaWypozyczalnia.Views
{
    partial class Hires
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specimen1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inmateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inmate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.specimen1DataGridViewTextBoxColumn,
            this.inmateDataGridViewTextBoxColumn,
            this.specimenDataGridViewTextBoxColumn,
            this.rentaldateDataGridViewTextBoxColumn,
            this.returnedDataGridViewCheckBoxColumn,
            this.inmate1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 407);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zwróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hireBindingSource
            // 
            this.hireBindingSource.DataSource = typeof(DomowaWypozyczalnia.Hire);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // specimen1DataGridViewTextBoxColumn
            // 
            this.specimen1DataGridViewTextBoxColumn.DataPropertyName = "Specimen1";
            this.specimen1DataGridViewTextBoxColumn.HeaderText = "Egzemplarz";
            this.specimen1DataGridViewTextBoxColumn.Name = "specimen1DataGridViewTextBoxColumn";
            // 
            // inmateDataGridViewTextBoxColumn
            // 
            this.inmateDataGridViewTextBoxColumn.DataPropertyName = "Inmate";
            this.inmateDataGridViewTextBoxColumn.HeaderText = "Inmate";
            this.inmateDataGridViewTextBoxColumn.Name = "inmateDataGridViewTextBoxColumn";
            this.inmateDataGridViewTextBoxColumn.Visible = false;
            // 
            // specimenDataGridViewTextBoxColumn
            // 
            this.specimenDataGridViewTextBoxColumn.DataPropertyName = "Specimen";
            this.specimenDataGridViewTextBoxColumn.HeaderText = "Specimen";
            this.specimenDataGridViewTextBoxColumn.Name = "specimenDataGridViewTextBoxColumn";
            this.specimenDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentaldateDataGridViewTextBoxColumn
            // 
            this.rentaldateDataGridViewTextBoxColumn.DataPropertyName = "Rentaldate";
            this.rentaldateDataGridViewTextBoxColumn.HeaderText = "Data wypożyczenia";
            this.rentaldateDataGridViewTextBoxColumn.Name = "rentaldateDataGridViewTextBoxColumn";
            // 
            // returnedDataGridViewCheckBoxColumn
            // 
            this.returnedDataGridViewCheckBoxColumn.DataPropertyName = "Returned";
            this.returnedDataGridViewCheckBoxColumn.HeaderText = "Returned";
            this.returnedDataGridViewCheckBoxColumn.Name = "returnedDataGridViewCheckBoxColumn";
            this.returnedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // inmate1DataGridViewTextBoxColumn
            // 
            this.inmate1DataGridViewTextBoxColumn.DataPropertyName = "Inmate1";
            this.inmate1DataGridViewTextBoxColumn.HeaderText = "Inmate1";
            this.inmate1DataGridViewTextBoxColumn.Name = "inmate1DataGridViewTextBoxColumn";
            this.inmate1DataGridViewTextBoxColumn.Visible = false;
            // 
            // Hires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hires";
            this.Text = "Wypożyczenia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specimen1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inmateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn returnedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inmate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hireBindingSource;
    }
}