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

            var listViewItem = new ListViewItem();

            List<string> carList = dBConnect.GetCar(email);
            List<string> rowCar = new List<string>();

            lstCar.View = View.Details;
            int count = 0;

            foreach (string item in carList)
            {
                count++;
                rowCar.Add(item);
                if(count >= 6)
                {
                    listViewItem = new ListViewItem(rowCar.ToArray());
                    lstCar.Items.Add(listViewItem);
                    rowCar.Clear();
                    count = 0;
                }
            }
        }
    }
}
