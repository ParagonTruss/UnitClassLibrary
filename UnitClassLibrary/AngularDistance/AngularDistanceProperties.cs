using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{
		public double Radians
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngularDistanceType.Radian); }
		}
		public double Degrees
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(AngularDistanceType.Degree); }
		}

		public double GetValue(AngularDistanceType Units)
		{
			switch (Units)
			{
				case AngularDistanceType.Radian:
					return Radians;
				case AngularDistanceType.Degree:
					return Degrees;
			}
			throw new Exception("Unknown AngularDistanceType");
		}
	}
}