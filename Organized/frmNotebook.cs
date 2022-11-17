using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organized
{
    public partial class frmNotebook : Form
    {
        public frmNotebook(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private User user;
        private string[] slike;
        private void UcitajSlike()
        {
            lbxNotebook.Items.Clear();
            slike = Directory.GetFiles(user.KorisnikovFolder + "sketches\\");
            foreach (var item in slike)
            {
                lbxNotebook.Items.Add(Path.GetFileName(item));
            }
        }
        private void frmNotebook_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void lbxNotebook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lbxNotebook.SelectedItems.Count != 0)
            {
                frmPreview preview = new frmPreview(Bitmap.FromFile(user.KorisnikovFolder + "sketches\\" + lbxNotebook.SelectedItem));
                preview.ShowDialog();
            }
        }

        private void pbxNew_Click(object sender, EventArgs e)
        {
            frmDraw draw = new frmDraw(user);
            draw.ShowDialog();
            UcitajSlike();
        }
    }
}
