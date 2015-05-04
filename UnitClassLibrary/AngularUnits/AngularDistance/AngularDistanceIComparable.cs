using System;

namespace UnitClassLibrary
{

	public partial class AngularDistance : IComparable, IComparable<AngularDistance >
	{
		/// <summary> This implements the IComparable (AngularDistance) interface and allows AngularDistances to be sorted and such </summary>
		public int CompareTo(AngularDistance other)
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

		/// <summary> This implements the IComparable (AngularDistance) interface and allows AngularDistances to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is AngularDistance))
			{
				throw new ArgumentException("Expected type AngularDistance.", "obj");
			}

			return this.CompareTo((AngularDistance)obj);
		}
	}
}