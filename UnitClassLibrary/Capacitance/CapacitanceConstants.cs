using System;

 namespace UnitClassLibrary
{

	public partial class Capacitance
	{

		public static Capacitance Picofarad
		{
			get { return new Capacitance(CapacitanceType.Picofarad, 1); }
		}

		public static Capacitance Nanofarad
		{
			get { return new Capacitance(CapacitanceType.Nanofarad, 1); }
		}

		public static Capacitance Microfarad
		{
			get { return new Capacitance(CapacitanceType.Microfarad, 1); }
		}

		public static Capacitance Millifarad
		{
			get { return new Capacitance(CapacitanceType.Millifarad, 1); }
		}

		public static Capacitance Farad
		{
			get { return new Capacitance(CapacitanceType.Farad, 1); }
		}

		public static Capacitance Abfarad
		{
			get { return new Capacitance(CapacitanceType.Abfarad, 1); }
		}

		public static Capacitance Statfarad
		{
			get { return new Capacitance(CapacitanceType.Statfarad, 1); }
		}
	}
}