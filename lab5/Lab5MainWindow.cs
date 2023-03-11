using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Lab5MainWindow : Form
    {

        private VehicleCollectionQueue<IVehicle> basicStorage;

        private BindingList<IVehicle> vehicleStorage;

        public Lab5MainWindow()
        {
            basicStorage = new VehicleCollectionQueue<IVehicle>();
            vehicleStorage = new BindingList<IVehicle>(basicStorage);
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

        private void addClones_Click(object sender, EventArgs e)
        {
            int storageCountForMomentOfEntering = vehicleStorage.Count;
            for (int i = 0; i < storageCountForMomentOfEntering; i++)
            {
                vehicleStorage.Add((IVehicle)vehicleStorage[i].Clone());
            }
        }

        //private void sortByPrice_Click(object sender, EventArgs e)
        //{
        //    basicStorage.Sort();
        //    vehicleStorage.ResetBindings();
        //}
    }
}
