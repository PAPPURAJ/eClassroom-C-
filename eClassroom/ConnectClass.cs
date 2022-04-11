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
    public partial class ConnectClass : Form
    {
        string myName,myMail;
        public ConnectClass(string name,string mail)
        {
            myMail = mail;
            myName = name;
            InitializeComponent();
        }

        private void connectClassConnectBtn_Click(object sender, EventArgs e)
        {
            string id, pass;
            id = connectClassIDLb.Text;
            pass = connectClassPassLb.Text;

            this.Hide();
            new MainMenu(false, myName, (id + pass).Replace("@", "__").Replace(".", "_"),myMail).Show();

        }

        private void connectCrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
