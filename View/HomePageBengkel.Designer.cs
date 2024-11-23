namespace BengkelinAja.View
{
    partial class HomePageBengkel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageBengkel));
            pictureBox1 = new PictureBox();
            bt_KelolaData = new Button();
            bt_LihatJadwalServis = new Button();
            bt_LayananAntarJemput = new Button();
            bt_KonfirmBayar = new Button();
            bt_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 474);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_KelolaData
            // 
            bt_KelolaData.BackColor = Color.DarkOrange;
            bt_KelolaData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_KelolaData.ForeColor = Color.White;
            bt_KelolaData.Location = new Point(211, 154);
            bt_KelolaData.Name = "bt_KelolaData";
            bt_KelolaData.Size = new Size(399, 52);
            bt_KelolaData.TabIndex = 1;
            bt_KelolaData.Text = "Kelola Data Bengkel";
            bt_KelolaData.UseVisualStyleBackColor = false;
            bt_KelolaData.Click += bt_KelolaData_Click;
            // 
            // bt_LihatJadwalServis
            // 
            bt_LihatJadwalServis.BackColor = Color.DarkOrange;
            bt_LihatJadwalServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_LihatJadwalServis.ForeColor = Color.White;
            bt_LihatJadwalServis.Location = new Point(211, 219);
            bt_LihatJadwalServis.Name = "bt_LihatJadwalServis";
            bt_LihatJadwalServis.Size = new Size(399, 52);
            bt_LihatJadwalServis.TabIndex = 2;
            bt_LihatJadwalServis.Text = "Lihat Jadwal Servis";
            bt_LihatJadwalServis.UseVisualStyleBackColor = false;
            bt_LihatJadwalServis.Click += bt_LihatJadwalServis_Click;
            // 
            // bt_LayananAntarJemput
            // 
            bt_LayananAntarJemput.BackColor = Color.DarkOrange;
            bt_LayananAntarJemput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_LayananAntarJemput.ForeColor = Color.White;
            bt_LayananAntarJemput.Location = new Point(211, 283);
            bt_LayananAntarJemput.Name = "bt_LayananAntarJemput";
            bt_LayananAntarJemput.Size = new Size(399, 53);
            bt_LayananAntarJemput.TabIndex = 3;
            bt_LayananAntarJemput.Text = "Lihat Layanan Antar Jemput Kendaraan";
            bt_LayananAntarJemput.UseVisualStyleBackColor = false;
            bt_LayananAntarJemput.Click += bt_LayananAntarJemput_Click;
            // 
            // bt_KonfirmBayar
            // 
            bt_KonfirmBayar.BackColor = Color.DarkOrange;
            bt_KonfirmBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_KonfirmBayar.ForeColor = Color.White;
            bt_KonfirmBayar.Location = new Point(211, 348);
            bt_KonfirmBayar.Name = "bt_KonfirmBayar";
            bt_KonfirmBayar.Size = new Size(399, 52);
            bt_KonfirmBayar.TabIndex = 4;
            bt_KonfirmBayar.Text = "Konfirmasi Pembayaran";
            bt_KonfirmBayar.UseVisualStyleBackColor = false;
            bt_KonfirmBayar.Click += bt_KonfirmBayar_Click;
            // 
            // bt_Logout
            // 
            bt_Logout.BackColor = Color.MediumBlue;
            bt_Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Logout.ForeColor = Color.White;
            bt_Logout.Location = new Point(691, 17);
            bt_Logout.Name = "bt_Logout";
            bt_Logout.Size = new Size(92, 39);
            bt_Logout.TabIndex = 5;
            bt_Logout.Text = "Logout";
            bt_Logout.UseVisualStyleBackColor = false;
            bt_Logout.Click += bt_Logout_Click;
            // 
            // HomePageBengkel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 453);
            Controls.Add(bt_Logout);
            Controls.Add(bt_KonfirmBayar);
            Controls.Add(bt_LayananAntarJemput);
            Controls.Add(bt_LihatJadwalServis);
            Controls.Add(bt_KelolaData);
            Controls.Add(pictureBox1);
            Name = "HomePageBengkel";
            Text = "HomePageBengkel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_KelolaData;
        private Button bt_LihatJadwalServis;
        private Button bt_LayananAntarJemput;
        private Button bt_KonfirmBayar;
        private Button bt_Logout;
    }
}