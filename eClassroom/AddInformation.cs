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
    public partial class AddInformation : Form
    {
        string link;
        public AddInformation(string classLink)
        {
            link = classLink;
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
        IFirebaseClient client;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "q8wgnL6pPC7RAJZ1LEcnBUIrRVbcoWEWWAAusYvO",
            BasePath = "https://online-class-reminder-e4bf0.firebaseio.com/"
        };
        private void addinformationSaveBtn_Click(object sender, EventArgs e)
        {
            string studentID = addinformationStdIDTb.Text;
            string name = addinformationNameTb.Text;
            string mail = addinformationMailTb.Text;
            string phone = addinformationPhoneTb.Text;
            string blood = addinformationBloodTb.Text;
            string homeTown = addinformationHometownTb.Text;



            StudentInfoData stdInfoData = new StudentInfoData()
            {
                stdID=studentID,
                name=name,
                phone=phone,
                mail=mail,
                blood=blood,
                homeTown=homeTown

            };

            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@""+link+"Info/Counter").ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }



            var set2 = client.Set(@"" + link + "Info/Counter", ++Counter);
            var set3 = client.Set(@"" + link + "Info/Data/" + Counter, stdInfoData);

            MessageBox.Show("INSERTED SUCCESSFULLY");
            this.Close();
            




        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
