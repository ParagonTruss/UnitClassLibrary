using System;

 namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		public double NewtonsPerMillimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerMillimeter); }
		}
		public double NewtonsPerCentimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerCentimeter); }
		}
		public double NewtonsPerMeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerMeter); }
		}
		public double NewtonsPerKilometers
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerKilometer); }
		}
		public double NewtonsPerThirtySeconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerThirtySecond); }
		}
		public double NewtonsPerSixteenths
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerSixteenth); }
		}
		public double NewtonsPerInches
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerInch); }
		}
		public double NewtonsPerFeet
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerFoot); }
		}
		public double NewtonsPerYards
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerYard); }
		}
		public double NewtonsPerMiles
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.NewtonsPerMile); }
		}
		public double PoundsPerMillimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerMillimeter); }
		}
		public double PoundsPerCentimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerCentimeter); }
		}
		public double PoundsPerMeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerMeter); }
		}
		public double PoundsPerKilometers
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerKilometer); }
		}
		public double PoundsPerThirtySeconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerThirtySecond); }
		}
		public double PoundsPerSixteenths
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerSixteenth); }
		}
		public double PoundsPerInches
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerInch); }
		}
		public double PoundsPerFeet
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerFoot); }
		}
		public double PoundsPerYards
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerYard); }
		}
		public double PoundsPerMiles
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.PoundsPerMile); }
		}
		public double KipsPerMillimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerMillimeter); }
		}
		public double KipsPerCentimeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerCentimeter); }
		}
		public double KipsPerMeters
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerMeter); }
		}
		public double KipsPerKilometers
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerKilometer); }
		}
		public double KipsPerThirtySeconds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerThirtySecond); }
		}
		public double KipsPerSixteenths
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerSixteenth); }
		}
		public double KipsPerInches
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerInch); }
		}
		public double KipsPerFeet
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerFoot); }
		}
		public double KipsPerYards
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerYard); }
		}
		public double KipsPerMiles
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(StiffnessType.KipsPerMile); }
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
				case StiffnessType.NewtonsPerThirtySecond:
					return NewtonsPerThirtySeconds;
				case StiffnessType.NewtonsPerSixteenth:
					return NewtonsPerSixteenths;
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
				case StiffnessType.PoundsPerThirtySecond:
					return PoundsPerThirtySeconds;
				case StiffnessType.PoundsPerSixteenth:
					return PoundsPerSixteenths;
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
				case StiffnessType.KipsPerThirtySecond:
					return KipsPerThirtySeconds;
				case StiffnessType.KipsPerSixteenth:
					return KipsPerSixteenths;
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