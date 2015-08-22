namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{
		/// <summary>Converts one unit of ElectricPotential to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertElectricPotential(ElectricPotentialType typeConvertingFrom, double passedValue, ElectricPotentialType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case ElectricPotentialType.Microvolt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue; // Return passed in Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue / 1e3; // Convert Microvolt to Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue / 1e6; // Convert Microvolt to Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue / 1e9; // Convert Microvolt to Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue / 1e12; // Convert Microvolt to Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue / 1e21; // Convert Microvolt to Petavolt
							break;
					}
					break;
				case ElectricPotentialType.Millivolt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue * 1000; // Convert Millivolt to Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue; // Return passed in Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue / 1e3; // Convert Millivolt to Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue / 1e6; // Convert Millivolt to Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue / 1e9; // Convert Millivolt to Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue / 1e18; // Convert Millivolt to Petavolt
							break;
					}
					break;
				case ElectricPotentialType.Volt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue * 1e6; // Convert Volt to Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue * 1e3; // Convert Volt to Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue; // Return passed in Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue / 1e3; // Convert Volt to Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue / 1e6; // Convert Volt to Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue / 1e15; // Convert Volt to Petavolt
							break;
					}
					break;
				case ElectricPotentialType.Kilovolt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue * 1e9; // Convert Kilovolt to Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue * 1e6; // Convert Kilovolt to Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue * 1e3; // Convert Kilovolt to Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue; // Return passed in Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue / 1e3; // Convert Kilovolt to Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue / 1e12; // Convert Kilovolt to Petavolt
							break;
					}
					break;
				case ElectricPotentialType.Megavolt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue * 1e12; // Convert Megavolt to Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue * 1e9; // Convert Megavolt to Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue * 1e6; // Convert Megavolt to Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue * 1e3; // Convert Megavolt to Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue; // Return passed in Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue / 1e9; // Convert Megavolt to Petavolt
							break;
					}
					break;
				case ElectricPotentialType.Petavolt:
					switch (typeConvertingTo)
					{
						case ElectricPotentialType.Microvolt:
							returnDouble = passedValue * 1e21; // Convert Petavolt to Microvolt
							break;
						case ElectricPotentialType.Millivolt:
							returnDouble = passedValue * 1e18; // Convert Petavolt to Millivolt
							break;
						case ElectricPotentialType.Volt:
							returnDouble = passedValue * 1e15; // Convert Petavolt to Volt
							break;
						case ElectricPotentialType.Kilovolt:
							returnDouble = passedValue * 1e12; // Convert Petavolt to Kilovolt
							break;
						case ElectricPotentialType.Megavolt:
							returnDouble = passedValue * 1e9; // Convert Petavolt to Megavolt
							break;
						case ElectricPotentialType.Petavolt:
							returnDouble = passedValue; // Return passed in Petavolt
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}