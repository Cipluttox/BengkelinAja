namespace BengkelinAja.View
{
    partial class KelolaDataBengkel__Edit_
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
            pictureBox1 = new PictureBox();
            bt_simpan = new Button();
            bt_kembali = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            L1_Pengelola = new CheckBox();
            L2_Pengelola = new CheckBox();
            L3_Pengelola = new CheckBox();
            L5_Pengelola = new CheckBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kelola_data_bengkel_Edit;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 454);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_simpan
            // 
            bt_simpan.BackColor = Color.FromArgb(255, 128, 0);
            bt_simpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_simpan.ForeColor = SystemColors.HighlightText;
            bt_simpan.Location = new Point(523, 371);
            bt_simpan.Name = "bt_simpan";
            bt_simpan.Size = new Size(131, 58);
            bt_simpan.TabIndex = 1;
            bt_simpan.Text = "Simpan";
            bt_simpan.UseVisualStyleBackColor = false;
            bt_simpan.Click += bt_simpan_Click;
            // 
            // bt_kembali
            // 
            bt_kembali.BackColor = Color.FromArgb(0, 0, 192);
            bt_kembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_kembali.ForeColor = SystemColors.HighlightText;
            bt_kembali.Location = new Point(660, 371);
            bt_kembali.Name = "bt_kembali";
            bt_kembali.Size = new Size(131, 58);
            bt_kembali.TabIndex = 2;
            bt_kembali.Text = "Kembali";
            bt_kembali.UseVisualStyleBackColor = false;
            bt_kembali.Click += bt_kembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(140, 152);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Nama Bengkel";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(140, 202);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Layanan";
            // 
            // L1_Pengelola
            // 
            L1_Pengelola.AutoSize = true;
            L1_Pengelola.Location = new Point(298, 198);
            L1_Pengelola.Name = "L1_Pengelola";
            L1_Pengelola.Size = new Size(107, 24);
            L1_Pengelola.TabIndex = 6;
            L1_Pengelola.Text = "Servis Rutin";
            L1_Pengelola.UseVisualStyleBackColor = true;
            // 
            // L2_Pengelola
            // 
            L2_Pengelola.AutoSize = true;
            L2_Pengelola.Location = new Point(298, 241);
            L2_Pengelola.Name = "L2_Pengelola";
            L2_Pengelola.Size = new Size(89, 24);
            L2_Pengelola.TabIndex = 7;
            L2_Pengelola.Text = "Ganti Oli";
            L2_Pengelola.UseVisualStyleBackColor = true;
            // 
            // L3_Pengelola
            // 
            L3_Pengelola.AutoSize = true;
            L3_Pengelola.Location = new Point(444, 198);
            L3_Pengelola.Name = "L3_Pengelola";
            L3_Pengelola.Size = new Size(122, 24);
            L3_Pengelola.TabIndex = 8;
            L3_Pengelola.Text = "Servis Garansi";
            L3_Pengelola.UseVisualStyleBackColor = true;
            L3_Pengelola.CheckedChanged += C3_servisGaransi_CheckedChanged;
            // 
            // L5_Pengelola
            // 
            L5_Pengelola.AutoSize = true;
            L5_Pengelola.Location = new Point(444, 241);
            L5_Pengelola.Name = "L5_Pengelola";
            L5_Pengelola.Size = new Size(123, 24);
            L5_Pengelola.TabIndex = 9;
            L5_Pengelola.Text = "Servis Darurat";
            L5_Pengelola.UseVisualStyleBackColor = true;
            L5_Pengelola.CheckedChanged += L5_Pengelola_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(141, 285);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 10;
            label3.Text = "Alamat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(141, 331);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 12;
            label4.Text = "Jam Buka";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(141, 371);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 13;
            label5.Text = "Jam Tutup";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(296, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(296, 368);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(91, 27);
            textBox4.TabIndex = 15;
            // 
            // KelolaDataBengkel__Edit_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(L5_Pengelola);
            Controls.Add(L3_Pengelola);
            Controls.Add(L2_Pengelola);
            Controls.Add(L1_Pengelola);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(bt_kembali);
            Controls.Add(bt_simpan);
            Controls.Add(pictureBox1);
            Name = "KelolaDataBengkel__Edit_";
            Text = "KelolaDataBengkel__Edit_";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_simpan;
        private Button bt_kembali;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private CheckBox L1_Pengelola;
        private CheckBox L2_Pengelola;
        private CheckBox L3_Pengelola;
        private CheckBox L5_Pengelola;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}