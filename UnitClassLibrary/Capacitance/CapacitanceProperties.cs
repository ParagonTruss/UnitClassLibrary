using System;

 namespace UnitClassLibrary
{

	public partial class Capacitance
	{
		public double Picofarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Picofarad); }
		}
		public double Nanofarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Nanofarad); }
		}
		public double Microfarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Microfarad); }
		}
		public double Millifarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Millifarad); }
		}
		public double Farads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Farad); }
		}
		public double Abfarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Abfarad); }
		}
		public double Statfarads
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(CapacitanceType.Statfarad); }
		}

		public double GetValue(CapacitanceType Units)
		{
			switch (Units)
			{
				case CapacitanceType.Picofarad:
					return Picofarads;
				case CapacitanceType.Nanofarad:
					return Nanofarads;
				case CapacitanceType.Microfarad:
					return Microfarads;
				case CapacitanceType.Millifarad:
					return Millifarads;
				case CapacitanceType.Farad:
					return Farads;
				case CapacitanceType.Abfarad:
					return Abfarads;
				case CapacitanceType.Statfarad:
					return Statfarads;
			}
			throw new Exception("Unknown CapacitanceType");
		}
	}
}