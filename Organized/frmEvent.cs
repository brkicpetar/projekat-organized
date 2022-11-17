using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Organized
{
    public partial class frmEvent : Form
    {
        public frmEvent(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private User user;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string folder = user.KorisnikovFolder + "todo\\" + dtpDate.Value.ToString("yyyy.MM.dd") + "\\";
            string[] content = new string[] { dtpDate.Value.ToString(user.DateFormat), txtName.Text };
            Directory.CreateDirectory(folder);
            if(Directory.GetFiles(folder).Length >= 2)
            {
                MessageBox.Show("Due to techical limiations, maximum number of events per day is 2.\n" +
                    "We're sorry for inconvinience.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            File.WriteAllLines(folder + User.HashString(txtName.Text + " " + dtpDate.Value.ToString("dd.MM.yyyy.")), content);
            MessageBox.Show("Successfully added new event for date " + dtpDate.Value.ToString("dd.MM.yyyy."), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
