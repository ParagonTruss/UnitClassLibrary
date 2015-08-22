using System;

namespace UnitClassLibrary
{

	public partial class Data
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="dataType"></param>
	public string ToString(DataType dataType)
	{
		return this.GetValue(dataType) + " " + dataType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Data Negate()
	{
		return new Data(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Data AbsoluteValue()
	{
		return new Data(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Data RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}