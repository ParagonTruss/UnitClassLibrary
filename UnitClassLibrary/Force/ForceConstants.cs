namespace UnitClassLibrary
{

	public partial class Force
	{

		public static Force Newton
		{
			get { return new Force(ForceType.Newton, 1); }
		}

		public static Force Pound
		{
			get { return new Force(ForceType.Pound, 1); }
		}

		public static Force Kip
		{
			get { return new Force(ForceType.Kip, 1); }
		}
	}
}