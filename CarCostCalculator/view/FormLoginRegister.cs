using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using model;

namespace view
{
    public partial class FormLoginRegister : Form
    {
        public FormLoginRegister()
        {
            InitializeComponent();
        }

        private void btnLoginRegisterChange_Click(object sender, EventArgs e)
        {
            if (lblConfirm.Visible == true)
            {
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;

                btnSubmit.Text = "Sign In";
                btnChange.Text = "Sign Up";
            }
            else
            {
                lblConfirm.Visible = true;
                txtConfirm.Visible = true;

                btnSubmit.Text = "Sign Up";
                btnChange.Text = "Sign In";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(txtConfirm.Visible == false)
            {
                Login login = new Login();
                login.IsLoginCorrect(txtEmail.Text, txtPassword.Text);
            }else if(txtConfirm.Visible == true)
            {
                Register register = new Register();
                register.RegisterNewAccount(txtEmail.Text, txtPassword.Text, txtConfirm.Text);
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite !");
            }
        }
    }
}
