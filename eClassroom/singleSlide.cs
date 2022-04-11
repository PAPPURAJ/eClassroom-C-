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
    public partial class singleSlide : UserControl
    {
        private string _slideName, _providedby, _dateTime;

        public singleSlide()
        {
            InitializeComponent();
        }

        [Category("Custom prop")]
        public string slideName
        {
            get { return _slideName; }
            set { _slideName = value; singleSlideNameLb.Text = value; }
        }

        [Category("Custom prop")]
        public string providedBy
        {
            get { return _providedby; }
            set { _providedby = value; singleSlideProvidedbyLb.Text = value; }
        }

        [Category("Custom prop")]
        public string dateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; singleSlideDateTimeLb.Text = value; }

        }
    }
}
