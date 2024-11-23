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
            Register_Pelanggan halPesanan = new Register_Pelanggan();
            halPesanan.Show();
            this.Hide();
        }

        private void bt_RegistBengkel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPengelolaBengkel HalRegistBengkel = new RegisterPengelolaBengkel();
            HalRegistBengkel.ShowDialog();
            this.Close();
        }

    } 
}
 

