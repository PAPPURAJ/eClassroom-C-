using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClassroom
{
    public partial class PassChange : Form
    {
        string  userMail;

        public PassChange(string mail)
        {
            userMail=mail;
            InitializeComponent();
        }

        private void loginCrossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void forgotPassClickBtn_Click(object sender, EventArgs e)
        {

            string oldPass, newPass, newPass2;
            oldPass = passChangeCorTb.Text;
            newPass = passChangeNewTb.Text;
            newPass2 = passChangeNew2Tb.Text;

            if (oldPass.Equals("") || newPass.Equals("") || newPass.Equals(""))
            {
                MessageBox.Show("Please enter all input!");
                return;
            }

            if (new MyFirebaseDatabase().updateUserPass(userMail, oldPass, newPass2))
            {

                MessageBox.Show("Password changed!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cannot be changed!"); 
            }


        }
    }
}
