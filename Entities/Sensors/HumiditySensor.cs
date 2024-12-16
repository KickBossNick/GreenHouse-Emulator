using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseEmulator.Entities.Sensors
{
    public class HumiditySensor : Sensor
    {
        public HumiditySensor(string name, string description)
         : base(name, description)
        { }
        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100;
            Console.WriteLine($"{Name} Humidity : {Value} % ");
        }

    }
}
