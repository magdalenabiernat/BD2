namespace DomowaWypozyczalnia
{
    partial class AddGenre : AddSingleProperty
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
            this.textBoxAddGenre = new System.Windows.Forms.TextBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddGenre
            // 
            this.textBoxAddGenre.Location = new System.Drawing.Point(12, 12);
            this.textBoxAddGenre.Name = "textBoxAddGenre";
            this.textBoxAddGenre.Size = new System.Drawing.Size(247, 22);
            this.textBoxAddGenre.TabIndex = 0;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(265, 12);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGenre.TabIndex = 1;
            this.buttonAddGenre.Text = "dodaj";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 139);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxAddGenre);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddGenre;
        private System.Windows.Forms.Button buttonAddGenre;
    }
}