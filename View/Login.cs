using BengkelinAja___Final_Project.Context;
using BengkelinAja___Final_Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelinAja___Final_Project.View
{

    public partial class Login : Form
    {
        public static class LoginSession
        {
            public static int BengkelId { get; set; }
            public static int PelangganId { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; }
        }


        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void btLogin_Click(object sender, EventArgs e)
        {
            var pelangganContext = new PelangganContext();
            var bengkelContext = new BengkelContext();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool isBengkel = bengkelContext.LoginBengkel(username, password);
            bool isPelanggan = pelangganContext.LoginPelanggan(username, password);
            if (isBengkel)
            {
                LoginSession.Username = username;
                LoginSession.Password = password;
                int id_bengkel = bengkelContext.LoginBengkelGetId(username, password);
                LoginSession.BengkelId = id_bengkel;
                this.DialogResult = DialogResult.OK;
                HomePageBengkel hpBengkel = new HomePageBengkel();
                this.Hide();
                hpBengkel.Show();
                //this.DialogResult = DialogResult.OK;
            }
            else if (isPelanggan)
            {
                LoginSession.Username = username;
                LoginSession.Password = password;
                int id_pelanggan = pelangganContext.LoginPelangganGetId(username, password);
                LoginSession.PelangganId = id_pelanggan;
                this.DialogResult = DialogResult.OK;
                HomePagePelanggan hpPelanggan = new HomePagePelanggan();
                this.Hide();
                hpPelanggan.Show();
            }
            else
            {
                MessageBox.Show("Username atau password anda salah");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


