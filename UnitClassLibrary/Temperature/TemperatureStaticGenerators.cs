using System;

 namespace UnitClassLibrary
{

	public partial class Temperature
	{

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in CelsiusDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithCelsiusDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Celsius, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in FahrenheitDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithFahrenheitDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Fahrenheit, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in KelvinDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithKelvinDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Kelvin, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in RankineDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithRankineDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Rankine, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in DelisleDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithDelisleDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Delisle, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in ReaumurDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithReaumurDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Reaumur, passedValue);
		}

		///<summary>Generator method that constructs Temperature with assumption that the passed value is in RomerDegrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Temperature MakeTemperatureWithRomerDegrees(double passedValue)
		{
			return new Temperature(TemperatureType.Romer, passedValue);
		}
	}
}