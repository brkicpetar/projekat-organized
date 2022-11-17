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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if((txtName.Text == "Name" && txtName.ForeColor == Color.DarkGray) ||
                (txtUsername.Text == "Username" && txtUsername.ForeColor == Color.DarkGray) ||
                (txtPassword.Text == "Password" && txtPassword.ForeColor == Color.DarkGray) ||
                (txtConfirmPassword.Text == "Confirm password" && txtConfirmPassword.ForeColor == Color.DarkGray))
            {
                MessageBox.Show("Some fields are blank.\nCheck all fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User newUser = new User();
            newUser.Username = txtUsername.Text;
            newUser.Name = txtName.Text;
            if (txtPassword.Text == txtConfirmPassword.Text) newUser.Password = txtPassword.Text;
            else
            {
                MessageBox.Show("Passwords are not matching! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newUser.TryRegister())
            {
                MessageBox.Show("Successfully created user! Feel free to login into system.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This user already exists in database.\n" +
                    "Try logging into system.\n" +
                    "If needed, contact assistance team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmLogin f = new frmLogin();
            f.Show();
            this.Close();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" && !txtPassword.UseSystemPasswordChar)
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DarkGray;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm password" && !txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "" && txtConfirmPassword.UseSystemPasswordChar)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.Text = "Confirm password";
                txtConfirmPassword.ForeColor = Color.DarkGray;
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            lblFocus.Focus();
            this.ActiveControl = lblFocus;
        }
    }
}
