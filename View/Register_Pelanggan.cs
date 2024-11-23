using BengkelinAja.Context;
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
using BengkelinAja.Model;

namespace BengkelinAja.View
{
    public partial class Register_Pelanggan : Form
    {   
        public Register_Pelanggan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
                PelangganContext.RegisterPelanggan(pelangganBaru);
                MessageBox.Show("Berhasil register");
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();

            HomePage_Pelanggan hpPelanggan = new HomePage_Pelanggan();
            hpPelanggan.Show();
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
