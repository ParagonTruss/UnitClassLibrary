using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="angleType"></param>
	public string ToString(AngleType angleType)
	{
		return this.GetValue(angleType) + " " + angleType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Angle Negate()
	{
		return new Angle(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Angle AbsoluteValue()
	{
		return new Angle(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Angle RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}