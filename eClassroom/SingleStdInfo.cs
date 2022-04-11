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
    public partial class SingleStdInfo : UserControl
    {
        public SingleStdInfo()
        {
            InitializeComponent();
        }

        private string _stdID, _name, _mobile, _email, _blood, _homeTown;

        [Category("Custom Prop")]
        public string StdID
        {
            get { return _stdID; }
            set
            {
                _stdID = value; singleStdIDTb.Text = "Student ID: " + value;}

        }


        [Category("Custom Prop")]
        public string Name
        {
            get { return _name; }
            set { _name = value; singleInfoNameLb.Text = value; }

        }




        [Category("Custom Prop")]
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; singleInfoPhoneLb.Text = "Phone: "+value; }

        }




        [Category("Custom Prop")]
        public string Email
        {
            get { return _email; }
            set { _email = value;}

        }




        [Category("Custom Prop")]
        public string Blood
        {
            get { return _blood; }
            set { _blood = value; }

        }




        [Category("Custom Prop")]
        public string HomeTown
        {
            get { return _homeTown; }
            set { _homeTown = value; }

        }

        private void SingleStdInfo_Click(object sender, EventArgs e)
        {
            StudentInfoData infoData = new StudentInfoData()
            {
                stdID=_stdID,
                name=_name,
                phone=_mobile,
                mail=_email,
                blood=_blood,
                homeTown=_homeTown

            };

            new ProfileDetails(infoData).Show();
        }


    }
}
