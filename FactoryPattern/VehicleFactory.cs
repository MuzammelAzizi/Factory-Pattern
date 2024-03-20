using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int doorCount) 
        {
            switch (doorCount) 
            {
                case 4:
                    return new Car();
                case 2: 
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }
}
