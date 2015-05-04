using System;

namespace UnitClassLibrary.AngularUnits.AngularDistance.AngleTypes.DegreeUnit
{
    public class Degree : IUnitType
    {
        public double ConversionFactor
        {
            get { return Math.PI * 180; }
        }
    }
}