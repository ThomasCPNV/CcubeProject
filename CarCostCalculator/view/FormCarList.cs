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
        List<string> item = new List<string>();

        public FormCarList(string email)
        {
            InitializeComponent();

            var listViewItem = new ListViewItem();

            lstCar.View = View.Details;
            item = dBConnect.GetCar(email);
            string[] rowCar = {
                item[0],
                item[1],
                item[2],
                item[3],
                item[4],
                item[5]
            };
            listViewItem = new ListViewItem(rowCar);
            lstCar.Items.Add(listViewItem);
        }
    }
}
