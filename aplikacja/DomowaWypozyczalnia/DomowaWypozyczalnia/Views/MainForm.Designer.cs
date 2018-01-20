namespace DomowaWypozyczalnia
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonRoles = new System.Windows.Forms.Button();
            this.buttonContries = new System.Windows.Forms.Button();
            this.buttonCast = new System.Windows.Forms.Button();
            this.buttonAHires = new System.Windows.Forms.Button();
            this.buttonProductionCountry = new System.Windows.Forms.Button();
            this.buttonLocations = new System.Windows.Forms.Button();
            this.buttonLocationTypes = new System.Windows.Forms.Button();
            this.buttonAFilms = new System.Windows.Forms.Button();
            this.buttonGenres = new System.Windows.Forms.Button();
            this.buttonCarries = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonATitles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.buttonWishList = new System.Windows.Forms.Button();
            this.buttonUHires = new System.Windows.Forms.Button();
            this.buttonUFilms = new System.Windows.Forms.Button();
            this.buttonUTitles = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.użytkownikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńDaneToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // zmieńDaneToolStripMenuItem
            // 
            this.zmieńDaneToolStripMenuItem.Name = "zmieńDaneToolStripMenuItem";
            this.zmieńDaneToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.zmieńDaneToolStripMenuItem.Text = "Zmień dane logowania";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.buttonRoles);
            this.panelAdmin.Controls.Add(this.buttonContries);
            this.panelAdmin.Controls.Add(this.buttonCast);
            this.panelAdmin.Controls.Add(this.buttonAHires);
            this.panelAdmin.Controls.Add(this.buttonProductionCountry);
            this.panelAdmin.Controls.Add(this.buttonLocations);
            this.panelAdmin.Controls.Add(this.buttonLocationTypes);
            this.panelAdmin.Controls.Add(this.buttonAFilms);
            this.panelAdmin.Controls.Add(this.buttonGenres);
            this.panelAdmin.Controls.Add(this.buttonCarries);
            this.panelAdmin.Controls.Add(this.buttonUsers);
            this.panelAdmin.Controls.Add(this.buttonATitles);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.labelAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(12, 27);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(641, 381);
            this.panelAdmin.TabIndex = 1;
            this.panelAdmin.Visible = false;
            // 
            // buttonRoles
            // 
            this.buttonRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRoles.Location = new System.Drawing.Point(412, 266);
            this.buttonRoles.Name = "buttonRoles";
            this.buttonRoles.Size = new System.Drawing.Size(172, 67);
            this.buttonRoles.TabIndex = 27;
            this.buttonRoles.Text = "Role";
            this.buttonRoles.UseVisualStyleBackColor = true;
            // 
            // buttonContries
            // 
            this.buttonContries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonContries.Location = new System.Drawing.Point(234, 266);
            this.buttonContries.Name = "buttonContries";
            this.buttonContries.Size = new System.Drawing.Size(172, 67);
            this.buttonContries.TabIndex = 26;
            this.buttonContries.Text = "Państwo";
            this.buttonContries.UseVisualStyleBackColor = true;
            // 
            // buttonCast
            // 
            this.buttonCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCast.Location = new System.Drawing.Point(56, 266);
            this.buttonCast.Name = "buttonCast";
            this.buttonCast.Size = new System.Drawing.Size(172, 67);
            this.buttonCast.TabIndex = 25;
            this.buttonCast.Text = "Obsada";
            this.buttonCast.UseVisualStyleBackColor = true;
            // 
            // buttonAHires
            // 
            this.buttonAHires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAHires.Location = new System.Drawing.Point(56, 193);
            this.buttonAHires.Name = "buttonAHires";
            this.buttonAHires.Size = new System.Drawing.Size(172, 67);
            this.buttonAHires.TabIndex = 24;
            this.buttonAHires.Text = "Wypożyczenia";
            this.buttonAHires.UseVisualStyleBackColor = true;
            // 
            // buttonProductionCountry
            // 
            this.buttonProductionCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProductionCountry.Location = new System.Drawing.Point(234, 193);
            this.buttonProductionCountry.Name = "buttonProductionCountry";
            this.buttonProductionCountry.Size = new System.Drawing.Size(172, 67);
            this.buttonProductionCountry.TabIndex = 23;
            this.buttonProductionCountry.Text = "Kraj produkcji";
            this.buttonProductionCountry.UseVisualStyleBackColor = true;
            // 
            // buttonLocations
            // 
            this.buttonLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLocations.Location = new System.Drawing.Point(412, 193);
            this.buttonLocations.Name = "buttonLocations";
            this.buttonLocations.Size = new System.Drawing.Size(172, 67);
            this.buttonLocations.TabIndex = 22;
            this.buttonLocations.Text = "Lokalizacja";
            this.buttonLocations.UseVisualStyleBackColor = true;
            // 
            // buttonLocationTypes
            // 
            this.buttonLocationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLocationTypes.Location = new System.Drawing.Point(412, 120);
            this.buttonLocationTypes.Name = "buttonLocationTypes";
            this.buttonLocationTypes.Size = new System.Drawing.Size(172, 67);
            this.buttonLocationTypes.TabIndex = 21;
            this.buttonLocationTypes.Text = "Typy lokalizacji";
            this.buttonLocationTypes.UseVisualStyleBackColor = true;
            // 
            // buttonAFilms
            // 
            this.buttonAFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAFilms.Location = new System.Drawing.Point(234, 120);
            this.buttonAFilms.Name = "buttonAFilms";
            this.buttonAFilms.Size = new System.Drawing.Size(172, 67);
            this.buttonAFilms.TabIndex = 20;
            this.buttonAFilms.Text = "Filmy (egzemplarze)";
            this.buttonAFilms.UseVisualStyleBackColor = true;
            // 
            // buttonGenres
            // 
            this.buttonGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenres.Location = new System.Drawing.Point(56, 120);
            this.buttonGenres.Name = "buttonGenres";
            this.buttonGenres.Size = new System.Drawing.Size(172, 67);
            this.buttonGenres.TabIndex = 19;
            this.buttonGenres.Text = "Gatunki";
            this.buttonGenres.UseVisualStyleBackColor = true;
            // 
            // buttonCarries
            // 
            this.buttonCarries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCarries.Location = new System.Drawing.Point(412, 47);
            this.buttonCarries.Name = "buttonCarries";
            this.buttonCarries.Size = new System.Drawing.Size(172, 67);
            this.buttonCarries.TabIndex = 18;
            this.buttonCarries.Text = "Nośniki";
            this.buttonCarries.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsers.Location = new System.Drawing.Point(234, 47);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(172, 67);
            this.buttonUsers.TabIndex = 17;
            this.buttonUsers.Text = "Użytkownicy";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonATitles
            // 
            this.buttonATitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonATitles.Location = new System.Drawing.Point(56, 47);
            this.buttonATitles.Name = "buttonATitles";
            this.buttonATitles.Size = new System.Drawing.Size(172, 67);
            this.buttonATitles.TabIndex = 16;
            this.buttonATitles.Text = "Tytuły filmów";
            this.buttonATitles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdmin.Location = new System.Drawing.Point(13, 12);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(129, 24);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Administrator: ";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.buttonWishList);
            this.panelUser.Controls.Add(this.buttonUHires);
            this.panelUser.Controls.Add(this.buttonUFilms);
            this.panelUser.Controls.Add(this.buttonUTitles);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(12, 27);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(641, 381);
            this.panelUser.TabIndex = 2;
            this.panelUser.Visible = false;
            // 
            // buttonWishList
            // 
            this.buttonWishList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWishList.Location = new System.Drawing.Point(323, 193);
            this.buttonWishList.Name = "buttonWishList";
            this.buttonWishList.Size = new System.Drawing.Size(172, 67);
            this.buttonWishList.TabIndex = 31;
            this.buttonWishList.Text = "Lista życzeń";
            this.buttonWishList.UseVisualStyleBackColor = true;
            // 
            // buttonUHires
            // 
            this.buttonUHires.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUHires.Location = new System.Drawing.Point(145, 193);
            this.buttonUHires.Name = "buttonUHires";
            this.buttonUHires.Size = new System.Drawing.Size(172, 67);
            this.buttonUHires.TabIndex = 30;
            this.buttonUHires.Text = "Wypożyczenia";
            this.buttonUHires.UseVisualStyleBackColor = true;
            // 
            // buttonUFilms
            // 
            this.buttonUFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUFilms.Location = new System.Drawing.Point(323, 120);
            this.buttonUFilms.Name = "buttonUFilms";
            this.buttonUFilms.Size = new System.Drawing.Size(172, 67);
            this.buttonUFilms.TabIndex = 29;
            this.buttonUFilms.Text = "Filmy (egzemplarze)";
            this.buttonUFilms.UseVisualStyleBackColor = true;
            // 
            // buttonUTitles
            // 
            this.buttonUTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUTitles.Location = new System.Drawing.Point(145, 120);
            this.buttonUTitles.Name = "buttonUTitles";
            this.buttonUTitles.Size = new System.Drawing.Size(172, 67);
            this.buttonUTitles.TabIndex = 28;
            this.buttonUTitles.Text = "Tytuły filmów";
            this.buttonUTitles.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUser.Location = new System.Drawing.Point(13, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(113, 24);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Użytkownik: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelAdmin);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Domowa Wypożyczalnia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńDaneToolStripMenuItem;
        private System.Windows.Forms.Button buttonRoles;
        private System.Windows.Forms.Button buttonContries;
        private System.Windows.Forms.Button buttonCast;
        private System.Windows.Forms.Button buttonAHires;
        private System.Windows.Forms.Button buttonProductionCountry;
        private System.Windows.Forms.Button buttonLocations;
        private System.Windows.Forms.Button buttonLocationTypes;
        private System.Windows.Forms.Button buttonAFilms;
        private System.Windows.Forms.Button buttonGenres;
        private System.Windows.Forms.Button buttonCarries;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonATitles;
        private System.Windows.Forms.Button buttonWishList;
        private System.Windows.Forms.Button buttonUHires;
        private System.Windows.Forms.Button buttonUFilms;
        private System.Windows.Forms.Button buttonUTitles;
    }
}