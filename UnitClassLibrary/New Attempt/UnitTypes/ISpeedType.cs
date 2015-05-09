namespace UnitClassLibrary.New_Attempt
{
    public interface ISpeedType:IUnitType
    {
        IDistanceType GetDistanceType();
        ITimeType GetTimeType();
    }
}