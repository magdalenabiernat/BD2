namespace DomowaWypozyczalnia
{
    partial class AddInmate : AddSingleProperty
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
            this.textBoxAddInmate = new System.Windows.Forms.TextBox();
            this.buttonAddInmate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddInmate
            // 
            this.textBoxAddInmate.Location = new System.Drawing.Point(12, 12);
            this.textBoxAddInmate.Name = "textBoxAddInmate";
            this.textBoxAddInmate.Size = new System.Drawing.Size(233, 22);
            this.textBoxAddInmate.TabIndex = 0;
            // 
            // buttonAddInmate
            // 
            this.buttonAddInmate.Location = new System.Drawing.Point(269, 12);
            this.buttonAddInmate.Name = "buttonAddInmate";
            this.buttonAddInmate.Size = new System.Drawing.Size(79, 31);
            this.buttonAddInmate.TabIndex = 1;
            this.buttonAddInmate.Text = "dodaj";
            this.buttonAddInmate.UseVisualStyleBackColor = true;
            this.buttonAddInmate.Click += new System.EventHandler(this.buttonAddInmate_Click);
            // 
            // AddInmate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 169);
            this.Controls.Add(this.buttonAddInmate);
            this.Controls.Add(this.textBoxAddInmate);
            this.Name = "AddInmate";
            this.Text = "AddInmate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddInmate;
        private System.Windows.Forms.Button buttonAddInmate;
    }
}