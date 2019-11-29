using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class FormLoginRegister : Form
    {
        public FormLoginRegister()
        {
            InitializeComponent();
        }

        int count = 0;
        DBConnect dbconnect = new DBConnect();
        private void btnLoginRegisterChange_Click(object sender, EventArgs e)
        {
            if (lblConfirm.Visible == true)
            {
                Text = "Car Cost Calculator - Login";
                lblTitle.Text = "Login";
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;

                btnSubmit.Text = "Sign In";
                btnChange.Text = "Sign Up";
            }
            else
            {
                Text = "Car Cost Calculator - Register";
                lblTitle.Text = "Register";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(lblConfirm.Visible == false)
            {
                dbconnect.CheckLogin(txtEmail.Text, txtPassword.PasswordChar);
            }
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                }
            }
        }
    }
}
