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
    public partial class FormRegisterACar : Form
    {
        DataManager dataManager = new DataManager();
        public FormRegisterACar()
        {
            InitializeComponent();
        }

        private void btnRegisterCar_Click(object sender, EventArgs e)
        {/*
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
            }*/
        }
    }
}
