namespace UnitClassLibrary
{

	public partial class Capacitance
	{

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Picofarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithPicofarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Picofarad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Nanofarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithNanofarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Nanofarad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Microfarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithMicrofarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Microfarad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Millifarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithMillifarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Millifarad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Farads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithFarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Farad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Abfarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithAbfarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Abfarad, passedValue);
		}

		///<summary>Generator method that constructs Capacitance with assumption that the passed value is in Statfarads</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Capacitance MakeCapacitanceWithStatfarads(double passedValue)
		{
			return new Capacitance(CapacitanceType.Statfarad, passedValue);
		}
	}
}