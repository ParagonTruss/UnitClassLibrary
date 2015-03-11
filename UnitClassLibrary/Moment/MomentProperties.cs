using System;

 namespace UnitClassLibrary
{

	public partial class Moment
	{
		public double NewtonsMillimeters
		{
			get { return _Force.Newtons * _Distance.Millimeters; }
		}
		public double NewtonsCentimeters
		{
			get { return _Force.Newtons * _Distance.Centimeters; }
		}
		public double NewtonsMeters
		{
			get { return _Force.Newtons * _Distance.Meters; }
		}
		public double NewtonsKilometers
		{
			get { return _Force.Newtons * _Distance.Kilometers; }
		}
		public double NewtonsInches
		{
			get { return _Force.Newtons * _Distance.Inches; }
		}
		public double NewtonsFeet
		{
			get { return _Force.Newtons * _Distance.Feet; }
		}
		public double NewtonsYards
		{
			get { return _Force.Newtons * _Distance.Yards; }
		}
		public double NewtonsMiles
		{
			get { return _Force.Newtons * _Distance.Miles; }
		}
		public double PoundsMillimeters
		{
			get { return _Force.Pounds * _Distance.Millimeters; }
		}
		public double PoundsCentimeters
		{
			get { return _Force.Pounds * _Distance.Centimeters; }
		}
		public double PoundsMeters
		{
			get { return _Force.Pounds * _Distance.Meters; }
		}
		public double PoundsKilometers
		{
			get { return _Force.Pounds * _Distance.Kilometers; }
		}
		public double PoundsInches
		{
			get { return _Force.Pounds * _Distance.Inches; }
		}
		public double PoundsFeet
		{
			get { return _Force.Pounds * _Distance.Feet; }
		}
		public double PoundsYards
		{
			get { return _Force.Pounds * _Distance.Yards; }
		}
		public double PoundsMiles
		{
			get { return _Force.Pounds * _Distance.Miles; }
		}
		public double KipsMillimeters
		{
			get { return _Force.Kips * _Distance.Millimeters; }
		}
		public double KipsCentimeters
		{
			get { return _Force.Kips * _Distance.Centimeters; }
		}
		public double KipsMeters
		{
			get { return _Force.Kips * _Distance.Meters; }
		}
		public double KipsKilometers
		{
			get { return _Force.Kips * _Distance.Kilometers; }
		}
		public double KipsInches
		{
			get { return _Force.Kips * _Distance.Inches; }
		}
		public double KipsFeet
		{
			get { return _Force.Kips * _Distance.Feet; }
		}
		public double KipsYards
		{
			get { return _Force.Kips * _Distance.Yards; }
		}
		public double KipsMiles
		{
			get { return _Force.Kips * _Distance.Miles; }
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