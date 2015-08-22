namespace UnitClassLibrary
{

	public partial class DataTransferRate
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="datatransferrateType"></param>
	public string ToString(DataTransferRateType datatransferrateType)
	{
		return this.GetValue(datatransferrateType) + " " + datatransferrateType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public DataTransferRate Negate()
	{
		return new DataTransferRate(_data *1, _time* -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public DataTransferRate AbsoluteValue()
	{
		return new DataTransferRate(_data *-1, _time* -1);
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public DataTransferRate RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}