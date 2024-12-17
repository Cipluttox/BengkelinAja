namespace BengkelinAja___Final_Project;
using BengkelinAja___Final_Project.Context;
using BengkelinAja___Final_Project.View;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;

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
        this.Hide();
        RegisterPengelolaBengkel HalRegistBengkel = new RegisterPengelolaBengkel();
        if (HalRegistBengkel.ShowDialog() == DialogResult.OK)
        {
            //this.Hide() ;
        }
        else
        {
            this.Show(); // Kembali ke landing page jika pendaftaran gagal/dibatalkan
        }
    }

    private void bt_RegistBengkel_Click(object sender, EventArgs e)
    {
        this.Hide();
        Register_Pelanggan halPelanggan = new Register_Pelanggan();
        if (halPelanggan.ShowDialog() == DialogResult.OK)
        {
            //this.Hide(); 
        }
        else { this.Show(); }
    }

}


