using BengkelinAja___Final_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BengkelinAja___Final_Project.View.PopupBengkel;
using static BengkelinAja___Final_Project.Model.M_Pelanggan;
using static BengkelinAja___Final_Project.View.Login;
using System.Net.NetworkInformation;
using BengkelinAja___Final_Project.Context;

namespace BengkelinAja___Final_Project.View
{
    public partial class PemesananLayananBengkel : Form
    {
        public static class TransaksiSession
        {
            public static int id_layanan { get; set; }
            public static int id_kendaraan { get; set; }
        }
        public PemesananLayananBengkel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void bt_Pesan_Click(object sender, EventArgs e)
        {
            int id_Bengkel = BengkelInitialization.id_bengkel;
            var pelangganContext = new PelangganContext();
            if (cb_JenisKendaraan.Text.Length == 0 ||
                cb_JenisLayanan.Text.Length == 0 || id_Bengkel == 0)
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "Anda yakin ingin memesan?",
                "Konfirmasi Pesanan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool AntarJemput = false;
                        DateTime waktuServis = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;
                        TimeOnly waktuJemput = TimeOnly.FromDateTime(dt_JamJemput.Value);
                        int id_Layanan = TransaksiSession.id_layanan;
                        int id_Kendaraan = TransaksiSession.id_kendaraan;
                        int id_transaksi = pelangganContext.GetLastTransaksiId();
                        int id_pelanggan = LoginSession.PelangganId;

                        M_Pelanggan.detail_transaksi newDetail = new ConcreteDetailTransaksi
                        {
                            id_bengkel = id_Bengkel,
                            id_pelanggan = id_pelanggan,
                            id_transaksi = id_transaksi
                        };

                        if (ch_AntarJemput.Checked)
                        {
                            AntarJemput = true;
                            M_Pelanggan.Transaksi TransaksiAnjem = new ConcreteTransaksi
                            {
                                waktu_transaksi = DateTime.Now,
                                waktu_servis = waktuServis,
                                is_antar_jemput = AntarJemput,
                                waktu_jemput = waktuJemput,
                                alamat_penjemputan = tb_alamat.Text,
                                id_kendaraan = id_Kendaraan,
                                id_layanan = id_Layanan
                            };
                            pelangganContext.InsertTransaksiAntarJemput(TransaksiAnjem);
                            pelangganContext.InsertDetailTransaksi(newDetail);
                        }
                        else
                        {
                            M_Pelanggan.Transaksi TransaksiNonAnjem = new ConcreteTransaksi
                            {
                                waktu_transaksi = DateTime.Now,
                                waktu_servis = waktuServis,
                                is_antar_jemput = AntarJemput,
                                id_kendaraan = id_Kendaraan,
                                id_layanan = id_Layanan
                            };
                            pelangganContext.InsertTransaksiNonAntarJemput(TransaksiNonAnjem);
                            pelangganContext.InsertDetailTransaksi(newDetail);
                        }

                        MessageBox.Show("Yay! Pesanan berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        HomePagePelanggan HalHomePage = new HomePagePelanggan();
                        HalHomePage.Show();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat melakukan transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Pesanan dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    HomePagePelanggan Homepage = new HomePagePelanggan();
                    Homepage.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_kendaraan = 0;
            int id_layanan = 0;
            bool lengkap = true;
            if (cb_JenisKendaraan.Text == "Mobil") { id_kendaraan = 1; }
            else if (cb_JenisKendaraan.Text == "Sepeda Motor") { id_kendaraan = 2; }
            else if (cb_JenisKendaraan.Text == "Truk") { id_kendaraan = 3; }
            else { lengkap = false; }

            if (cb_JenisLayanan.Text == "Servis Rutin") { id_layanan = 1; }
            else if (cb_JenisLayanan.Text == "Ganti Oli") { id_layanan = 2; }
            else if (cb_JenisLayanan.Text == "Servis Garansi") { id_layanan = 3; }
            else if (cb_JenisLayanan.Text == "Servis Darurat") { id_layanan = 4; }
            else { lengkap = false; }

            TransaksiSession.id_kendaraan = id_kendaraan;
            TransaksiSession.id_layanan = id_layanan;

            if (id_kendaraan == 0 || id_layanan == 0)
            {
                MessageBox.Show("Pilihan bengkel/layanan anda tidak valid. Pilih yang tersedia");
            }
            else
            {
                PopupBengkel popupBengkel = new PopupBengkel();
                if (popupBengkel.ShowDialog() == DialogResult.OK)
                {
                    label4.Text = popupBengkel.SelectedBengkel;
                }
            }
        }

        private void bt_Batal_Click(object sender, EventArgs e)
        {
            HomePagePelanggan homePagePelanggan = new HomePagePelanggan();
            this.Close();
            homePagePelanggan.Show();
        }

        private void PemesananLayananBengkel_Load(object sender, EventArgs e)
        {

        }
    }
}
