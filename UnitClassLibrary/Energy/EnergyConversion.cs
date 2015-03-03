using System;

 namespace UnitClassLibrary
{

	public partial class Energy
	{
		/// <summary>Converts one unit of Energy to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertEnergy(EnergyType typeConvertingFrom, double passedValue, EnergyType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case EnergyType.Calorie:
					switch (typeConvertingTo)
					{
						case EnergyType.Calorie:
							returnDouble = passedValue; // Return passed in Calorie
							break;
						case EnergyType.Kilocalorie:
							returnDouble = passedValue * 1e-3; // Convert Calorie to Kilocalorie
							break;
						case EnergyType.Erg:
							returnDouble = passedValue * 4.184e7; // Convert Calorie to Erg
							break;
						case EnergyType.Footpound:
							returnDouble = passedValue * 3.086; // Convert Calorie to Footpound
							break;
						case EnergyType.Joule:
							returnDouble = passedValue * 4.184; // Convert Calorie to Joule
							break;
					}
					break;
				case EnergyType.Kilocalorie:
					switch (typeConvertingTo)
					{
						case EnergyType.Calorie:
							returnDouble = passedValue * 1000; // Convert Kilocalorie to Calorie
							break;
						case EnergyType.Kilocalorie:
							returnDouble = passedValue; // Return passed in Kilocalorie
							break;
						case EnergyType.Erg:
							returnDouble = passedValue * 4.184e10; // Convert Kilocalorie to Erg
							break;
						case EnergyType.Footpound:
							returnDouble = passedValue * 3086; // Convert Kilocalorie to Footpound
							break;
						case EnergyType.Joule:
							returnDouble = passedValue * 4180; // Convert Kilocalorie to Joule
							break;
					}
					break;
				case EnergyType.Erg:
					switch (typeConvertingTo)
					{
						case EnergyType.Calorie:
							returnDouble = passedValue * 2.39e-8; // Convert Erg to Calorie
							break;
						case EnergyType.Kilocalorie:
							returnDouble = passedValue * 2.39e-11; // Convert Erg to Kilocalorie
							break;
						case EnergyType.Erg:
							returnDouble = passedValue; // Return passed in Erg
							break;
						case EnergyType.Footpound:
							returnDouble = passedValue * 7.376e-8; // Convert Erg to Footpound
							break;
						case EnergyType.Joule:
							returnDouble = passedValue * 1e-7; // Convert Erg to Joule
							break;
					}
					break;
				case EnergyType.Footpound:
					switch (typeConvertingTo)
					{
						case EnergyType.Calorie:
							returnDouble = passedValue * .324; // Convert Footpound to Calorie
							break;
						case EnergyType.Kilocalorie:
							returnDouble = passedValue * 3.24e-4; // Convert Footpound to Kilocalorie
							break;
						case EnergyType.Erg:
							returnDouble = passedValue * 1.356e7; // Convert Footpound to Erg
							break;
						case EnergyType.Footpound:
							returnDouble = passedValue; // Return passed in Footpound
							break;
						case EnergyType.Joule:
							returnDouble = passedValue * 1.356; // Convert Footpound to Joule
							break;
					}
					break;
				case EnergyType.Joule:
					switch (typeConvertingTo)
					{
						case EnergyType.Calorie:
							returnDouble = passedValue * .239; // Convert Joule to Calorie
							break;
						case EnergyType.Kilocalorie:
							returnDouble = passedValue * 2.39e-4; // Convert Joule to Kilocalorie
							break;
						case EnergyType.Erg:
							returnDouble = passedValue * 1e7; // Convert Joule to Erg
							break;
						case EnergyType.Footpound:
							returnDouble = passedValue * .7376; // Convert Joule to Footpound
							break;
						case EnergyType.Joule:
							returnDouble = passedValue; // Return passed in Joule
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}