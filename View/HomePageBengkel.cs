using BengkelinAja___Final_Project.View;
using BengkelinAja___Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelinAja___Final_Project.View
{
    public partial class HomePageBengkel : Form
    {
        public HomePageBengkel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bt_KelolaData_Click(object sender, EventArgs e)
        {
            this.Close();
            KelolaDataBengkel_View_ kelolaDataBengkel = new KelolaDataBengkel_View_();
            kelolaDataBengkel.Show();
        }

        private void bt_LihatJadwalServis_Click(object sender, EventArgs e)
        {
            this.Close();
            LihatJadwalServis lihatJadwal = new LihatJadwalServis();
            lihatJadwal.Show();
        }

        private void bt_LayananAntarJemput_Click(object sender, EventArgs e)
        {
            this.Close();
            LihatLayananAntarJemput antarJemput = new LihatLayananAntarJemput();
            antarJemput.Show();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Form1 landingPage = new Form1();
            this.Close();
            landingPage.Show();
            MessageBox.Show("Anda berhasil logout");
            //Application.Exit();
        }
    }
}
