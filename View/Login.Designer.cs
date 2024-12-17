namespace BengkelinAja___Final_Project.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btLogin = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(472, 197);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 3;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(472, 248);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Password : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 452);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Transparent;
            btLogin.BackgroundImage = (Image)resources.GetObject("btLogin.BackgroundImage");
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.Transparent;
            btLogin.Location = new Point(652, 308);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(83, 29);
            btLogin.TabIndex = 7;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.WhiteSmoke;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(478, 188);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(248, 20);
            tbUsername.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.WhiteSmoke;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Location = new Point(478, 253);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(237, 20);
            tbPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(472, 195);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(472, 242);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // Login
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btLogin);
            Controls.Add(pictureBox2);
            Name = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btLogin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label3;
        private Label label4;
    }
}

