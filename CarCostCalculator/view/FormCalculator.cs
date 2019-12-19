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
        public FormCalculator()
        {
            InitializeComponent();

            lblEmailView.Text = Tag.ToString();
        }

        private void tmrCalculator_Tick(object sender, EventArgs e)
        {
        }

        private void btnSaveDatas_Click(object sender, EventArgs e)
        {
            dataManager.LicensePlate(lblEmailView.Text, cbxCantonRegistration.Text, Convert.ToDouble(txtPower.Text), Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text), Convert.ToDouble(txtLicensePlateCpY.Text), Convert.ToDouble(txtLicensePlateCpM.Text));
            dataManager.EssentialMaintain(lblEmailView.Text, Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text), Convert.ToDouble(txtEssentialsMaintainsCpY.Text), Convert.ToDouble(txtEssentialsMaintainsCpM.Text));
            dataManager.InitialPrice(lblEmailView.Text, Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToDouble(txtCarSLifetimeEstimation.Text), Convert.ToDouble(txtInitialCarSPriceCpY.Text), Convert.ToDouble(txtInitialCarSPriceCpM.Text));
            dataManager.Consommation(lblEmailView.Text, cbxFuel.Text, Convert.ToDouble(txtAverageFuelPricePerLiter.Text), Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text), Convert.ToDouble(txtConsommationCpY.Text), Convert.ToDouble(txtConsommationCpM.Text));
        }
    }
}
