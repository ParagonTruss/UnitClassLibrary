using System;

 namespace UnitClassLibrary
{

	public partial class Force
	{
		public double Newtons
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ForceType.Newton); }
		}
		public double Pounds
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ForceType.Pound); }
		}
		public double Kips
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(ForceType.Kip); }
		}

		public double GetValue(ForceType Units)
		{
			switch (Units)
			{
				case ForceType.Newton:
					return Newtons;
				case ForceType.Pound:
					return Pounds;
				case ForceType.Kip:
					return Kips;
			}
			throw new Exception("Unknown ForceType");
		}
	}
}