using System;

 namespace UnitClassLibrary
{

	public partial class Mass
	{

		public static Mass Gram
		{
			get { return new Mass(MassType.Gram, 1); }
		}

		public static Mass Kilogram
		{
			get { return new Mass(MassType.Kilogram, 1); }
		}

		public static Mass MetricTon
		{
			get { return new Mass(MassType.MetricTon, 1); }
		}

		public static Mass Milligram
		{
			get { return new Mass(MassType.Milligram, 1); }
		}

		public static Mass Microgram
		{
			get { return new Mass(MassType.Microgram, 1); }
		}

		public static Mass LongTon
		{
			get { return new Mass(MassType.LongTon, 1); }
		}

		public static Mass ShortTon
		{
			get { return new Mass(MassType.ShortTon, 1); }
		}

		public static Mass Stone
		{
			get { return new Mass(MassType.Stone, 1); }
		}

		public static Mass Pound
		{
			get { return new Mass(MassType.Pound, 1); }
		}

		public static Mass Ounce
		{
			get { return new Mass(MassType.Ounce, 1); }
		}
	}
}