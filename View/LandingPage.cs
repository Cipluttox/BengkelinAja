using BengkelinAja.Context;
using BengkelinAja.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BengkelinAja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login HalLogin = new Login();
            if (HalLogin.ShowDialog() == DialogResult.OK)
            {
                //this.Close();
            }
            else
            {
                this.Show();
            }

        }
        private void bt_RegistPelanggan_Click(object sender, EventArgs e)
        {
            this.Show();
            Register_Pelanggan halPelanggan = new Register_Pelanggan();
            if (halPelanggan.ShowDialog() == DialogResult.OK) { 
                //this.Close(); 
            }
            else { this.Show(); }
        }

        private void bt_RegistBengkel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPengelolaBengkel HalRegistBengkel = new RegisterPengelolaBengkel();
            if (HalRegistBengkel.ShowDialog() == DialogResult.OK)
            {
                //this.Close(); // Tutup hanya jika pendaftaran berhasil
            }
            else
            {
                this.Show(); // Kembali ke landing page jika pendaftaran gagal/dibatalkan
            }
        }

    } 
}
 

