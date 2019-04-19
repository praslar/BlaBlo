namespace ChatApp_Client
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new LollipopButton();
            this.textBoxpass = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.textBoxlogin = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatApp_Client.Properties.Resources._583bdad4218a5_thumb900;
            this.pictureBox1.Location = new System.Drawing.Point(92, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BGColor = "#508ef5";
            this.buttonLogin.FontColor = "#ffffff";
            this.buttonLogin.Location = new System.Drawing.Point(92, 468);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(169, 44);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "Sign in";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // textBoxpass
            // 
            this.textBoxpass.FocusedColor = "#508ef5";
            this.textBoxpass.FontColor = "#999999";
            this.textBoxpass.IsEnabled = true;
            this.textBoxpass.Location = new System.Drawing.Point(14, 405);
            this.textBoxpass.MaxLength = 32767;
            this.textBoxpass.Multiline = false;
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.ReadOnly = false;
            this.textBoxpass.Size = new System.Drawing.Size(329, 24);
            this.textBoxpass.TabIndex = 18;
            this.textBoxpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxpass.UseSystemPasswordChar = true;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(10, 382);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(66, 17);
            this.lollipopLabel2.TabIndex = 17;
            this.lollipopLabel2.Text = "Mật khẩu";
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.FocusedColor = "#508ef5";
            this.textBoxlogin.FontColor = "#999999";
            this.textBoxlogin.IsEnabled = true;
            this.textBoxlogin.Location = new System.Drawing.Point(14, 339);
            this.textBoxlogin.MaxLength = 32767;
            this.textBoxlogin.Multiline = false;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.ReadOnly = false;
            this.textBoxlogin.Size = new System.Drawing.Size(329, 24);
            this.textBoxlogin.TabIndex = 16;
            this.textBoxlogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxlogin.UseSystemPasswordChar = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(10, 317);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(105, 17);
            this.lollipopLabel1.TabIndex = 15;
            this.lollipopLabel1.Text = "Tên đăng nhập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 23);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // Login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 534);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "BlaBlo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox textBoxlogin;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox textBoxpass;
        private LollipopButton buttonLogin;
        private System.Windows.Forms.Button button1;
    }
}