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
            this.user = user;
            slika = new Bitmap(pbxPlatno.Width, pbxPlatno.Height);
            g = Graphics.FromImage(slika);
            g.Clear(Color.White);
            pbxPlatno.Image = slika;
        }
        private User user;
        private Bitmap slika;
        private bool click = false;
        private Graphics g;
        private Point a;
        private Point b;
        private int count = 0;
        private Color boja = Color.Black;
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
                    Paint.Oblik oblik = new Paint.Oblik();
                    if (rdbLine.Checked) oblik = Organized.Paint.Oblik.linija;
                    else if (rdbRectangle.Checked) oblik = Organized.Paint.Oblik.cetvorougao;
                    else if (rdbEllipse.Checked) oblik = Organized.Paint.Oblik.elipsa;
                    Paint p = new Paint(slika);
                    p.PostaviPopunjenostOblika(chkSolid.Checked);
                    p.PostaviBoju(boja);
                    p.PostaviDebljinu((int)numWeight.Value);
                    p.Crtaj(oblik, a, b);
                }
            }
            pbxPlatno.Refresh();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click && rdbFreehand.Checked)
            {
                int a = (int)numWeight.Value;
                g.FillEllipse(new SolidBrush(boja), e.X - a / 2, e.Y - a / 2, a, a);
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
                pictureBox2.BackColor = boja;
            }
        }

        private void rdbLine_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbLine.Checked) chkSolid.Checked = false;
        }

        private void chkSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLine.Checked || rdbFreehand.Checked) chkSolid.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNaslov.Text))
            {
                MessageBox.Show("Title field is blank. Please fill it in and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            slika.Save(user.KorisnikovFolder + "sketches\\" + txtNaslov.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".png", ImageFormat.Png);
            MessageBox.Show("Successfully saved sketch.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void rdbFreehand_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFreehand.Checked) chkSolid.Checked = false;
        }
    }
}
