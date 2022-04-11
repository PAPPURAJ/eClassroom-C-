using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eClassroom
{
    public partial class SingleNotice : UserControl
    {
        private string messageText,senderName, dateTimee,classLink;   

        public SingleNotice(String dbLink)
        {
            classLink = dbLink;
            InitializeComponent();
        }




        [Category("Custom Prop")]
        public string sender
        {
            get { return senderName; }
            set { senderName = value; SingleNoticeSenderLb.Text = value; }

        }


        [Category("Custom Prop")]
        public string dateTime
        {
            get { return dateTimee; }
            set { dateTimee = value; SingleDateTimeLb.Text = value; }

        }


        [Category("Custom Prop")]
        public string message
        {
            get { return messageText; }
            set { messageText = value; SingleNoticeLb.Text = value; }

        }

        private void singleNoticeEditBtn_Click(object sender, EventArgs e)
        {
            if (new MyFirebaseDatabase().editOrDeleteNotice(classLink, messageText))
            {
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Deleting failed!");
            }
        }


    }
}
