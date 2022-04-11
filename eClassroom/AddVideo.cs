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
    public partial class AddVideo : Form
    {
        string link;
        IFirebaseClient client;
        public AddVideo(string Classlink)
        {
            link = Classlink;
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

        private void addVideoSubmitBtn_Click(object sender, EventArgs e)
        {
            VideoData noticeData = new VideoData()
            {
                VideName = addVideoNameTb.Text,
                VideProvidedBye = addVideoProvidedbyTb.Text,
                VideoDateTime = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy"),
                VideoLink = addVideoLinkTb.Text
            };

            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"" + link + "Video/Counter").ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }



            var set2 = client.Set(@"" + link + "Video/Counter", ++Counter);
            var set3 = client.Set(@"" + link + "Video/Data/" + Counter, noticeData);

            MessageBox.Show("INSERTED SUCCESSFULLY");
            this.Close();
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
