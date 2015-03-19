using System;

 namespace UnitClassLibrary
{

	public partial class Stiffness : IComparable, IComparable<Stiffness >
	{
		/// <summary> This implements the IComparable (Stiffness) interface and allows Stiffnesss to be sorted and such </summary>
		public int CompareTo(Stiffness other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return this.NewtonsPerCentimeters.CompareTo(other.GetValue(StiffnessType.NewtonsPerCentimeter));
			}
		}

		/// <summary> This implements the IComparable (Stiffness) interface and allows Stiffnesss to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Stiffness))
			{
				throw new ArgumentException("Expected type Stiffness.", "obj");
			}

			return this.CompareTo((Stiffness)obj);
		}
	}
}