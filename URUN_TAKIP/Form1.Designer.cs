namespace URUN_TAKIP
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.button_UrunGor = new System.Windows.Forms.Button();
            this.button_SayimList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "SATISLAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "SAYIM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.Location = new System.Drawing.Point(414, 218);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(242, 90);
            this.button_ayarlar.TabIndex = 2;
            this.button_ayarlar.Text = "AYARLAR";
            this.button_ayarlar.UseVisualStyleBackColor = true;
            this.button_ayarlar.Click += new System.EventHandler(this.button_ayarlar_Click);
            // 
            // button_UrunGor
            // 
            this.button_UrunGor.Location = new System.Drawing.Point(98, 218);
            this.button_UrunGor.Name = "button_UrunGor";
            this.button_UrunGor.Size = new System.Drawing.Size(242, 90);
            this.button_UrunGor.TabIndex = 3;
            this.button_UrunGor.Text = "ÜRÜNLERİ GÖR";
            this.button_UrunGor.UseVisualStyleBackColor = true;
            this.button_UrunGor.Click += new System.EventHandler(this.button_UrunGor_Click);
            // 
            // button_SayimList
            // 
            this.button_SayimList.Location = new System.Drawing.Point(728, 75);
            this.button_SayimList.Name = "button_SayimList";
            this.button_SayimList.Size = new System.Drawing.Size(242, 90);
            this.button_SayimList.TabIndex = 4;
            this.button_SayimList.Text = "SAYIM LİSTESİ";
            this.button_SayimList.UseVisualStyleBackColor = true;
            this.button_SayimList.Click += new System.EventHandler(this.button_SayimList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.button_SayimList);
            this.Controls.Add(this.button_UrunGor);
            this.Controls.Add(this.button_ayarlar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ANA EKRAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_ayarlar;
        private System.Windows.Forms.Button button_UrunGor;
        private System.Windows.Forms.Button button_SayimList;
    }
}

