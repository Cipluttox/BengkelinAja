using BengkelinAja.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BengkelinAja.View.Login;

namespace BengkelinAja.View
{
    public partial class KelolaDataBengkel__View_ : Form
    {
        public KelolaDataBengkel__View_()
        {
            InitializeComponent();
            LoadBengkelData();
        }

        private void KelolaDataBengkel__View__Load(object sender, EventArgs e)
        {
            LoadBengkelData(); // Memuat data ke DataGridView saat form dibuka
        }


        //private void LoadBengkelData()
        //{
        //    try
        //    {
        //        int bengkelId = LoginSession.BengkelId;

        //        var dataTable = BengkelContext.GetAllBengkel();
        //        if (dataTable != null && dataTable.Rows.Count > 0)
        //        {
        //            dataGridView1.DataSource = dataTable; 
        //            FormatGrid();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Tidak ada data untuk ditampilkan.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
        //    }
        //}

        private void LoadBengkelData()
        {
            try
            {
                // Mengambil ID bengkel dari session login
                int bengkelId = LoginSession.BengkelId;

                // Ambil data bengkel beserta layanan yang terkait dengan ID pengelola yang login
                var dataTable = BengkelContext.GetBengkelWithLayanan(bengkelId);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                    FormatGrid();
                }
                else
                {
                    MessageBox.Show("Tidak ada data untuk ditampilkan.");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
}


        private void FormatGrid()
        {
            // Atur kolom-kolom DataGridView agar lebih rapi
            dataGridView1.Columns["id_bengkel"].HeaderText = "ID Bengkel";
            dataGridView1.Columns["nama_bengkel"].HeaderText = "Nama Bengkel";
            dataGridView1.Columns["nama_pemilik"].HeaderText = "Nama Pemilik";
            dataGridView1.Columns["alamat_bengkel"].HeaderText = "Alamat";
            dataGridView1.Columns["no_telp"].HeaderText = "Telepon";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["jam_buka"].HeaderText = "Jam Buka";
            dataGridView1.Columns["jam_tutup"].HeaderText = "Jam Tutup";
            dataGridView1.Columns["layanan"].HeaderText = "Daftar Layanan"; // Kolom layanan
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void bt_edit_Click(object sender, EventArgs e)
        {
            KelolaDataBengkel__Edit_ editForm = new KelolaDataBengkel__Edit_();
            editForm.Show();
            this.Hide();
        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            HomePageBengkel homePage = new HomePageBengkel();
            homePage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
