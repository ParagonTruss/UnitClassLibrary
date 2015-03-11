using System;

 namespace UnitClassLibrary
{

	public partial class Energy
	{

		///<summary>Generator method that constructs Energy with assumption that the passed value is in Calories</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Energy MakeEnergyWithCalories(double passedValue)
		{
			return new Energy(EnergyType.Calorie, passedValue);
		}

		///<summary>Generator method that constructs Energy with assumption that the passed value is in Kilocalories</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Energy MakeEnergyWithKilocalories(double passedValue)
		{
			return new Energy(EnergyType.Kilocalorie, passedValue);
		}

		///<summary>Generator method that constructs Energy with assumption that the passed value is in Ergs</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Energy MakeEnergyWithErgs(double passedValue)
		{
			return new Energy(EnergyType.Erg, passedValue);
		}

		///<summary>Generator method that constructs Energy with assumption that the passed value is in Footpounds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Energy MakeEnergyWithFootpounds(double passedValue)
		{
			return new Energy(EnergyType.Footpound, passedValue);
		}

		///<summary>Generator method that constructs Energy with assumption that the passed value is in Joules</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Energy MakeEnergyWithJoules(double passedValue)
		{
			return new Energy(EnergyType.Joule, passedValue);
		}
	}
}