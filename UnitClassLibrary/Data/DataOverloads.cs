using System;

 namespace UnitClassLibrary
{

	public partial class Data : IEquatable <Data>
	{

		/// <summary>Raise to power operator</summary>
		/// <param name="o1"></param>
		/// <param name="power"></param>
		/// <returns></returns>
		public static Data operator ^(Data o1, double power)
		{
			return new Data(o1._internalUnitType, Math.Pow(o1._intrinsicValue, power));
		}

		/// <summary>Returns new unit with sum of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Data operator +(Data o1, Data o2)
		{
			return new Data(o1._internalUnitType, o1._intrinsicValue + o2.GetValue(o1._internalUnitType));
		}

		/// <summary>Returns new unit with difference of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Data operator -(Data o1, Data o2)
		{
			return new Data(o1._internalUnitType, o1._intrinsicValue - o2.GetValue(o1._internalUnitType));
		}

		/// <summary>ratio between differences</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static double operator/(Data o1, Data o2)
		{
			return o1.GetValue(o1._internalUnitType) / o2.GetValue(o1._internalUnitType);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Data operator*(Data o1, double multiplier)
		{
			return new Data(o1._internalUnitType, o1._intrinsicValue * multiplier);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Data operator*(double multiplier, Data o1)
		{
			return o1 * multiplier;
		}

		/// <summary>scalar division</summary>
		/// <param name="o1"></param>
		/// <param name="divisor"></param>
		/// <returns></returns>
		public static Data operator/(Data o1, double divisor)
		{
			return new Data(o1._internalUnitType, o1._intrinsicValue / divisor);
		}

		/// <summary>Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant </summary>
		public static bool operator !=(Data o1, Data o2)
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
		public static bool operator ==(Data o1, Data o2)
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
		public static bool operator >(Data o1, Data o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1._intrinsicValue > o2.GetValue(o1._internalUnitType);
		}

		/// <summary>less than</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator <(Data o1, Data o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1._intrinsicValue < o2.GetValue(o1._internalUnitType);
		}

		/// <summary>less than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator<=(Data o1, Data o2)
		{
			return o1.Equals(o2) || o1 < o2;
		}

		/// <summary>greater than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator>=(Data o1, Data o2)
		{
			return o1.Equals(o2) || o1 > o2;
		}

		/// <summary>This override determines how this object is inserted into hashtables.</summary>
		/// <returns>same hashcode as any double would</returns>
		public override int GetHashCode()
		{
			return _intrinsicValue.GetHashCode();
		}

		/// <summary>The value and unit in terms of what the object was created with. </summary>
		/// <returns>Should never return anything</returns>
		public override string ToString()
		{
			return this._intrinsicValue + " " + this._internalUnitType;
		}

		/// <summary>calls the Dimension only Equals method</summary>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			return this.Equals((Data)obj);
		}

		/// <summary>Compares using the function specified by strategy</summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(Data other)
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