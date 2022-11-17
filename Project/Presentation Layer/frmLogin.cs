using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            pnlSignUp.Show();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNewUsername.Focus();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            pnlSignUp.Hide();
            pnlLogin.Show();
            txtNewUsername.Text = "";
            txtNewPassword.Text = "";
            txtConfirm.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.Login(txtUsername.Text, txtPassword.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The username or password you have entered is not correct.", "Access Denied",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string usr = txtNewUsername.Text;
            string pass = txtNewPassword.Text;
            string confirm = txtConfirm.Text;
            MessageBox.Show(Validator.CreateAccount(usr, pass, confirm), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            DialogResult = DialogResult.OK;
        }
    }
}
