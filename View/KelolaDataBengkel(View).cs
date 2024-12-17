using BengkelinAja___Final_Project.Context;
using BengkelinAja___Final_Project.Model;
using BengkelinAja___Final_Project.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BengkelinAja___Final_Project.View
{
    public partial class KelolaDataBengkel_View_ : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int BengkelId { get; set; }

        public KelolaDataBengkel_View_()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBengkelData();

        }

        private void LoadBengkelData()
        {
            var bengkelContext = new BengkelContext();
            try
            {
                int BengkelId = LoginSession.BengkelId;
                DataTable dt = bengkelContext.GetBengkelByPengelola(BengkelId);
                DataTable layananTable = bengkelContext.GetDataLayanan(BengkelId);
                DataTable kendaraanTable = bengkelContext.GetDataKendaraan(BengkelId);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNamaBengkel.Text = row["nama_bengkel"].ToString();
                    txtNamaBengkel.Enabled = false;
                    txtAlamat.Text = row["alamat_bengkel"].ToString();
                    txtAlamat.Enabled = false;
                    txtJamBuka.Text = row["jam_buka"].ToString();
                    txtJamBuka.Enabled = false;
                    txtJamTutup.Text = row["jam_tutup"].ToString();
                    txtJamTutup.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan.");
                }

                if (layananTable != null)
                {
                    // Reset semua checkbox
                    cbServisRutin.Checked = false;
                    cbServisGaransi.Checked = false;
                    cbGantiOli.Checked = false;
                    cbServisDarurat.Checked = false;

                    // Centang checkbox sesuai layanan
                    foreach (DataRow row in layananTable.Rows)
                    {
                        string namaLayanan = row["nama_layanan"].ToString();

                        if (namaLayanan == "Servis Rutin")
                        {
                            cbServisRutin.Checked = true;
                        };
                        if (namaLayanan == "Servis Garansi")
                        {
                            cbServisGaransi.Checked = true;
                        };
                        if (namaLayanan == "Ganti Oli")
                        {
                            cbGantiOli.Checked = true;
                        };
                        if (namaLayanan == "Servis Darurat")
                        {
                            cbServisDarurat.Checked = true;
                        };

                        cbServisRutin.Enabled = false;
                        cbServisGaransi.Enabled = false;
                        cbGantiOli.Enabled = false;
                        cbServisDarurat.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada layanan yang tersedia untuk bengkel ini.");
                }

                if (kendaraanTable != null)
                {
                    // Reset semua checkbox
                    cbMobil.Checked = false;
                    cbSepedaMotor.Checked = false;
                    cbKendaraanBesar.Checked = false;

                    // Centang checkbox sesuai kendaraan
                    foreach (DataRow row in kendaraanTable.Rows)
                    {
                        string namaKendaraan = row["jenis_kendaraan"].ToString();

                        if (namaKendaraan == "Mobil") cbMobil.Checked = true;
                        if (namaKendaraan == "Sepeda Motor") cbSepedaMotor.Checked = true;
                        if (namaKendaraan == "Kendaraan Besar") cbKendaraanBesar.Checked = true;

                        cbMobil.Enabled = false;
                        cbSepedaMotor.Enabled = false;
                        cbKendaraanBesar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada kendaraan yang ditangani untuk bengkel ini.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }



        private void bt_edit_Click(object sender, EventArgs e)
        {
            LihatJadwalServis jadwal = new LihatJadwalServis();
            jadwal.Show();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void L3_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L1_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            KelolaDataBengkel_Edit_ EditDataBengkel = new KelolaDataBengkel_Edit_();
            this.Close();
            EditDataBengkel.Show();
        }

        private void bt_kembali_Click_1(object sender, EventArgs e)
        {
            HomePageBengkel HalUtama = new HomePageBengkel();
            this.Close();
            HalUtama.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LihatLayananAntarJemput layanan = new LihatLayananAntarJemput();
            layanan.Show();
            this.Hide();
        }
    }

}
