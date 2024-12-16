using GreenHouseEmulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseEmulator.Entities.Systems
{
    public class LightingSystem : IControllable
    {
        public bool IsOn { get; set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Ventilation system is turmed on");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Ventilation system is turmed off");
        }
    }
}
