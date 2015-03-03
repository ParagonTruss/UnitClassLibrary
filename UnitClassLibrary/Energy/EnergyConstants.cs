using System;

 namespace UnitClassLibrary
{

	public partial class Energy
	{

		public static Energy Calorie
		{
			get { return new Energy(EnergyType.Calorie, 1); }
		}

		public static Energy Kilocalorie
		{
			get { return new Energy(EnergyType.Kilocalorie, 1); }
		}

		public static Energy Erg
		{
			get { return new Energy(EnergyType.Erg, 1); }
		}

		public static Energy Footpound
		{
			get { return new Energy(EnergyType.Footpound, 1); }
		}

		public static Energy Joule
		{
			get { return new Energy(EnergyType.Joule, 1); }
		}
	}
}