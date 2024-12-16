using GreenHouseEmulator.Entities.Sensors;
using GreenHouseEmulator.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseEmulator.Entities
{
    public class GreenHouse
    {
        public List<Sensor> Sensors { get; set; } = new List<Sensor>();

        public IrrigationSystem Irrigation { get; set; } = new IrrigationSystem();
        public VentilationSystem Ventilation { get; set; } = new VentilationSystem();
        public LightingSystem Lighting { get; set; } = new LightingSystem();

        public GreenHouse()

        {

            Sensors = new List<Sensor>();
            Ventilation = new VentilationSystem();
            Lighting = new LightingSystem();
            Irrigation = new IrrigationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors)
            { sensor.ReadValue(); }
        }



    }
}
