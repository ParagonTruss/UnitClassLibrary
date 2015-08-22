using System;

namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		public double NewtonsPerMillimeters
		{
			get { return _force.Newtons / _distance.Millimeters; }
		}
		public double NewtonsPerCentimeters
		{
			get { return _force.Newtons / _distance.Centimeters; }
		}
		public double NewtonsPerMeters
		{
			get { return _force.Newtons / _distance.Meters; }
		}
		public double NewtonsPerKilometers
		{
			get { return _force.Newtons / _distance.Kilometers; }
		}
		public double NewtonsPerInches
		{
			get { return _force.Newtons / _distance.Inches; }
		}
		public double NewtonsPerFeet
		{
			get { return _force.Newtons / _distance.Feet; }
		}
		public double NewtonsPerYards
		{
			get { return _force.Newtons / _distance.Yards; }
		}
		public double NewtonsPerMiles
		{
			get { return _force.Newtons / _distance.Miles; }
		}
		public double PoundsPerMillimeters
		{
			get { return _force.Pounds / _distance.Millimeters; }
		}
		public double PoundsPerCentimeters
		{
			get { return _force.Pounds / _distance.Centimeters; }
		}
		public double PoundsPerMeters
		{
			get { return _force.Pounds / _distance.Meters; }
		}
		public double PoundsPerKilometers
		{
			get { return _force.Pounds / _distance.Kilometers; }
		}
		public double PoundsPerInches
		{
			get { return _force.Pounds / _distance.Inches; }
		}
		public double PoundsPerFeet
		{
			get { return _force.Pounds / _distance.Feet; }
		}
		public double PoundsPerYards
		{
			get { return _force.Pounds / _distance.Yards; }
		}
		public double PoundsPerMiles
		{
			get { return _force.Pounds / _distance.Miles; }
		}
		public double KipsPerMillimeters
		{
			get { return _force.Kips / _distance.Millimeters; }
		}
		public double KipsPerCentimeters
		{
			get { return _force.Kips / _distance.Centimeters; }
		}
		public double KipsPerMeters
		{
			get { return _force.Kips / _distance.Meters; }
		}
		public double KipsPerKilometers
		{
			get { return _force.Kips / _distance.Kilometers; }
		}
		public double KipsPerInches
		{
			get { return _force.Kips / _distance.Inches; }
		}
		public double KipsPerFeet
		{
			get { return _force.Kips / _distance.Feet; }
		}
		public double KipsPerYards
		{
			get { return _force.Kips / _distance.Yards; }
		}
		public double KipsPerMiles
		{
			get { return _force.Kips / _distance.Miles; }
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