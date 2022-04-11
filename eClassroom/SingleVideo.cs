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
    public partial class SingleVideo : UserControl
    {
        public SingleVideo()
        {
            InitializeComponent();
        }

        private string _name, _providedBy, _link, _date;



        [Category("Custom Prop")]
        public string Name
        {
            get { return _name; }
            set { _name = value; singleVideoNameTb.Text = value; }

        }


        [Category("Custom Prop")]
        public string Providedby
        {
            get { return _providedBy; }
            set { _providedBy = value; singleVideoProvidedbyTb.Text = value; }

        }


        [Category("Custom Prop")]
        public string Link
        {
            get { return _link; }
            set { _link = value;}

        }


        [Category("Custom Prop")]
        public string DateTime
        {
            get { return _date; }
            set { _date = value; sinVideoDateTimeTb.Text = value; }

        }

        private void SingleVideo_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Video_Player(_link).Show();
        }

    }
}
