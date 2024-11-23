using BengkelinAja.Context;
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

namespace BengkelinAja.View
{

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        public void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool isBengkel = BengkelContext.LoginBengkel(username, password);
            bool isPelanggan = PelangganContext.LoginPelanggan(username, password);
            if (isBengkel)
            {
                this.Hide();
                HomePageBengkel hpBengkel = new HomePageBengkel();
                hpBengkel.Show();
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            else if (isPelanggan)
            {
                this.Hide();
                this .DialogResult = DialogResult.OK;
                HomePage_Pelanggan hpPelanggan = new HomePage_Pelanggan();
                hpPelanggan.Show();
            }
            else 
            {
                MessageBox.Show("Username atau password anda salah");
            }
        }
    }
}
