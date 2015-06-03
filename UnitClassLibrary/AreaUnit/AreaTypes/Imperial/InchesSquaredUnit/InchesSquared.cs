using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.InchesSquaredUnit
{
    public class InchesSquared:IAreaType
    {

        public double ConversionFactor
        {
            
            get{return new Inch().ConversionFactor *2; }
        }
    }
}