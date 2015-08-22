using System;

namespace UnitClassLibrary
{

	public partial class Temperature
	{
		public double CelsiusDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Celsius); }
		}
		public double FahrenheitDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Fahrenheit); }
		}
		public double KelvinDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Kelvin); }
		}
		public double RankineDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Rankine); }
		}
		public double DelisleDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Delisle); }
		}
		public double ReaumurDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Reaumur); }
		}
		public double RomerDegrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(TemperatureType.Romer); }
		}

		public double GetValue(TemperatureType Units)
		{
			switch (Units)
			{
				case TemperatureType.Celsius:
					return CelsiusDegrees;
				case TemperatureType.Fahrenheit:
					return FahrenheitDegrees;
				case TemperatureType.Kelvin:
					return KelvinDegrees;
				case TemperatureType.Rankine:
					return RankineDegrees;
				case TemperatureType.Delisle:
					return DelisleDegrees;
				case TemperatureType.Reaumur:
					return ReaumurDegrees;
				case TemperatureType.Romer:
					return RomerDegrees;
			}
			throw new Exception("Unknown TemperatureType");
		}
	}
}