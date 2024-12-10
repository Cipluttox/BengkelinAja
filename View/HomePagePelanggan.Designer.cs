namespace BengkelinAja___Final_Project.View
{
    partial class HomePagePelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePagePelanggan));
            pictureBox1 = new PictureBox();
            bt_PesanBengkel = new Button();
            bt_Riwayat = new Button();
            bt_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 452);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_PesanBengkel
            // 
            bt_PesanBengkel.BackColor = Color.DarkOrange;
            bt_PesanBengkel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_PesanBengkel.ForeColor = Color.White;
            bt_PesanBengkel.Location = new Point(197, 213);
            bt_PesanBengkel.Name = "bt_PesanBengkel";
            bt_PesanBengkel.Size = new Size(399, 52);
            bt_PesanBengkel.TabIndex = 2;
            bt_PesanBengkel.Text = "Menu Pemesanan Layanan Bengkel";
            bt_PesanBengkel.UseVisualStyleBackColor = false;
            bt_PesanBengkel.Click += bt_PesanBengkel_Click;
            // 
            // bt_Riwayat
            // 
            bt_Riwayat.BackColor = Color.DarkOrange;
            bt_Riwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Riwayat.ForeColor = Color.White;
            bt_Riwayat.Location = new Point(197, 277);
            bt_Riwayat.Name = "bt_Riwayat";
            bt_Riwayat.Size = new Size(399, 52);
            bt_Riwayat.TabIndex = 3;
            bt_Riwayat.Text = "Riwayat Pemesanan";
            bt_Riwayat.UseVisualStyleBackColor = false;
            bt_Riwayat.Click += bt_Riwayat_Click;
            // 
            // bt_Logout
            // 
            bt_Logout.BackColor = Color.MediumBlue;
            bt_Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Logout.ForeColor = Color.White;
            bt_Logout.Location = new Point(674, 16);
            bt_Logout.Name = "bt_Logout";
            bt_Logout.Size = new Size(92, 39);
            bt_Logout.TabIndex = 6;
            bt_Logout.Text = "Logout";
            bt_Logout.UseVisualStyleBackColor = false;
            bt_Logout.Click += bt_Logout_Click;
            // 
            // HomePagePelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_Logout);
            Controls.Add(bt_Riwayat);
            Controls.Add(bt_PesanBengkel);
            Controls.Add(pictureBox1);
            Name = "HomePagePelanggan";
            Text = "HomePagePelanggan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_PesanBengkel;
        private Button bt_Riwayat;
        private Button bt_Logout;
    }
}
