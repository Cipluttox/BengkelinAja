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
using static BengkelinAja___Final_Project.Context.BengkelContext;
using static BengkelinAja___Final_Project.View.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BengkelinAja___Final_Project.View
{
    public partial class KelolaDataBengkel_Edit_ : Form
    {
        public KelolaDataBengkel_Edit_()
        {
            InitializeComponent();
            LoadBengkelData();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                    txtAlamat.Text = row["alamat_bengkel"].ToString();
                    txtJamBuka.Text = row["jam_buka"].ToString();
                    txtJamTutup.Text = row["jam_tutup"].ToString();
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
        private void bt_simpan_Click(object sender, EventArgs e)
        {
            var bengkelContext = new BengkelContext();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaBengkel.Text) || string.IsNullOrWhiteSpace(txtAlamat.Text))
                {
                    MessageBox.Show("Nama bengkel dan alamat tidak boleh kosong.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaBengkel = txtNamaBengkel.Text;
                string alamat = txtAlamat.Text;
                string jamBuka = txtJamBuka.Text;
                string jamTutup = txtJamTutup.Text;
                string username = LoginSession.Username;
                string password = LoginSession.Password;
                int id_bengkel = LoginSession.BengkelId;

                bengkelContext.UpdateDataBengkel(id_bengkel, namaBengkel, alamat, jamBuka, jamTutup);
                bengkelContext.Deletedetail(id_bengkel);

                List<int> listLayanan = new List<int>();
                if (cbServisRutin.Checked) { listLayanan.Add(1); }
                if (cbGantiOli.Checked) { listLayanan.Add(2); }
                if (cbServisGaransi.Checked) { listLayanan.Add(3); }
                if (cbServisDarurat.Checked) { listLayanan.Add(4); }

                for (int i = 0; i < listLayanan.Count; i++) { bengkelContext.TambahLayananBengkel(id_bengkel, listLayanan[i]); }

                List<int> listKendaraan = new List<int>();
                if (cbMobil.Checked) { listKendaraan.Add(1); }
                if (cbSepedaMotor.Checked) { listKendaraan.Add(2); }
                if (cbKendaraanBesar.Checked) { listKendaraan.Add(3); }

                for (int i = 0; i < listKendaraan.Count; i++) { bengkelContext.TambahKendaraan(id_bengkel, listKendaraan[i]); }

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePageBengkel homePage = new HomePageBengkel();
                this.Close();
                homePage.Show();
            }

            catch
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            KelolaDataBengkel_View_ showData = new KelolaDataBengkel_View_();
            showData.Show();
            this.Close();
        }

        private void C3_servisGaransi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L5_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KelolaDataBengkel_Edit__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LihatJadwalServis jadwal = new LihatJadwalServis();
            jadwal.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LihatLayananAntarJemput layanan = new LihatLayananAntarJemput();
            layanan.Show();
            this.Hide();
        }
    }
}
