using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClassLibrary.Interfaces
{
    public interface IDistance
    {
        double Inches
        {
            get;
        }

        double Feet
        {
            get;
        }

        double Millimeters
        {
            get;
        }

        double Meters
        {
            get;
        }

        double Centimeters
        {
            get;
        }
    }
}
