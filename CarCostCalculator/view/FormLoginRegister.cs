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
        string locationStringFileName = @"..\..\..\data\formLocation.json";
        TryCatch tryCatch = new TryCatch();
        DBConnect dbConnect = new DBConnect();

        public FormLoginRegister()
        {
            InitializeComponent();

            if (!Directory.Exists(dataStringPath)) { Directory.CreateDirectory(dataStringPath); }

            if (File.Exists(emailStringFileName))
            {
                long fileWeight = new FileInfo(emailStringFileName).Length;
                if (fileWeight > 0) { txtEmail.Text = ReadEmailInJson(); }
            }
            else
            {
                File.Create(emailStringFileName).Close();
                File.WriteAllText(@"..\..\..\data\email.json", "\"\"");
            }

            if (File.Exists(locationStringFileName))
            {
                var jsonLocation = ReadLocationInJson();
                var location = jsonLocation.Split(',');
                Location = new Point(
                    int.Parse(location[0]),
                    int.Parse(location[1])
                    );
            }
            else
            {
                File.Create(locationStringFileName).Close();
                File.WriteAllText(@"..\..\..\data\formLocation.json", "\"\"");
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
            realPassword = "";
            txtPassword.Text = "";
            realConfirm = "";
            txtConfirm.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (dbConnect.TestConnectionBD() == false)
            {
                MessageBox.Show("Error : The application can not connect to the database !");
               
            }
            else
            {
                if (tryCatch.IsValidEmail(txtEmail.Text))
                {
                    if (tryCatch.IsGoodPassword(realPassword))
                    {
                        if (tryCatch.LoginOrRegisterView(txtConfirm.Visible))
                        {
                            Login login = new Login();
                            if (login.IsLoginCorrect(txtEmail.Text, realPassword) == true)
                            {
                                FormCalculator form = new FormCalculator();
                                form.ShowDialog();
                                WriteEmailInJson(txtEmail.Text);
                                form.Tag = txtEmail.Text;
                                MessageBox.Show("You are connected !");
                                Application.Exit();
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
                                if (register.RegisterNewAccount(txtEmail.Text, realPassword, realConfirm) == true)
                                {
                                    FormCalculator form = new FormCalculator();
                                    form.ShowDialog();
                                    WriteEmailInJson(txtEmail.Text);
                                    form.Tag = txtEmail.Text;
                                    MessageBox.Show("You are registred !");
                                    Application.Exit();
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

        private string ReadLocationInJson()
        {
            string location = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\..\data\formLocation.json")).ToString();
            return location;
        }

        string realPassword = "";
        string realConfirm = "";
        string passwordOut = "";
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength > realPassword.Length)
            {
                tmrPassword.Enabled = false;
                string hiddingPasswordPart = "";
                string fullPassword = "";
                string lastPasswordLetter = txtPassword.Text[txtPassword.TextLength - 1].ToString();
                realPassword += lastPasswordLetter;
                for (int count = 1; count <= txtPassword.TextLength - 1; count++) { hiddingPasswordPart += '*'; }
                fullPassword = hiddingPasswordPart + lastPasswordLetter;
                tmrPassword.Enabled = true;
                txtPassword.Text = fullPassword;
                txtPassword.SelectionStart = txtPassword.TextLength;
            }
            if(txtPassword.TextLength < realPassword.Length)
            {
                realPassword = realPassword.Remove(realPassword.Length - 1);
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.TextLength > realConfirm.Length)
            {
                tmrConfirm.Enabled = false;
                string hiddingConfirmPart = "";
                string fullConfirm = "";
                string lastConfirmLetter = txtConfirm.Text[txtConfirm.TextLength - 1].ToString();
                realConfirm += lastConfirmLetter;
                for (int count = 1; count <= txtConfirm.TextLength - 1; count++) { hiddingConfirmPart += '*'; }
                fullConfirm = hiddingConfirmPart + lastConfirmLetter;
                tmrConfirm.Enabled = true;
                txtConfirm.Text = fullConfirm;
                txtConfirm.SelectionStart = txtConfirm.TextLength;
            }
            if (txtConfirm.TextLength < realConfirm.Length)
            {
                realConfirm = realConfirm.Remove(realConfirm.Length - 1);
            }
        }

        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            string hiddingPasswordPart = "";
            for (int count = 1; count <= txtPassword.TextLength; count++) { hiddingPasswordPart += '*'; }
            txtPassword.Text = hiddingPasswordPart;
            txtPassword.SelectionStart = txtPassword.TextLength;

            tmrPassword.Enabled = false;
        }

        private void tmrConfirm_Tick(object sender, EventArgs e)
        {
            string hiddingPasswordPart = "";
            for (int count = 1; count <= txtConfirm.TextLength; count++) { hiddingPasswordPart += '*'; }
            txtConfirm.Text = hiddingPasswordPart;
            txtConfirm.SelectionStart = txtConfirm.TextLength;

            tmrConfirm.Enabled = false;
        }

        private void FormLoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            string jsonLocation = JsonConvert.SerializeObject(Location);
            File.WriteAllText(@"..\..\..\data\formLocation.json", jsonLocation);
        }
    }
}