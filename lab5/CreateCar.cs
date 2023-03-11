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
    public partial class CreateCar : Form
    {

        private BindingList<IVehicle> vehicles;

        public CreateCar(BindingList<IVehicle> vehicles)
        {
            this.vehicles = vehicles;
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Car car = GetCarFromForm();
            if(car == null)
            {
                return;
            }
            vehicles.Add(car);
            Close();
        }

        private Car GetCarFromForm()
        {
            Car car = null;
            try
            {
                int price = int.Parse(priceField.Text);
                int speed = int.Parse(speedField.Text);
                int manufacturingYear = int.Parse(manufacturingYearField.Text);
                car = new Car(price, speed, manufacturingYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return car;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
