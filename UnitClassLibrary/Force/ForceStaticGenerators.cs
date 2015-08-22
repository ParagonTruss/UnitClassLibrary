namespace UnitClassLibrary
{

	public partial class Force
	{

		///<summary>Generator method that constructs Force with assumption that the passed value is in Newtons</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Force MakeForceWithNewtons(double passedValue)
		{
			return new Force(ForceType.Newton, passedValue);
		}

		///<summary>Generator method that constructs Force with assumption that the passed value is in Pounds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Force MakeForceWithPounds(double passedValue)
		{
			return new Force(ForceType.Pound, passedValue);
		}

		///<summary>Generator method that constructs Force with assumption that the passed value is in Kips</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Force MakeForceWithKips(double passedValue)
		{
			return new Force(ForceType.Kip, passedValue);
		}
	}
}