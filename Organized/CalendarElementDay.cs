using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organized
{
    public partial class CalendarElementDay : UserControl
    {
        public CalendarElementDay(int numOfEvents)
        {
            InitializeComponent();
            this.numOfEvents = numOfEvents;
        }
        private int numOfEvents;
        public void PostaviDan(int brojDana)
        {
            lblBrojDana.Text = brojDana.ToString();
        }
        public void PostaviEvent(string eventName)
        {
            if (lblEvent1.Text == "label1")
            {
                lblEvent1.Text = eventName;
            }
            else lblEvent2.Text = eventName;
        }
        private void CalendarElementDay_Load(object sender, EventArgs e)
        {
            if(numOfEvents == 0)
            {
                pnlEvent1.Visible = false;
                pnlEvent2.Visible = false;
            }
            else if(numOfEvents == 1)
            {
                pnlEvent2.Visible = false;
            }
        }
    }
}
