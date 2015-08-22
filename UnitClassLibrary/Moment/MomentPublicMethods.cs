namespace UnitClassLibrary
{

	public partial class Moment
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="momentType"></param>
	public string ToString(MomentType momentType)
	{
		return this.GetValue(momentType) + " " + momentType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Moment Negate()
	{
		return new Moment(_force *1, _distance* -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Moment AbsoluteValue()
	{
		return new Moment(_force *-1, _distance* -1);
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Moment RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}