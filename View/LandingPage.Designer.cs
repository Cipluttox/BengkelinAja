namespace BengkelinAja
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_Login
            // 
            bt_Login.BackColor = Color.DarkOrange;
            bt_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login.ForeColor = SystemColors.ButtonHighlight;
            bt_Login.Location = new Point(489, 169);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(218, 37);
            bt_Login.TabIndex = 1;
            bt_Login.Text = "Log In";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // bt_RegistBengkel
            // 
            bt_RegistBengkel.BackColor = Color.DarkOrange;
            bt_RegistBengkel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_RegistBengkel.ForeColor = SystemColors.ButtonHighlight;
            bt_RegistBengkel.Location = new Point(489, 275);
            bt_RegistBengkel.Name = "bt_RegistBengkel";
            bt_RegistBengkel.Size = new Size(218, 37);
            bt_RegistBengkel.TabIndex = 2;
            bt_RegistBengkel.Text = "Register Pengelola Bengkel";
            bt_RegistBengkel.UseVisualStyleBackColor = false;
            bt_RegistBengkel.Click += bt_RegistBengkel_Click;
            // 
            // bt_RegistPelanggan
            // 
            bt_RegistPelanggan.BackColor = Color.DarkOrange;
            bt_RegistPelanggan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_RegistPelanggan.ForeColor = SystemColors.ButtonHighlight;
            bt_RegistPelanggan.Location = new Point(489, 222);
            bt_RegistPelanggan.Name = "bt_RegistPelanggan";
            bt_RegistPelanggan.Size = new Size(218, 37);
            bt_RegistPelanggan.TabIndex = 3;
            bt_RegistPelanggan.Text = "Register Pelanggan";
            bt_RegistPelanggan.UseVisualStyleBackColor = false;
            bt_RegistPelanggan.Click += bt_RegistPelanggan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_RegistPelanggan);
            Controls.Add(bt_RegistBengkel);
            Controls.Add(bt_Login);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private PictureBox pictureBox1;
        private Button bt_Login;
        private Button bt_RegistBengkel;
        private Button bt_RegistPelanggan;
    }
}
