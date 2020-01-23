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
            List<string> licenseList = dBConnect.GetLicensePlate(email);

            List<string> rowLicense = new List<string>();
            int count = 0;

            foreach (string item in licenseList)
            {
                count++;
                rowLicense.Add(item);
                if (count >= 6)
                {
                    listViewItem = new ListViewItem(rowLicense.ToArray());
                    lstLicense.Items.Add(listViewItem);
                    rowLicense.Clear();
                    count = 0;
                }
            }
            rowLicense.Clear();

            lstEssentials.View = View.Details;
            List<string> essentialsList = dBConnect.GetEssentialMaintain(email);

            List<string> rowEssentials = new List<string>();
            count = 0;

            foreach (string item in essentialsList)
            {
                count++;
                rowEssentials.Add(item);
                if (count >= 5)
                {
                    listViewItem = new ListViewItem(rowEssentials.ToArray());
                    lstEssentials.Items.Add(listViewItem);
                    rowEssentials.Clear();
                    count = 0;
                }
            }
            rowEssentials.Clear();

            lstInitialPurchase.View = View.Details;
            List<string> initialPurchaseList = dBConnect.GetInitialPrice(email);

            List<string> rowInitialPurchase = new List<string>();
            count = 0;

            foreach (string item in initialPurchaseList)
            {
                count++;
                rowInitialPurchase.Add(item);
                if (count >= 4)
                {
                    listViewItem = new ListViewItem(rowInitialPurchase.ToArray());
                    lstInitialPurchase.Items.Add(listViewItem);
                    rowInitialPurchase.Clear();
                    count = 0;
                }
            }
            rowInitialPurchase.Clear();

            lstConsommation.View = View.Details;
            List<string> consommationList = dBConnect.GetConsommation(email);

            List<string> rowConsommation = new List<string>();
            count = 0;

            foreach (string item in consommationList)
            {
                count++;
                rowConsommation.Add(item);
                if (count >= 5)
                {
                    listViewItem = new ListViewItem(rowConsommation.ToArray());
                    lstConsommation.Items.Add(listViewItem);
                    rowConsommation.Clear();
                    count = 0;
                }
            }
            rowConsommation.Clear();
        }
    }
}
