﻿using BengkelinAja.Context;
using BengkelinAja.Model;
using static BengkelinAja.Model.M_Bengkel;

namespace BengkelinAja.View
{
    public partial class RegisterPengelolaBengkel : Form
    {
        public RegisterPengelolaBengkel()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan Tidak Valid!!!");
                return;
            }

            try
            {
                M_Bengkel.DataBengkel pengelolaBaru = new M_Bengkel.DataBengkel
                {
                    nama_bengkel = NB_Pengelola.Text,
                    nama_pemilik = NP_Pengelola.Text,
                    alamat_pemilik = AP_Pengelola.Text,
                    username = US_Pengelola.Text,
                    password = PW_Pengelola.Text,
                    email = E_Pengelola.Text,
                    no_telp = NT_Pengelola.Text,
                    alamat_bengkel = AB_Pengelola.Text,
                    jam_buka = TimeOnly.Parse(JB_Pengelola.Text),
                    jam_tutup = TimeOnly.Parse(JT_Pengelola.Text),
                    Layanans = new List<layanan>()
                };

                if (L1_Pengelola.Checked)
                    pengelolaBaru.Layanans.Add(new layanan { id_layanan = 1 }); // ID layanan sesuai dengan data di database
                if (L2_Pengelola.Checked)
                    pengelolaBaru.Layanans.Add(new layanan { id_layanan = 2 });
                if (L3_Pengelola.Checked)
                    pengelolaBaru.Layanans.Add(new layanan { id_layanan = 3 });
                if (L5_Pengelola.Checked)
                    pengelolaBaru.Layanans.Add(new layanan { id_layanan = 5 });

                BengkelContext.RegisterPengelola(pengelolaBaru);


                //this.DialogResult = DialogResult.OK;
                //this.Hide();
                MessageBox.Show("Berhasil register");
                //HomePageBengkel daftarPengelola = new HomePageBengkel();
                //daftarPengelola.Show();

                var kelolaDataForm = new KelolaDataBengkel__View_();
                kelolaDataForm.Show();
                this.Close(); // Menutup form register
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format jam buka/tutup tidak valid. Gunakan format HH:mm. " + ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mendaftarkan pengelola baru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(NB_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(NP_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(AP_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(US_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(PW_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(E_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(AB_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(JB_Pengelola.Text) ||
                string.IsNullOrWhiteSpace(JT_Pengelola.Text))
            {
                MessageBox.Show("Semua field harus diisi!");
                return false;
            }

            return true;
        }

        private void L_Pengelola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NB_Pengelola_TextChanged(object sender, EventArgs e)
        {

        }

        private void L2_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L5_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L1_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L3_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JT_Pengelola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
