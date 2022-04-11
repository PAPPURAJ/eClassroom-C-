using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class CreateAnAccountForm : Form
    {
        IFirebaseClient client;
        public CreateAnAccountForm()
        {
            InitializeComponent();

            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There is a problem with your internet connection!");
            }
        }



        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "q8wgnL6pPC7RAJZ1LEcnBUIrRVbcoWEWWAAusYvO",
            BasePath = "https://online-class-reminder-e4bf0.firebaseio.com/"
        };

        private void createAccLoginBtn_Click(object sender, EventArgs e)
        {
            String name, mail, pass, pass2, classID, classPass;
            bool isAdmin;


            name = createAccNameLb.Text;
            mail = createAccMailLb.Text;
            pass = createAccPassLb.Text;
            pass2 = createAccPass2Lb.Text;
            classID = createAccClassIDTb.Text;
            classPass = createAccClassPassLb.Text;

            if (!(mail.LastIndexOf("@") > -1))
            {
                MessageBox.Show("Invalid email!");
                return;
            }


            if (createAccUserRadio.Checked == false || createAccAdminRadio.Checked == true)
                isAdmin = true;
            else
                isAdmin = false;

            UserData userDt;

            if (isAdmin)
            {

                userDt = new UserData
                {
                    name = name,
                    pass = pass,
                    email = mail,
                    userType = "admin",
                    classID = classID,
                    classPass = classPass

                };

            }

            else
            {
                userDt = new UserData
                {
                    name = name,
                    pass = pass,
                    email = mail,
                    userType = "user",
                    classID = "",
                    classPass = ""

                };



            }

            new MyFirebaseDatabase().addUser(userDt);

            MessageBox.Show("Sign up successfully!");
            createAccountClick_Click(null,null);



        }

        private void createAccountClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_form().Show();
        }

        private void CreateAccCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
