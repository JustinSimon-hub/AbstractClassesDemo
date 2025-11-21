using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public bool hasTwoWheels { get; set; }
        public string motorcycleBrand { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcycle is a {motorcycleBrand} and it is {hasTwoWheels} that it has two wheels.vrooooooooooom");
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
