using BengkelinAja___Final_Project.Context;
using BengkelinAja___Final_Project.Model;
using BengkelinAja___Final_Project.View;
using static BengkelinAja___Final_Project.Model.M_Bengkel;
using static BengkelinAja___Final_Project.View.Login;

namespace BengkelinAja___Final_Project.View
{
    public partial class RegisterPengelolaBengkel : Form
    {

        public RegisterPengelolaBengkel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PAdd_Click(object sender, EventArgs e)
        {
            if ((!ValidateInput()) ||
                !E_Pengelola.Text.EndsWith("@gmail.com") ||
                !long.TryParse(NT_Pengelola.Text, out _))

            {
                MessageBox.Show("Inputan Tidak Valid!!!");
                return;
            }

            try
            {
                M_Bengkel.DataBengkel pengelolaBaru = new ConcreteDataBengkel
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

                string username = US_Pengelola.Text;
                string password = PW_Pengelola.Text;

                var bengkelContext = new BengkelContext();

                bengkelContext.RegisterPengelola(pengelolaBaru);
                int id_bengkel = bengkelContext.LoginBengkelGetId(username, password);

                List<int> listLayanan = new List<int>();
                int adaLayanan = 0;
                if (L1_ServisRutin.Checked) { listLayanan.Add(1); adaLayanan += 1; }
                if (L2_GantiOli.Checked) { listLayanan.Add(2); adaLayanan += 1; }
                if (L3_ServisGaransi.Checked) { listLayanan.Add(3); adaLayanan += 1; }
                if (L5_ServisDarurat.Checked) { listLayanan.Add(4); adaLayanan += 1; }

                for (int i = 0; i < listLayanan.Count; i++) { bengkelContext.TambahLayananBengkel(id_bengkel, listLayanan[i]); }

                List<int> listKendaraan = new List<int>();
                int adaKendaraan = 0;
                if (cb_mobil.Checked) { listKendaraan.Add(1); adaKendaraan += 1; }
                if (cb_SepedaMotor.Checked) { listKendaraan.Add(2); adaKendaraan += 1; }
                if (cb_KendaraanBesar.Checked) { listKendaraan.Add(3); adaKendaraan += 1; }

                for (int i = 0; i < listKendaraan.Count; i++) { bengkelContext.TambahKendaraan(id_bengkel, listKendaraan[i]); }
                if (adaKendaraan < 1 || adaLayanan <1)
                {
                    MessageBox.Show("Pilih layanan/kendaraan minimal 1");
                }
                else {
                    MessageBox.Show("Berhasil register");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    Login login = new Login();
                    login.Show();
                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NP_Pengelola_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void JT_Pengelola_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            Form1 landingpage = new Form1();
            this.Close();
            landingpage.Show();
        }
    }
}
