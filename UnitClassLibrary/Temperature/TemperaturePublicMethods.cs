using System;

 namespace UnitClassLibrary
{

	public partial class Temperature
	{

	/// <summary>prints the value and unit type converted to</summary>
	/// <param name="temperatureType"></param>
	public string ToString(TemperatureType temperatureType)
	{
		return this.GetValue(temperatureType) + " " + temperatureType;
	}

	/// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	public Temperature Negate()
	{
		return new Temperature(_internalUnitType, _intrinsicValue * -1);
	}

	/// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	public Temperature AbsoluteValue()
	{
		return new Temperature(_internalUnitType, Math.Abs(_intrinsicValue));
	}

	/// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	public Temperature RaiseToPower(double power)
	{
		return this ^ power;
	}
	}
}