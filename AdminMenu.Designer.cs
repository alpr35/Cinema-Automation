namespace NewProject
{
    partial class AdminMenu
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
            this.KullaniciEkle = new System.Windows.Forms.Button();
            this.SlnEkle = new System.Windows.Forms.Button();
            this.FlmEkle = new System.Windows.Forms.Button();
            this.seansEkle = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciEkle
            // 
            this.KullaniciEkle.Location = new System.Drawing.Point(117, 68);
            this.KullaniciEkle.Name = "KullaniciEkle";
            this.KullaniciEkle.Size = new System.Drawing.Size(97, 97);
            this.KullaniciEkle.TabIndex = 0;
            this.KullaniciEkle.Text = "Kullanıcı Ekle";
            this.KullaniciEkle.UseVisualStyleBackColor = true;
            this.KullaniciEkle.Click += new System.EventHandler(this.KullaniciEkle_Click);
            // 
            // SlnEkle
            // 
            this.SlnEkle.Location = new System.Drawing.Point(209, 68);
            this.SlnEkle.Name = "SlnEkle";
            this.SlnEkle.Size = new System.Drawing.Size(102, 97);
            this.SlnEkle.TabIndex = 1;
            this.SlnEkle.Text = "Salon Ekle";
            this.SlnEkle.UseVisualStyleBackColor = true;
            this.SlnEkle.Click += new System.EventHandler(this.SlnEkle_Click);
            // 
            // FlmEkle
            // 
            this.FlmEkle.Location = new System.Drawing.Point(117, 162);
            this.FlmEkle.Name = "FlmEkle";
            this.FlmEkle.Size = new System.Drawing.Size(97, 88);
            this.FlmEkle.TabIndex = 2;
            this.FlmEkle.Text = "Film Ekle";
            this.FlmEkle.UseVisualStyleBackColor = true;
            this.FlmEkle.Click += new System.EventHandler(this.FlmEkle_Click);
            // 
            // seansEkle
            // 
            this.seansEkle.Location = new System.Drawing.Point(209, 162);
            this.seansEkle.Name = "seansEkle";
            this.seansEkle.Size = new System.Drawing.Size(102, 88);
            this.seansEkle.TabIndex = 3;
            this.seansEkle.Text = "Seans Ekle";
            this.seansEkle.UseVisualStyleBackColor = true;
            this.seansEkle.Click += new System.EventHandler(this.seansEkle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(117, 247);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(97, 83);
            this.Guncelle.TabIndex = 4;
            this.Guncelle.Text = "Guncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.seansEkle);
            this.Controls.Add(this.FlmEkle);
            this.Controls.Add(this.SlnEkle);
            this.Controls.Add(this.KullaniciEkle);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KullaniciEkle;
        private System.Windows.Forms.Button SlnEkle;
        private System.Windows.Forms.Button FlmEkle;
        private System.Windows.Forms.Button seansEkle;
        private System.Windows.Forms.Button Guncelle;
    }
}