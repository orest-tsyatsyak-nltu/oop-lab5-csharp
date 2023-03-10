using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Lab5MainWindow : Form
    {

        private BindingList<Vehicle> vehicleStorage = new BindingList<Vehicle>();

        public Lab5MainWindow()
        {
            InitializeComponent();
            vehicles.DataSource = vehicleStorage;
            vehicles.DisplayMember = "Price";
        }

        private void addCar_Click(object sender, EventArgs e)
        {
            new CreateCar(vehicleStorage).Show();
        }


        private void vehicles_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void addPlain_Click(object sender, EventArgs e)
        {
            new CreatePlain(vehicleStorage).Show();
        }

        private void addShip_Click(object sender, EventArgs e)
        {
            new CreateShip(vehicleStorage).Show();
        }

    }
}
