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
    public partial class FormCarList : Form
    {
        DBConnect dBConnect = new DBConnect();

        public FormCarList(string email)
        {
            InitializeComponent();

            lstCar.View = View.Details;
            foreach (string item in dBConnect.GetCar(email))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(dBConnect.GetCar(email)[0]);
                lvi.SubItems.Add(dBConnect.GetCar(email)[1]);
                lvi.SubItems.Add(dBConnect.GetCar(email)[2]);
                lvi.SubItems.Add(dBConnect.GetCar(email)[3]);
                lvi.SubItems.Add(dBConnect.GetCar(email)[4]);
                lvi.SubItems.Add(dBConnect.GetCar(email)[5]);
                lstCar.Items.Add(lvi);
            }
        }
    }
}
