namespace UnitClassLibrary.DistanceUnits.DistanceTypes.Metirc.CentimeterUnit
{
    public static class CentimeterDoubleExtension
    {
        public static Distance ToDistanceAsCentimeter(this double passedDouble)
        {
            return new Distance(new Centimeter(), passedDouble);
        }
    }
}
