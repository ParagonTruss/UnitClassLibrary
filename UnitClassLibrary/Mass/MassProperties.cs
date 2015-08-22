using System;

namespace UnitClassLibrary
{

	public partial class Mass
	{
		public double Grams
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Gram); }
		}
		public double Kilograms
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Kilogram); }
		}
		public double MetricTons
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.MetricTon); }
		}
		public double Milligrams
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Milligram); }
		}
		public double Micrograms
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Microgram); }
		}
		public double LongTons
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.LongTon); }
		}
		public double ShortTons
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.ShortTon); }
		}
		public double Stones
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Stone); }
		}
		public double Pounds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Pound); }
		}
		public double Ounces
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(MassType.Ounce); }
		}

		public double GetValue(MassType Units)
		{
			switch (Units)
			{
				case MassType.Gram:
					return Grams;
				case MassType.Kilogram:
					return Kilograms;
				case MassType.MetricTon:
					return MetricTons;
				case MassType.Milligram:
					return Milligrams;
				case MassType.Microgram:
					return Micrograms;
				case MassType.LongTon:
					return LongTons;
				case MassType.ShortTon:
					return ShortTons;
				case MassType.Stone:
					return Stones;
				case MassType.Pound:
					return Pounds;
				case MassType.Ounce:
					return Ounces;
			}
			throw new Exception("Unknown MassType");
		}
	}
}