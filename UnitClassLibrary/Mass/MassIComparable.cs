using System;

 namespace UnitClassLibrary
{

	public partial class Mass : IComparable, IComparable<Mass >
	{
		/// <summary> This implements the IComparable (Mass) interface and allows Masss to be sorted and such </summary>
		public int CompareTo(Mass other)
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

		/// <summary> This implements the IComparable (Mass) interface and allows Masss to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Mass))
			{
				throw new ArgumentException("Expected type Mass.", "obj");
			}

			return this.CompareTo((Mass)obj);
		}
	}
}