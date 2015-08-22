namespace UnitClassLibrary
{

	public partial class Temperature
	{

		public static Temperature Celsius
		{
			get { return new Temperature(TemperatureType.Celsius, 1); }
		}

		public static Temperature Fahrenheit
		{
			get { return new Temperature(TemperatureType.Fahrenheit, 1); }
		}

		public static Temperature Kelvin
		{
			get { return new Temperature(TemperatureType.Kelvin, 1); }
		}

		public static Temperature Rankine
		{
			get { return new Temperature(TemperatureType.Rankine, 1); }
		}

		public static Temperature Delisle
		{
			get { return new Temperature(TemperatureType.Delisle, 1); }
		}

		public static Temperature Reaumur
		{
			get { return new Temperature(TemperatureType.Reaumur, 1); }
		}

		public static Temperature Romer
		{
			get { return new Temperature(TemperatureType.Romer, 1); }
		}
	}
}