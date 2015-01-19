using System;

 namespace UnitClassLibrary
{

	public partial class Force : IComparable, IComparable<Force >
	{
		/// <summary> This implements the IComparable (Force) interface and allows Forces to be sorted and such </summary>
		public int CompareTo(Force other)
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

		/// <summary> This implements the IComparable (Force) interface and allows Forces to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Force))
			{
				throw new ArgumentException("Expected type Force.", "obj");
			}

			return this.CompareTo((Force)obj);
		}
	}
}