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

            M_Pelanggan.dataAkun pelangganBaru = new M_Pelanggan.dataAkun
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
            else
            {
                pelangganContext.RegisterPelanggan(pelangganBaru);
                MessageBox.Show("Berhasil register");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

            Login login = new Login();
            login.Show();
        }

        // Validasi input
        private bool ValidateInput()
        {
            return true;
        }
        private void tbpNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
