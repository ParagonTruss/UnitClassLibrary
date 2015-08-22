using System;

namespace UnitClassLibrary
{

	public partial class Capacitance
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="capacitanceType"></param>
	public string ToString(CapacitanceType capacitanceType)
	{
		return this.GetValue(capacitanceType) + " " + capacitanceType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Capacitance Negate()
	{
		return new Capacitance(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Capacitance AbsoluteValue()
	{
		return new Capacitance(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Capacitance RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}