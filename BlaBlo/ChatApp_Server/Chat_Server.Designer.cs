namespace ChatApp_Server
{
    partial class Chat_Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxClientList = new System.Windows.Forms.CheckedListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.textBoxMessage = new LollipopTextBox();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkedListBoxClientList);
            this.groupBox1.Location = new System.Drawing.Point(7, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client List";
            // 
            // checkedListBoxClientList
            // 
            this.checkedListBoxClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxClientList.CheckOnClick = true;
            this.checkedListBoxClientList.FormattingEnabled = true;
            this.checkedListBoxClientList.Location = new System.Drawing.Point(7, 20);
            this.checkedListBoxClientList.Name = "checkedListBoxClientList";
            this.checkedListBoxClientList.Size = new System.Drawing.Size(165, 120);
            this.checkedListBoxClientList.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(524, 431);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(10, 10);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(191, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(343, 324);
            this.webBrowser1.TabIndex = 7;
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonFile.BackgroundImage = global::ChatApp_Server.Properties.Resources.icons8_attach_241;
            this.buttonFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Location = new System.Drawing.Point(34, 392);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(21, 20);
            this.buttonFile.TabIndex = 18;
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonImg
            // 
            this.buttonImg.BackColor = System.Drawing.Color.Transparent;
            this.buttonImg.BackgroundImage = global::ChatApp_Server.Properties.Resources.icons8_image_file_26;
            this.buttonImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonImg.FlatAppearance.BorderSize = 0;
            this.buttonImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImg.Location = new System.Drawing.Point(7, 392);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(21, 20);
            this.buttonImg.TabIndex = 17;
            this.buttonImg.UseVisualStyleBackColor = false;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ChatApp_Server.Properties.Resources._583bdad4218a5_thumb900;
            this.pictureBox1.Location = new System.Drawing.Point(0, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            this.openFileDialogImg.Filter = "PNG|*.png";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.FocusedColor = "#508ef5";
            this.textBoxMessage.FontColor = "#999999";
            this.textBoxMessage.IsEnabled = true;
            this.textBoxMessage.Location = new System.Drawing.Point(61, 392);
            this.textBoxMessage.MaxLength = 32767;
            this.textBoxMessage.Multiline = false;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = false;
            this.textBoxMessage.Size = new System.Drawing.Size(473, 24);
            this.textBoxMessage.TabIndex = 5;
            this.textBoxMessage.Text = "Nhập tin nhắn...";
            this.textBoxMessage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMessage.UseSystemPasswordChar = false;
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialog1";
            // 
            // Chat_Server
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chat_Server";
            this.Text = "BlaBlo: Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_Server_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxClientList;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private LollipopTextBox textBoxMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
    }
}

