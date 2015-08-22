namespace UnitClassLibrary
{

	public partial class Speed
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="speedType"></param>
	public string ToString(SpeedType speedType)
	{
		return this.GetValue(speedType) + " " + speedType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Speed Negate()
	{
		return new Speed(_distance *1, _time* -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Speed AbsoluteValue()
	{
		return new Speed(_distance *-1, _time* -1);
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Speed RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}