using System;

 namespace UnitClassLibrary
{

	public partial class Force
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="forceType"></param>
	public string ToString(ForceType forceType)
	{
		return this.GetValue(forceType) + " " + forceType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Force Negate()
	{
		return new Force(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Force AbsoluteValue()
	{
		return new Force(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Force RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}