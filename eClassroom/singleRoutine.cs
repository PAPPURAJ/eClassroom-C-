using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace eClassroom
{
    public partial class singleRoutine : UserControl
    {
        string databaseLink;
        public singleRoutine(string dbLink)
        {
            databaseLink = dbLink;
            InitializeComponent();
        }


        private string _title,_teacherName,_duration,_lastUpdate,_link;

        [Category("Custom Prop")]
        public string Title
        {
            get { return _title; }
            set { _title = value; singleRoutineSubNameLb.Text = value; }

        }


        [Category("Custom Prop")]
        public string TeacherName
        {
            get { return _teacherName; }
            set { _teacherName = value; sinTeachNameLb.Text = value; }

        }



        [Category("Custom Prop")]
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; singleRoutineDuration.Text = value; }

        }



        [Category("Custom Prop")]
        public string LastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; singleRoutineLastUpdateLb.Text = "Last Update: "+ value; }

        }



       [Category("Custom Prop")]
       public string ClassURL
       {
           get { return _link; }
           set { _link = value; }

       }

       private void singleRoutine_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start("https://" + _link);
       }

       private void singleRoutineDeleteBtn_Click(object sender, EventArgs e)
       {
           if (new MyFirebaseDatabase().deleteRoutine(databaseLink, _duration))
           {
               MessageBox.Show("Routine Deleted!");

           }
           else
           {
               MessageBox.Show("Routine not deleted!");
           }
       }

       private void singleRoutineEditBtn_Click(object sender, EventArgs e)
       {

       }






        


    }
}
