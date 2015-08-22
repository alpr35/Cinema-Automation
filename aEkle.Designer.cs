namespace NewProject
{
    partial class aEkle
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Adı = new System.Windows.Forms.TextBox();
            this.Soyadı = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.YetkiBox = new System.Windows.Forms.ComboBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetki Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-Mail";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(116, 60);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(100, 22);
            this.kAdi.TabIndex = 7;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(116, 96);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(100, 22);
            this.Sifre.TabIndex = 8;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(116, 275);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 22);
            this.Mail.TabIndex = 9;
            // 
            // Adı
            // 
            this.Adı.Location = new System.Drawing.Point(116, 169);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(100, 22);
            this.Adı.TabIndex = 10;
            // 
            // Soyadı
            // 
            this.Soyadı.Location = new System.Drawing.Point(116, 201);
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.Size = new System.Drawing.Size(100, 22);
            this.Soyadı.TabIndex = 11;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(116, 240);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 22);
            this.Tel.TabIndex = 12;
            // 
            // YetkiBox
            // 
            this.YetkiBox.FormattingEnabled = true;
            this.YetkiBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.YetkiBox.Location = new System.Drawing.Point(116, 132);
            this.YetkiBox.Name = "YetkiBox";
            this.YetkiBox.Size = new System.Drawing.Size(121, 24);
            this.YetkiBox.TabIndex = 13;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(378, 138);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(135, 119);
            this.Ekle.TabIndex = 14;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // aEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 373);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.YetkiBox);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Soyadı);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "aEkle";
            this.Text = "aEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Adı;
        private System.Windows.Forms.TextBox Soyadı;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.ComboBox YetkiBox;
        private System.Windows.Forms.Button Ekle;
    }
}