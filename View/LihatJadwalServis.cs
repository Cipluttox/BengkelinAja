using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BengkelinAja___Final_Project.Context;
using static BengkelinAja___Final_Project.View.Login;

namespace BengkelinAja___Final_Project.View
{
    public partial class LihatJadwalServis : Form
    {
        public LihatJadwalServis()
        {
            InitializeComponent();
            LoadJadwalServis();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadJadwalServis()
        {
            var pelangganContext = new PelangganContext();
            try
            {
                int id_bengkel = LoginSession.BengkelId;

                // Ambil data jadwal servis yang terkait dengan ID pelanggan
                var dataTable = pelangganContext.GetJadwalServis(id_bengkel);


                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Mengisi DataGridView dengan data jadwal servis
                    dataGridViewServis.DataSource = dataTable;
                    FormatGrid();
                }
                else
                {
                    MessageBox.Show("Tidak ada jadwal servis yang tersedia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            // Menetapkan nama kolom untuk DataGridView
            dataGridViewServis.Columns["waktu_transaksi"].HeaderText = "Waktu Transaksi";
            dataGridViewServis.Columns["waktu_servis"].HeaderText = "Waktu Servis";
            dataGridViewServis.Columns["nama_layanan"].HeaderText = "Nama Layanan";
            dataGridViewServis.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
            dataGridViewServis.Columns["no_telp"].HeaderText = "Nomor Telepon";
            dataGridViewServis.Columns["alamat_penjemputan"].HeaderText = "Alamat Penjemputan";
            dataGridViewServis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Tombol Kembali untuk kembali ke halaman utama pelanggan
        private void bt_kembali_Click(object sender, EventArgs e)
        {
            LihatLayananAntarJemput layanan = new LihatLayananAntarJemput();
            layanan.Show();
            this.Hide();
        }

        private void dataGridViewServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_kembali_Click_1(object sender, EventArgs e)
        {
            HomePageBengkel homePage = new HomePageBengkel();
            this.Hide();
            homePage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaDataBengkel_View_ kelola = new KelolaDataBengkel_View_();
            kelola.Show();
            this.Hide();
        }
    }
}
