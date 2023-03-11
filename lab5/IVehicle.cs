using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public interface IVehicle : ICloneable, IComparable<IVehicle>
    {
        int Price { get; set; }
        int Speed { get; set; }
        int ManufacturingYear { get; set; }
        int this[string propertyName] { get; set; }
        void SetSpeed(int speed);
    }

    public abstract class AbstractVehicle : IVehicle
    {
        private int price = 0;

        private int speed = 0;

        private int manufacturingYear = 0;

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be negative");
                }
                price = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int ManufacturingYear
        {
            get
            {
                return manufacturingYear;
            }
            set
            {
                manufacturingYear = value;
            }
        }

        public int this[string property]
        {
            get
            {
                if (property.Equals("price"))
                {
                    return Price;
                }
                else if (property.Equals("speed"))
                {
                    return Speed;
                }
                else if (property.Equals("manufacturingYear"))
                {
                    return ManufacturingYear;
                }
                else
                {
                    throw new ArgumentException("property '" + property + "' not found");
                }
            }
            set
            {
                if (property.Equals("price"))
                {
                    Price = value;
                }
                else if (property.Equals("speed"))
                {
                    Speed = value;
                }
                else if (property.Equals("manufacturingYear"))
                {
                    ManufacturingYear = value;
                }
                else
                {
                    throw new ArgumentException("property '" + property + "' not found");
                }
            }
        }

        public AbstractVehicle()
        {
        }

        public abstract void SetSpeed(int speed);

        public AbstractVehicle(int price, int speed, int manufacturingYear)
        {
            Price = price;
            Speed = speed;
            ManufacturingYear = manufacturingYear;
        }

        public override string ToString()
        {
            return "Vehicle{price = " + price + ", speed = " + speed + ", manufacturingYear = " + manufacturingYear + "}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(IVehicle other)
        {
            return Price.CompareTo(other.Price);
        }
        
    }

    public class Car : AbstractVehicle
    {

        public Car()
        {
        }

        public Car(int price, int speed, int year) : base(price, speed, year)
        {
        }

        public override void SetSpeed(int speed)
        {
            if(speed < 0)
            {
                throw new ArgumentException("Cars can not have negative speed");
            }
            Speed = speed;
        }

        public override string ToString()
        {
            return "Car{price = " + Price + ", speed = " + Speed + ", manufacturingYear = " + ManufacturingYear + "}";
        }
    }

    public abstract class MultiSeaterVehicle : AbstractVehicle
    {
        private int numberOfPassangers = 0;

        public int NumberOfPassangers
        {
            get
            {
                return numberOfPassangers;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Number of passangers can not be less than 0");
                }
                numberOfPassangers = value;
            }
        }

        public MultiSeaterVehicle()
        {
        }

        public override void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public MultiSeaterVehicle(int numberOfPassangers, int price, int speed, int year) : base(price, speed, year)
        {
            NumberOfPassangers = numberOfPassangers;
        }

        public override string ToString()
        {
            return "MultiSeaterVehicle{price = " + Price + ", speed = " + Speed +
                ", manufacturing year = " + ManufacturingYear + ", numberOfPassangers = " + numberOfPassangers + "}";
        }
    }

    public class Plain : MultiSeaterVehicle
    {
        private int height = 1;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Max height can not be less or equal to 0");
                }
                height = value;
            }
        }

        public Plain()
        {
        }

        public Plain(int height, int numberOfPassangers, int price, int speed, int year) : base(numberOfPassangers, price, speed, year)
        {
            Height = height;
        }

        public void SetHeight(int height)
        {
            Height = height;
        }

        public override string ToString()
        {
            return "Plain{price = " + Price + ", speed = " + Speed +
                ", manufacturing year = " + ManufacturingYear + "numberOfPassangers = " + NumberOfPassangers +
                ", maxHeight = " + height + "}";
        }
    }

    public class Ship : MultiSeaterVehicle
    {
        private string homePort;

        public string HomePort
        {
            get
            {
                return homePort;
            }
            set
            {
                homePort = value;
            }
        }

        public Ship()
        {
        }

        public Ship(string homePort, int numberOfPassangers, int price, int speed, int year) : base(numberOfPassangers, price, speed, year)
        {
            HomePort = homePort;
        }

        public override string ToString()
        {
            return "Ship{price = " + Price + ", speed = " + Speed +
                ", manufacturing year = " + ManufacturingYear + "numberOfPassangers = " + NumberOfPassangers +
                ", homePort = " + homePort + "}";
        }

    }

}
