namespace NewProject
{
    partial class SeansEkle
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
            this.SaloonBox = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaman";
            // 
            // SaloonBox
            // 
            this.SaloonBox.FormattingEnabled = true;
            this.SaloonBox.Location = new System.Drawing.Point(155, 106);
            this.SaloonBox.Name = "SaloonBox";
            this.SaloonBox.Size = new System.Drawing.Size(121, 24);
            this.SaloonBox.TabIndex = 2;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(155, 193);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 22);
            this.Time.TabIndex = 3;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(387, 120);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(110, 90);
            this.Ekle.TabIndex = 4;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 375);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.SaloonBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeansEkle";
            this.Text = "SeansEkle";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SaloonBox;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Button Ekle;
    }
}