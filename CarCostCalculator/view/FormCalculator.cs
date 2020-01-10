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
            if (cbxCantonRegistration.Text != "" && txtPower.Text != "" && cbxPower.Text != "" && txtWeight.Text != "" && txtCO2Emission.Text != "")
            {
                licenseResult = dataManager.CalculLicensePlate(cbxCantonRegistration.Text, Convert.ToDouble(txtPower.Text), cbxPower.Text, Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text));
                txtLicensePlateCpY.Text = licenseResult.ToString();
                txtLicensePlateCpM.Text = (licenseResult / 12).ToString();
            }
            else
            {
                txtLicensePlateCpY.Text = "";
                txtLicensePlateCpM.Text = "";
            }
            if (!ckbUseLicencePlate.Checked) { licenseResult = 0; }
            
            if(txtInsurancepY.Text != "" && txtTirespY.Text != "" && txtRevisionpY.Text != "")
            {
                supportsResult = dataManager.CalculEssentialMaintain(Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text));
                txtEssentialsMaintainsCpY.Text = supportsResult.ToString();
                txtEssentialsMaintainsCpM.Text = (supportsResult / 12).ToString();
            }
            else
            {
                txtEssentialsMaintainsCpY.Text = "";
                txtEssentialsMaintainsCpM.Text = "";
            }
            if (!ckbUseEssentialSupports.Checked) { supportsResult = 0; }
            
            if(txtCarPurchasePrice.Text != "" && txtCarSLifetimeEstimation.Text != "")
            {
                initialCarResult = dataManager.CalculInitialPrice(Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToInt16(txtCarSLifetimeEstimation.Text));
                txtInitialCarSPriceCpY.Text = initialCarResult.ToString();
                txtInitialCarSPriceCpM.Text = (initialCarResult / 12).ToString();
            }
            else
            {
                txtInitialCarSPriceCpY.Text = "";
                txtInitialCarSPriceCpM.Text = "";
            }
            if (!ckbUseInitialCarSPrice.Checked) { initialCarResult = 0; }
            
            if(cbxFuel.Text != "" && txtCarSCp100km.Text != "" && txtDpM.Text != "")
            {
                double fuelPrice = dataManager.CalculFuelPrice(cbxFuel.Text);
                consommationResult = dataManager.CalculConsommation(fuelPrice, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
                txtConsommationCpY.Text = consommationResult.ToString();
                txtConsommationCpM.Text = (consommationResult / 12).ToString();
            }
            else
            {
                txtConsommationCpY.Text = "";
                txtConsommationCpM.Text = "";
            }
            if (!ckbUseConsommation.Checked) { consommationResult = 0; }
                
            finalResult = licenseResult + supportsResult + initialCarResult + consommationResult;
            txtResultCpY.Text = finalResult.ToString();
            txtResultCpM.Text = (finalResult / 12).ToString();
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
    }
}
