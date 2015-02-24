using System;

 namespace UnitClassLibrary
{

	public partial class Mass
	{

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Grams</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithGrams(double passedValue)
		{
			return new Mass(MassType.Gram, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Kilograms</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithKilograms(double passedValue)
		{
			return new Mass(MassType.Kilogram, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in MetricTons</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithMetricTons(double passedValue)
		{
			return new Mass(MassType.MetricTon, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Milligrams</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithMilligrams(double passedValue)
		{
			return new Mass(MassType.Milligram, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Micrograms</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithMicrograms(double passedValue)
		{
			return new Mass(MassType.Microgram, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in LongTons</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithLongTons(double passedValue)
		{
			return new Mass(MassType.LongTon, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in ShortTons</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithShortTons(double passedValue)
		{
			return new Mass(MassType.ShortTon, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Stones</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithStones(double passedValue)
		{
			return new Mass(MassType.Stone, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Pounds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithPounds(double passedValue)
		{
			return new Mass(MassType.Pound, passedValue);
		}

		///<summary>Generator method that constructs Mass with assumption that the passed value is in Ounces</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Mass MakeMassWithOunces(double passedValue)
		{
			return new Mass(MassType.Ounce, passedValue);
		}
	}
}