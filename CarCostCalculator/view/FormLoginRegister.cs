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
        TryCatch tryCatch = new TryCatch();
        DBConnect dbConnect = new DBConnect();

        public FormLoginRegister()
        {
            InitializeComponent();

            tmrPassword.Interval = 1000;
            tmrPassword.Enabled = false;

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
           
            if(dbConnect.TestConnectionBD() == false)
            {
                MessageBox.Show("Error : The application can not connect to the database !");
               
            }
            else
            {
                if (tryCatch.IsValidEmail(txtEmail.Text))
                {
                    if (tryCatch.IsGoodPassword(txtPassword.Text))
                    {
                        if (tryCatch.LoginOrRegisterView(txtConfirm.Visible))
                        {
                            Login login = new Login();
                            if (login.IsLoginCorrect(txtEmail.Text, txtPassword.Text) == true)
                            {
                                Application.Run(new FormCalculator());
                                Application.Exit();
                                WriteEmailInJson(txtEmail.Text);
                                MessageBox.Show("You are connected !");
                            }
                            else
                            {
                                MessageBox.Show("Error : This email don't exists or your password is false !");
                            }
                        }
                        else if (txtConfirm.Visible == true)
                        {
                            Register register = new Register();
                            if (!dbConnect.VerifyEmailAlreadyExist(txtEmail.Text))
                            {
                                if (register.RegisterNewAccount(txtEmail.Text, txtPassword.Text, txtConfirm.Text) == true)
                                {
                                    Application.Run(new FormCalculator());
                                    Application.Exit();
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
                                MessageBox.Show("Error : This email already exists !");
                            }
                        }
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
            /*
            string lastPasswordLetter = txtPassword.Text[txtPassword.Text.Length-1].ToString();
            realPassword += lastPasswordLetter;

            string hiddingPasswordPart = "";
            for (int count = 0; count < realPassword.Length - 1; count++)
            {
                hiddingPasswordPart += "*";
            }
            string passwordOut = hiddingPasswordPart + lastPasswordLetter;
            tmrPassword.Enabled = true;
            txtPassword.Text = passwordOut;
            */
        }

        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            /*
            passwordOut = "";
            for (int count = 0; count < txtPassword.TextLength; count++)
            {
                passwordOut += "*";
            }
            tmrPassword.Enabled = false;
            txtPassword.Text = passwordOut;
            */
        }
    }
}
