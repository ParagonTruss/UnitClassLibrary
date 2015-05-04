using UnitClassLibrary.AngularUnits.AngularDistance.AngleTypes.RadianUnit;

namespace UnitClassLibrary.AngleTypes.RadianUnit
{
    public static class Radian_AngleExtension
    {
        public static double ToDoubleAsRadians(this AngularDistance angularDistance)
        {
            return angularDistance.GetValue(new Radian());
        }
    }
}