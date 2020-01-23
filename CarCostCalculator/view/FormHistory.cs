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
        List<string> item = new List<string>();

        public FormHistory(string email)
        {
            InitializeComponent();

            var listViewItem = new ListViewItem();

            lstLicense.View = View.Details;
            item = dBConnect.GetLicensePlate(email);
            string[] rowLicense = {
                item[0],
                item[1],
                item[2],
                item[3],
                item[4]
            };
            listViewItem = new ListViewItem(rowLicense);
            lstLicense.Items.Add(listViewItem);

            lstEssentials.View = View.Details;
            item = dBConnect.GetEssentialMaintain(email);
            string[] rowEssentials = {
                item[0],
                item[1],
                item[2],
                item[3],
                item[4]
            };
            listViewItem = new ListViewItem(rowEssentials);
            lstEssentials.Items.Add(listViewItem);

            lstInitialPurchase.View = View.Details;
            item = dBConnect.GetInitialPrice(email);
            string[] rowInitialPurchase = {
                item[0],
                item[1],
                item[2],
                item[3]
            };
            listViewItem = new ListViewItem(rowInitialPurchase);
            lstInitialPurchase.Items.Add(listViewItem);

            lstConsommation.View = View.Details;
            item = dBConnect.GetConsommation(email);
            string[] rowConsommation = {
                item[0],
                item[1],
                item[2],
                item[3],
                item[4]
            };
            listViewItem = new ListViewItem(rowConsommation);
            lstConsommation.Items.Add(listViewItem);
        }
    }
}
