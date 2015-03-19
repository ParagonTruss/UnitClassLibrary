using System;

 namespace UnitClassLibrary
{

	public partial class Moment : IComparable, IComparable<Moment >
	{
		/// <summary> This implements the IComparable (Moment) interface and allows Moments to be sorted and such </summary>
		public int CompareTo(Moment other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return this.NewtonsCentimeters.CompareTo(other.GetValue(MomentType.NewtonsCentimeter));
			}
		}

		/// <summary> This implements the IComparable (Moment) interface and allows Moments to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Moment))
			{
				throw new ArgumentException("Expected type Moment.", "obj");
			}

			return this.CompareTo((Moment)obj);
		}
	}
}