namespace BengkelinAja.View
{
    partial class KelolaDataBengkel__View_
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
            dataGridView1 = new DataGridView();
            bt_edit = new Button();
            bt_kembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kelola_data_bengkel_Edit;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 451);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(655, 188);
            dataGridView1.TabIndex = 1;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = Color.FromArgb(255, 128, 0);
            bt_edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_edit.ForeColor = SystemColors.HighlightText;
            bt_edit.Location = new Point(523, 373);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(128, 54);
            bt_edit.TabIndex = 2;
            bt_edit.Text = "Edit ";
            bt_edit.UseVisualStyleBackColor = false;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_kembali
            // 
            bt_kembali.BackColor = Color.FromArgb(0, 0, 192);
            bt_kembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_kembali.ForeColor = SystemColors.HighlightText;
            bt_kembali.Location = new Point(660, 373);
            bt_kembali.Name = "bt_kembali";
            bt_kembali.Size = new Size(128, 54);
            bt_kembali.TabIndex = 3;
            bt_kembali.Text = "Kembali";
            bt_kembali.UseVisualStyleBackColor = false;
            // 
            // KelolaDataBengkel__View_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_kembali);
            Controls.Add(bt_edit);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "KelolaDataBengkel__View_";
            Text = "KelolaDataBengkel__View_";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button bt_edit;
        private Button bt_kembali;
    }
}