using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    public interface ILandvehicles
    {
        void StartRoute();
        void GetCargo();
    }
}