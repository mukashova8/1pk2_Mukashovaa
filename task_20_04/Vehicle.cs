using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_04
{
    internal class Vehicle
    {
        public List<VehicleType> vehicleTypes { get; set; }
        public Vehicle()
        {
            vehicleTypes = new List<VehicleType>();
        }
        public void VehicleAdd(VehicleType VehicleType)
        {
            vehicleTypes.Add(VehicleType);
        }
        public int VehicleCount(VehicleType type)
        {
            int count = 0;
            for (int i = 0; i < vehicleTypes.Count; i++)
            {
                if (vehicleTypes[i] == type)
                    count++;
            }
            return count;
        }
        public void FindOf(VehicleType type)
        {
            List<VehicleType> newvehicleTypes =  new List<VehicleType>();
            for (int i = 0; i < vehicleTypes.Count; i++)
            {
                if (vehicleTypes[i] == type)
                {
                    newvehicleTypes.Add(vehicleTypes[i]);
                    Console.WriteLine(vehicleTypes[i]);
                }
            }
        }
    }
}
