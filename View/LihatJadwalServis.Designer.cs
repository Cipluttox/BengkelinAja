namespace BengkelinAja___Final_Project.View
{
    partial class LihatJadwalServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatJadwalServis));
            pictureBox1 = new PictureBox();
            dataGridViewServis = new DataGridView();
            button1 = new Button();
            bt_kembali = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServis).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewServis
            // 
            dataGridViewServis.AllowUserToAddRows = false;
            dataGridViewServis.AllowUserToDeleteRows = false;
            dataGridViewServis.BackgroundColor = Color.Silver;
            dataGridViewServis.BorderStyle = BorderStyle.None;
            dataGridViewServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServis.Location = new Point(235, 82);
            dataGridViewServis.Name = "dataGridViewServis";
            dataGridViewServis.RowHeadersWidth = 51;
            dataGridViewServis.Size = new Size(508, 270);
            dataGridViewServis.TabIndex = 1;
            dataGridViewServis.CellContentClick += dataGridViewServis_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(19, 114);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += bt_kembali_Click;
            // 
            // bt_kembali
            // 
            bt_kembali.BackgroundImage = (Image)resources.GetObject("bt_kembali.BackgroundImage");
            bt_kembali.FlatAppearance.BorderSize = 0;
            bt_kembali.FlatStyle = FlatStyle.Flat;
            bt_kembali.Location = new Point(678, 368);
            bt_kembali.Name = "bt_kembali";
            bt_kembali.Size = new Size(64, 24);
            bt_kembali.TabIndex = 3;
            bt_kembali.UseVisualStyleBackColor = true;
            bt_kembali.Click += bt_kembali_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 36);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LihatJadwalServis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(bt_kembali);
            Controls.Add(button1);
            Controls.Add(dataGridViewServis);
            Controls.Add(pictureBox1);
            Name = "LihatJadwalServis";
            Text = "LihatJadwalServis";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewServis;
        private Button button1;
        private Button bt_kembali;
        private Button button2;
    }
}
