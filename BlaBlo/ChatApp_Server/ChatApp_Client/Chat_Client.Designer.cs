namespace ChatApp_Client
{
    partial class Chat_Client
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxMessage = new LollipopTextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.textBoxName = new LollipopLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonImg = new System.Windows.Forms.Button();
            this.buttonfile = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(365, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.FocusedColor = "#508ef5";
            this.textBoxMessage.FontColor = "#999999";
            this.textBoxMessage.IsEnabled = true;
            this.textBoxMessage.Location = new System.Drawing.Point(12, 517);
            this.textBoxMessage.MaxLength = 32767;
            this.textBoxMessage.Multiline = false;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.textBoxMessage.ReadOnly = false;
            this.textBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMessage.Size = new System.Drawing.Size(353, 24);
            this.textBoxMessage.TabIndex = 8;
            this.textBoxMessage.Text = " Nhập tin nhắn...";
            this.textBoxMessage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMessage.UseSystemPasswordChar = false;
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(102, 495);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(42, 17);
            this.lollipopLabel1.TabIndex = 12;
            this.lollipopLabel1.Text = "User:";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoSize = true;
            this.textBoxName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.textBoxName.Location = new System.Drawing.Point(150, 495);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(31, 17);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "abc";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 67);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(365, 420);
            this.webBrowser1.TabIndex = 14;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSend.Location = new System.Drawing.Point(355, 548);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(10, 10);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonImg
            // 
            this.buttonImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonImg.BackgroundImage = global::ChatApp_Client.Properties.Resources.icons8_image_file_26;
            this.buttonImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonImg.FlatAppearance.BorderSize = 0;
            this.buttonImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImg.Location = new System.Drawing.Point(12, 493);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(21, 20);
            this.buttonImg.TabIndex = 16;
            this.buttonImg.UseVisualStyleBackColor = false;
            // 
            // buttonfile
            // 
            this.buttonfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonfile.BackgroundImage = global::ChatApp_Client.Properties.Resources.icons8_attach_24;
            this.buttonfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfile.FlatAppearance.BorderSize = 0;
            this.buttonfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfile.Location = new System.Drawing.Point(39, 493);
            this.buttonfile.Name = "buttonfile";
            this.buttonfile.Size = new System.Drawing.Size(21, 20);
            this.buttonfile.TabIndex = 17;
            this.buttonfile.UseVisualStyleBackColor = false;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.Transparent;
            this.buttonFriends.BackgroundImage = global::ChatApp_Client.Properties.Resources.add_user;
            this.buttonFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFriends.FlatAppearance.BorderSize = 0;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.Location = new System.Drawing.Point(66, 493);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(21, 20);
            this.buttonFriends.TabIndex = 18;
            this.buttonFriends.UseVisualStyleBackColor = false;
            // 
            // Chat_Client
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 558);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonfile);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Chat_Client";
            this.Text = "BlaBlo - Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_Client_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private LollipopTextBox textBoxMessage;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel textBoxName;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.Button buttonfile;
        private System.Windows.Forms.Button buttonFriends;
    }
}

