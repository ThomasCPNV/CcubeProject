﻿using System;
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
        public FormLoginRegister()
        {
            InitializeComponent();
            txtEmail.Text = ReadEmailInJson();
        }

        string dataStringPath = @"..\..\..\data";

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
            if(txtConfirm.Visible == false)
            {
                Login login = new Login();
                if(login.IsLoginCorrect(txtEmail.Text, txtPassword.Text) == true)
                {
                    //Application.Run(new FormCarCostCalculator());
                    MessageBox.Show("Vous êtes connectés !");
                }
                else
                {
                    MessageBox.Show("Erreur : L'adresse mail ou le mot de passe est invalide !");
                }
            }else if(txtConfirm.Visible == true)
            {
                Register register = new Register();
                if(register.RegisterNewAccount(txtEmail.Text, txtPassword.Text, txtConfirm.Text) == true)
                {
                    //Application.Run(new FormCarCostCalculator());
                    MessageBox.Show("Vous êtes enregistrés !");
                }
                else
                {
                    MessageBox.Show("Erreur : L'adresse mail n'est pas valide ou la confirmation de mot de passe n'est pas identique à celui-ci !");
                }
            }
            else
            {
                MessageBox.Show("Erreur : Une erreur s'est produite !");
            }
        }

        private void WriteEmailInJson(string email)
        {
            if (!Directory.Exists(dataStringPath))
            {
                Directory.CreateDirectory(dataStringPath);
            }
            string jsonEmail = JsonConvert.SerializeObject(email);
            File.WriteAllText(@"..\..\..\data\email.json", jsonEmail);
        }

        private string ReadEmailInJson()
        {
            if (!Directory.Exists(dataStringPath))
            {
                Directory.CreateDirectory(dataStringPath);
            }
            string email = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\..\data\email.json")).ToString();

            return email;
        }
    }
}
