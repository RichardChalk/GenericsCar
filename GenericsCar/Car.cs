using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCar
{
    // 1. I sin egen fil skapa en public klass som heter Car

    public class Car
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Tank Petrol { get; set; }

        public Car()
        {
            Petrol = Tank.Empty;
        }

        // 5. Tanka bilen
        public void FillUp()
        {
            Petrol= Tank.Full;
        }

        public void Drive()
        {
            if (Petrol == Tank.Empty)
            {
                Console.WriteLine("Sorry No petrol!");
            }
            else 
            {
                Console.WriteLine("I'm driving baby!");
            }
        }
    }
}
