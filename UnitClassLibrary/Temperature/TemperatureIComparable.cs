using System;

namespace UnitClassLibrary
{

	public partial class Temperature : IComparable, IComparable<Temperature >
	{
		/// <summary> This implements the IComparable (Temperature) interface and allows Temperatures to be sorted and such </summary>
		public int CompareTo(Temperature other)
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

		/// <summary> This implements the IComparable (Temperature) interface and allows Temperatures to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Temperature))
			{
				throw new ArgumentException("Expected type Temperature.", "obj");
			}

			return this.CompareTo((Temperature)obj);
		}
	}
}