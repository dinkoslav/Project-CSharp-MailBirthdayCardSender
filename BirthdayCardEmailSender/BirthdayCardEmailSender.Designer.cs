namespace BirthdayCardEmailSender
    {
    partial class BirthdayCardEmailSender
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
            this.imageChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.senderName = new System.Windows.Forms.TextBox();
            this.recieverName = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.senderEmail = new System.Windows.Forms.TextBox();
            this.recieverEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smtpServer = new System.Windows.Forms.TextBox();
            this.priviewBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.messageInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageChange
            // 
            this.imageChange.FormattingEnabled = true;
            this.imageChange.Items.AddRange(new object[] {
            "First Card",
            "Second Card",
            "Third Card"});
            this.imageChange.Location = new System.Drawing.Point(55, 8);
            this.imageChange.Name = "imageChange";
            this.imageChange.Size = new System.Drawing.Size(151, 21);
            this.imageChange.TabIndex = 0;
            this.imageChange.SelectedIndexChanged += new System.EventHandler(this.imageChange_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sender Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reciever Name:";
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(310, 9);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(130, 20);
            this.senderName.TabIndex = 4;
            // 
            // recieverName
            // 
            this.recieverName.Location = new System.Drawing.Point(554, 9);
            this.recieverName.Name = "recieverName";
            this.recieverName.Size = new System.Drawing.Size(144, 20);
            this.recieverName.TabIndex = 5;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(15, 49);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(363, 268);
            this.previewBox.TabIndex = 7;
            this.previewBox.TabStop = false;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(387, 101);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(311, 138);
            this.message.TabIndex = 8;
            this.message.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject:";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(447, 49);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(251, 20);
            this.subject.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Text on Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email To:";
            // 
            // senderEmail
            // 
            this.senderEmail.Location = new System.Drawing.Point(97, 335);
            this.senderEmail.Name = "senderEmail";
            this.senderEmail.Size = new System.Drawing.Size(236, 20);
            this.senderEmail.TabIndex = 14;
            // 
            // recieverEmail
            // 
            this.recieverEmail.Location = new System.Drawing.Point(97, 365);
            this.recieverEmail.Name = "recieverEmail";
            this.recieverEmail.Size = new System.Drawing.Size(236, 20);
            this.recieverEmail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "SMTP:";
            // 
            // smtpServer
            // 
            this.smtpServer.Location = new System.Drawing.Point(97, 394);
            this.smtpServer.Name = "smtpServer";
            this.smtpServer.Size = new System.Drawing.Size(236, 20);
            this.smtpServer.TabIndex = 17;
            // 
            // priviewBtn
            // 
            this.priviewBtn.Location = new System.Drawing.Point(483, 296);
            this.priviewBtn.Name = "priviewBtn";
            this.priviewBtn.Size = new System.Drawing.Size(147, 38);
            this.priviewBtn.TabIndex = 18;
            this.priviewBtn.Text = "Priview";
            this.priviewBtn.UseVisualStyleBackColor = true;
            this.priviewBtn.Click += new System.EventHandler(this.priviewBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(483, 347);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(147, 38);
            this.sendBtn.TabIndex = 19;
            this.sendBtn.Text = "Send Card";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Font Size:";
            // 
            // fontSize
            // 
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48"});
            this.fontSize.Location = new System.Drawing.Point(454, 258);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(88, 21);
            this.fontSize.TabIndex = 29;
            this.fontSize.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Font Color:";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(653, 257);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(23, 23);
            this.colorBox.TabIndex = 31;
            this.colorBox.UseVisualStyleBackColor = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // messageInfo
            // 
            this.messageInfo.AutoSize = true;
            this.messageInfo.Location = new System.Drawing.Point(500, 394);
            this.messageInfo.Name = "messageInfo";
            this.messageInfo.Size = new System.Drawing.Size(0, 13);
            this.messageInfo.TabIndex = 32;
            // 
            // BirthdayCardEmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 423);
            this.Controls.Add(this.messageInfo);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.priviewBtn);
            this.Controls.Add(this.smtpServer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.recieverEmail);
            this.Controls.Add(this.senderEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.message);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.recieverName);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageChange);
            this.Name = "BirthdayCardEmailSender";
            this.Text = "BDEmail Sender";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.ComboBox imageChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senderName;
        private System.Windows.Forms.TextBox recieverName;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox senderEmail;
        private System.Windows.Forms.TextBox recieverEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox smtpServer;
        private System.Windows.Forms.Button priviewBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox fontSize;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Label messageInfo;

        }
    }

