using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organized
{
    public partial class frmDraw : Form
    {
        public frmDraw(User user)
        {
            InitializeComponent();
            slika = new Bitmap(pbxPlatno.Width, pbxPlatno.Height);
            g = Graphics.FromImage(slika);
            this.user = user;
        }
        private User user;
        private Bitmap slika;
        private bool click = false;
        private Graphics g;
        private Point a;
        private Point b;
        private int count = 0;
        private Color boja;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbFreehand.Checked) click = false;
            else
            {
                if (count == 0)
                {
                    a = e.Location;
                    count++;
                }
                else
                {
                    b = e.Location;
                    count = 0;
                    Oblik oblik = new Oblik();
                    if (rdbLine.Checked) oblik = Oblik.linija;
                    else if (rdbRectangle.Checked) oblik = Oblik.cetvorougao;
                    else if (rdbEllipse.Checked) oblik = Oblik.elipsa;
                    Paint p = new Paint(g);
                    p.PostaviPopunjenostOblika(chkSolid.Checked);
                    p.PostaviBoju(boja);
                    p.PostaviDebljinu((int)numWeight.Value);
                    p.Crtaj(oblik, a, b);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click && rdbFreehand.Checked)
            {
                int a = (int)numWeight.Value;
                g.FillEllipse(new SolidBrush(Color.Black), e.X - a / 2, e.Y - a / 2, a, a);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbFreehand.Checked) click = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                boja = colorDialog.Color;
            }
        }

        private void rdbLine_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbLine.Checked) chkSolid.Checked = false;
        }

        private void chkSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLine.Checked) chkSolid.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            slika.Save(user.KorisnikovFolder + "sketches\\" + txtNaslov.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".png", ImageFormat.Png);
            MessageBox.Show("Successfully saved sketch.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
