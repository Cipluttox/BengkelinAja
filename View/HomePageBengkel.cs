using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelinAja.View
{
    public partial class HomePageBengkel : Form
    {
        public HomePageBengkel()
        {
            InitializeComponent();
        }

        private void bt_KelolaData_Click(object sender, EventArgs e)
        {
            this.Close();
            KelolaDataBengkel__View_ kelolaDataBengkel = new KelolaDataBengkel__View_();
            kelolaDataBengkel.Show();
        }

        private void bt_LihatJadwalServis_Click(object sender, EventArgs e)
        {
            this.Close();
            LihatJadwalServis lihatJadwal = new LihatJadwalServis();
            lihatJadwal.Show();
        }

        private void bt_LayananAntarJemput_Click(object sender, EventArgs e)
        {
            this.Close();
            LihatLayananAntarJemput antarJemput = new LihatLayananAntarJemput();
            antarJemput.Show();
        }

        private void bt_KonfirmBayar_Click(object sender, EventArgs e)
        {
            this.Close();
            Konfirmasi_pembayaran konfirmBayara = new Konfirmasi_pembayaran();
            konfirmBayara.Show();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda berhasil keluar dari aplikasi");
            this.Close();
            Form1 landingPage = new Form1();
            landingPage.Show();
        }
    }
}
