/*
 * Developer : Samuel Meyer
 * Version : 1.0
 * Creation date : 29.11.2019 
 */

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
    /// <summary>
    /// This is used for all the interactions with the Login/Register's view
    /// </summary>
    public partial class FormLoginRegister : Form
    {
        string dataStringPath = @"..\..\..\data";
        string emailStringFileName = @"..\..\..\data\email.json";
        string locationStringFileName = @"..\..\..\data\formLocation.json";
        TryCatch tryCatch = new TryCatch();
        DBConnect dbConnect = new DBConnect();
        string email = "";

        string realPassword = "";
        string realConfirm = "";
        string passwordOut = "";

        public FormLoginRegister()
        {
            InitializeComponent();

            /// Directory and files creation if don't exists.
            /// When thy exists, read in files and enter then in the window.

            // Directory verifier.
            if (!Directory.Exists(dataStringPath)) { Directory.CreateDirectory(dataStringPath); }

            // Email datas verifier.
            if (File.Exists(emailStringFileName))
            {
                // Email login/Register entry initialisation with json file value.
                long fileWeight = new FileInfo(emailStringFileName).Length;
                if (fileWeight > 0) { txtEmail.Text = ReadEmailInJson(); }
            }
            else
            {
                // Email json file creation.
                File.Create(emailStringFileName).Close();
                File.WriteAllText(@"..\..\..\data\email.json", "\"\"");
            }

            // Window location datas verifier.
            if (File.Exists(locationStringFileName))
            {
                // Convert json location to two integers.
                var jsonLocation = ReadLocationInJson();
                var location = jsonLocation.Split(',');
                Location = new Point(
                    int.Parse(location[0]),
                    int.Parse(location[1])
                    );
            }
            else
            {
                // Location json file creation.
                File.Create(locationStringFileName).Close();
                File.WriteAllText(@"..\..\..\data\formLocation.json", "\"\"");
            }
        }

        /// <summary>
        /// Login Register Window switcher function.
        /// </summary>
        private void btnLoginRegisterChange_Click(object sender, EventArgs e)
        {
            // Login window initialisation.
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
                // Register window initialisation.
                lblConfirm.Visible = true;
                txtConfirm.Visible = true;

                btnSubmit.Text = "Sign Up";
                btnChange.Text = "Sign In";

                Text = "CarCostCalculator - Register";
            }
        }

        /// <summary>
        /// Login/Register entries reseter.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";

            txtPassword.Text = "";
            realPassword = "";
            passwordOut = "";

            txtConfirm.Text = "";
            realConfirm = "";

            email = txtEmail.Text;
        }

        // Login/Register Quit button.
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Login/Register functions.
        /// </summary>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Database connection.
            if (dbConnect.TestConnectionBD() == false)
            {
                MessageBox.Show("Error : The application can not connect to the database !");
            }
            else
            {
                // Email verification.
                if (tryCatch.IsValidEmail(txtEmail.Text))
                {
                    // Password verification.
                    if (tryCatch.IsGoodPassword(realPassword))
                    {
                        // Login or register ?
                        if (tryCatch.LoginOrRegisterView(txtConfirm.Visible))
                        {
                            Login login = new Login();
                            // Login connection.
                            if (login.IsLoginCorrect(txtEmail.Text, realPassword) == true)
                            {
                                this.Hide();
                                MessageBox.Show("You are connected !");
                                email = txtEmail.Text;
                                // Open calculator window.
                                FormCalculator form = new FormCalculator(email);
                                form.ShowDialog();
                                // Write email in json.
                                WriteEmailInJson(txtEmail.Text);
                            }
                            else
                            {
                                MessageBox.Show("Error : This email don't exists or your password is false !");
                            }
                        }
                        else if (txtConfirm.Visible == true)
                        {
                            Register register = new Register();
                            // Registration and connection.
                            if (!dbConnect.VerifyEmailAlreadyExist(txtEmail.Text))
                            {
                                if (register.RegisterNewAccount(txtEmail.Text, realPassword, realConfirm) == true)
                                {
                                    this.Hide();
                                    MessageBox.Show("You are registred !");
                                    email = txtEmail.Text;
                                    // Open calculator window.
                                    FormCalculator form = new FormCalculator(email);
                                    form.ShowDialog();
                                    // Write email in json.
                                    WriteEmailInJson(txtEmail.Text);
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
            txtEmail.Text = "";

            txtPassword.Text = "";
            realPassword = "";
            passwordOut = "";

            txtConfirm.Text = "";
            realConfirm = "";
        }

        /// <summary>
        /// Write the email in json file
        /// </summary>
        private void WriteEmailInJson(string email)
        {
            if (txtEmail.Text != null)
            {
                // Convert email string to json
                string jsonEmail = JsonConvert.SerializeObject(email);
                // Write json in file
                File.WriteAllText(@"..\..\..\data\email.json", jsonEmail);
            }
        }

        /// <summary>
        /// Reader in json file
        /// </summary>
        private string ReadEmailInJson()
        {
            // Convert json to email string
            string email = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\..\data\email.json")).ToString();
            return email;
        }

        /// <summary>
        /// Reader Window location in json file
        /// </summary>
        private string ReadLocationInJson()
        {
            // Convert json to two integers X and Y
            string location = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\..\data\formLocation.json")).ToString();
            return location;
        }

        /// <summary>
        /// Password WildCard
        /// Replace all caracters by a star apart the last letter.
        /// </summary>
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

        /// <summary>
        /// Confirm WildCard
        /// Replace all caracters by a star apart the last letter.
        /// </summary>
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

        /// <summary>
        /// Change password entry to stars envery seconds
        /// </summary>
        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            string hiddingPasswordPart = "";
            for (int count = 1; count <= txtPassword.TextLength; count++) { hiddingPasswordPart += '*'; }
            txtPassword.Text = hiddingPasswordPart;
            txtPassword.SelectionStart = txtPassword.TextLength;

            tmrPassword.Enabled = false;
        }

        /// <summary>
        /// Change confirm entry to stars envery seconds
        /// </summary>
        private void tmrConfirm_Tick(object sender, EventArgs e)
        {
            string hiddingPasswordPart = "";
            for (int count = 1; count <= txtConfirm.TextLength; count++) { hiddingPasswordPart += '*'; }
            txtConfirm.Text = hiddingPasswordPart;
            txtConfirm.SelectionStart = txtConfirm.TextLength;

            tmrConfirm.Enabled = false;
        }

        /// <summary>
        /// Email saver in json file while FormLoginRegister Closed
        /// </summary>
        private void FormLoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Convert email string to json
            string jsonLocation = JsonConvert.SerializeObject(Location);
            // Write json in file
            File.WriteAllText(@"..\..\..\data\formLocation.json", jsonLocation);
        }
    }
}