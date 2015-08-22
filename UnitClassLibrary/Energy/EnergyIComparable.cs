using System;

namespace UnitClassLibrary
{

	public partial class Energy : IComparable, IComparable<Energy >
	{
		/// <summary> This implements the IComparable (Energy) interface and allows Energys to be sorted and such </summary>
		public int CompareTo(Energy other)
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

		/// <summary> This implements the IComparable (Energy) interface and allows Energys to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Energy))
			{
				throw new ArgumentException("Expected type Energy.", "obj");
			}

			return this.CompareTo((Energy)obj);
		}
	}
}