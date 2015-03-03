using System;

 namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{

		public static ElectricCurrent Ampere
		{
			get { return new ElectricCurrent(ElectricCurrentType.Ampere, 1); }
		}

		public static ElectricCurrent Milliampere
		{
			get { return new ElectricCurrent(ElectricCurrentType.Milliampere, 1); }
		}

		public static ElectricCurrent Microampere
		{
			get { return new ElectricCurrent(ElectricCurrentType.Microampere, 1); }
		}
	}
}