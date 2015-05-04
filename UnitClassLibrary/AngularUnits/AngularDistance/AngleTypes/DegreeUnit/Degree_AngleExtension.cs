using UnitClassLibrary.AngularUnits.AngularDistance.AngleTypes.DegreeUnit;

namespace UnitClassLibrary.AngleTypes.DegreeUnit
{

    public static class Degree_AngleExtension
    {
        public static double ToDoubleAsDegrees(this AngularDistance angularDistance)
        {
            return angularDistance.GetValue(new Degree());
        }
    }
}