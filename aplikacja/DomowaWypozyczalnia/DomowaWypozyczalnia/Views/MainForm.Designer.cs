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
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zmieńDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
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
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.button13);
            this.panelAdmin.Controls.Add(this.button12);
            this.panelAdmin.Controls.Add(this.button11);
            this.panelAdmin.Controls.Add(this.button10);
            this.panelAdmin.Controls.Add(this.button9);
            this.panelAdmin.Controls.Add(this.button8);
            this.panelAdmin.Controls.Add(this.button7);
            this.panelAdmin.Controls.Add(this.button6);
            this.panelAdmin.Controls.Add(this.button5);
            this.panelAdmin.Controls.Add(this.button4);
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.button2);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.labelAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(12, 27);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(641, 381);
            this.panelAdmin.TabIndex = 1;
            this.panelAdmin.Visible = false;
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
            this.panelUser.Controls.Add(this.button14);
            this.panelUser.Controls.Add(this.button17);
            this.panelUser.Controls.Add(this.button21);
            this.panelUser.Controls.Add(this.button25);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(12, 27);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(641, 381);
            this.panelUser.TabIndex = 2;
            this.panelUser.Visible = false;
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
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńDaneToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(412, 266);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 67);
            this.button13.TabIndex = 27;
            this.button13.Text = "Role";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(234, 266);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 67);
            this.button12.TabIndex = 26;
            this.button12.Text = "Państwo";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(56, 266);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 67);
            this.button11.TabIndex = 25;
            this.button11.Text = "Obsada";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(56, 193);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(172, 67);
            this.button10.TabIndex = 24;
            this.button10.Text = "Wypożyczenia";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(234, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 67);
            this.button9.TabIndex = 23;
            this.button9.Text = "Kraj produkcji";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(412, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 67);
            this.button8.TabIndex = 22;
            this.button8.Text = "Lokalizacja";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(412, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 67);
            this.button7.TabIndex = 21;
            this.button7.Text = "Typy lokalizacji";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(234, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 67);
            this.button6.TabIndex = 20;
            this.button6.Text = "Filmy (egzemplarze)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(56, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 67);
            this.button5.TabIndex = 19;
            this.button5.Text = "Gatunki";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(412, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 67);
            this.button4.TabIndex = 18;
            this.button4.Text = "Nośniki";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(234, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 67);
            this.button3.TabIndex = 17;
            this.button3.Text = "Użytkownicy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(56, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 67);
            this.button2.TabIndex = 16;
            this.button2.Text = "Tytuły filmów";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // zmieńDaneToolStripMenuItem
            // 
            this.zmieńDaneToolStripMenuItem.Name = "zmieńDaneToolStripMenuItem";
            this.zmieńDaneToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.zmieńDaneToolStripMenuItem.Text = "Zmień dane logowania";
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(323, 193);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 67);
            this.button14.TabIndex = 31;
            this.button14.Text = "Lista życzeń";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(145, 193);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(172, 67);
            this.button17.TabIndex = 30;
            this.button17.Text = "Wypożyczenia";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.Location = new System.Drawing.Point(323, 120);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(172, 67);
            this.button21.TabIndex = 29;
            this.button21.Text = "Filmy (egzemplarze)";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.Location = new System.Drawing.Point(145, 120);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(172, 67);
            this.button25.TabIndex = 28;
            this.button25.Text = "Tytuły filmów";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelUser);
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
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button25;
    }
}