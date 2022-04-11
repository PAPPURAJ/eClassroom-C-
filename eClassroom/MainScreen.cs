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
    public partial class MainMenu : Form
    {
        bool isAdmin;
        string myName,classLink,myMail;



        public MainMenu(bool isAdmn,string Name, string classLi,string mail)
        {
            
            
            InitializeComponent();
            this.isAdmin = isAdmn;
            this.myName = Name;
            this.classLink = classLi+"\\";
            myMail = mail;
            
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "q8wgnL6pPC7RAJZ1LEcnBUIrRVbcoWEWWAAusYvO",
            BasePath = "https://online-class-reminder-e4bf0.firebaseio.com/"
        };

        IFirebaseClient client;


        private void crossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }









        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                Display();
            }
            catch
            {
                MessageBox.Show("There is a problem with your internet connection!");
            }

        }



        private void Display()
        {
            string type = appNameLb.Text;

            FirebaseResponse res = client.Get(@"" + classLink + type + "/Counter");
            int Counter;
            try
            {
                Counter = int.Parse(res.ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }

            for (int i = 1; i <= Counter; i++)
            {

                try
                {

                    switch (appNameLb.Text)
                    {

                        case "Routine":
                            FirebaseResponse res2 = client.Get(@"" + classLink + type + "/Data/" + i);
                            RoutineData routineData = res2.ResultAs<RoutineData>();


                            if (!routineData.Equals(null))
                            {
                                singleRoutine sinRou = new singleRoutine(classLink);
                                sinRou.Title = routineData.RoutineName;
                                sinRou.TeacherName = routineData.RoutineTeacher;
                                sinRou.Duration = routineData.RoutineDuration;
                                sinRou.ClassURL = routineData.RoutineLink;
                                sinRou.LastUpdate = routineData.RoutineLastupdate;
                                routineFlPanel.Controls.Add(sinRou);
                            }
                            break;



                        case "Notice":
                            FirebaseResponse res3 = client.Get(@"" + classLink + type + "/Data/" + i);
                            NoticeData noticeData = res3.ResultAs<NoticeData>();


                            if (!noticeData.message.Equals(""))
                            {
                                SingleNotice sinNotice = new SingleNotice(classLink);
                                sinNotice.message = noticeData.message;
                                sinNotice.sender = noticeData.senderName;
                                sinNotice.dateTime = noticeData.time + " - " + noticeData.date;

                                routineFlPanel.Controls.Add(sinNotice);
                            }
                            break;



                        case "Slide":
                            FirebaseResponse res4 = client.Get(@"" + classLink + type + "/Data/" + i);
                            slideData slideData = res4.ResultAs<slideData>();


                            if (!slideData.SlideLink.Equals(""))
                            {
                                singleSlide sinSlide = new singleSlide();
                                sinSlide.slideName = slideData.SlideName;
                                sinSlide.dateTime = slideData.SlideDateTime;
                                sinSlide.providedBy = slideData.SlideProvidedBye;
                                routineFlPanel.Controls.Add(sinSlide);
                            }
                            break;



                        case "Video":
                            FirebaseResponse res5 = client.Get(@"" + classLink + type + "/Data/" + i);
                            VideoData videoData = res5.ResultAs<VideoData>();


                            if (!videoData.VideoLink.Equals(""))
                            {
                                SingleVideo singleVideo = new SingleVideo();
                                singleVideo.Name = videoData.VideName;
                                singleVideo.Providedby = videoData.VideProvidedBye;
                                singleVideo.DateTime = videoData.VideoDateTime;
                                singleVideo.Link = videoData.VideoLink;
                                routineFlPanel.Controls.Add(singleVideo);
                            }
                            break;



                        case "Info":
                            FirebaseResponse res6 = client.Get(@"" + classLink + type + "/Data/" + i);
                            StudentInfoData stdInfoData = res6.ResultAs<StudentInfoData>();


                            if (!stdInfoData.name.Equals(""))
                            {
                                SingleStdInfo singleStdInfo = new SingleStdInfo();
                                singleStdInfo.StdID = stdInfoData.stdID;
                                singleStdInfo.Name = stdInfoData.name;
                                singleStdInfo.Email = stdInfoData.mail;
                                singleStdInfo.Mobile = stdInfoData.phone;
                                singleStdInfo.HomeTown = stdInfoData.homeTown;
                                singleStdInfo.Blood = stdInfoData.blood;
                                routineFlPanel.Controls.Add(singleStdInfo);
                            }
                            break;

                    }

                }
                catch { }
            }

 
        }






        private void addItem_Click(object sender, EventArgs e)
        {


            switch (appNameLb.Text)
            {


                case "Routine":
                       new AddRoutine(classLink).Show();                        
                        break;


                case "Notice":
                        new Notice(myName, classLink).Show();
                        break;


                case "Slide":
                        new AddSlide(classLink).Show();
                        break;


                case "Video":
                        new AddVideo(classLink).Show();
                        break;
                    

                default:
                    {
                        new AddInformation(classLink).Show();
                        break;
                    }



            }


            Display();

        }

        private void routineBtn_Click(object sender, EventArgs e)
        {
            
            routineFlPanel.Controls.Clear();   
            appNameLb.Text = "Routine";
            Display();
        }

        private void noticeBtn_Click(object sender, EventArgs e)
        {

            routineFlPanel.Controls.Clear();   
            appNameLb.Text = "Notice";
            Display();
        }

        private void slideBtn_Click(object sender, EventArgs e)
        {
            routineFlPanel.Controls.Clear(); 
            appNameLb.Text = "Slide";
            Display();
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {

            routineFlPanel.Controls.Clear();   
            appNameLb.Text = "Video";
            Display();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {

            routineFlPanel.Controls.Clear();   
            appNameLb.Text = "Info";
            Display();
        }




        private void mainScreenPassEditBtn_Click(object sender, EventArgs e)
        {
            new PassChange(myMail).Show();
        }


    }
}
