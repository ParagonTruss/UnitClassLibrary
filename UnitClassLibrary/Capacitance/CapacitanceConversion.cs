namespace UnitClassLibrary
{

	public partial class Capacitance
	{
		/// <summary>Converts one unit of Capacitance to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertCapacitance(CapacitanceType typeConvertingFrom, double passedValue, CapacitanceType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case CapacitanceType.Picofarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue; // Return passed in Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue / .001; // Convert Picofarad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue / 1e6; // Convert Picofarad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue / 1e9; // Convert Picofarad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue / 1e12; // Convert Picofarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1e21; // Convert Picofarad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * .8988; // Convert Picofarad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Nanofarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1000; // Convert Nanofarad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue; // Return passed in Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue / 1e3; // Convert Nanofarad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue / 1e6; // Convert Nanofarad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue / 1e9; // Convert Nanofarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1e18; // Convert Nanofarad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * 898.8; // Convert Nanofarad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Microfarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1e6; // Convert Microfarad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue * 1e3; // Convert Microfarad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue; // Return passed in Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue / 1e3; // Convert Microfarad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue / 1e6; // Convert Microfarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1e15; // Convert Microfarad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * 898755; // Convert Microfarad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Millifarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1e9; // Convert Millifarad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue * 1e6; // Convert Millifarad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue * 1e3; // Convert Millifarad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue; // Return passed in Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue / 1e3; // Convert Millifarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1e12; // Convert Millifarad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * 8.988e8; // Convert Millifarad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Farad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1e12; // Convert Farad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue * 1e9; // Convert Farad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue * 1e6; // Convert Farad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue * 1e3; // Convert Farad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue; // Return passed in Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1e9; // Convert Farad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * 8.988e11; // Convert Farad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Abfarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1e21; // Convert Abfarad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue * 1e18; // Convert Abfarad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue * 1e15; // Convert Abfarad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue * 1e12; // Convert Abfarad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue * 1e9; // Convert Abfarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue; // Return passed in Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue * 8.988e20; // Convert Abfarad to Statfarad
							break;
					}
					break;
				case CapacitanceType.Statfarad:
					switch (typeConvertingTo)
					{
						case CapacitanceType.Picofarad:
							returnDouble = passedValue * 1.113; // Convert Statfarad to Picofarad
							break;
						case CapacitanceType.Nanofarad:
							returnDouble = passedValue / 1.113e3; // Convert Statfarad to Nanofarad
							break;
						case CapacitanceType.Microfarad:
							returnDouble = passedValue / 1.113e6; // Convert Statfarad to Microfarad
							break;
						case CapacitanceType.Millifarad:
							returnDouble = passedValue / 1.113e9; // Convert Statfarad to Millifarad
							break;
						case CapacitanceType.Farad:
							returnDouble = passedValue / 1.113e12; // Convert Statfarad to Farad
							break;
						case CapacitanceType.Abfarad:
							returnDouble = passedValue / 1.113e21; // Convert Statfarad to Abfarad
							break;
						case CapacitanceType.Statfarad:
							returnDouble = passedValue; // Return passed in Statfarad
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}