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
    public partial class Notice : Form
    {
        IFirebaseClient client;
        string link;
        string snderName;


        public Notice(string name, string li)
        {
            MessageBox.Show(name);
            link = li;
            snderName = name;

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

        private void addNoticeBtn_Click(object sender, EventArgs e)
        {
            NoticeData noticeData = new NoticeData()
            {
                message=addNoticeTb.Text,
                date = DateTime.Now.ToString("MM/dd/yyyy"),
                time = DateTime.Now.ToString("HH:mm:ss"),
                senderName=snderName


            };

            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"" + link + "Notice/Counter").ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }



            var set2 = client.Set(@"" + link + "Notice/Counter", ++Counter);
            var set3 = client.Set(@"" + link + "Notice/Data/" + Counter, noticeData);

            MessageBox.Show("INSERTED SUCCESSFULLY");
            this.Close();
        }

        private void noticeCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
