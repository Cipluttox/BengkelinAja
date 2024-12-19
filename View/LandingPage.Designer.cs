namespace BengkelinAja___Final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            pictureBox1 = new PictureBox();
            bt_Login = new Button();
            bt_RegistBengkel = new Button();
            bt_RegistPelanggan = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_Login
            // 
            bt_Login.BackColor = Color.FromArgb(55, 76, 252);
            bt_Login.FlatAppearance.BorderSize = 0;
            bt_Login.FlatStyle = FlatStyle.Flat;
            bt_Login.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            bt_Login.ForeColor = Color.Transparent;
            bt_Login.Location = new Point(693, 9);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(87, 21);
            bt_Login.TabIndex = 1;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // bt_RegistBengkel
            // 
            bt_RegistBengkel.BackColor = Color.FromArgb(55, 76, 252);
            bt_RegistBengkel.FlatAppearance.BorderSize = 0;
            bt_RegistBengkel.FlatStyle = FlatStyle.Flat;
            bt_RegistBengkel.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            bt_RegistBengkel.ForeColor = Color.Transparent;
            bt_RegistBengkel.Location = new Point(183, 208);
            bt_RegistBengkel.Name = "bt_RegistBengkel";
            bt_RegistBengkel.Size = new Size(115, 32);
            bt_RegistBengkel.TabIndex = 2;
            bt_RegistBengkel.Text = "Register Pelanggan";
            bt_RegistBengkel.UseVisualStyleBackColor = false;
            bt_RegistBengkel.Click += bt_RegistBengkel_Click;
            // 
            // bt_RegistPelanggan
            // 
            bt_RegistPelanggan.BackColor = Color.FromArgb(55, 76, 252);
            bt_RegistPelanggan.FlatAppearance.BorderColor = Color.MediumBlue;
            bt_RegistPelanggan.FlatAppearance.BorderSize = 0;
            bt_RegistPelanggan.FlatStyle = FlatStyle.Flat;
            bt_RegistPelanggan.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            bt_RegistPelanggan.ForeColor = Color.Transparent;
            bt_RegistPelanggan.Location = new Point(55, 208);
            bt_RegistPelanggan.Name = "bt_RegistPelanggan";
            bt_RegistPelanggan.Size = new Size(115, 32);
            bt_RegistPelanggan.TabIndex = 3;
            bt_RegistPelanggan.Text = "Register Pengelola";
            bt_RegistPelanggan.UseVisualStyleBackColor = false;
            bt_RegistPelanggan.Click += bt_RegistPelanggan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 449);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_RegistPelanggan);
            Controls.Add(bt_RegistBengkel);
            Controls.Add(bt_Login);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private PictureBox pictureBox1;
        private Button bt_Login;
        private Button bt_RegistBengkel;
        private Button bt_RegistPelanggan;
        private PictureBox pictureBox2;
    }
}
