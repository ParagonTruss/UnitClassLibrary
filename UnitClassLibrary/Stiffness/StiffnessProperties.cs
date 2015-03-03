using System;

 namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		public double NewtonsPerMillimeters
		{
			get { return _Force.Newtons / _Distance.Millimeters; }
		}
		public double NewtonsPerCentimeters
		{
			get { return _Force.Newtons / _Distance.Centimeters; }
		}
		public double NewtonsPerMeters
		{
			get { return _Force.Newtons / _Distance.Meters; }
		}
		public double NewtonsPerKilometers
		{
			get { return _Force.Newtons / _Distance.Kilometers; }
		}
		public double NewtonsPerInches
		{
			get { return _Force.Newtons / _Distance.Inches; }
		}
		public double NewtonsPerFeet
		{
			get { return _Force.Newtons / _Distance.Feet; }
		}
		public double NewtonsPerYards
		{
			get { return _Force.Newtons / _Distance.Yards; }
		}
		public double NewtonsPerMiles
		{
			get { return _Force.Newtons / _Distance.Miles; }
		}
		public double PoundsPerMillimeters
		{
			get { return _Force.Pounds / _Distance.Millimeters; }
		}
		public double PoundsPerCentimeters
		{
			get { return _Force.Pounds / _Distance.Centimeters; }
		}
		public double PoundsPerMeters
		{
			get { return _Force.Pounds / _Distance.Meters; }
		}
		public double PoundsPerKilometers
		{
			get { return _Force.Pounds / _Distance.Kilometers; }
		}
		public double PoundsPerInches
		{
			get { return _Force.Pounds / _Distance.Inches; }
		}
		public double PoundsPerFeet
		{
			get { return _Force.Pounds / _Distance.Feet; }
		}
		public double PoundsPerYards
		{
			get { return _Force.Pounds / _Distance.Yards; }
		}
		public double PoundsPerMiles
		{
			get { return _Force.Pounds / _Distance.Miles; }
		}
		public double KipsPerMillimeters
		{
			get { return _Force.Kips / _Distance.Millimeters; }
		}
		public double KipsPerCentimeters
		{
			get { return _Force.Kips / _Distance.Centimeters; }
		}
		public double KipsPerMeters
		{
			get { return _Force.Kips / _Distance.Meters; }
		}
		public double KipsPerKilometers
		{
			get { return _Force.Kips / _Distance.Kilometers; }
		}
		public double KipsPerInches
		{
			get { return _Force.Kips / _Distance.Inches; }
		}
		public double KipsPerFeet
		{
			get { return _Force.Kips / _Distance.Feet; }
		}
		public double KipsPerYards
		{
			get { return _Force.Kips / _Distance.Yards; }
		}
		public double KipsPerMiles
		{
			get { return _Force.Kips / _Distance.Miles; }
		}

		public double GetValue(StiffnessType Units)
		{
			switch (Units)
			{
				case StiffnessType.NewtonsPerMillimeter:
					return NewtonsPerMillimeters;
				case StiffnessType.NewtonsPerCentimeter:
					return NewtonsPerCentimeters;
				case StiffnessType.NewtonsPerMeter:
					return NewtonsPerMeters;
				case StiffnessType.NewtonsPerKilometer:
					return NewtonsPerKilometers;
				case StiffnessType.NewtonsPerInch:
					return NewtonsPerInches;
				case StiffnessType.NewtonsPerFoot:
					return NewtonsPerFeet;
				case StiffnessType.NewtonsPerYard:
					return NewtonsPerYards;
				case StiffnessType.NewtonsPerMile:
					return NewtonsPerMiles;
				case StiffnessType.PoundsPerMillimeter:
					return PoundsPerMillimeters;
				case StiffnessType.PoundsPerCentimeter:
					return PoundsPerCentimeters;
				case StiffnessType.PoundsPerMeter:
					return PoundsPerMeters;
				case StiffnessType.PoundsPerKilometer:
					return PoundsPerKilometers;
				case StiffnessType.PoundsPerInch:
					return PoundsPerInches;
				case StiffnessType.PoundsPerFoot:
					return PoundsPerFeet;
				case StiffnessType.PoundsPerYard:
					return PoundsPerYards;
				case StiffnessType.PoundsPerMile:
					return PoundsPerMiles;
				case StiffnessType.KipsPerMillimeter:
					return KipsPerMillimeters;
				case StiffnessType.KipsPerCentimeter:
					return KipsPerCentimeters;
				case StiffnessType.KipsPerMeter:
					return KipsPerMeters;
				case StiffnessType.KipsPerKilometer:
					return KipsPerKilometers;
				case StiffnessType.KipsPerInch:
					return KipsPerInches;
				case StiffnessType.KipsPerFoot:
					return KipsPerFeet;
				case StiffnessType.KipsPerYard:
					return KipsPerYards;
				case StiffnessType.KipsPerMile:
					return KipsPerMiles;
			}
			throw new Exception("Unknown StiffnessType");
		}
	}
}