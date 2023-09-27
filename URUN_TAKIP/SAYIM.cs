using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace URUN_TAKIP
{
    public partial class SAYIM : Form
    {
        public SAYIM()
        {
            InitializeComponent();
        }
        // burda girdiğim miktar stok_takipp den stok kalanı arttırsın.
        
        private void button_Kaydet_Click(object sender, EventArgs e)
        {

            string strconnetion = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using(SqlConnection conn = new SqlConnection(strconnetion))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO urun_miktarr(ID, URUN_KOD, MİKTARI, TARIH) VALUES (@ID, @URUN_KOD, @MIKTAR, @TARIH)", conn);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_ıd.Text));
                    cmd.Parameters.AddWithValue("@URUN_KOD", txt_urunKod.Text);
                    cmd.Parameters.AddWithValue("@MIKTAR", txt_miktar.Text);
                    cmd.Parameters.AddWithValue("@TARIH", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    txt_ıd.Clear();
                    txt_urunKod.Clear();
                    txt_miktar.Clear();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kaydetme İşilemi Tamamlandı");
                        SAYIM_URUNLER sayım_urunler = new SAYIM_URUNLER();
                        sayım_urunler.Show();
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
            int miktar;
            int stok_kalan;
            int sonuc;
            //SqlCommand komut = new SqlCommand("SELECT STOK_KALAN FROM stok_takipp WHERE ID=@Id", con);
            stok_kalan = Convert.ToInt32(label_StokKalan.Text);
            //miktar=Convert.ToInt32(txt_miktar.Text) ;
            // sayı ve değerleri topla
            sonuc =  stok_kalan + Convert.ToInt32(txt_miktar.Text);
  
        }


        private void SAYIM_Load(object sender, EventArgs e)
        {
           
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            string strconnection = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID,URUN_KOD, KATEGORI, MARKA, ALIS_FIYATI, SATIS_FIYATI, SATILAN, STOK_KALAN FROM stok_takipp WHERE ID LIKE'%" + txt_ıd.Text + "%'", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txt_ıd.Text = rdr["ID"].ToString();
                    txt_urunKod.Text= rdr["URUN_KOD"].ToString();
                    label_StokKalan.Text = rdr["STOK_KALAN"].ToString();
                }
                conn.Close();
            }
        }
    }
}
