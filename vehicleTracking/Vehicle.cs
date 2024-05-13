using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    class Vehicle
    {
        // Variable declaration.
        public string Make { get; set; }
        public string Model { get; set; }
        public int Condition { get; set; }
        public double Price { get; set; }


        // Empty constructor.
        public Vehicle()
        {
        }
        // Constructor.
        public Vehicle(string newMake, string newModel, int newCondition, double newPrice)
        {
            Make = newMake;
            Model = newModel;
            Condition = newCondition;
            Price = newPrice;
        }
    }
}
