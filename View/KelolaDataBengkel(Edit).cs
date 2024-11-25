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
            string namaBengkel = textBox1.Text;
            string alamat = textBox2.Text;
            string jamBuka = textBox3.Text;
            string jamTutup = textBox4.Text;

            bool servisRutin = C1_servisRutin.Checked;
            bool gantiOli = C2_gantiOli.Checked;
            bool servisGaransi = C3_servisGaransi.Checked;
            bool servisDarurat = C4_servisDarurat.Checked;

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
    }
}
