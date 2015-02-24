using System;

 namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{
		/// <summary>Converts one unit of ElectricCurrent to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertElectricCurrent(ElectricCurrentType typeConvertingFrom, double passedValue, ElectricCurrentType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case ElectricCurrentType.Ampere:
					switch (typeConvertingTo)
					{
						case ElectricCurrentType.Ampere:
							returnDouble = passedValue; // Return passed in Ampere
							break;
						case ElectricCurrentType.Milliampere:
							returnDouble = passedValue * 1000; // Convert Ampere to Milliampere
							break;
						case ElectricCurrentType.Microampere:
							returnDouble = passedValue * 1e6; // Convert Ampere to Microampere
							break;
					}
					break;
				case ElectricCurrentType.Milliampere:
					switch (typeConvertingTo)
					{
						case ElectricCurrentType.Ampere:
							returnDouble = passedValue / 1000; // Convert Milliampere to Ampere
							break;
						case ElectricCurrentType.Milliampere:
							returnDouble = passedValue; // Return passed in Milliampere
							break;
						case ElectricCurrentType.Microampere:
							returnDouble = passedValue * 1000; // Convert Milliampere to Microampere
							break;
					}
					break;
				case ElectricCurrentType.Microampere:
					switch (typeConvertingTo)
					{
						case ElectricCurrentType.Ampere:
							returnDouble = passedValue / 1e6; // Convert Microampere to Ampere
							break;
						case ElectricCurrentType.Milliampere:
							returnDouble = passedValue / 1000; // Convert Microampere to Milliampere
							break;
						case ElectricCurrentType.Microampere:
							returnDouble = passedValue; // Return passed in Microampere
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}