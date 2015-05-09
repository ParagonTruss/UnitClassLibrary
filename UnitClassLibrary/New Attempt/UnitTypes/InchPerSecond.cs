namespace UnitClassLibrary.New_Attempt
{
    public class InchPerSecond:ISpeedType
    {


        public double GetConversionFactor()
        {
            return new Inch().GetConversionFactor()/new Second().GetConversionFactor();
        }

        public IDistanceType GetDistanceType()
        {
            return new Inch();
        }

        public ITimeType GetTimeType()
        {
            return new Second();
        }
    }
}