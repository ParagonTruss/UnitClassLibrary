using System;

 namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="electricpotentialType"></param>
	public string ToString(ElectricPotentialType electricpotentialType)
	{
		return this.GetValue(electricpotentialType) + " " + electricpotentialType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public ElectricPotential Negate()
	{
		return new ElectricPotential(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public ElectricPotential AbsoluteValue()
	{
		return new ElectricPotential(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public ElectricPotential RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}