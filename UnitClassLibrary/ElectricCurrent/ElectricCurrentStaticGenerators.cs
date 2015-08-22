namespace UnitClassLibrary
{

	public partial class ElectricCurrent
	{

		///<summary>Generator method that constructs ElectricCurrent with assumption that the passed value is in Amperes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricCurrent MakeElectricCurrentWithAmperes(double passedValue)
		{
			return new ElectricCurrent(ElectricCurrentType.Ampere, passedValue);
		}

		///<summary>Generator method that constructs ElectricCurrent with assumption that the passed value is in Milliamperes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricCurrent MakeElectricCurrentWithMilliamperes(double passedValue)
		{
			return new ElectricCurrent(ElectricCurrentType.Milliampere, passedValue);
		}

		///<summary>Generator method that constructs ElectricCurrent with assumption that the passed value is in Microamperes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static ElectricCurrent MakeElectricCurrentWithMicroamperes(double passedValue)
		{
			return new ElectricCurrent(ElectricCurrentType.Microampere, passedValue);
		}
	}
}