using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{
		public double Degrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType.Degree); }
		}
		public double Radians
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType.Radian); }
		}

		public double GetValue(AngleType Units)
		{
			switch (Units)
			{
				case AngleType.Degree:
					return Degrees;
				case AngleType.Radian:
					return Radians;
			}
			throw new Exception("Unknown AngleType");
		}
	}
}