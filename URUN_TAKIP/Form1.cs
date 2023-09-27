using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URUN_TAKIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button_ayarlar_Click(object sender, EventArgs e)
        {
            AYARLAR ayarlar = new AYARLAR();
            ayarlar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SATISLAR satis = new SATISLAR();
            satis.Show();
        }

        private void button_UrunGor_Click(object sender, EventArgs e)
        {
            URUNLER urunler = new URUNLER();
            urunler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SAYIM sayım = new SAYIM();
            sayım.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_SayimList_Click(object sender, EventArgs e)
        {
            SAYIM_LISTESI sayım_listesi = new SAYIM_LISTESI();
            sayım_listesi.Show();
        }
    }
}
