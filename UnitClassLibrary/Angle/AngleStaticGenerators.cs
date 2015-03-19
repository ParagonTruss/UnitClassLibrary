using System;

 namespace UnitClassLibrary
{

	public partial class Angle
	{

		///<summary>Generator method that constructs Angle with assumption that the passed value is in Degrees</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Angle MakeAngleWithDegrees(double passedValue)
		{
			return new Angle(AngleType.Degree, passedValue);
		}

		///<summary>Generator method that constructs Angle with assumption that the passed value is in Radians</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Angle MakeAngleWithRadians(double passedValue)
		{
			return new Angle(AngleType.Radian, passedValue);
		}
	}
}