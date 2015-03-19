using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{
		/// <summary>Converts one unit of AngularDistance to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertAngularDistance(AngularDistanceType typeConvertingFrom, double passedValue, AngularDistanceType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case AngularDistanceType.Radian:
					switch (typeConvertingTo)
					{
						case AngularDistanceType.Radian:
							returnDouble = passedValue; // Return passed in Radian
							break;
						case AngularDistanceType.Degree:
							returnDouble = passedValue * (180/Math.PI); // Convert Radian to Degree
							break;
					}
					break;
				case AngularDistanceType.Degree:
					switch (typeConvertingTo)
					{
						case AngularDistanceType.Radian:
							returnDouble = passedValue * (Math.PI / 180.0); // Convert Degree to Radian
							break;
						case AngularDistanceType.Degree:
							returnDouble = passedValue; // Return passed in Degree
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}