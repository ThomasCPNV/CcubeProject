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
        double licenseResult;
        double supportsResult;
        double initialCarResult;
        double consommationResult;
        double finalResult;

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
                txtLicensePlateCpY.Text = Math.Round(licenseResult,2).ToString();
                txtLicensePlateCpM.Text = Math.Round((licenseResult / 12),2).ToString();
            }
            else
            {
                licenseResult = 0;
                txtLicensePlateCpY.Text = "";
                txtLicensePlateCpM.Text = "";
            }
            if (!ckbUseLicencePlate.Checked) { licenseResult = 0; }
            
            if(txtInsurancepY.Text != "" && txtTirespY.Text != "" && txtRevisionpY.Text != "")
            {
                supportsResult = dataManager.CalculEssentialMaintain(Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text));
                txtEssentialsMaintainsCpY.Text = Math.Round(supportsResult,2).ToString();
                txtEssentialsMaintainsCpM.Text = Math.Round((supportsResult / 12),2).ToString();
            }
            else
            {
                supportsResult = 0;
                txtEssentialsMaintainsCpY.Text = "";
                txtEssentialsMaintainsCpM.Text = "";
            }
            if (!ckbUseEssentialSupports.Checked) { supportsResult = 0; }
            
            if(txtCarPurchasePrice.Text != "" && txtCarSLifetimeEstimation.Text != "")
            {
                initialCarResult = dataManager.CalculInitialPrice(Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToInt16(txtCarSLifetimeEstimation.Text));
                txtInitialCarSPriceCpY.Text = Math.Round(initialCarResult,2).ToString();
                txtInitialCarSPriceCpM.Text = Math.Round((initialCarResult / 12),2).ToString();
            }
            else
            {
                initialCarResult = 0;
                txtInitialCarSPriceCpY.Text = "";
                txtInitialCarSPriceCpM.Text = "";
            }
            if (!ckbUseInitialCarSPrice.Checked) { initialCarResult = 0; }
            
            if(cbxFuel.Text != "" && txtCarSCp100km.Text != "" && txtDpM.Text != "")
            {
                double fuelPrice = dataManager.CalculFuelPrice(cbxFuel.Text);
                consommationResult = dataManager.CalculConsommation(fuelPrice, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
                txtConsommationCpY.Text = Math.Round(consommationResult,2).ToString();
                txtConsommationCpM.Text = Math.Round((consommationResult / 12),2).ToString();
            }
            else
            {
                consommationResult = 0;
                txtConsommationCpY.Text = "";
                txtConsommationCpM.Text = "";
            }
            if (!ckbUseConsommation.Checked) { consommationResult = 0; }
                
            finalResult = licenseResult + supportsResult + initialCarResult + consommationResult;
            txtResultCpY.Text = Math.Round(finalResult,2).ToString();
            txtResultCpM.Text = Math.Round((finalResult / 12),2).ToString();
        }

        // Datas verification for save on database.
        private void btnRegisterACar_Click(object sender, EventArgs e)
        {
            try
            {
                dataManager.LicensePlate(lblEmailView.Text, cbxCantonRegistration.Text, Convert.ToDouble(txtPower.Text), cbxPower.Text, Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text), licenseResult);
                dataManager.EssentialMaintain(lblEmailView.Text, Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text), supportsResult);
                dataManager.InitialPrice(lblEmailView.Text, Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToDouble(txtCarSLifetimeEstimation.Text), initialCarResult);
                dataManager.Consommation(lblEmailView.Text, cbxFuel.Text, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text), consommationResult);
                MessageBox.Show("Insertion in database completed !");
            }
            catch
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
        public static bool IsFloat(ValueType value)
        {
            return (value is float | value is double | value is Decimal);
        }
    }
}
