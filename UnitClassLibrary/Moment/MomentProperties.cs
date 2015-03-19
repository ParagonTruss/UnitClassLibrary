using System;

 namespace UnitClassLibrary
{

	public partial class Moment
	{
		public double NewtonsMillimeters
		{
			get { return _force.Newtons * _distance.Millimeters; }
		}
		public double NewtonsCentimeters
		{
			get { return _force.Newtons * _distance.Centimeters; }
		}
		public double NewtonsMeters
		{
			get { return _force.Newtons * _distance.Meters; }
		}
		public double NewtonsKilometers
		{
			get { return _force.Newtons * _distance.Kilometers; }
		}
		public double NewtonsInches
		{
			get { return _force.Newtons * _distance.Inches; }
		}
		public double NewtonsFeet
		{
			get { return _force.Newtons * _distance.Feet; }
		}
		public double NewtonsYards
		{
			get { return _force.Newtons * _distance.Yards; }
		}
		public double NewtonsMiles
		{
			get { return _force.Newtons * _distance.Miles; }
		}
		public double PoundsMillimeters
		{
			get { return _force.Pounds * _distance.Millimeters; }
		}
		public double PoundsCentimeters
		{
			get { return _force.Pounds * _distance.Centimeters; }
		}
		public double PoundsMeters
		{
			get { return _force.Pounds * _distance.Meters; }
		}
		public double PoundsKilometers
		{
			get { return _force.Pounds * _distance.Kilometers; }
		}
		public double PoundsInches
		{
			get { return _force.Pounds * _distance.Inches; }
		}
		public double PoundsFeet
		{
			get { return _force.Pounds * _distance.Feet; }
		}
		public double PoundsYards
		{
			get { return _force.Pounds * _distance.Yards; }
		}
		public double PoundsMiles
		{
			get { return _force.Pounds * _distance.Miles; }
		}
		public double KipsMillimeters
		{
			get { return _force.Kips * _distance.Millimeters; }
		}
		public double KipsCentimeters
		{
			get { return _force.Kips * _distance.Centimeters; }
		}
		public double KipsMeters
		{
			get { return _force.Kips * _distance.Meters; }
		}
		public double KipsKilometers
		{
			get { return _force.Kips * _distance.Kilometers; }
		}
		public double KipsInches
		{
			get { return _force.Kips * _distance.Inches; }
		}
		public double KipsFeet
		{
			get { return _force.Kips * _distance.Feet; }
		}
		public double KipsYards
		{
			get { return _force.Kips * _distance.Yards; }
		}
		public double KipsMiles
		{
			get { return _force.Kips * _distance.Miles; }
		}

		public double GetValue(MomentType Units)
		{
			switch (Units)
			{
				case MomentType.NewtonsMillimeter:
					return NewtonsMillimeters;
				case MomentType.NewtonsCentimeter:
					return NewtonsCentimeters;
				case MomentType.NewtonsMeter:
					return NewtonsMeters;
				case MomentType.NewtonsKilometer:
					return NewtonsKilometers;
				case MomentType.NewtonsInch:
					return NewtonsInches;
				case MomentType.NewtonsFoot:
					return NewtonsFeet;
				case MomentType.NewtonsYard:
					return NewtonsYards;
				case MomentType.NewtonsMile:
					return NewtonsMiles;
				case MomentType.PoundsMillimeter:
					return PoundsMillimeters;
				case MomentType.PoundsCentimeter:
					return PoundsCentimeters;
				case MomentType.PoundsMeter:
					return PoundsMeters;
				case MomentType.PoundsKilometer:
					return PoundsKilometers;
				case MomentType.PoundsInch:
					return PoundsInches;
				case MomentType.PoundsFoot:
					return PoundsFeet;
				case MomentType.PoundsYard:
					return PoundsYards;
				case MomentType.PoundsMile:
					return PoundsMiles;
				case MomentType.KipsMillimeter:
					return KipsMillimeters;
				case MomentType.KipsCentimeter:
					return KipsCentimeters;
				case MomentType.KipsMeter:
					return KipsMeters;
				case MomentType.KipsKilometer:
					return KipsKilometers;
				case MomentType.KipsInch:
					return KipsInches;
				case MomentType.KipsFoot:
					return KipsFeet;
				case MomentType.KipsYard:
					return KipsYards;
				case MomentType.KipsMile:
					return KipsMiles;
			}
			throw new Exception("Unknown MomentType");
		}
	}
}