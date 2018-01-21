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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionCompany1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCast = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxCast = new System.Windows.Forms.GroupBox();
            this.buttonCastEdit = new System.Windows.Forms.Button();
            this.buttonAddCast = new System.Windows.Forms.Button();
            this.textBoxCharacter = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.labelActorName = new System.Windows.Forms.Label();
            this.labelCharacter = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.groupBoxTitles = new System.Windows.Forms.GroupBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonTitleEdit = new System.Windows.Forms.Button();
            this.buttonAddTitle = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxProductionDate = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castBindingSource)).BeginInit();
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
            this.dataGridViewTitles.Size = new System.Drawing.Size(829, 262);
            this.dataGridViewTitles.TabIndex = 0;
            this.dataGridViewTitles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTitles_RowEnter);
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
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(DomowaWypozyczalnia.Film);
            // 
            // dataGridViewCast
            // 
            this.dataGridViewCast.AutoGenerateColumns = false;
            this.dataGridViewCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.person1DataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.role1DataGridViewTextBoxColumn,
            this.characterDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.film1DataGridViewTextBoxColumn});
            this.dataGridViewCast.DataSource = this.castBindingSource;
            this.dataGridViewCast.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewCast.Name = "dataGridViewCast";
            this.dataGridViewCast.Size = new System.Drawing.Size(829, 231);
            this.dataGridViewCast.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // person1DataGridViewTextBoxColumn
            // 
            this.person1DataGridViewTextBoxColumn.DataPropertyName = "Person1";
            this.person1DataGridViewTextBoxColumn.HeaderText = "Osoba";
            this.person1DataGridViewTextBoxColumn.Name = "person1DataGridViewTextBoxColumn";
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.Visible = false;
            // 
            // role1DataGridViewTextBoxColumn
            // 
            this.role1DataGridViewTextBoxColumn.DataPropertyName = "Role1";
            this.role1DataGridViewTextBoxColumn.HeaderText = "Rola";
            this.role1DataGridViewTextBoxColumn.Name = "role1DataGridViewTextBoxColumn";
            // 
            // characterDataGridViewTextBoxColumn
            // 
            this.characterDataGridViewTextBoxColumn.DataPropertyName = "Character";
            this.characterDataGridViewTextBoxColumn.HeaderText = "Postać";
            this.characterDataGridViewTextBoxColumn.Name = "characterDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Rola";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "Film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "Film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            this.filmDataGridViewTextBoxColumn.Visible = false;
            // 
            // film1DataGridViewTextBoxColumn
            // 
            this.film1DataGridViewTextBoxColumn.DataPropertyName = "Film1";
            this.film1DataGridViewTextBoxColumn.HeaderText = "Film1";
            this.film1DataGridViewTextBoxColumn.Name = "film1DataGridViewTextBoxColumn";
            this.film1DataGridViewTextBoxColumn.Visible = false;
            // 
            // castBindingSource
            // 
            this.castBindingSource.DataSource = typeof(DomowaWypozyczalnia.Cast);
            // 
            // groupBoxCast
            // 
            this.groupBoxCast.Controls.Add(this.button2);
            this.groupBoxCast.Controls.Add(this.buttonCastEdit);
            this.groupBoxCast.Controls.Add(this.buttonAddCast);
            this.groupBoxCast.Controls.Add(this.textBoxCharacter);
            this.groupBoxCast.Controls.Add(this.dataGridViewCast);
            this.groupBoxCast.Controls.Add(this.textBoxRole);
            this.groupBoxCast.Controls.Add(this.textBoxPerson);
            this.groupBoxCast.Controls.Add(this.labelActorName);
            this.groupBoxCast.Controls.Add(this.labelCharacter);
            this.groupBoxCast.Controls.Add(this.labelRole);
            this.groupBoxCast.Location = new System.Drawing.Point(12, 299);
            this.groupBoxCast.Name = "groupBoxCast";
            this.groupBoxCast.Size = new System.Drawing.Size(1148, 260);
            this.groupBoxCast.TabIndex = 2;
            this.groupBoxCast.TabStop = false;
            this.groupBoxCast.Text = "Obsada";
            // 
            // buttonCastEdit
            // 
            this.buttonCastEdit.Location = new System.Drawing.Point(959, 206);
            this.buttonCastEdit.Name = "buttonCastEdit";
            this.buttonCastEdit.Size = new System.Drawing.Size(74, 23);
            this.buttonCastEdit.TabIndex = 16;
            this.buttonCastEdit.Text = "Edytuj";
            this.buttonCastEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddCast
            // 
            this.buttonAddCast.Location = new System.Drawing.Point(877, 206);
            this.buttonAddCast.Name = "buttonAddCast";
            this.buttonAddCast.Size = new System.Drawing.Size(76, 23);
            this.buttonAddCast.TabIndex = 15;
            this.buttonAddCast.Text = "Dodaj nowego";
            this.buttonAddCast.UseVisualStyleBackColor = true;
            // 
            // textBoxCharacter
            // 
            this.textBoxCharacter.Enabled = false;
            this.textBoxCharacter.Location = new System.Drawing.Point(955, 149);
            this.textBoxCharacter.Name = "textBoxCharacter";
            this.textBoxCharacter.Size = new System.Drawing.Size(167, 20);
            this.textBoxCharacter.TabIndex = 12;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Enabled = false;
            this.textBoxRole.Location = new System.Drawing.Point(955, 114);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(167, 20);
            this.textBoxRole.TabIndex = 11;
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Enabled = false;
            this.textBoxPerson.Location = new System.Drawing.Point(955, 79);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(167, 20);
            this.textBoxPerson.TabIndex = 10;
            // 
            // labelActorName
            // 
            this.labelActorName.AutoSize = true;
            this.labelActorName.Location = new System.Drawing.Point(860, 82);
            this.labelActorName.Name = "labelActorName";
            this.labelActorName.Size = new System.Drawing.Size(38, 13);
            this.labelActorName.TabIndex = 7;
            this.labelActorName.Text = "Osoba";
            // 
            // labelCharacter
            // 
            this.labelCharacter.AutoSize = true;
            this.labelCharacter.Location = new System.Drawing.Point(860, 152);
            this.labelCharacter.Name = "labelCharacter";
            this.labelCharacter.Size = new System.Drawing.Size(40, 13);
            this.labelCharacter.TabIndex = 9;
            this.labelCharacter.Text = "Postać";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(860, 117);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Rola";
            // 
            // groupBoxTitles
            // 
            this.groupBoxTitles.Controls.Add(this.button1);
            this.groupBoxTitles.Controls.Add(this.textBoxCompany);
            this.groupBoxTitles.Controls.Add(this.textBoxGenre);
            this.groupBoxTitles.Controls.Add(this.labelCompany);
            this.groupBoxTitles.Controls.Add(this.labelGenre);
            this.groupBoxTitles.Controls.Add(this.buttonTitleEdit);
            this.groupBoxTitles.Controls.Add(this.buttonAddTitle);
            this.groupBoxTitles.Controls.Add(this.textBoxDuration);
            this.groupBoxTitles.Controls.Add(this.textBoxProductionDate);
            this.groupBoxTitles.Controls.Add(this.textBoxName);
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
            // textBoxCompany
            // 
            this.textBoxCompany.Enabled = false;
            this.textBoxCompany.Location = new System.Drawing.Point(955, 183);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(167, 20);
            this.textBoxCompany.TabIndex = 18;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Enabled = false;
            this.textBoxGenre.Location = new System.Drawing.Point(955, 148);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(167, 20);
            this.textBoxGenre.TabIndex = 17;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(860, 186);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(57, 13);
            this.labelCompany.TabIndex = 16;
            this.labelCompany.Text = "Wytwórnia";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(860, 151);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 13);
            this.labelGenre.TabIndex = 15;
            this.labelGenre.Text = "Gatunek";
            // 
            // buttonTitleEdit
            // 
            this.buttonTitleEdit.Location = new System.Drawing.Point(958, 234);
            this.buttonTitleEdit.Name = "buttonTitleEdit";
            this.buttonTitleEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTitleEdit.TabIndex = 14;
            this.buttonTitleEdit.Text = "Edytuj";
            this.buttonTitleEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddTitle
            // 
            this.buttonAddTitle.Location = new System.Drawing.Point(877, 234);
            this.buttonAddTitle.Name = "buttonAddTitle";
            this.buttonAddTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTitle.TabIndex = 13;
            this.buttonAddTitle.Text = "Dodaj nowy";
            this.buttonAddTitle.UseVisualStyleBackColor = true;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Enabled = false;
            this.textBoxDuration.Location = new System.Drawing.Point(955, 110);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(167, 20);
            this.textBoxDuration.TabIndex = 6;
            // 
            // textBoxProductionDate
            // 
            this.textBoxProductionDate.Enabled = false;
            this.textBoxProductionDate.Location = new System.Drawing.Point(955, 75);
            this.textBoxProductionDate.Name = "textBoxProductionDate";
            this.textBoxProductionDate.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductionDate.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(955, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Czas trwania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data produkcji";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(860, 43);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(64, 13);
            this.labelFilmName.TabIndex = 1;
            this.labelFilmName.Text = "Nazwa filmu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1039, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1039, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.castBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxCharacter;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Label labelActorName;
        private System.Windows.Forms.Label labelCharacter;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonTitleEdit;
        private System.Windows.Forms.Button buttonAddTitle;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxProductionDate;
        private System.Windows.Forms.TextBox textBoxName;
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
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn person1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn role1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn film1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource castBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}