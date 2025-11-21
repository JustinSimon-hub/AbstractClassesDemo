using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool hasTrunk { get; set; }

        public int numberOfDoors { get; set; }
        public override  void DriveAbstract()
        {
            Console.WriteLine($"The car has {numberOfDoors} and it is {hasTrunk} that it has a trunk.skrrrrrrrrrrrt");
        }
    }
}
