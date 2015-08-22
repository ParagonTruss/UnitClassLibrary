using System;

namespace UnitClassLibrary
{

	public partial class Time : IComparable, IComparable<Time >
	{
		/// <summary> This implements the IComparable (Time) interface and allows Times to be sorted and such </summary>
		public int CompareTo(Time other)
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

		/// <summary> This implements the IComparable (Time) interface and allows Times to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Time))
			{
				throw new ArgumentException("Expected type Time.", "obj");
			}

			return this.CompareTo((Time)obj);
		}
	}
}