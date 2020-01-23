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
    public partial class FormHistory : Form
    {
        DBConnect dBConnect = new DBConnect();

        public FormHistory(string email)
        {
            InitializeComponent();
            

            lstLicense.View = View.Details;

            foreach (string item in dBConnect.GetLicensePlate(email))
            {
                string[] row = {
                    dBConnect.GetLicensePlate(email)[0],
                    dBConnect.GetLicensePlate(email)[1],
                    dBConnect.GetLicensePlate(email)[2],
                    dBConnect.GetLicensePlate(email)[3],
                    dBConnect.GetLicensePlate(email)[4],
                    dBConnect.GetLicensePlate(email)[5]
                };
                var listViewItem = new ListViewItem(row);
                lstLicense.Items.Add(listViewItem);
            }

            foreach (string item in dBConnect.GetEssentialMaintain(email))
            {
                string[] row = {
                    dBConnect.GetEssentialMaintain(email)[0],
                    dBConnect.GetEssentialMaintain(email)[1],
                    dBConnect.GetEssentialMaintain(email)[2],
                    dBConnect.GetEssentialMaintain(email)[3],
                    dBConnect.GetEssentialMaintain(email)[4]
                };
                var listViewItem = new ListViewItem(row);
                lstEssentials.Items.Add(listViewItem);
            }

            foreach (string item in dBConnect.GetInitialPrice(email))
            {
                string[] row = {
                    dBConnect.GetInitialPrice(email)[0],
                    dBConnect.GetInitialPrice(email)[1],
                    dBConnect.GetInitialPrice(email)[2],
                    dBConnect.GetInitialPrice(email)[3]
                };
                var listViewItem = new ListViewItem(row);
                lstInitialPurchase.Items.Add(listViewItem);
            }

            foreach (string item in dBConnect.GetConsommation(email))
            {
                string[] row = {
                    dBConnect.GetConsommation(email)[0],
                    dBConnect.GetConsommation(email)[1],
                    dBConnect.GetConsommation(email)[2],
                    dBConnect.GetConsommation(email)[3],
                    dBConnect.GetConsommation(email)[4]
                };
                var listViewItem = new ListViewItem(row);
                lstConsommation.Items.Add(listViewItem);
            }
        }
    }
}
