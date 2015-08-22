using System;

namespace UnitClassLibrary
{

	public partial class ElectricCurrent : IComparable, IComparable<ElectricCurrent >
	{
		/// <summary> This implements the IComparable (ElectricCurrent) interface and allows ElectricCurrents to be sorted and such </summary>
		public int CompareTo(ElectricCurrent other)
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

		/// <summary> This implements the IComparable (ElectricCurrent) interface and allows ElectricCurrents to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is ElectricCurrent))
			{
				throw new ArgumentException("Expected type ElectricCurrent.", "obj");
			}

			return this.CompareTo((ElectricCurrent)obj);
		}
	}
}