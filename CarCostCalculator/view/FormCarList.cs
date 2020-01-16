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
            /*
            string[,] array2D = new string[,] { { "pomme", "poire" }, { "fraise", "framboise" }, { "mangue", "ananas" }, { "noisette", "amande" } };

            foreach (var group in array2D)
            {
                var item = new ListViewItem();
                item.Text = group;

                lstCar.Items.Add(item);
            }
            */
            lstCar.View = View.Details;
            foreach (string item in dBConnect.GetCar(email)) { lstCar.Items.Add(new ListViewItem(item)); }
        }
    }
}
