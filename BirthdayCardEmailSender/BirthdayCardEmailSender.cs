using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace BirthdayCardEmailSender
    {
    public partial class BirthdayCardEmailSender : Form
        {

        private string footerInfo = "This message was send with BDEmail Sender";
        private int tempCurrentPicture = 2;
        private Color myColor = Color.Black;

        public BirthdayCardEmailSender()
            {
            //initializa and set up the default pic
            InitializeComponent();
            previewBox.Image = Image.FromFile(@"..\..\Images\empty.jpg");
            previewBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

        private void imageChange_SelectedIndexChanged(object sender, EventArgs e)
            {
            //changes the preview card when a card is selected
            if (imageChange.Text == "First Card") 
                {
                previewBox.Image = Image.FromFile(@"..\..\Images\blank_BDC1.jpg");
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            else if (imageChange.Text == "Second Card")
                {
                previewBox.Image = Image.FromFile(@"..\..\Images\blank_BDC2.jpg");
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            else if (imageChange.Text == "Third Card")
                {
                previewBox.Image = Image.FromFile(@"..\..\Images\blank_BDC3.jpg");
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

        private void priviewBtn_Click(object sender, EventArgs e)
            {
            //prepare footer text
            if (senderName.Text != "") 
                {
                footerInfo = footerInfo + " by " + senderName.Text;
                }
            if (recieverName.Text != "")
                {
                footerInfo = footerInfo + " to " + recieverName.Text;
                }
            //draw text on the card
            if (imageChange.Text != "")
                {
                drawTextOnImage(imageChange.Text, senderName.Text, message.Text, footerInfo);
                }
            else 
                {
                previewBox.Image = Image.FromFile(@"..\..\Images\empty.jpg");
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            
            }

        private void drawTextOnImage(string imageName, string authorName, string inputText, string footerText)
            {
            if (tempCurrentPicture == 2)
                {
                File.Delete(@"..\..\Images\temp1.jpg");
                }
            else
                {
                File.Delete(@"..\..\Images\temp2.jpg");
                }

            switch (imageName)
                { 
                case "First Card":
                    draw(1, 300, 170, 285, 330, footerText, myColor);
                    break;
                case "Second Card":
                    draw(2, 145, 140, 330, 360, footerText, myColor);
                    break;
                case "Third Card":
                    draw(3, 305, 90, 255, 340, footerText, myColor);
                    break;
                }
                previewBox.SizeMode = PictureBoxSizeMode.Zoom;
                GC.Collect();
            }

        private void sendBtn_Click(object sender, EventArgs e)
            {

            //create the mail message
            MailMessage mail = new MailMessage();

            //set the addresses
            if (senderEmail.Text == "" || !IsValid(senderEmail.Text))
                {
                senderEmail.BackColor = Color.LightCoral;
                messageInfo.Text = "Please enter Your Mail Adress!";
                return;
                }
            else 
                {
                mail.From = new MailAddress(senderEmail.Text);
                messageInfo.Text = "";
                senderEmail.BackColor = Color.White;
                }

            if (recieverEmail.Text == "" || !IsValid(recieverEmail.Text))
                {
                recieverEmail.BackColor = Color.LightCoral;
                messageInfo.Text = "Please enter a Reciever Mail Adress!";
                return;
                }
            else
                {
                mail.To.Add(recieverEmail.Text);
                messageInfo.Text = "";
                recieverEmail.BackColor = Color.White;
                }
            
            

            //set the content
            mail.Subject = subject.Text;
            string htmlBody = "<html><body><h1>Happy Birthday from BirthdayCardEmailSender</h1><br><img src=\"cid:BDCard\"></body></html>";
            AlternateView avHtml = AlternateView.CreateAlternateViewFromString
                (htmlBody, null, MediaTypeNames.Text.Html);

            //create the LinkedResource (embedded image)
            string imagePath = "";
            if (tempCurrentPicture == 1)
                { 
                imagePath = imagePath + @"..\..\Images\temp1.jpg";
                }
            else
                {
                imagePath = imagePath + @"..\..\Images\temp2.jpg";
                }
            LinkedResource BDCard = new LinkedResource(@"" + imagePath, MediaTypeNames.Image.Jpeg);
            BDCard.ContentId = "BDCard";
            avHtml.LinkedResources.Add(BDCard);
            mail.AlternateViews.Add(avHtml);

            //check for missing data and send the mail
            if (subject.Text == "")
                {
                subject.BackColor = Color.LightCoral;
                messageInfo.Text = "Please enter a Subject !";
                return;
                }
            else
                {
                subject.BackColor = Color.White;
                messageInfo.Text = "";
                }

            if (imageChange.Text == "")
                {
                messageInfo.Text = "Please make a Birthday Card first !";
                return;
                }
            else
                {
                messageInfo.Text = "";
                }

            if (smtpServer.Text == "")
                {
                smtpServer.BackColor = Color.LightCoral;
                messageInfo.Text = "Invalid SMTP Server !";
                return;
                }
            else
                {
                smtpServer.BackColor = Color.White;
                messageInfo.Text = "";
                SmtpClient client = new SmtpClient(smtpServer.Text);
                try
                    {
                    client.Send(mail);
                    messageInfo.Text = "Mail successfully send !";
                    return;
                    }
                catch (SmtpException)
                    {

                    messageInfo.Text = "Mail fail to send !";
                    return;
                    }
                
                }
            

            

            }

        private void draw(int cardNumber, int xText, int yText, int widthText, int heightText, string footerText, Color colorText)
            {
                //create the picture and the brush for the color
                Bitmap myBitmap = new Bitmap(@"..\..\Images\blank_BDC"+cardNumber+".jpg");
                Graphics g = Graphics.FromImage(myBitmap);
                SolidBrush brush = new SolidBrush(colorText);

                //draw text on it
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(message.Text,
                             new Font("Tahoma", Int32.Parse(fontSize.Text)),
                             brush,
                             new Rectangle(xText, yText, widthText, heightText));

                //draw footer
                g.DrawString(footerText,
                             new Font("Tahoma", 10),
                             Brushes.Black,
                             new PointF(10, 575));
                //set the text positions
                StringFormat strFormat = new StringFormat();
                strFormat.Trimming = StringTrimming.Word;
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                
                //prevent exception for file usage
                if (tempCurrentPicture == 2)
                    {
                    myBitmap.Save(@"..\..\Images\temp1.jpg");
                    previewBox.Image = Image.FromFile(@"..\..\Images\temp1.jpg");
                    tempCurrentPicture = 1;
                    }
                else
                    {
                    myBitmap.Save(@"..\..\Images\temp2.jpg");
                    previewBox.Image = Image.FromFile(@"..\..\Images\temp2.jpg");
                    tempCurrentPicture = 2;
                    }
            }

        private void colorBox_Click(object sender, EventArgs e)
            {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed OK
            if (result == DialogResult.OK)
                {
                // Set form background to the selected color.
                myColor = colorDialog1.Color;
                colorBox.BackColor = colorDialog1.Color;
                }
            }

        public bool IsValid(string emailaddress)
            {
            try
                {
                MailAddress m = new MailAddress(emailaddress);

                return true;
                }
            catch (FormatException)
                {
                return false;
                }
            }
        }
    }
