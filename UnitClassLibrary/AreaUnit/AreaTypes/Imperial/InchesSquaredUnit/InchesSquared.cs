using UnitClassLibrary.DistanceUnit.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.AreaUnit.AreaTypes.Imperial.InchesSquaredUnit
{
    public class InchesSquared:IAreaType
    {

        public double GetConversionFactor()
        {
            return new Inch().GetConversionFactor() *2;
        }
    }
}