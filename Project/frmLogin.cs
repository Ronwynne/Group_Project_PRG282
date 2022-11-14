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
        Validation val = new Validation();
        LoginHandler login = new LoginHandler();
        frmMain main = new frmMain();
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool correct = false;

            bool validated = val.LogInValidation(username, password);
            if (validated == false)
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                correct = login.Login(username, password);
            }
            if (correct == true)
            {
                main.Show();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect, please enter the correct username and password.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;  
            string password = txtNewPassword.Text;
            string confirm = txtConfirm.Text;
            string message = "";

           bool flag = val.newUserValidation(username, password, confirm);
            if (flag == false)
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                message = login.CreateAccount(username, password, confirm);
            }

            if (message == "Account successfully created")
            {
                
                main.Show();
            }

        }
    }
}
