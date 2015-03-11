using System;

 namespace UnitClassLibrary
{

	public partial class Energy
	{
		public double Calories
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType.Calorie); }
		}
		public double Kilocalories
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType.Kilocalorie); }
		}
		public double Ergs
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType.Erg); }
		}
		public double Footpounds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType.Footpound); }
		}
		public double Joules
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(EnergyType.Joule); }
		}

		public double GetValue(EnergyType Units)
		{
			switch (Units)
			{
				case EnergyType.Calorie:
					return Calories;
				case EnergyType.Kilocalorie:
					return Kilocalories;
				case EnergyType.Erg:
					return Ergs;
				case EnergyType.Footpound:
					return Footpounds;
				case EnergyType.Joule:
					return Joules;
			}
			throw new Exception("Unknown EnergyType");
		}
	}
}