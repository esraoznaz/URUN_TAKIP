using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URUN_TAKIP
{
    public partial class SATISLAR : Form
    {
        public SATISLAR()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string Id;
        public string UrunKod;
        public string Kategori;
        public string Marka;
        public string Stok;
        public string AlısFiyat;
        public string SatisFiyat;
        
        private void SATISLAR_Load(object sender, EventArgs e)
        {
            txt_Id.Text = Id;
            txt_UrunKod.Text = UrunKod;
            txt_kategori.Text = Kategori;
            txt_Marka.Text = Marka;
            txt_AlisFiyati.Text = AlısFiyat;
            txt_SatisFiyati.Text = SatisFiyat;
        }
       

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            string strgconnection = "Data Source = LAPTOP-3H9G77VD\\SQLEXPRESS; Initial Catalog = deneme; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(strgconnection))
            {
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO stok_takipp(ID,URUN_KOD, KATEGORI, MARKA, ALIS_FIYATI, SATIS_FIYATI, SATILAN, STOK_KALAN) VALUES (@ID, @URUN_KOD, @KATEGORİ, @MARKA, @ALIS_FIYATI, @SATIS_FIYATI, 0, 0)", conn);
                    
                    
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_Id.Text));
                    cmd.Parameters.AddWithValue("@URUN_KOD", txt_UrunKod.Text);
                    cmd.Parameters.AddWithValue("@KATEGORİ", txt_kategori.Text);
                    cmd.Parameters.AddWithValue("@MARKA", txt_Marka.Text);
                    cmd.Parameters.AddWithValue("@ALIS_FIYATI", Convert.ToInt32(txt_AlisFiyati.Text));
                    cmd.Parameters.AddWithValue("@SATIS_FIYATI", Convert.ToInt32(txt_SatisFiyati.Text));
                    txt_Id.Clear();
                    txt_UrunKod.Clear();
                    txt_kategori.Clear(); 
                    txt_Marka.Clear();  
                    txt_AlisFiyati.Clear();
                    txt_SatisFiyati.Clear();
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kaydetme İşilemi Tamamlandı");
                    }
                    else
                    {
                        MessageBox.Show("Kaydetme İşleminde Bir Sorun Oluştu");
                    }
                    
                }

                else
                {
                    MessageBox.Show("Veritabanına Bağlantı Başarısız.");
                }
            } 
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            string strconnetion = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            
            float AlisFiyati;
            float SatisFiyati;
            
            if(!float.TryParse(txt_AlisFiyati.Text,out AlisFiyati))
            {
                MessageBox.Show("Sayısal Bir Değer girin");
                return;

            }
            if(!float.TryParse(txt_SatisFiyati.Text ,out SatisFiyati))
            {
                MessageBox.Show("Sayısal Bir Değer girin");
                return;
            }
            
            using (SqlConnection conn =new SqlConnection(strconnetion))
            {
                conn.Open();
                string guncelle = "UPDATE stok_takipp SET URUN_KOD=@UrunKod, KATEGORI=@Kategori, MARKA=@Marka, ALIS_FIYATI=@AlisFiyati, SATIS_FIYATI=@SatisFiyati WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(guncelle, conn);
                cmd.Parameters.AddWithValue("@UrunKod", txt_UrunKod.Text);
                cmd.Parameters.AddWithValue("@Kategori", txt_kategori.Text);
                cmd.Parameters.AddWithValue("@Marka", txt_Marka.Text);
                cmd.Parameters.AddWithValue("@AlisFiyati", txt_AlisFiyati.Text);
                cmd.Parameters.AddWithValue("@SatisFiyati", txt_SatisFiyati.Text);
                cmd.Parameters.AddWithValue("@Id",txt_Id.Text);
               
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Güncelleme İşilemi Tamamlandı.");
                }
                else
                {
                    MessageBox.Show("ID Değerine Güncelleme İşlemi Yapılmaz. ");
                }
                conn.Close();
                
            }
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
