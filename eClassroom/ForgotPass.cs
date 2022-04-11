using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClassroom
{
    public partial class ForgotPass : Form
    {

        string OTP;

        public ForgotPass()
        {
            InitializeComponent();
        }

        public void SendEmail(string address, string subject, string message)
        {
            string email = "komol.paul.raozan@gmail.com";
            string password = "Abc@1234";

            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);

            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(address));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            smtpClient.Send(msg);
        }


        string getRandom()
        {
            return new Random().Next(0, 1000000).ToString("000000");
        }


        private void forgotPassSendOTPBtn_Click(object sender, EventArgs e)
        {
            OTP = getRandom();

            String sendTo = forgotPassMailTb.Text;

            if(sendTo.Equals("")){
                MessageBox.Show("Please input first!");
                return;
            }

            SendEmail(sendTo, "Reset yout eClassroom password", "Your OTP is "+OTP+"! \nPlease don't share with others.");

        }

        private void forgotPassClickBtn_Click(object sender, EventArgs e)
        {
            if (OTP.Equals(forgotPassOTPTb.Text) && forgotPassPassTb.Text.Equals(forgotPassReEnPassTb.Text) && new MyFirebaseDatabase().updateUserPass(forgotPassMailTb.Text, forgotPassPassTb.Text))
           
            {
                
                MessageBox.Show("Password changed!");

            }
            else
            {
                MessageBox.Show("Password not changed!");

            }

        }

        private void loginCrossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
