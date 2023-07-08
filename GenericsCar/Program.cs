using System;
using System.Collections.Generic;

namespace GenericsCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. I Main() Skapa en List<Car> med minst 4 
            // bilar(använd Collection Initializer Syntax)

            var myCars = new List<Car>()
            {
                new Car()
                {
                    LicenseNumber = "ABC123",
                    Make = "Ford",
                    Model = "Focus",
                    Year = 2020
                },
                  new Car()
                {
                    LicenseNumber = "KFC456",
                    Make = "Fiat",
                    Model = "Panda",
                    Year = 2015
                },
                    new Car()
                {
                    LicenseNumber = "OPP789",
                    Make = "Kia",
                    Model = "Ceed",
                    Year = 2019
                },
                      new Car()
                {
                    LicenseNumber = "POW345",
                    Make = "Volksvagen",
                    Model = "Golf",
                    Year = 2023
                },
            };

            // 3. Ta bort den tredje bilen i listan
            myCars.RemoveAt(2);

            // 4.Lägg till en ny bil på tredje platsen i listan
            myCars.Insert(2, new Car()
            {
                LicenseNumber = "NEW098",
                Make = "Kia",
                Model = "Ceed version 2",
                Year = 2023
            });

            // 5.Ta den första bilen i listan bilen på en åktur
            // (det ska inte funka utan bensin)
            myCars[0].Drive();

            // 6. Tanka den första bilen i listan full med bensin
            myCars[0].FillUp();

            // 7.Ta bilen på en åktur
            myCars[0].Drive();
        }
    }
}