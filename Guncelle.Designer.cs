namespace NewProject
{
    partial class Guncelle
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
            this.flmguncel = new System.Windows.Forms.Button();
            this.Salongnclle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flmguncel
            // 
            this.flmguncel.Location = new System.Drawing.Point(93, 132);
            this.flmguncel.Name = "flmguncel";
            this.flmguncel.Size = new System.Drawing.Size(117, 96);
            this.flmguncel.TabIndex = 0;
            this.flmguncel.Text = "Film Güncelle";
            this.flmguncel.UseVisualStyleBackColor = true;
            this.flmguncel.Click += new System.EventHandler(this.flmguncel_Click);
            // 
            // Salongnclle
            // 
            this.Salongnclle.Location = new System.Drawing.Point(206, 132);
            this.Salongnclle.Name = "Salongnclle";
            this.Salongnclle.Size = new System.Drawing.Size(123, 96);
            this.Salongnclle.TabIndex = 1;
            this.Salongnclle.Text = "Salon Güncelle";
            this.Salongnclle.UseVisualStyleBackColor = true;
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 359);
            this.Controls.Add(this.Salongnclle);
            this.Controls.Add(this.flmguncel);
            this.Name = "Guncelle";
            this.Text = "Guncelle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flmguncel;
        private System.Windows.Forms.Button Salongnclle;
    }
}