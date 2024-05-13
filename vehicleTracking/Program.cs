using System;

namespace vehicleTracking
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle testVehicle = new Vehicle("Opel", "Corsa", 3, 85000);

            Console.WriteLine("Car: " + testVehicle.Make + " " + testVehicle.Model

              + " – R" + testVehicle.Price + ". Condition: " + testVehicle.Condition + "/5");
        }
    }
}
