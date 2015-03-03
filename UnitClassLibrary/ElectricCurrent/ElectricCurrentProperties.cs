using System;

 namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{
		public double Amperes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricCurrentType.Ampere); }
		}
		public double Milliamperes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricCurrentType.Milliampere); }
		}
		public double Microamperes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricCurrentType.Microampere); }
		}

		public double GetValue(ElectricCurrentType Units)
		{
			switch (Units)
			{
				case ElectricCurrentType.Ampere:
					return Amperes;
				case ElectricCurrentType.Milliampere:
					return Milliamperes;
				case ElectricCurrentType.Microampere:
					return Microamperes;
			}
			throw new Exception("Unknown ElectricCurrentType");
		}
	}
}