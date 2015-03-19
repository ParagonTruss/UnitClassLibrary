using System;

 namespace UnitClassLibrary
{

	public partial class Angle : IComparable, IComparable<Angle >
	{
		/// <summary> This implements the IComparable (Angle) interface and allows Angles to be sorted and such </summary>
		public int CompareTo(Angle other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return _intrinsicValue.CompareTo(other.GetValue(_internalUnitType));
			}
		}

		/// <summary> This implements the IComparable (Angle) interface and allows Angles to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Angle))
			{
				throw new ArgumentException("Expected type Angle.", "obj");
			}

			return this.CompareTo((Angle)obj);
		}
	}
}