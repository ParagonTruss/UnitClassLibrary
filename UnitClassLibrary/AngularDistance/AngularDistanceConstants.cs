using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{

		public static AngularDistance Radian
		{
			get { return new AngularDistance(AngleType.Radian, 1); }
		}

		public static AngularDistance Degree
		{
			get { return new AngularDistance(AngleType.Degree, 1); }
		}
	}
}