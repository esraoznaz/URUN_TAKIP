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
using System.Collections;
using System.Net.NetworkInformation;

namespace URUN_TAKIP
{
    public partial class SAYIM_LISTESI : Form
    {
        public SAYIM_LISTESI()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter;
        DataSet ds;
        void getir()
        {
            string strconnection = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    DataTable dataTable = new DataTable();
                    adapter = new SqlDataAdapter("select URUN_KOD, count(*) as'Urun Sayısı',sum(MİKTARI) as 'Toplam Miktarı' from urun_miktarr group by URUN_KOD;", conn);
                    ds = new DataSet();
                    adapter.Fill(ds, "urun_miktarr");
                    dataGridView1.DataSource = ds.Tables["urun_miktarr"];

                }
            }
        }
        private void SAYIM_LISTESI_Load(object sender, EventArgs e)
        {
            getir();
        }
    }
}