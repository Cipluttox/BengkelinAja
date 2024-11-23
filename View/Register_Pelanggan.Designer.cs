namespace BengkelinAja.View
{
    partial class Register_Pelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Pelanggan));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbpNamaLengkap = new TextBox();
            pictureBox1 = new PictureBox();
            tbpEmail = new TextBox();
            tbpAlamat = new TextBox();
            tbpNoTelp = new TextBox();
            tbpUsername = new TextBox();
            tbpPassword = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 109);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Pelanggan : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 145);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 185);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Alamat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 224);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 4;
            label4.Text = "No.Telepon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 265);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "username :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 304);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 6;
            label6.Text = "Password :";
            // 
            // tbpNamaLengkap
            // 
            tbpNamaLengkap.Location = new Point(370, 106);
            tbpNamaLengkap.Name = "tbpNamaLengkap";
            tbpNamaLengkap.Size = new Size(208, 27);
            tbpNamaLengkap.TabIndex = 13;
            tbpNamaLengkap.TextChanged += tbpNamaLengkap_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 456);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbpEmail
            // 
            tbpEmail.Location = new Point(370, 145);
            tbpEmail.Name = "tbpEmail";
            tbpEmail.Size = new Size(208, 27);
            tbpEmail.TabIndex = 14;
            // 
            // tbpAlamat
            // 
            tbpAlamat.Location = new Point(370, 185);
            tbpAlamat.Name = "tbpAlamat";
            tbpAlamat.Size = new Size(208, 27);
            tbpAlamat.TabIndex = 15;
            // 
            // tbpNoTelp
            // 
            tbpNoTelp.Location = new Point(370, 224);
            tbpNoTelp.Name = "tbpNoTelp";
            tbpNoTelp.Size = new Size(208, 27);
            tbpNoTelp.TabIndex = 16;
            // 
            // tbpUsername
            // 
            tbpUsername.Location = new Point(370, 262);
            tbpUsername.Name = "tbpUsername";
            tbpUsername.Size = new Size(208, 27);
            tbpUsername.TabIndex = 17;
            // 
            // tbpPassword
            // 
            tbpPassword.Location = new Point(370, 301);
            tbpPassword.Name = "tbpPassword";
            tbpPassword.Size = new Size(208, 27);
            tbpPassword.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(492, 350);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Register_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbpPassword);
            Controls.Add(tbpUsername);
            Controls.Add(tbpNoTelp);
            Controls.Add(tbpAlamat);
            Controls.Add(tbpEmail);
            Controls.Add(tbpNamaLengkap);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Register_Pelanggan";
            Text = "Register_Pelanggan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbpNamaLengkap;
        private PictureBox pictureBox1;
        private TextBox tbpEmail;
        private TextBox tbpAlamat;
        private TextBox tbpNoTelp;
        private TextBox tbpUsername;
        private TextBox tbpPassword;
        private Button button1;
    }
}