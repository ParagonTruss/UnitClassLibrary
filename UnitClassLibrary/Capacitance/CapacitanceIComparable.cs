using System;

 namespace UnitClassLibrary
{

	public partial class Capacitance : IComparable, IComparable<Capacitance >
	{
		/// <summary> This implements the IComparable (Capacitance) interface and allows Capacitances to be sorted and such </summary>
		public int CompareTo(Capacitance other)
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

		/// <summary> This implements the IComparable (Capacitance) interface and allows Capacitances to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Capacitance))
			{
				throw new ArgumentException("Expected type Capacitance.", "obj");
			}

			return this.CompareTo((Capacitance)obj);
		}
	}
}