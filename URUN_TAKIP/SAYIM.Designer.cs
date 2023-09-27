namespace URUN_TAKIP
{
    partial class SAYIM
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
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.txt_urunKod = new System.Windows.Forms.TextBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_ara = new System.Windows.Forms.Button();
            this.label_StokKalan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN KOD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MİKTARI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TARİH:";
            // 
            // txt_ıd
            // 
            this.txt_ıd.Location = new System.Drawing.Point(299, 81);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(206, 22);
            this.txt_ıd.TabIndex = 4;
            // 
            // txt_urunKod
            // 
            this.txt_urunKod.Location = new System.Drawing.Point(299, 127);
            this.txt_urunKod.Name = "txt_urunKod";
            this.txt_urunKod.Size = new System.Drawing.Size(206, 22);
            this.txt_urunKod.TabIndex = 5;
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(299, 169);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(206, 22);
            this.txt_miktar.TabIndex = 6;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.Location = new System.Drawing.Point(256, 279);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(314, 79);
            this.button_Kaydet.TabIndex = 8;
            this.button_Kaydet.Text = "KAYDET";
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(536, 80);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 23);
            this.button_ara.TabIndex = 10;
            this.button_ara.Text = "ARA";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // label_StokKalan
            // 
            this.label_StokKalan.AutoSize = true;
            this.label_StokKalan.Location = new System.Drawing.Point(533, 175);
            this.label_StokKalan.Name = "label_StokKalan";
            this.label_StokKalan.Size = new System.Drawing.Size(34, 16);
            this.label_StokKalan.TabIndex = 11;
            this.label_StokKalan.Text = ".........";
            // 
            // SAYIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_StokKalan);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.txt_urunKod);
            this.Controls.Add(this.txt_ıd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SAYIM";
            this.Text = "SAYIM";
            this.Load += new System.EventHandler(this.SAYIM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ıd;
        private System.Windows.Forms.TextBox txt_urunKod;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Label label_StokKalan;
    }
}