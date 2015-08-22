using System;

namespace UnitClassLibrary
{

	public partial class DataTransferRate : IComparable, IComparable<DataTransferRate >
	{
		/// <summary> This implements the IComparable (DataTransferRate) interface and allows DataTransferRates to be sorted and such </summary>
		public int CompareTo(DataTransferRate other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return this.BitsPerMicroseconds.CompareTo(other.GetValue(DataTransferRateType.BitsPerMicrosecond));
			}
		}

		/// <summary> This implements the IComparable (DataTransferRate) interface and allows DataTransferRates to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is DataTransferRate))
			{
				throw new ArgumentException("Expected type DataTransferRate.", "obj");
			}

			return this.CompareTo((DataTransferRate)obj);
		}
	}
}