using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{

		public static Angle Degree
		{
			get { return new Angle(AngleType.Degree, 1); }
		}

		public static Angle Radian
		{
			get { return new Angle(AngleType.Radian, 1); }
		}
	}
}