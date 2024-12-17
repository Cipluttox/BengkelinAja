namespace BengkelinAja___Final_Project.View
{
    partial class LihatLayananAntarJemput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatLayananAntarJemput));
            pictureBox1 = new PictureBox();
            dataGridViewLayanan = new DataGridView();
            bt_kembali = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLayanan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewLayanan
            // 
            dataGridViewLayanan.AllowUserToAddRows = false;
            dataGridViewLayanan.AllowUserToDeleteRows = false;
            dataGridViewLayanan.BackgroundColor = Color.Silver;
            dataGridViewLayanan.BorderStyle = BorderStyle.None;
            dataGridViewLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLayanan.Location = new Point(237, 80);
            dataGridViewLayanan.Name = "dataGridViewLayanan";
            dataGridViewLayanan.RowHeadersWidth = 51;
            dataGridViewLayanan.Size = new Size(509, 275);
            dataGridViewLayanan.TabIndex = 1;
            // 
            // bt_kembali
            // 
            bt_kembali.BackColor = Color.Transparent;
            bt_kembali.BackgroundImage = (Image)resources.GetObject("bt_kembali.BackgroundImage");
            bt_kembali.FlatAppearance.BorderSize = 0;
            bt_kembali.FlatStyle = FlatStyle.Flat;
            bt_kembali.ForeColor = Color.Transparent;
            bt_kembali.Location = new Point(681, 368);
            bt_kembali.Name = "bt_kembali";
            bt_kembali.Size = new Size(66, 21);
            bt_kembali.TabIndex = 2;
            bt_kembali.UseVisualStyleBackColor = false;
            bt_kembali.Click += bt_kembali_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(17, 39);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(19, 76);
            button2.Name = "button2";
            button2.Size = new Size(150, 27);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LihatLayananAntarJemput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bt_kembali);
            Controls.Add(dataGridViewLayanan);
            Controls.Add(pictureBox1);
            Name = "LihatLayananAntarJemput";
            Text = "LihatLayananAntarJemput";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLayanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewLayanan;
        private Button bt_kembali;
        private Button button1;
        private Button button2;
    }
}
