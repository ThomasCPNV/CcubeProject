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

            cbxCantonRegistration.SelectedIndex = 23;
            cbxPower.SelectedIndex = 0;
            cbxFuel.SelectedIndex = 0;
        }

        private void tmrCalculator_Tick(object sender, EventArgs e)
        {
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

            if (cbxFuel.Text != "" && txtCarSCp100km.Text != "" && txtDpM.Text != "")
            {
                double fuelPrice = dataManager.CalculFuelPrice(cbxFuel.Text);
                consommationResult = dataManager.CalculConsommation(fuelPrice, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
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

            finalResult = licenseResult + supportsResult + initialCarResult + consommationResult;
            txtResultCpY.Text = Math.Round(finalResult, 2).ToString();
            txtResultCpM.Text = Math.Round((finalResult / 12), 2).ToString();
        }

        // Datas verification for save on database.
        private void btnRegisterACar_Click(object sender, EventArgs e)
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
            Application.Exit();
            // Open Login/register window.
            FormLoginRegister form = new FormLoginRegister();
            form.ShowDialog();
        }

        private void cbxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAverageFuelPricePerLiter.Text = dataManager.CalculFuelPrice(cbxFuel.Text).ToString();
        }

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
    }
}
