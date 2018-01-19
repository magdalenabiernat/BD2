namespace DomowaWypozyczalnia
{
    partial class AddCountry : AddSingleProperty
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
            this.textBoxAddCountry = new System.Windows.Forms.TextBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddCountry
            // 
            this.textBoxAddCountry.Location = new System.Drawing.Point(12, 12);
            this.textBoxAddCountry.Name = "textBoxAddCountry";
            this.textBoxAddCountry.Size = new System.Drawing.Size(283, 22);
            this.textBoxAddCountry.TabIndex = 0;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(301, 12);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCountry.TabIndex = 1;
            this.buttonAddCountry.Text = "dodaj";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 92);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.textBoxAddCountry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCountry";
            this.Text = "Dodaj państwo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddCountry;
        private System.Windows.Forms.Button buttonAddCountry;
    }
}