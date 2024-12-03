using BengkelinAja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BengkelinAja.Context.BengkelContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BengkelinAja.View
{
    public partial class KelolaDataBengkel__Edit_ : Form
    {
        public KelolaDataBengkel__Edit_()
        {
            InitializeComponent();
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Nama bengkel dan alamat tidak boleh kosong.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaBengkel = textBox1.Text;
            string alamat = textBox2.Text;
            string jamBuka = textBox3.Text;
            string jamTutup = textBox4.Text;

            bool servisRutin = L1_Pengelola.Checked;
            bool gantiOli = L2_Pengelola.Checked;
            bool servisGaransi = L3_Pengelola.Checked;
            bool servisDarurat = L5_Pengelola.Checked;

            bool isSuccess = BengkelController.UpdateDataBengkel(namaBengkel, servisRutin, gantiOli, servisGaransi, servisDarurat, alamat, jamBuka, jamTutup);

            if (isSuccess)
            {
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            KelolaDataBengkel__View_ showData = new KelolaDataBengkel__View_();
            showData.Show();
            this.Close();
        }

        private void C3_servisGaransi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void L5_Pengelola_CheckedChanged(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> df18044dd7e3840d9a7ec8475b567e884b7181c8
    }
}
