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
    public partial class ProfileDetails : Form
    {
        public ProfileDetails()
        {
            InitializeComponent();
        }

        public ProfileDetails(StudentInfoData userData)
        {
            InitializeComponent();
            userProfileStdIDLb.Text = userData.stdID;
            userProfileNameLb.Text = userData.name;
            userProfilePhnLb.Text = userData.phone;
            userProfileMailLb.Text = userData.mail;
            userProfileBloodLb.Text = userData.blood;
            userProfileHomeLb.Text = userData.homeTown;
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
