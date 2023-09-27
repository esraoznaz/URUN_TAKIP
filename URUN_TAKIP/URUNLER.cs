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

namespace URUN_TAKIP
{
    public partial class URUNLER : Form
    {
        public URUNLER()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        void urun_getir()
        {
            string strconnection = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using(SqlConnection conn=new SqlConnection(strconnection))
            {
                conn.Open();
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    DataTable dataTable = new DataTable();
                    adapter = new SqlDataAdapter("SELECT * FROM stok_takipp",conn);
                    ds= new DataSet();
                    adapter.Fill(ds,"stok_takipp");
                    dataGridView1.DataSource = ds.Tables["stok_takipp"];

                }
            }
        }
        void kayıt_sil( int ID)
        {
            string strconnection = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {                    
                    string sql = "DELETE FROM stok_takipp WHERE @ID=ID";
                    string sql1 = "DELETE FROM urun_miktarr WHERE @ID=ıd";
                    SqlCommand komut =new SqlCommand(sql1,conn);
                    komut.Parameters.AddWithValue("ıd", ID);
                    komut.ExecuteNonQuery();    
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ID", ID);
                    cmd.ExecuteNonQuery();
                }
            }
            
        }

        private void button_SatirSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                kayıt_sil(ID);
            }
            urun_getir();
        }

        private void URUNLER_Load(object sender, EventArgs e)
        {
            urun_getir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_Tası_Click(object sender, EventArgs e)
        {
            SATISLAR st = new SATISLAR();
            st.Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            st.UrunKod = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            st.Kategori = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            st.Marka= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            st.Stok= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            st.AlısFiyat= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            st.SatisFiyat = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            st.Show();
        }
    }
}
