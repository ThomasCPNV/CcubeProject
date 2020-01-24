/*
 * Developer : Samuel Meyer
 * Version : 1.0
 * Creation date : 12.12.2019 
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

using model;

namespace view
{
    /// <summary>
    /// This is used for all the interactions with the Calculator's view
    /// </summary>
    public partial class FormCalculator : Form
    {
        DataManager dataManager = new DataManager();
        private double licenseResult;
        private double supportsResult;
        private double initialCarResult;
        private double consommationResult;
        private double finalResult;

        public FormCalculator(string email)
        {
            InitializeComponent();

            // Email pin up
            lblEmailView.Text = email;

            // Initialize combobox default values
            cbxCantonRegistration.SelectedIndex = 23;
            cbxPower.SelectedIndex = 0;
            cbxFuel.SelectedIndex = 0;

            btnRegisterACar.Enabled = false;
        }

        /// <summary>
        /// Calculate and display results every tick
        /// </summary>
        private void tmrCalculator_Tick(object sender, EventArgs e)
        {
            // Check all entries validity
            entryVerification(txtPower, lblPower.Text);
            entryVerification(txtWeight, lblWeight.Text);
            entryVerification(txtCO2Emission, lblCO2Emission.Text);
            entryVerification(txtInsurancepY, lblInsurancepY.Text);
            entryVerification(txtTirespY, lblTirespY.Text);
            entryVerification(txtRevisionpY, lblRevisionpY.Text);
            entryVerification(txtCarPurchasePrice, lblCarPurchasePrice.Text);
            entryVerification(txtCarSLifetimeEstimation, lblCarSLifetimeEstimation.Text);
            entryVerification(txtCarSCp100km, lblCarSCp100km.Text);
            entryVerification(txtDpM, lblDpM.Text);

            // Calculate and display license plate's result
            if (cbxCantonRegistration.Text != "" && txtPower.Text != "" && cbxPower.Text != "" && txtWeight.Text != "" && txtCO2Emission.Text != "")
            {
                licenseResult = dataManager.CalculLicensePlate(cbxCantonRegistration.Text, Convert.ToDouble(txtPower.Text), cbxPower.Text, Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text));
                txtLicensePlateCpY.Text = Math.Round(licenseResult, 2).ToString();
                txtLicensePlateCpM.Text = Math.Round((licenseResult / 12), 2).ToString();
            }
            else
            {
                licenseResult = 0;
                txtLicensePlateCpY.Text = "";
                txtLicensePlateCpM.Text = "";
            }
            if (!ckbUseLicencePlate.Checked) { licenseResult = 0; }

            // Calculate and display essentials supports's result
            if (txtInsurancepY.Text != "" && txtTirespY.Text != "" && txtRevisionpY.Text != "")
            {
                supportsResult = dataManager.CalculEssentialMaintain(Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text));
                txtEssentialsMaintainsCpY.Text = Math.Round(supportsResult, 2).ToString();
                txtEssentialsMaintainsCpM.Text = Math.Round((supportsResult / 12), 2).ToString();
            }
            else
            {
                supportsResult = 0;
                txtEssentialsMaintainsCpY.Text = "";
                txtEssentialsMaintainsCpM.Text = "";
            }
            if (!ckbUseEssentialSupports.Checked) { supportsResult = 0; }

            // Calculate and display car purchase price's result
            if (txtCarPurchasePrice.Text != "" && txtCarSLifetimeEstimation.Text != "")
            {
                initialCarResult = dataManager.CalculInitialPrice(Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToInt16(txtCarSLifetimeEstimation.Text));
                txtInitialCarSPriceCpY.Text = Math.Round(initialCarResult, 2).ToString();
                txtInitialCarSPriceCpM.Text = Math.Round((initialCarResult / 12), 2).ToString();
            }
            else
            {
                initialCarResult = 0;
                txtInitialCarSPriceCpY.Text = "";
                txtInitialCarSPriceCpM.Text = "";
            }
            if (!ckbUseInitialCarSPrice.Checked) { initialCarResult = 0; }

            // Calculate and display consommation's result
            if (cbxFuel.Text != "" && txtCarSCp100km.Text != "" && txtDpM.Text != "")
            {
                consommationResult = dataManager.CalculConsommation(cbxFuel.Text, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
                txtConsommationCpY.Text = Math.Round(consommationResult, 2).ToString();
                txtConsommationCpM.Text = Math.Round((consommationResult / 12), 2).ToString();
            }
            else
            {
                consommationResult = 0;
                txtConsommationCpY.Text = "";
                txtConsommationCpM.Text = "";
            }
            if (!ckbUseConsommation.Checked) { consommationResult = 0; }

            // Calculate and display the final result
            finalResult = licenseResult + supportsResult + initialCarResult + consommationResult;
            txtResultCpY.Text = Math.Round(finalResult, 2).ToString();
            txtResultCpM.Text = Math.Round((finalResult / 12), 2).ToString();

            // Enablement and disablement set
            if (txtPower.Text != ""
                && txtWeight.Text != ""
                && txtCO2Emission.Text != ""
                && txtInsurancepY.Text != ""
                && txtTirespY.Text != ""
                && txtRevisionpY.Text != ""
                && txtCarPurchasePrice.Text != ""
                && txtCarSLifetimeEstimation.Text != ""
                && txtCarSCp100km.Text != ""
                && txtDpM.Text != "")
            { btnRegisterACar.Enabled = true; }
            else { btnRegisterACar.Enabled = false; }
        }

        /// <summary>
        /// Open car list's window if click on button
        /// </summary>
        private void btnCarList_Click(object sender, EventArgs e)
        {
            FormCarList form = new FormCarList(Email);
            form.ShowDialog();
        }

        /// <summary>
        /// Open history's window if click on button
        /// </summary>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistory form = new FormHistory(Email);
            form.ShowDialog();
        }

        /// <summary>
        /// Open register a car's window if click on button
        /// </summary>
        private void btnRegisterACar_Click(object sender, EventArgs e)
        {
            // Condition transfert the calculator's datas to the register a car's window
            if (txtPower.Text != ""
                && txtWeight.Text != ""
                && txtCO2Emission.Text != ""
                && txtInsurancepY.Text != ""
                && txtTirespY.Text != ""
                && txtRevisionpY.Text != ""
                && txtCarPurchasePrice.Text != ""
                && txtCarSLifetimeEstimation.Text != ""
                && txtCarSCp100km.Text != ""
                && txtDpM.Text != "")
            {
                FormRegisterACar form = new FormRegisterACar();
                form.email = Email;

                form.cantonRegistration = CantonRegistration;
                form.carPower = CarPower;
                form.powerType = PowerType;
                form.weight = Weight;
                form.cO2Emission = CO2Emission;
                form.licenseResult = licenseResult;

                form.insurance = Insurance;
                form.tires = Tires;
                form.revision = Revision;
                form.supportsResult = supportsResult;

                form.carPurchasePrice = CarPurchasePrice;
                form.carSLifetimeEstimation = CarSLifetimeEstimation;
                form.initialCarResult = initialCarResult;

                form.fuel = Fuel;
                form.carSCp100km = CarSCp100km;
                form.dpM = DpM;
                form.consommationResult = consommationResult;

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error : All entries need a value !");
            }
        }

        // Calculator quit button.
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Calculator disconnection button.
        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("You are disconnected !");
            // Open Login/register window.
            FormLoginRegister form = new FormLoginRegister();
            form.ShowDialog();
        }

        // Update fuel price view if combobox's value change
        private void cbxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAverageFuelPricePerLiter.Text = dataManager.CalculFuelPrice(cbxFuel.Text).ToString();
        }

        /// <summary>
        /// Check if an entry is invalid
        /// </summary>
        /// <param name="entry">contain the entry that needs to be checked</param>
        /// <param name="label">contain the entry label</param>
        private void entryVerification(TextBox entry, string label)
        {
            if (!Double.TryParse(entry.Text, out double convertEntry) && entry.Text != "")
            {
                tmrCalculator.Enabled = false;

                MessageBox.Show("Error: The '" + label + "' entry have a bad value.");
                entry.Text = "";

                tmrCalculator.Enabled = true;
            }
        }

        // Get list of Calculator's all entries
        public string Email { get { return lblEmailView.Text; } }
        
        public string CantonRegistration { get { return cbxCantonRegistration.Text; } }
        public double CarPower { get { return Convert.ToDouble(txtPower.Text); } }
        public string PowerType { get { return cbxPower.Text; } }
        public double Weight { get { return Convert.ToDouble(txtWeight.Text); } }
        public double CO2Emission { get { return Convert.ToDouble(txtCO2Emission.Text); } }
        
        public double Insurance { get { return Convert.ToDouble(txtInsurancepY.Text); } }
        public double Tires { get { return Convert.ToDouble(txtTirespY.Text); } }
        public double Revision { get { return Convert.ToDouble(txtRevisionpY.Text); } }
        
        public double CarPurchasePrice { get { return Convert.ToDouble(txtCarPurchasePrice.Text); } }
        public double CarSLifetimeEstimation { get { return Convert.ToDouble(txtCarSLifetimeEstimation.Text); } }
        
        public string Fuel { get { return cbxFuel.Text; } }
        public double CarSCp100km { get { return Convert.ToDouble(txtCarSCp100km.Text); } }
        public double DpM { get { return Convert.ToDouble(txtDpM.Text); } }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
