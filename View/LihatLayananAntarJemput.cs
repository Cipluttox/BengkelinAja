using System;
using System.Data;
using System.Windows.Forms;
using BengkelinAja___Final_Project.Context;
using static BengkelinAja___Final_Project.View.Login;

namespace BengkelinAja___Final_Project.View
{
    public partial class LihatLayananAntarJemput : Form
    {
        public LihatLayananAntarJemput()
        {
            InitializeComponent();
            LoadAntarJemputData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Method untuk mengambil dan menampilkan data layanan antar jemput
        private void LoadAntarJemputData()
        {
            var pelangganContext = new PelangganContext();
            try
            {
                int id_bengkel = LoginSession.BengkelId;
                var dataTable = pelangganContext.GetLayananAntarJemput(id_bengkel);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    dataGridViewLayanan.DataSource = dataTable;
                    FormatGrid();
                }
                else
                {
                    MessageBox.Show("Tidak ada data layanan antar jemput yang tersedia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // Memformat kolom-kolom DataGridView agar lebih rapi
        private void FormatGrid()
        {
            // Menetapkan nama kolom untuk DataGridView
            dataGridViewLayanan.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
            dataGridViewLayanan.Columns["no_telp"].HeaderText = "Nomor Telepon";
            dataGridViewLayanan.Columns["alamat_penjemputan"].HeaderText = "Alamat Penjemputan";
            dataGridViewLayanan.Columns["waktu_jemput"].HeaderText = "Waktu Penjemputan";

            // Menyesuaikan lebar kolom
            dataGridViewLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bt_kembali_Click_1(object sender, EventArgs e)
        {
            HomePageBengkel homePage = new HomePageBengkel();
            this.Hide();
            homePage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelolaDataBengkel_View_ kelola = new KelolaDataBengkel_View_();
            kelola.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LihatJadwalServis jadwal = new LihatJadwalServis();
            jadwal.Show();
            this.Hide();
        }
    }
}
