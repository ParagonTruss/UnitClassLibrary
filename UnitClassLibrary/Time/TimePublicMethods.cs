using System;

namespace UnitClassLibrary
{

	public partial class Time
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="timeType"></param>
	public string ToString(TimeType timeType)
	{
		return this.GetValue(timeType) + " " + timeType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Time Negate()
	{
		return new Time(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Time AbsoluteValue()
	{
		return new Time(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Time RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}