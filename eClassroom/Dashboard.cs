﻿using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(bool userType)
        {
            InitializeComponent();
            label1.Text = "" + userType;
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
