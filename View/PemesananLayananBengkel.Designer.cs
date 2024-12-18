using System.Windows.Forms;
namespace BengkelinAja___Final_Project.View
{
    partial class PemesananLayananBengkel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PemesananLayananBengkel));
            label1 = new Label();
            cb_JenisKendaraan = new ComboBox();
            label2 = new Label();
            cb_JenisLayanan = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ch_AntarJemput = new CheckBox();
            dt_JamJemput = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            bt_Pesan = new Button();
            bt_Batal = new Button();
            tb_alamat = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(166, 127);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Jenis Kendaraan : ";
            // 
            // cb_JenisKendaraan
            // 
            cb_JenisKendaraan.FormattingEnabled = true;
            cb_JenisKendaraan.Items.AddRange(new object[] { "Mobil", "Sepeda Motor", "Truk" });
            cb_JenisKendaraan.Location = new Point(335, 124);
            cb_JenisKendaraan.Name = "cb_JenisKendaraan";
            cb_JenisKendaraan.Size = new Size(259, 28);
            cb_JenisKendaraan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(166, 173);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 4;
            label2.Text = "Jenis Layanan Servis : ";
            // 
            // cb_JenisLayanan
            // 
            cb_JenisLayanan.FormattingEnabled = true;
            cb_JenisLayanan.Items.AddRange(new object[] { "Servis Rutin", "Ganti Oli", "Servis Garansi", "Servis Darurat" });
            cb_JenisLayanan.Location = new Point(335, 170);
            cb_JenisLayanan.Name = "cb_JenisLayanan";
            cb_JenisLayanan.Size = new Size(259, 28);
            cb_JenisLayanan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(166, 219);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Bengkel :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(331, 223);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 7;
            label4.Text = "                                             ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(530, 219);
            button1.Name = "button1";
            button1.Size = new Size(64, 30);
            button1.TabIndex = 8;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(335, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(259, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(335, 265);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(259, 27);
            dateTimePicker2.TabIndex = 10;
            // 
            // ch_AntarJemput
            // 
            ch_AntarJemput.AutoSize = true;
            ch_AntarJemput.BackColor = Color.White;
            ch_AntarJemput.Location = new Point(335, 349);
            ch_AntarJemput.Name = "ch_AntarJemput";
            ch_AntarJemput.Size = new Size(46, 24);
            ch_AntarJemput.TabIndex = 11;
            ch_AntarJemput.Text = "Ya";
            ch_AntarJemput.UseVisualStyleBackColor = false;
            // 
            // dt_JamJemput
            // 
            dt_JamJemput.CustomFormat = "HH:mm";
            dt_JamJemput.Format = DateTimePickerFormat.Custom;
            dt_JamJemput.Location = new Point(335, 388);
            dt_JamJemput.Name = "dt_JamJemput";
            dt_JamJemput.ShowUpDown = true;
            dt_JamJemput.Size = new Size(259, 27);
            dt_JamJemput.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(166, 270);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 13;
            label5.Text = "Tanggal Servis : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(166, 312);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 14;
            label6.Text = "Jam Servis :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(166, 352);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 15;
            label7.Text = "Antar Jemput :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(166, 395);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 16;
            label8.Text = "Jam Jemput :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 549);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // bt_Pesan
            // 
            bt_Pesan.BackColor = Color.FromArgb(0, 0, 192);
            bt_Pesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Pesan.ForeColor = Color.White;
            bt_Pesan.Location = new Point(672, 481);
            bt_Pesan.Name = "bt_Pesan";
            bt_Pesan.Size = new Size(104, 44);
            bt_Pesan.TabIndex = 18;
            bt_Pesan.Text = "Pesan";
            bt_Pesan.UseVisualStyleBackColor = false;
            bt_Pesan.Click += bt_Pesan_Click;
            // 
            // bt_Batal
            // 
            bt_Batal.BackColor = Color.DarkOrange;
            bt_Batal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Batal.ForeColor = Color.White;
            bt_Batal.Location = new Point(562, 481);
            bt_Batal.Name = "bt_Batal";
            bt_Batal.Size = new Size(104, 44);
            bt_Batal.TabIndex = 19;
            bt_Batal.Text = "Batal";
            bt_Batal.UseVisualStyleBackColor = false;
            bt_Batal.Click += bt_Batal_Click;
            // 
            // tb_alamat
            // 
            tb_alamat.Location = new Point(335, 433);
            tb_alamat.Name = "tb_alamat";
            tb_alamat.Size = new Size(259, 27);
            tb_alamat.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(166, 436);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 21;
            label9.Text = "Alamat Penjemputan :";
            // 
            // PemesananLayananBengkel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 552);
            Controls.Add(label9);
            Controls.Add(tb_alamat);
            Controls.Add(bt_Batal);
            Controls.Add(bt_Pesan);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dt_JamJemput);
            Controls.Add(ch_AntarJemput);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_JenisLayanan);
            Controls.Add(label2);
            Controls.Add(cb_JenisKendaraan);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PemesananLayananBengkel";
            Text = "PemesananLayananBengkel";
            Load += PemesananLayananBengkel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cb_JenisKendaraan;
        private Label label2;
        private ComboBox cb_JenisLayanan;
        private Label label3;
        private Label label4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CheckBox ch_AntarJemput;
        private DateTimePicker dt_JamJemput;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button bt_Pesan;
        private Button bt_Batal;
        private TextBox tb_alamat;
        private Label label9;
    }
}