using System;

 namespace UnitClassLibrary
{

	public partial class AngularDistance
	{

		///<summary>Generator method that constructs AngularDistance with assumption that the passed value is in Radians</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static AngularDistance MakeAngularDistanceWithRadians(double passedValue)
		{
			return new AngularDistance(AngleType.Radian, passedValue);
		}

		///<summary>Generator method that constructs AngularDistance with assumption that the passed value is in Degrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static AngularDistance MakeAngularDistanceWithDegrees(double passedValue)
		{
			return new AngularDistance(AngleType.Degree, passedValue);
		}
	}
}