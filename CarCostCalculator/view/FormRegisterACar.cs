﻿using System;
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
    /// <summary>
    /// This is used for all the interactions with the Register a car
    /// </summary>
    public partial class FormRegisterACar : Form
    {
        DBConnect dBConnect = new DBConnect();
        public string email;

        public string cantonRegistration;
        public double carPower;
        public string powerType;
        public double weight;
        public double cO2Emission;
        public double licenseResult;

        public double insurance;
        public double tires;
        public double revision;
        public double supportsResult;

        public double carPurchasePrice;
        public double carSLifetimeEstimation;
        public double initialCarResult;

        public string fuel;
        public double carSCp100km;
        public double dpM;
        public double consommationResult;

        public FormRegisterACar()
        {
            InitializeComponent();

            // Initialize combobox default values
            cbxType.SelectedIndex = 5;
            cbxReleaseYear.SelectedIndex = 0;
        }

        /// <summary>
        /// Insert car in database
        /// </summary>
        private void btnRegisterCar_Click(object sender, EventArgs e)
        {
            // Check entries
            if (isNotNull(txtBrand, lblBrand.Text) &&
                isNotNull(txtModel, lblModel.Text) &&
                isNotNull(txtVersion, lblVersion.Text))
            {
                // Insert datas in database
                try
                {
                    dBConnect.InsertLicensePlate(cantonRegistration, carPower, weight, cO2Emission, licenseResult);
                    dBConnect.InsertEssentialMaintain(insurance, tires, revision, supportsResult);
                    dBConnect.InsertInitialCarPrice(carPurchasePrice, carSLifetimeEstimation, initialCarResult);
                    dBConnect.InsertConsommation(fuel, carSCp100km, dpM, consommationResult);
                    dBConnect.InsertCar(txtBrand.Text, txtModel.Text, txtVersion.Text, cbxType.Text, Convert.ToInt16(cbxReleaseYear.Text), email);
                    MessageBox.Show("Insertion in database completed !");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Error : An error has occurred !");
                }
            }
            else { }
        }

        /// <summary>
        /// Check the validity of entries every tick
        /// </summary>
        private void tmr_Tick(object sender, EventArgs e)
        {
            entryVerification(txtBrand, lblBrand.Text);
            entryVerification(txtModel, lblModel.Text);
            entryVerification(txtVersion, lblVersion.Text);
        }

        /// <summary>
        /// Check if an entry is invalid
        /// </summary>
        /// <param name="entry">contain the entry that needs to be checked</param>
        /// <param name="label">contain the entry label</param>
        private void entryVerification(TextBox entry, string label)
        {
            if (entry.Text.Contains("\"") || entry.Text.Contains("\'"))
            {
                tmr.Enabled = false;

                MessageBox.Show("Error: The '" + label + "' entry have a bad value.");
                entry.Text = "";

                tmr.Enabled = true;
            }
        }

        /// <summary>
        /// Check if an entry is invalid
        /// </summary>
        /// <param name="text">contain the entry that needs to be checked</param>
        /// <param name="label">contain the entry label</param>
        private bool isNotNull(TextBox text, string label)
        {
            if(text.Text != "") {
                return true;
            }
            else {
                MessageBox.Show("Error : the '" + label + "' entry is invalid.");
                return false;
            }
        }
        
        /// <summary>
        /// Quit the window if click on button
        /// </summary>
        private void btnRegisterACarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
