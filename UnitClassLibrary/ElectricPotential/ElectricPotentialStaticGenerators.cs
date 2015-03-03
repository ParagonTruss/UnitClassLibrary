using System;

 namespace UnitClassLibrary
{

	public partial class ElectricPotential
	{

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Microvolts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithMicrovolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Microvolt, passedValue);
		}

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Millivolts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithMillivolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Millivolt, passedValue);
		}

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Volts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithVolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Volt, passedValue);
		}

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Kilovolts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithKilovolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Kilovolt, passedValue);
		}

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Megavolts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithMegavolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Megavolt, passedValue);
		}

		///<summary>Generator method that constructs ElectricPotential with assumption that the passed value is in Petavolts</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricPotential MakeElectricPotentialWithPetavolts(double passedValue)
		{
			return new ElectricPotential(ElectricPotentialType.Petavolt, passedValue);
		}
	}
}