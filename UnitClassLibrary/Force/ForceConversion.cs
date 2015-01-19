using System;

 namespace UnitClassLibrary
{

	public partial class Force
	{
		/// <summary>Converts one unit of Force to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertForce(ForceType typeConvertingFrom, double passedValue, ForceType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case ForceType.Newton:
					switch (typeConvertingTo)
					{
						case ForceType.Newton:
							returnDouble = passedValue; // Return passed in Newton
							break;
						case ForceType.Pound:
							returnDouble = passedValue * (1/4.44822162); // Convert Newton to Pound
							break;
						case ForceType.Kip:
							returnDouble = passedValue * (1/4448.2216); // Convert Newton to Kip
							break;
					}
					break;
				case ForceType.Pound:
					switch (typeConvertingTo)
					{
						case ForceType.Newton:
							returnDouble = passedValue * 4.44822162; // Convert Pound to Newton
							break;
						case ForceType.Pound:
							returnDouble = passedValue; // Return passed in Pound
							break;
						case ForceType.Kip:
							returnDouble = passedValue * (1/1000); // Convert Pound to Kip
							break;
					}
					break;
				case ForceType.Kip:
					switch (typeConvertingTo)
					{
						case ForceType.Newton:
							returnDouble = passedValue * 4448.2216; // Convert Kip to Newton
							break;
						case ForceType.Pound:
							returnDouble = passedValue * 1000; // Convert Kip to Pound
							break;
						case ForceType.Kip:
							returnDouble = passedValue; // Return passed in Kip
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}