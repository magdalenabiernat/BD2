namespace DomowaWypozyczalnia
{
    partial class ShowTitles
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
            this.dataGridViewTitles = new System.Windows.Forms.DataGridView();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCast = new System.Windows.Forms.DataGridView();
            this.groupBoxCast = new System.Windows.Forms.GroupBox();
            this.buttonCastEdit = new System.Windows.Forms.Button();
            this.buttonAddCast = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelActorName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.groupBoxTitles = new System.Windows.Forms.GroupBox();
            this.buttonTitleEdit = new System.Windows.Forms.Button();
            this.buttonAddTitle = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionCompany1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCast)).BeginInit();
            this.groupBoxCast.SuspendLayout();
            this.groupBoxTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTitles
            // 
            this.dataGridViewTitles.AutoGenerateColumns = false;
            this.dataGridViewTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.productionCompanyDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.genre1DataGridViewTextBoxColumn,
            this.productionCompany1DataGridViewTextBoxColumn});
            this.dataGridViewTitles.DataSource = this.filmBindingSource;
            this.dataGridViewTitles.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTitles.Name = "dataGridViewTitles";
            this.dataGridViewTitles.Size = new System.Drawing.Size(835, 262);
            this.dataGridViewTitles.TabIndex = 0;
            this.dataGridViewTitles.Click += new System.EventHandler(this.dataGridViewTitles_Click);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(DomowaWypozyczalnia.Film);
            // 
            // dataGridViewCast
            // 
            this.dataGridViewCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCast.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewCast.Name = "dataGridViewCast";
            this.dataGridViewCast.Size = new System.Drawing.Size(829, 235);
            this.dataGridViewCast.TabIndex = 1;
            // 
            // groupBoxCast
            // 
            this.groupBoxCast.Controls.Add(this.buttonCastEdit);
            this.groupBoxCast.Controls.Add(this.buttonAddCast);
            this.groupBoxCast.Controls.Add(this.textBox4);
            this.groupBoxCast.Controls.Add(this.dataGridViewCast);
            this.groupBoxCast.Controls.Add(this.textBox5);
            this.groupBoxCast.Controls.Add(this.textBox6);
            this.groupBoxCast.Controls.Add(this.labelActorName);
            this.groupBoxCast.Controls.Add(this.labelCountry);
            this.groupBoxCast.Controls.Add(this.labelSurname);
            this.groupBoxCast.Location = new System.Drawing.Point(12, 299);
            this.groupBoxCast.Name = "groupBoxCast";
            this.groupBoxCast.Size = new System.Drawing.Size(1148, 260);
            this.groupBoxCast.TabIndex = 2;
            this.groupBoxCast.TabStop = false;
            this.groupBoxCast.Text = "Obsada";
            // 
            // buttonCastEdit
            // 
            this.buttonCastEdit.Location = new System.Drawing.Point(1016, 224);
            this.buttonCastEdit.Name = "buttonCastEdit";
            this.buttonCastEdit.Size = new System.Drawing.Size(63, 23);
            this.buttonCastEdit.TabIndex = 16;
            this.buttonCastEdit.Text = "Edytuj";
            this.buttonCastEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddCast
            // 
            this.buttonAddCast.Location = new System.Drawing.Point(897, 224);
            this.buttonAddCast.Name = "buttonAddCast";
            this.buttonAddCast.Size = new System.Drawing.Size(76, 23);
            this.buttonAddCast.TabIndex = 15;
            this.buttonAddCast.Text = "Dodaj nowego";
            this.buttonAddCast.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(967, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(967, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(967, 79);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 20);
            this.textBox6.TabIndex = 10;
            // 
            // labelActorName
            // 
            this.labelActorName.AutoSize = true;
            this.labelActorName.Location = new System.Drawing.Point(860, 82);
            this.labelActorName.Name = "labelActorName";
            this.labelActorName.Size = new System.Drawing.Size(26, 13);
            this.labelActorName.TabIndex = 7;
            this.labelActorName.Text = "Imię";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(860, 152);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(89, 13);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Kraj pochodzenia";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(860, 117);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Nazwisko";
            // 
            // groupBoxTitles
            // 
            this.groupBoxTitles.Controls.Add(this.buttonTitleEdit);
            this.groupBoxTitles.Controls.Add(this.buttonAddTitle);
            this.groupBoxTitles.Controls.Add(this.textBox3);
            this.groupBoxTitles.Controls.Add(this.textBox2);
            this.groupBoxTitles.Controls.Add(this.textBox1);
            this.groupBoxTitles.Controls.Add(this.label2);
            this.groupBoxTitles.Controls.Add(this.label1);
            this.groupBoxTitles.Controls.Add(this.labelFilmName);
            this.groupBoxTitles.Controls.Add(this.dataGridViewTitles);
            this.groupBoxTitles.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTitles.Name = "groupBoxTitles";
            this.groupBoxTitles.Size = new System.Drawing.Size(1148, 287);
            this.groupBoxTitles.TabIndex = 3;
            this.groupBoxTitles.TabStop = false;
            this.groupBoxTitles.Text = "Tytuły";
            // 
            // buttonTitleEdit
            // 
            this.buttonTitleEdit.Location = new System.Drawing.Point(1010, 235);
            this.buttonTitleEdit.Name = "buttonTitleEdit";
            this.buttonTitleEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTitleEdit.TabIndex = 14;
            this.buttonTitleEdit.Text = "Edytuj";
            this.buttonTitleEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddTitle
            // 
            this.buttonAddTitle.Location = new System.Drawing.Point(891, 235);
            this.buttonAddTitle.Name = "buttonAddTitle";
            this.buttonAddTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTitle.TabIndex = 13;
            this.buttonAddTitle.Text = "Dodaj nowy";
            this.buttonAddTitle.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(955, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(955, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(955, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czas trwania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data produkcji";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(860, 73);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(64, 13);
            this.labelFilmName.TabIndex = 1;
            this.labelFilmName.Text = "Nazwa filmu";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Visible = false;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "Data produkcji";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            // 
            // productionCompanyDataGridViewTextBoxColumn
            // 
            this.productionCompanyDataGridViewTextBoxColumn.DataPropertyName = "ProductionCompany";
            this.productionCompanyDataGridViewTextBoxColumn.HeaderText = "ProductionCompany";
            this.productionCompanyDataGridViewTextBoxColumn.Name = "productionCompanyDataGridViewTextBoxColumn";
            this.productionCompanyDataGridViewTextBoxColumn.Visible = false;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Czas trwania";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // genre1DataGridViewTextBoxColumn
            // 
            this.genre1DataGridViewTextBoxColumn.DataPropertyName = "Genre1";
            this.genre1DataGridViewTextBoxColumn.HeaderText = "Gatunek";
            this.genre1DataGridViewTextBoxColumn.Name = "genre1DataGridViewTextBoxColumn";
            // 
            // productionCompany1DataGridViewTextBoxColumn
            // 
            this.productionCompany1DataGridViewTextBoxColumn.DataPropertyName = "ProductionCompany1";
            this.productionCompany1DataGridViewTextBoxColumn.HeaderText = "Wytwórnia";
            this.productionCompany1DataGridViewTextBoxColumn.Name = "productionCompany1DataGridViewTextBoxColumn";
            // 
            // ShowTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 569);
            this.Controls.Add(this.groupBoxTitles);
            this.Controls.Add(this.groupBoxCast);
            this.Name = "ShowTitles";
            this.Text = "Tytuły";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCast)).EndInit();
            this.groupBoxCast.ResumeLayout(false);
            this.groupBoxCast.PerformLayout();
            this.groupBoxTitles.ResumeLayout(false);
            this.groupBoxTitles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTitles;
        private System.Windows.Forms.DataGridView dataGridViewCast;
        private System.Windows.Forms.GroupBox groupBoxCast;
        private System.Windows.Forms.GroupBox groupBoxTitles;
        private System.Windows.Forms.Button buttonCastEdit;
        private System.Windows.Forms.Button buttonAddCast;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelActorName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonTitleEdit;
        private System.Windows.Forms.Button buttonAddTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionCompany1DataGridViewTextBoxColumn;
    }
}