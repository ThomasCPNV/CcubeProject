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
        double consomationResult;
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
            try
            {
                licenseResult = dataManager.DoCalculLicensePlate(cbxCantonRegistration.SelectedText, Convert.ToDouble(txtPower.Text), cbxPower.SelectedText, Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text));
                txtLicensePlateCpY.Text = licenseResult.ToString();
                txtLicensePlateCpM.Text = (licenseResult / 12).ToString();


                finalResult = licenseResult + supportsResult + initialCarResult + consomationResult;
                txtResultCpY.Text = finalResult.ToString();
                txtResultCpM.Text = (finalResult / 12).ToString();
            }
            catch
            {

            }
        }

        // Datas verification for save on database.
        private void btnRegisterACar_Click(object sender, EventArgs e)
        {
            try
            {
                dataManager.LicensePlate(lblEmailView.Text, cbxCantonRegistration.SelectedText, Convert.ToDouble(txtPower.Text), cbxPower.SelectedText, Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text));
                dataManager.EssentialMaintain(lblEmailView.Text, Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text));
                dataManager.InitialPrice(lblEmailView.Text, Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToDouble(txtCarSLifetimeEstimation.Text));
                dataManager.Consommation(lblEmailView.Text, cbxFuel.Text, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
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
    }
}
