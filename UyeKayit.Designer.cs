namespace NewProject
{
    partial class UyeKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Numara";
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(350, 155);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(114, 97);
            this.Ekle.TabIndex = 5;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(154, 80);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(100, 22);
            this.kAdi.TabIndex = 6;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(154, 123);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(100, 22);
            this.Sifre.TabIndex = 7;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(154, 167);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(100, 22);
            this.Ad.TabIndex = 8;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(154, 207);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(100, 22);
            this.Soyad.TabIndex = 9;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(154, 248);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 22);
            this.Tel.TabIndex = 10;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(154, 298);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 22);
            this.Mail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail";
            // 
            // UyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 454);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyeKayit";
            this.Text = "NewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label6;
    }
}