using System;

 namespace UnitClassLibrary
{

	public partial class Speed : IComparable, IComparable<Speed >
	{
		/// <summary> This implements the IComparable (Speed) interface and allows Speeds to be sorted and such </summary>
		public int CompareTo(Speed other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return this.MillimetersPerMicroseconds.CompareTo(other.GetValue(SpeedType.MillimetersPerMicrosecond));
			}
		}

		/// <summary> This implements the IComparable (Speed) interface and allows Speeds to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Speed))
			{
				throw new ArgumentException("Expected type Speed.", "obj");
			}

			return this.CompareTo((Speed)obj);
		}
	}
}