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
    public partial class SAYIM_URUNLER : Form
    {
        public SAYIM_URUNLER()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter;
        DataSet ds;
        void urun_gor()
        {
            string strconnection = "Data Source=LAPTOP-3H9G77VD\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    DataTable dataTable = new DataTable();
                    adapter = new SqlDataAdapter("SELECT * FROM urun_miktarr", conn);
                    ds = new DataSet();
                    adapter.Fill(ds, "urun_miktarr");
                    dataGridView1.DataSource = ds.Tables["urun_miktarr"];

                }
            }
        }
        private void SAYIM_URUNLER_Load(object sender, EventArgs e)
        {
            urun_gor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
