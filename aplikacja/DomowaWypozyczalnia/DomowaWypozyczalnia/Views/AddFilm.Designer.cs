namespace DomowaWypozyczalnia.Views
{
    partial class AddFilm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxProductionCompany = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelProductionDate = new System.Windows.Forms.Label();
            this.labelProductionCompany = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.dateTimePickerProductionDate = new System.Windows.Forms.DateTimePicker();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(251, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxProductionCompany
            // 
            this.textBoxProductionCompany.Location = new System.Drawing.Point(251, 157);
            this.textBoxProductionCompany.Name = "textBoxProductionCompany";
            this.textBoxProductionCompany.Size = new System.Drawing.Size(252, 22);
            this.textBoxProductionCompany.TabIndex = 3;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(251, 185);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(252, 22);
            this.textBoxDuration.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(140, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Tytuł";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(140, 101);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(62, 17);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Gatunek";
            // 
            // labelProductionDate
            // 
            this.labelProductionDate.AutoSize = true;
            this.labelProductionDate.Location = new System.Drawing.Point(140, 129);
            this.labelProductionDate.Name = "labelProductionDate";
            this.labelProductionDate.Size = new System.Drawing.Size(99, 17);
            this.labelProductionDate.TabIndex = 7;
            this.labelProductionDate.Text = "Data produkcji";
            // 
            // labelProductionCompany
            // 
            this.labelProductionCompany.AutoSize = true;
            this.labelProductionCompany.Location = new System.Drawing.Point(140, 157);
            this.labelProductionCompany.Name = "labelProductionCompany";
            this.labelProductionCompany.Size = new System.Drawing.Size(71, 17);
            this.labelProductionCompany.TabIndex = 8;
            this.labelProductionCompany.Text = "Produkcja";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(140, 185);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(59, 17);
            this.labelDuration.TabIndex = 9;
            this.labelDuration.Text = "Długość";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(251, 101);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(252, 24);
            this.comboBoxGenre.TabIndex = 10;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(282, 226);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFilm.TabIndex = 11;
            this.buttonAddFilm.Text = "dodaj";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(251, 129);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerProductionDate.TabIndex = 12;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(363, 226);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Location = new System.Drawing.Point(12, 306);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.Size = new System.Drawing.Size(602, 150);
            this.dataGridViewFilms.TabIndex = 14;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 468);
            this.Controls.Add(this.dataGridViewFilms);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dateTimePickerProductionDate);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelProductionCompany);
            this.Controls.Add(this.labelProductionDate);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxProductionCompany);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddFilm";
            this.Text = "AddFilm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxProductionCompany;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelProductionDate;
        private System.Windows.Forms.Label labelProductionCompany;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductionDate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
    }
}