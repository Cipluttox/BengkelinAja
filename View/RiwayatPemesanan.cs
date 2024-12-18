using BengkelinAja___Final_Project.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BengkelinAja___Final_Project.View.Login;

namespace BengkelinAja___Final_Project.View
{
    public partial class Riwayat_Pemesanan : Form
    {
        public Riwayat_Pemesanan()
        {
            InitializeComponent();
            LoadBengkelData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadBengkelData()
        {
            var pelangganContext = new PelangganContext();

            try
            {
                string username = LoginSession.Username;
                string password = LoginSession.Password;
                pelangganContext.LoginPelangganGetId(username, password);
                int id_pelanggan = LoginSession.PelangganId;
                var dataTable = pelangganContext.RiwayatPemesanan(id_pelanggan);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    FormatGrid();
                }
                else
                {
                    MessageBox.Show($"Kamu belum pernah melakukan pesanan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void FormatGrid()
        {
            dataGridView1.Columns["waktu_transaksi"].HeaderText = "Waktu Transaksi";
            dataGridView1.Columns["waktu_servis"].HeaderText = "Waktu Servis";
            dataGridView1.Columns["nama_layanan"].HeaderText = "Jenis Layanan";
            dataGridView1.Columns["waktu_jemput"].HeaderText = "Waktu penjemputan";
            dataGridView1.Columns["alamat_penjemputan"].HeaderText = "Alamat Penjemputan";
            dataGridView1.Columns["jenis_kendaraan"].HeaderText = "Jenis Kendaraan";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePagePelanggan homePagePelanggan = new HomePagePelanggan();
            this.Close();
            homePagePelanggan.Show();
        }
    }
}
