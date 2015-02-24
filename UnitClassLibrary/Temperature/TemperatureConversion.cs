using System;

 namespace UnitClassLibrary
{

	public partial class Temperature
	{
		/// <summary>Converts one unit of Temperature to another
		/// Conversion source: http://en.wikipedia.org/wiki/Conversion_of_units_of_temperature
		/// </summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertTemperature(TemperatureType typeConvertingFrom, double passedValue, TemperatureType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case TemperatureType.Celsius:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = passedValue; // Return passed in Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = passedValue * (9.0/5.0) + 32; // Convert Celsius to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = passedValue + 273.15; // Convert Celsius to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = (passedValue + 273.15) * (9.0/5.0); // Convert Celsius to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (100 - passedValue) * (3.0/2.0); // Convert Celsius to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = passedValue * (4.0/5.0); // Convert Celsius to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = passedValue * (21.0/40.0) + 7.5; // Convert Celsius to Romer
							break;
					}
					break;
				case TemperatureType.Fahrenheit:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = (passedValue - 32) * (5.0/9.0); // Convert Fahrenheit to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = passedValue; // Return passed in Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = (passedValue + 459.67) * (5.0/9.0); // Convert Fahrenheit to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = passedValue + 459.67; // Convert Fahrenheit to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (212 - passedValue) * (5.0/6.0); // Convert Fahrenheit to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = (passedValue - 32.0) * (4.0/9.0); // Convert Fahrenheit to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = (passedValue - 32) * (7.0/24.0) + 7.5; // Convert Fahrenheit to Romer
							break;
					}
					break;
				case TemperatureType.Kelvin:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = passedValue - 273.15; // Convert Kelvin to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = passedValue * (9.0/5.0) - 459.67; // Convert Kelvin to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = passedValue; // Return passed in Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = passedValue * (9.0/5.0); // Convert Kelvin to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (373.15 - passedValue) * (3.0/2.0); // Convert Kelvin to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = (passedValue - 273.15) * (4.0/5.0); // Convert Kelvin to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = (passedValue - 273.15) * (21.0/40.0) + 7.5; // Convert Kelvin to Romer
							break;
					}
					break;
				case TemperatureType.Rankine:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = (passedValue - 491.67) * (5.0/9.0); // Convert Rankine to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = passedValue - 459.67; // Convert Rankine to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = passedValue * (5.0/9.0); // Convert Rankine to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = passedValue; // Return passed in Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (671.67 - passedValue) * (5.0/6.0); // Convert Rankine to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = (passedValue - 491.67) * (4.0/9.0); // Convert Rankine to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = (passedValue - 491.67) * (7.0/24.0) + 7.5; // Convert Rankine to Romer
							break;
					}
					break;
				case TemperatureType.Delisle:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = (100 - passedValue) * (2.0/3.0); // Convert Delisle to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = (212 - passedValue) * (6.0/5.0); // Convert Delisle to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = (373.15 - passedValue) * (2.0/3.0); // Convert Delisle to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = (671.67 - passedValue) * (6.0/5.0); // Convert Delisle to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = passedValue; // Return passed in Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = (80 - passedValue) * (8.0/15.0); // Convert Delisle to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = (60 - passedValue) * (7.0/20.0); // Convert Delisle to Romer
							break;
					}
					break;
				case TemperatureType.Reaumur:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = passedValue * (5.0/4.0); // Convert Reaumur to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = passedValue * (9.0/4.0) + 32; // Convert Reaumur to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = passedValue * (5.0/4.0) + 273.15; // Convert Reaumur to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = passedValue * (9.0/4.0) + 491.67; // Convert Reaumur to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (80 - passedValue) * (15.0/8.0); // Convert Reaumur to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = passedValue; // Return passed in Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = passedValue * (21.0/32.0) + 7.5; // Convert Reaumur to Romer
							break;
					}
					break;
				case TemperatureType.Romer:
					switch (typeConvertingTo)
					{
						case TemperatureType.Celsius:
							returnDouble = (passedValue -7.5) * (40.0/21.0); // Convert Romer to Celsius
							break;
						case TemperatureType.Fahrenheit:
							returnDouble = (passedValue - 7.5) * (24.0/7.0) + 32; // Convert Romer to Fahrenheit
							break;
						case TemperatureType.Kelvin:
							returnDouble = (passedValue - 7.5) * (40.0/21.0) + 273.15; // Convert Romer to Kelvin
							break;
						case TemperatureType.Rankine:
							returnDouble = (passedValue - 7.5) * (24.0/7.0) + 491.67; // Convert Romer to Rankine
							break;
						case TemperatureType.Delisle:
							returnDouble = (60 - passedValue) * (20.0/7.0); // Convert Romer to Delisle
							break;
						case TemperatureType.Reaumur:
							returnDouble = (passedValue - 7.5) * (32.0/21.0); // Convert Romer to Reaumur
							break;
						case TemperatureType.Romer:
							returnDouble = passedValue; // Return passed in Romer
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}