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
    public partial class CreatePlain : Form
    {

        private BindingList<IVehicle> vehicles;

        public CreatePlain(BindingList<IVehicle> vehicles)
        {
            this.vehicles = vehicles;
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Plain plain = GetPlainFromForm();
            if (plain == null)
            {
                return;
            }
            vehicles.Add(plain);
            Close();
        }

        private Plain GetPlainFromForm()
        {
            Plain plain = null;
            try
            {
                int price = int.Parse(priceField.Text);
                int speed = int.Parse(speedField.Text);
                int manufacturingYear = int.Parse(manufacturingYearField.Text);
                int numberOfPassangers = int.Parse(numOfPassfield.Text);
                int maxHeight = int.Parse(heightfield.Text);
                plain = new Plain(maxHeight, numberOfPassangers, price, speed, manufacturingYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return plain;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
