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
            foreach (string item in dBConnect.GetLicensePlate(email)) {

                lstLicense.Items.Add(new ListViewItem(item));
            }

            lstEssentials.View = View.Details;
            foreach (string item in dBConnect.GetEssentialMaintain(email)) { lstEssentials.Items.Add(new ListViewItem(item)); }

            lstInitialPurchase.View = View.Details;
            foreach (string item in dBConnect.GetInitialPrice(email)) { lstInitialPurchase.Items.Add(new ListViewItem(item)); }

            lstConsommation.View = View.Details;
            foreach (string item in dBConnect.GetConsommation(email)) { lstConsommation.Items.Add(new ListViewItem(item)); }
        }
    }
}
