using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class AddRoutine : Form
    {
        string link;
        RoutineData routineData;




        public AddRoutine(string Classlink)
        {
            link = Classlink;
            InitializeComponent();
            initFire();
        }

        void initFire()
        {
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

        IFirebaseClient client;

        private void addRoutineSubmitBtn_Click(object sender, EventArgs e)
        {


            RoutineData routineData = new RoutineData()
            {
                RoutineName=addRoutineClassNameTb.Text,
                RoutineTeacher=addRoutineTeacherNameTb.Text,
                RoutineDuration=addRoutineClassStartTb.Text+"-"+addRoutineClassEndTb.Text,
                RoutineLastupdate = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy"),
                RoutineLink=addRoutineClassLinkTb.Text
                
            };

            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@""+link+"Routine/Counter").ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }



            var set2 = client.Set(@"" + link + "Routine/Counter", ++Counter);
            var set3 = client.Set(@"" + link + "Routine/Data/" + Counter, routineData);

            MessageBox.Show("INSERTED SUCCESSFULLY");
            this.Close();




        }

        private void loginCrossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
