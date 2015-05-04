namespace UnitClassLibrary.DistanceUnits.DistanceTypes.Metirc.CentimeterUnit
{
    public static class Centimeter_DistanceExtension
    {
        public static double ToDoubleAsCentimeters(this Distance passedDistance)
        {
            return passedDistance.GetValue(new Centimeter());
        }
    }
}
