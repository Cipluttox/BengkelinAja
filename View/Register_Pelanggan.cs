using BengkelinAja___Final_Project.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BengkelinAja___Final_Project.Model;
using BengkelinAja___Final_Project.View;
using static BengkelinAja___Final_Project.Model.M_Pelanggan;

namespace BengkelinAja___Final_Project.View
{
    public partial class Register_Pelanggan : Form
    {
        public Register_Pelanggan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pelangganContext = new PelangganContext();
            string errorNama = "";
            string errorUsername = "";
            string errorPassword = "";
            string errorEmail = "";
            string errorNoTelp = "";
            string errorAlamat = "";
            bool error = false;

            if (tbpNamaLengkap.Text.Length < 5) { errorNama = " nama \n"; error = true; }
            else if (tbpUsername.Text.Length < 3) { errorUsername = "Username \n"; error = true; }
            else if (tbpPassword.Text.Length < 2) { errorPassword = "Password "; error = true; }
            else if ((tbpEmail.Text.Length < 10) || !tbpEmail.Text.EndsWith("@gmail.com")) { errorEmail = "Email \n"; error = true; }
            else if ((tbpNoTelp.Text.Length < 10)|| !long.TryParse(tbpNoTelp.Text, out _)) { errorNoTelp = "Nomor Telepon \n"; error = true; }
            else if (tbpAlamat.Text.Length < 8) { errorAlamat = "Password \n"; error = true; }
            else {  error = false; }

            ConcreteDataAkun pelangganBaru = new ConcreteDataAkun
            {
                nama_pelanggan = tbpNamaLengkap.Text,
                username_pelanggan = tbpUsername.Text,
                password_pelanggan = tbpPassword.Text,
                email_pelanggan = tbpEmail.Text,
                no_telp = tbpNoTelp.Text,
                alamat_pelanggan = tbpAlamat.Text
            };

            if (!ValidateInput())
            {
                MessageBox.Show("Inputan Tidak Valid!!!");
                return;
            }
            else if (error) { MessageBox.Show($"Data anda tidak valid! Data yang tidak valid : {errorNama}{errorUsername}{errorPassword}{errorEmail}{errorNoTelp}{errorAlamat}"); } 
            else
            {
                pelangganContext.RegisterPelanggan(pelangganBaru);
                MessageBox.Show("Berhasil register");
                this.DialogResult = DialogResult.OK;
                this.Close();

                Login login = new Login();
                login.Show();
            }
            
        }

        // Validasi input
        private bool ValidateInput()
        {
            return true;
        }
        private void tbpNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 landingpage = new Form1();
            this.Close();
            landingpage.Show();
        }
    }
}
