namespace UnitClassLibrary.New_Attempt
{
    public class InchesSquared:IAreaType
    {

        public double GetConversionFactor()
        {
            return new Inch().GetConversionFactor() *2;
        }
    }
}