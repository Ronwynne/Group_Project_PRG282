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
            this.DialogResult = DialogResult.OK;
        }
    }
}
