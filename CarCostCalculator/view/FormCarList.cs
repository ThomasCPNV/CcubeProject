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
        public string email;

        public FormCarList()
        {
            InitializeComponent();

            //string[,] array2D = new string[,] { { "pomme", "poire" }, { "fraise", "framboise" }, { "mangue", "ananas" }, { "noisette", "amande" } };

            lstCar.View = View.Details;
            foreach (string item in dBConnect.GetCar(email)) { lstCar.Items.Add(new ListViewItem(item)); }
        }
        /*
        public IEnumerable<Tuple<string, string>> GetRowData()
        {
            foreach (var item in array2D)
            {
                string first 

                yield return
                    new Tuple<string, string>(name + extension, date.ToString(),
                        (new FileInfo(imagePath).Length / 1024).ToString() + " KB");
            }
        }
        */
    }
}
