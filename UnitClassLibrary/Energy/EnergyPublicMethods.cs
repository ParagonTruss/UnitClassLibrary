using System;

 namespace UnitClassLibrary
{

	public partial class Energy
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="energyType"></param>
	public string ToString(EnergyType energyType)
	{
		return this.GetValue(energyType) + " " + energyType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Energy Negate()
	{
		return new Energy(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Energy AbsoluteValue()
	{
		return new Energy(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Energy RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}