using System;

 namespace UnitClassLibrary
{

	public partial class ElectricPotential : IComparable, IComparable<ElectricPotential >
	{
		/// <summary> This implements the IComparable (ElectricPotential) interface and allows ElectricPotentials to be sorted and such </summary>
		public int CompareTo(ElectricPotential other)
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

		/// <summary> This implements the IComparable (ElectricPotential) interface and allows ElectricPotentials to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is ElectricPotential))
			{
				throw new ArgumentException("Expected type ElectricPotential.", "obj");
			}

			return this.CompareTo((ElectricPotential)obj);
		}
	}
}