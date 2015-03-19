using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{
		/// <summary>Converts one unit of Angle to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertAngle(AngleType typeConvertingFrom, double passedValue, AngleType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case AngleType.Degree:
					switch (typeConvertingTo)
					{
						case AngleType.Degree:
							returnDouble = passedValue; // Return passed in Degree
							break;
						case AngleType.Radian:
							returnDouble = passedValue * (Math.PI / 180.0); // Convert Degree to Radian
							break;
					}
					break;
				case AngleType.Radian:
					switch (typeConvertingTo)
					{
						case AngleType.Degree:
							returnDouble = passedValue * (180.0/Math.PI); // Convert Radian to Degree
							break;
						case AngleType.Radian:
							returnDouble = passedValue; // Return passed in Radian
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}