using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelinAja___Final_Project.View
{
    public partial class HomePagePelanggan : Form
    {
        public HomePagePelanggan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void bt_PesanBengkel_Click(object sender, EventArgs e)
        {
            this.Close();
            PemesananLayananBengkel HalPemesanan = new PemesananLayananBengkel();
            HalPemesanan.Show();
        }

        private void bt_Riwayat_Click(object sender, EventArgs e)
        {
            this.Close();
            Riwayat_Pemesanan HalRiwayat = new Riwayat_Pemesanan();
            HalRiwayat.Show();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Form1 landingPage = new Form1();
            this.Close();
            landingPage.Show();
            MessageBox.Show("Anda berhasil logout");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 landingPage = new Form1();
            this.Close();
            landingPage.Show();
            MessageBox.Show("Anda berhasil logout");
        }
    }
}
