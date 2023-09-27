namespace URUN_TAKIP
{
    partial class AYARLAR
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
            this.txt_SunucuAdı = new System.Windows.Forms.TextBox();
            this.txt_VeritabanıAdı = new System.Windows.Forms.TextBox();
            this.txt_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre;";
            // 
            // txt_SunucuAdı
            // 
            this.txt_SunucuAdı.Location = new System.Drawing.Point(340, 42);
            this.txt_SunucuAdı.Name = "txt_SunucuAdı";
            this.txt_SunucuAdı.Size = new System.Drawing.Size(276, 22);
            this.txt_SunucuAdı.TabIndex = 4;
            this.txt_SunucuAdı.TextChanged += new System.EventHandler(this.txt_SunucuAdı_TextChanged);
            // 
            // txt_VeritabanıAdı
            // 
            this.txt_VeritabanıAdı.Location = new System.Drawing.Point(340, 86);
            this.txt_VeritabanıAdı.Name = "txt_VeritabanıAdı";
            this.txt_VeritabanıAdı.Size = new System.Drawing.Size(276, 22);
            this.txt_VeritabanıAdı.TabIndex = 5;
            // 
            // txt_KullanıcıAdı
            // 
            this.txt_KullanıcıAdı.Location = new System.Drawing.Point(340, 130);
            this.txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            this.txt_KullanıcıAdı.Size = new System.Drawing.Size(276, 22);
            this.txt_KullanıcıAdı.TabIndex = 6;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(340, 179);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(276, 22);
            this.txt_Sifre.TabIndex = 7;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(158, 256);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(202, 80);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "KAYDET";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 80);
            this.button2.TabIndex = 9;
            this.button2.Text = "TEST ET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AYARLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullanıcıAdı);
            this.Controls.Add(this.txt_VeritabanıAdı);
            this.Controls.Add(this.txt_SunucuAdı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AYARLAR";
            this.Text = "AYARLAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SunucuAdı;
        private System.Windows.Forms.TextBox txt_VeritabanıAdı;
        private System.Windows.Forms.TextBox txt_KullanıcıAdı;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button2;
    }
}