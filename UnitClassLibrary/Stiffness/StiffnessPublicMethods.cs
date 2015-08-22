namespace UnitClassLibrary
{

	public partial class Stiffness
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="stiffnessType"></param>
	public string ToString(StiffnessType stiffnessType)
	{
		return this.GetValue(stiffnessType) + " " + stiffnessType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Stiffness Negate()
	{
		return new Stiffness(_force *1, _distance* -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Stiffness AbsoluteValue()
	{
		return new Stiffness(_force *-1, _distance* -1);
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Stiffness RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}