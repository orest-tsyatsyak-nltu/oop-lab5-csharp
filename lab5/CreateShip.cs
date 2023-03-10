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
    public partial class CreateShip : Form
    {

        private BindingList<Vehicle> vehicles;

        public CreateShip(BindingList<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Ship ship = GetShipFromForm();
            if (ship == null)
            {
                return;
            }
            vehicles.Add(ship);
            Close();
        }

        private Ship GetShipFromForm()
        {
            Ship ship = null;
            try
            {
                int price = int.Parse(priceField.Text);
                int speed = int.Parse(speedField.Text);
                int manufacturingYear = int.Parse(manufacturingYearField.Text);
                int numberOfPassangers = int.Parse(numOfPassfield.Text);
                ship = new Ship(homePortField.Text, numberOfPassangers, price, speed, manufacturingYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ship;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
