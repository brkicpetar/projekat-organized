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
    public partial class frmPreview : Form
    {
        public frmPreview(Image slika)
        {
            InitializeComponent();
            this.slika = slika;
        }
        private Image slika;
        private void frmPreview_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = slika;
            pictureBox1.Refresh();
        }
    }
}
