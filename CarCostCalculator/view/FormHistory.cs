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
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[0]);
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[1]);
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[2]);
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[3]);
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[4]);
                lvi.SubItems.Add(dBConnect.GetLicensePlate(email)[5]);
                lstLicense.Items.Add(lvi);
            }

            foreach (string item in dBConnect.GetEssentialMaintain(email))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[0]);
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[1]);
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[2]);
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[3]);
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[4]);
                lvi.SubItems.Add(dBConnect.GetEssentialMaintain(email)[5]);
                lstEssentials.Items.Add(lvi);
            }

            foreach (string item in dBConnect.GetInitialPrice(email))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[0]);
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[1]);
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[2]);
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[3]);
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[4]);
                lvi.SubItems.Add(dBConnect.GetInitialPrice(email)[5]);
                lstInitialPurchase.Items.Add(lvi);
            }

            foreach (string item in dBConnect.GetConsommation(email))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[0]);
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[1]);
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[2]);
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[3]);
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[4]);
                lvi.SubItems.Add(dBConnect.GetConsommation(email)[5]);
                lstConsommation.Items.Add(lvi);
            }
        }
    }
}
