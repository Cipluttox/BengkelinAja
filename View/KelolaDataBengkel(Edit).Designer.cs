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
            bt_PesanBengkel = new Button();
            bt_Riwayat = new Button();
            bt_Logout = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // bt_PesanBengkel
            // 
            bt_PesanBengkel.BackColor = Color.Transparent;
            bt_PesanBengkel.BackgroundImage = (Image)resources.GetObject("bt_PesanBengkel.BackgroundImage");
            bt_PesanBengkel.FlatAppearance.BorderSize = 0;
            bt_PesanBengkel.FlatStyle = FlatStyle.Flat;
            bt_PesanBengkel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_PesanBengkel.ForeColor = Color.Transparent;
            bt_PesanBengkel.Location = new Point(236, 169);
            bt_PesanBengkel.Name = "bt_PesanBengkel";
            bt_PesanBengkel.Size = new Size(333, 60);
            bt_PesanBengkel.TabIndex = 2;
            bt_PesanBengkel.UseVisualStyleBackColor = false;
            bt_PesanBengkel.Click += bt_PesanBengkel_Click;
            // 
            // bt_Riwayat
            // 
            bt_Riwayat.BackColor = Color.Transparent;
            bt_Riwayat.BackgroundImage = (Image)resources.GetObject("bt_Riwayat.BackgroundImage");
            bt_Riwayat.FlatAppearance.BorderSize = 0;
            bt_Riwayat.FlatStyle = FlatStyle.Flat;
            bt_Riwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Riwayat.ForeColor = Color.Transparent;
            bt_Riwayat.Location = new Point(236, 256);
            bt_Riwayat.Name = "bt_Riwayat";
            bt_Riwayat.Size = new Size(329, 52);
            bt_Riwayat.TabIndex = 3;
            bt_Riwayat.UseVisualStyleBackColor = false;
            bt_Riwayat.Click += bt_Riwayat_Click;
            // 
            // bt_Logout
            // 
            bt_Logout.BackColor = Color.Transparent;
            bt_Logout.FlatAppearance.BorderSize = 0;
            bt_Logout.FlatStyle = FlatStyle.Flat;
            bt_Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Logout.ForeColor = Color.Transparent;
            bt_Logout.Location = new Point(696, -1);
            bt_Logout.Name = "bt_Logout";
            bt_Logout.Size = new Size(92, 39);
            bt_Logout.TabIndex = 6;
            bt_Logout.UseVisualStyleBackColor = false;
            bt_Logout.Click += bt_Logout_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(696, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 20);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HomePagePelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bt_Logout);
            Controls.Add(bt_Riwayat);
            Controls.Add(bt_PesanBengkel);
            Name = "HomePagePelanggan";
            Text = "HomePagePelanggan";
            ResumeLayout(false);
        }

        #endregion
        private Button bt_PesanBengkel;
        private Button bt_Riwayat;
        private Button bt_Logout;
        private Button button1;
    }
}
