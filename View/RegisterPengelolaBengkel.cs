using BengkelinAja.Context;
using BengkelinAja.Model;

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
                    jam_tutup = TimeOnly.Parse(JT_Pengelola.Text)
                };

                BengkelContext.RegisterPengelola(pengelolaBaru);
                

                this.DialogResult = DialogResult.OK;
                this.Hide();

                HomePageBengkel daftarPengelola = new HomePageBengkel();
                daftarPengelola.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format jam buka/tutup tidak valid. Gunakan format HH:mm.");
            }
            MessageBox.Show("Berhasil register");
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
    }
}
