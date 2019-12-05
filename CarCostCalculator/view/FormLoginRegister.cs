using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

using model;

namespace view
{
    public partial class FormLoginRegister : Form
    {
        string dataStringPath = @"..\..\..\data";
        string emailStringFileName = @"..\..\..\data\email.json";

        public FormLoginRegister()
        {
            InitializeComponent();
            tmrPassword.Interval = 1000;
            tmrPassword.Enabled = true;
            if (File.Exists(emailStringFileName))
            {
                long fileWeight = new FileInfo(emailStringFileName).Length;
                if (fileWeight > 0)
                {
                    txtEmail.Text = ReadEmailInJson();
                }
            }
            else
            {
                if (!Directory.Exists(dataStringPath))
                {
                    Directory.CreateDirectory(dataStringPath);
                    File.Create(emailStringFileName).Close();
                    File.WriteAllText(@"..\..\..\data\email.json", "\"\"");
                }
            }
        }

        private void btnLoginRegisterChange_Click(object sender, EventArgs e)
        {
            if (lblConfirm.Visible == true)
            {
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;

                btnSubmit.Text = "Sign In";
                btnChange.Text = "Sign Up";

                Text = "CarCostCalculator - Login";
            }
            else
            {
                lblConfirm.Visible = true;
                txtConfirm.Visible = true;

                btnSubmit.Text = "Sign Up";
                btnChange.Text = "Sign In";

                Text = "CarCostCalculator - Register";
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
            if (IsValidEmail(txtEmail.Text))
            {
                if (IsGoodPassword(txtPassword.Text))
                {
                    if (txtConfirm.Visible == false)
                    {
                        Login login = new Login();
                        if (login.IsLoginCorrect(txtEmail.Text, txtPassword.Text) == true)
                        {
                            //Application.Run(new FormCarCostCalculator());
                            WriteEmailInJson(txtEmail.Text);
                            MessageBox.Show("You are connected !");
                        }
                        else
                        {
                            MessageBox.Show("Error : Your email or your password is false !");
                        }
                    }
                    else if (txtConfirm.Visible == true)
                    {
                        Register register = new Register();
                        if (register.RegisterNewAccount(txtEmail.Text, txtPassword.Text, txtConfirm.Text) == true)
                        {
                            //Application.Run(new FormCarCostCalculator());
                            WriteEmailInJson(txtEmail.Text);
                            MessageBox.Show("You are registred !");
                        }
                        else
                        {
                            MessageBox.Show("Error : Your email is false or the password and the confirmation are not sames !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : An error has occurred !");
                    }
                }
            }
        }

        private void WriteEmailInJson(string email)
        {
            if (txtEmail.Text != null)
            {
                string jsonEmail = JsonConvert.SerializeObject(email);
                File.WriteAllText(@"..\..\..\data\email.json", jsonEmail);
            }
        }

        private string ReadEmailInJson()
        {
            string email = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\..\data\email.json")).ToString();
            return email;
        }

        string realPassword = "";
        string passwordOut = "";
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string lastPasswordLetter = txtPassword.Text[txtPassword.Text.Length - 1].ToString();
            realPassword += lastPasswordLetter;

            string hiddingPasswordPart = "";
            for (int count = 0; count < realPassword.Length - 1; count++)
            {
                hiddingPasswordPart += "*";
            }
            string passwordOut = hiddingPasswordPart + lastPasswordLetter;
            tmrPassword.Enabled = true;
            txtPassword.Text = passwordOut;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            passwordOut = "";
            for (int count = 0; count < txtPassword.TextLength; count++)
            {
                passwordOut += "*";
            }
            tmrPassword.Enabled = false;
            txtPassword.Text = passwordOut;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("This isn't an email !");
                return false;
            }
        }

        private bool IsGoodPassword(string password)
        {
            try
            {
                return password.Length >= 8;
            }
            catch
            {
                MessageBox.Show("The password must be at least eight characters long !");
                return false;
            }
        }
    }
}
