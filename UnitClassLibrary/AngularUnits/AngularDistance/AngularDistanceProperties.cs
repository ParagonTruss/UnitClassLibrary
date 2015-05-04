using System;

namespace UnitClassLibrary
{
	public partial class AngularDistance
	{
        public double Radians
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType.Radian); }
		}
		public double Degrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngleType.Degree); }
		}

		public double GetValue(AngleType units)
		{
			switch (units)
			{
				case AngleType.Radian:
					return Radians;
				case AngleType.Degree:
					return Degrees;
			}

			throw new Exception("Unknown AngleType");
		}
	}
}