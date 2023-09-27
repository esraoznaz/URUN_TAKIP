using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using static URUN_TAKIP.AYARLAR;

namespace URUN_TAKIP
{
    public partial class AYARLAR : Form
    {
        public AYARLAR()
        {
            InitializeComponent();
            txt_SunucuAdı.Text = "SQLEXPRESS";
            txt_VeritabanıAdı.Text = "deneme";
            txt_KullanıcıAdı.Text = "LAPTOP-3H9G77VD";
            txt_Sifre.Text = "1";
            //INIKaydet ini = new INIKaydet(Application.StartupPath + @"\KAYDET01.ini");
            //txt_SunucuAdı.Text = ini.Oku("Sunucu Bilgileri", "Sunucu Adı");
            //txt_VeritabanıAdı.Text = ini.Oku("Veritabanı Bilgileri", "Veritabanı Adı");
            //txt_KullanıcıAdı.Text = ini.Oku("Kullanıcı Bilgileri", "Kullanıcıadı");
            //txt_Sifre.Text = ini.Oku("Şifre Bilgileri", "Şifre");
            //ReadSettings();
            //LoadSettings();
        }
        private void ReadSettings()
        {
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\KAYDET01.ini");
            txt_SunucuAdı.Text = ini.Oku("Sunucu Bilgileri", "Sunucu Adı");
            txt_VeritabanıAdı.Text = ini.Oku("Veritabanı Bilgileri", "Veritabanı Adı");
            txt_KullanıcıAdı.Text = ini.Oku("Kullanıcı Bilgileri", "Kullanıcıadı");
            txt_Sifre.Text = ini.Oku("Şifre Bilgileri", "Şifre");
        }
        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfilString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = string.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfilString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }


        void Test_Et()
        {
            if (txt_KullanıcıAdı.Text == "" || txt_Sifre.Text == "" || txt_SunucuAdı.Text == "" || txt_VeritabanıAdı.Text == "")
            {
                MessageBox.Show("Kullanıcı Bilgilerini Eksiksiz Girin.");
            }
            else
            {
                string strgcoonection = "Data Source=" + txt_KullanıcıAdı.Text + "\\" + txt_SunucuAdı.Text + ";Initial Catalog=" + txt_VeritabanıAdı.Text + ";Integrated Security=True";
                using (SqlConnection con = new SqlConnection(strgcoonection))
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Veritabanına Bağlantı Başarılı.");
                    }

                    else
                    {
                        MessageBox.Show("Veritabanına Bağlantı Başarısız.");
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test_Et();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\KAYDET01.ini");
            ini.Yaz("Sunucu Bilgileri", "Sunucu Adı", txt_SunucuAdı.Text);
            ini.Yaz("Veritabanı Bilgileri", "Veritabanı Adı", txt_VeritabanıAdı.Text);
            ini.Yaz("Kullanıcı Bilgileri", "Kullanıcıadı", txt_KullanıcıAdı.Text);
            ini.Yaz("Şifre Bilgileri", "Şifre", txt_Sifre.Text);
            MessageBox.Show("Bilgileriniz Kaydedildi.");
        }
        private void LoadSettings()
        {
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\KAYDET01.ini");
            txt_SunucuAdı.Text = ini.Oku("Sunucu Bilgileri", "Sunucu Adı");
            txt_VeritabanıAdı.Text = ini.Oku("Veritabanı Bilgileri", "Veritabanı Adı");
            txt_KullanıcıAdı.Text = ini.Oku("Kullanıcı Bilgileri", "Kullanıcıadı");
            txt_Sifre.Text = ini.Oku("Şifre Bilgileri", "Şifre");
        }

        private void txt_SunucuAdı_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

