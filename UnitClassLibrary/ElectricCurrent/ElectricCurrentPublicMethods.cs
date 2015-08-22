using System;

namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="electriccurrentType"></param>
	public string ToString(ElectricCurrentType electriccurrentType)
	{
		return this.GetValue(electriccurrentType) + " " + electriccurrentType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public ElectricCurrent Negate()
	{
		return new ElectricCurrent(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public ElectricCurrent AbsoluteValue()
	{
		return new ElectricCurrent(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public ElectricCurrent RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}