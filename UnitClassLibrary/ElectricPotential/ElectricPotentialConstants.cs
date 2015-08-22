namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{

		public static ElectricPotential Microvolt
		{
			get { return new ElectricPotential(ElectricPotentialType.Microvolt, 1); }
		}

		public static ElectricPotential Millivolt
		{
			get { return new ElectricPotential(ElectricPotentialType.Millivolt, 1); }
		}

		public static ElectricPotential Volt
		{
			get { return new ElectricPotential(ElectricPotentialType.Volt, 1); }
		}

		public static ElectricPotential Kilovolt
		{
			get { return new ElectricPotential(ElectricPotentialType.Kilovolt, 1); }
		}

		public static ElectricPotential Megavolt
		{
			get { return new ElectricPotential(ElectricPotentialType.Megavolt, 1); }
		}

		public static ElectricPotential Petavolt
		{
			get { return new ElectricPotential(ElectricPotentialType.Petavolt, 1); }
		}
	}
}