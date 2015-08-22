using System;

namespace UnitClassLibrary
{

	public partial class Mass
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="massType"></param>
	public string ToString(MassType massType)
	{
		return this.GetValue(massType) + " " + massType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Mass Negate()
	{
		return new Mass(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Mass AbsoluteValue()
	{
		return new Mass(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Mass RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}