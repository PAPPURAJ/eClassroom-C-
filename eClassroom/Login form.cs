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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void createAccountClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateAnAccountForm().Show();  
       
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string mail=loginMailTb.Text;
            string pass=loginPassTb.Text;

            if (!(mail.LastIndexOf("@") > -1))
            {
                MessageBox.Show("Invalid email!");
                return;
            }


            switch (new MyFirebaseDatabase().checkUserisAdmin(mail, pass))
            {
                case 1:
                    this.Hide();
                    break;


                case 0:
                    //MessageBox.Show("User");
                  //  new Dashboard(false).Show();
                    this.Hide();
                    break;


                case -1:
                    MessageBox.Show("Not registered!");
                    break;

            }

        }

        private void loginCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forgotPassLb_Click(object sender, EventArgs e)
        {
            new ForgotPass().Show();
        }
    }
}
