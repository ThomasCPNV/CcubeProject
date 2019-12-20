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

        // Email pin up
        public FormCalculator(string email)
        {
            InitializeComponent();

            lblEmailView.Text = email;
        }

        private void tmrCalculator_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        // Datas verification for save on database.
        private void btnSaveDatas_Click(object sender, EventArgs e)
        {
            try
            {
                // License plate entries verifier.
                try
                {
                    dataManager.LicensePlate(lblEmailView.Text, cbxCantonRegistration.Text, Convert.ToDouble(txtPower.Text), Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtCO2Emission.Text));
                }
                catch { MessageBox.Show("Error : All 'License' entries need a value or the format isn't respected"); }

                // Essential supports entries verifier.
                try
                {
                    dataManager.EssentialMaintain(lblEmailView.Text, Convert.ToDouble(txtInsurancepY.Text), Convert.ToDouble(txtTirespY.Text), Convert.ToDouble(txtRevisionpY.Text));
                }
                catch { MessageBox.Show("Error : All 'Essential supports' entries need a value or the format isn't respected"); }

                // Initial price entries verifier.
                try
                {
                    dataManager.InitialPrice(lblEmailView.Text, Convert.ToDouble(txtCarPurchasePrice.Text), Convert.ToDouble(txtCarSLifetimeEstimation.Text));
                }
                catch { MessageBox.Show("Error : All 'Initial Price' entries need a value or the format isn't respected"); }

                // Consommation entries verifier.
                try
                {
                    dataManager.Consommation(lblEmailView.Text, cbxFuel.Text, Convert.ToDouble(txtCarSCp100km.Text), Convert.ToDouble(txtDpM.Text));
                }
                catch { MessageBox.Show("Error : All 'Consommation' entries need a value or the format isn't respected"); }
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
