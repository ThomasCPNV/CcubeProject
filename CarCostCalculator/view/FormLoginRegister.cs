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
            txtPassword.Text = "";
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
                    if (tryCatch.IsGoodPassword(txtPassword.Text))
                    {
                        if (tryCatch.LoginOrRegisterView(txtConfirm.Visible))
                        {
                            Login login = new Login();
                            if (login.IsLoginCorrect(txtEmail.Text, txtPassword.Text) == true)
                            {
                                FormCalculator form = new FormCalculator();
                                form.ShowDialog();
                                WriteEmailInJson(txtEmail.Text);
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
                                if (register.RegisterNewAccount(txtEmail.Text, txtPassword.Text, txtConfirm.Text) == true)
                                {
                                    FormCalculator form = new FormCalculator();
                                    form.ShowDialog();
                                    WriteEmailInJson(txtEmail.Text);
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
        string passwordOut = "";
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            tmrPassword.Enabled = false;
            if (txtPassword.TextLength > realPassword.Length)
            {
                string lastPasswordLetter = txtPassword.Text[txtPassword.Text.Length - 1].ToString();
                realPassword += lastPasswordLetter;
                tmrPassword.Enabled = true;
            }
        }

        private void tmrPassword_Tick(object sender, EventArgs e)
        {
            string hiddingPasswordPart = "";
            for (int count = 0; count >= txtPassword.TextLength; count++) { hiddingPasswordPart += "*"; }
            MessageBox.Show(hiddingPasswordPart);
            txtPassword.Text = hiddingPasswordPart;
            MessageBox.Show(hiddingPasswordPart);
            tmrPassword.Enabled = false;
        }

        private void FormLoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            string jsonLocation = JsonConvert.SerializeObject(Location);
            File.WriteAllText(@"..\..\..\data\formLocation.json", jsonLocation);
        }

        private void FormLoginRegister_Load(object sender, EventArgs e)
        {

        }
    }
}