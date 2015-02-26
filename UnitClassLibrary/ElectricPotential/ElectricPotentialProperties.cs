using System;

 namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{
		public double Microvolts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Microvolt); }
		}
		public double Millivolts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Millivolt); }
		}
		public double Volts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Volt); }
		}
		public double Kilovolts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Kilovolt); }
		}
		public double Megavolts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Megavolt); }
		}
		public double Petavolts
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ElectricPotentialType.Petavolt); }
		}

		public double GetValue(ElectricPotentialType Units)
		{
			switch (Units)
			{
				case ElectricPotentialType.Microvolt:
					return Microvolts;
				case ElectricPotentialType.Millivolt:
					return Millivolts;
				case ElectricPotentialType.Volt:
					return Volts;
				case ElectricPotentialType.Kilovolt:
					return Kilovolts;
				case ElectricPotentialType.Megavolt:
					return Megavolts;
				case ElectricPotentialType.Petavolt:
					return Petavolts;
			}
			throw new Exception("Unknown ElectricPotentialType");
		}
	}
}