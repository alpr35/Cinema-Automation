namespace NewProject
{
    partial class KullanıcıMenu
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
            this.FilmArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmArama
            // 
            this.FilmArama.Location = new System.Drawing.Point(161, 93);
            this.FilmArama.Name = "FilmArama";
            this.FilmArama.Size = new System.Drawing.Size(180, 173);
            this.FilmArama.TabIndex = 0;
            this.FilmArama.Text = "Film Ara\r\nVe Görüntüle";
            this.FilmArama.UseVisualStyleBackColor = true;
            this.FilmArama.Click += new System.EventHandler(this.FilmArama_Click);
            // 
            // KullanıcıMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 389);
            this.Controls.Add(this.FilmArama);
            this.Name = "KullanıcıMenu";
            this.Text = "KullanıcıMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilmArama;
    }
}