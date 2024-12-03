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

namespace BengkelinAja.View
{
    public partial class KelolaDataBengkel__View_ : Form
    {
        public KelolaDataBengkel__View_()
        {
            InitializeComponent();
            //this.Load += KelolaDataBengkel__View__Load;
            //this.Load += new System.EventHandler(this.KelolaDataBengkel__View__Load);
            LoadBengkelData();
        }

        private void KelolaDataBengkel__View__Load(object sender, EventArgs e)
        {
            LoadBengkelData(); // Memuat data ke DataGridView saat form dibuka
        }


        private void LoadBengkelData()
        {
            try
            {
                var dataTable = BengkelContext.GetBengkelWithLayanan();
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable; // Asumsikan nama DataGridView adalah dataGridView1
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
            dataGridView1.Columns["ID Bengkel"].HeaderText = "ID Bengkel";
            dataGridView1.Columns["Nama Bengkel"].HeaderText = "Nama Bengkel";
            dataGridView1.Columns["Nama Pemilik"].HeaderText = "Nama Pemilik";
            dataGridView1.Columns["Alamat Bengkel"].HeaderText = "Alamat";
            dataGridView1.Columns["No. Telepon"].HeaderText = "Telepon";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Jam Buka"].HeaderText = "Jam Buka";
            dataGridView1.Columns["Jam Tutup"].HeaderText = "Jam Tutup";
            dataGridView1.Columns["Layanan"].HeaderText = "Daftar Layanan";
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
