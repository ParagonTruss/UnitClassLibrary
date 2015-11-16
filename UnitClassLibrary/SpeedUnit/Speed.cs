using System.Collections.Generic;
using UnitClassLibrary.DistanceUnit;
using UnitClassLibrary.GenericUnit;
using UnitClassLibrary.SpeedUnit.SpeedTypes;
using UnitClassLibrary.TimeUnit;

namespace UnitClassLibrary.SpeedUnit
{
    public class Speed : Unit<ISpeedUnit>
    {

        public Speed(ISpeedUnit speedType, Measurement measurement)
            : base(speedType, measurement) { }
  

        new public Speed Negate()
        {
            return (Speed)(this.Negate());
        }
    }
}
