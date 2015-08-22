using System;

namespace UnitClassLibrary
{

	public partial class DataTransferRate : IEquatable <DataTransferRate>
	{

		/// <summary>Raise to power operator</summary>
		/// <param name="o1"></param>
		/// <param name="power"></param>
		/// <returns></returns>
		public static DataTransferRate operator ^(DataTransferRate o1, double power)
		{
			return new DataTransferRate(DataTransferRateType.BitsPerMicrosecond, Math.Pow(o1.BitsPerMicroseconds, power));
		}

		/// <summary>Returns new unit with sum of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static DataTransferRate operator + (DataTransferRate o1, DataTransferRate o2)
		{
			return new DataTransferRate(DataTransferRateType.BitsPerMicrosecond, o1.GetValue(DataTransferRateType.BitsPerMicrosecond) + o2.GetValue(DataTransferRateType.BitsPerMicrosecond));
		}

		/// <summary>Returns new unit with difference of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static DataTransferRate operator - (DataTransferRate o1, DataTransferRate o2)
		{
			return new DataTransferRate(DataTransferRateType.BitsPerMicrosecond, o1.GetValue(DataTransferRateType.BitsPerMicrosecond) - o2.GetValue(DataTransferRateType.BitsPerMicrosecond));
		}

		/// <summary>ratio between differences</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static double operator / (DataTransferRate o1, DataTransferRate o2)
		{
			return o1.GetValue(DataTransferRateType.BitsPerMicrosecond) / o2.GetValue(DataTransferRateType.BitsPerMicrosecond);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static DataTransferRate operator * (DataTransferRate o1, double multiplier)
		{
			return new DataTransferRate(DataTransferRateType.BitsPerMicrosecond, o1.BitsPerMicroseconds * multiplier);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static DataTransferRate operator*(double multiplier, DataTransferRate o1)
		{
			return o1 * multiplier;
		}

		/// <summary>scalar division</summary>
		/// <param name="o1"></param>
		/// <param name="divisor"></param>
		/// <returns></returns>
		public static DataTransferRate operator/(DataTransferRate o1, double divisor)
		{
			return new DataTransferRate(DataTransferRateType.BitsPerMicrosecond, o1.BitsPerMicroseconds / divisor);
		}

		/// <summary>Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant </summary>
		public static bool operator !=(DataTransferRate o1, DataTransferRate o2)
		{
			if ((object)o1 == null)
			{
				if ((object)o2 == null)
				{
					return false;
				}
				return true;
			}
			return !o1.Equals(o2);
		}

		/// <summary>Not a perfect equality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant </summary>
		public static bool operator ==(DataTransferRate o1, DataTransferRate o2)
		{
			if ((object)o1 == null)
			{
				if ((object)o2 == null)
				{
					return true;
				}
				return true;
			}
			return o1.Equals(o2);
		}

		/// <summary>greater than</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator >(DataTransferRate o1, DataTransferRate o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.BitsPerMicroseconds > o2.BitsPerMicroseconds;
		}

		/// <summary>less than</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator <(DataTransferRate o1, DataTransferRate o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.BitsPerMicroseconds < o2.BitsPerMicroseconds;
		}

		/// <summary>less than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator<=(DataTransferRate o1, DataTransferRate o2)
		{
			return o1.Equals(o2) || o1 < o2;
		}

		/// <summary>greater than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator>=(DataTransferRate o1, DataTransferRate o2)
		{
			return o1.Equals(o2) || o1 > o2;
		}

		/// <summary>This override determines how this object is inserted into hashtables.</summary>
		/// <returns>same hashcode as any double would</returns>
		public override int GetHashCode()
		{
			return this._data.GetHashCode() * this._time.GetHashCode();
		}

		/// <summary>The value and unit in terms of what the object was created with. </summary>
		/// <returns>Should never return anything</returns>
		public override string ToString()
		{
			return this._data + " " + this._time;
		}

		/// <summary>calls the Dimension only Equals method</summary>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			return this.Equals((DataTransferRate)obj);
		}

		/// <summary>Compares using the function specified by strategy</summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(DataTransferRate other)
		{
			if (other == null)
			{
				return false;
			}
			try
			{
				return this._equalityStrategy(this, other);
			}
			catch
			{
				return false;
			}
		}
	}
}