using System;

namespace UnitClassLibrary
{

	public partial class Speed : IEquatable <Speed>
	{

		/// <summary>Raise to power operator</summary>
		/// <param name="o1"></param>
		/// <param name="power"></param>
		/// <returns></returns>
		public static Speed operator ^(Speed o1, double power)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, Math.Pow(o1.MillimetersPerMicroseconds, power));
		}

		/// <summary>Returns new unit with sum of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Speed operator + (Speed o1, Speed o2)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, o1.GetValue(SpeedType.MillimetersPerMicrosecond) + o2.GetValue(SpeedType.MillimetersPerMicrosecond));
		}

		/// <summary>Returns new unit with difference of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Speed operator - (Speed o1, Speed o2)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, o1.GetValue(SpeedType.MillimetersPerMicrosecond) - o2.GetValue(SpeedType.MillimetersPerMicrosecond));
		}

		/// <summary>ratio between differences</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static double operator / (Speed o1, Speed o2)
		{
			return o1.GetValue(SpeedType.MillimetersPerMicrosecond) / o2.GetValue(SpeedType.MillimetersPerMicrosecond);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Speed operator * (Speed o1, double multiplier)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, o1.MillimetersPerMicroseconds * multiplier);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Speed operator*(double multiplier, Speed o1)
		{
			return o1 * multiplier;
		}

		/// <summary>scalar division</summary>
		/// <param name="o1"></param>
		/// <param name="divisor"></param>
		/// <returns></returns>
		public static Speed operator/(Speed o1, double divisor)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, o1.MillimetersPerMicroseconds / divisor);
		}

		/// <summary>Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant </summary>
		public static bool operator !=(Speed o1, Speed o2)
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
		public static bool operator ==(Speed o1, Speed o2)
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
		public static bool operator >(Speed o1, Speed o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.MillimetersPerMicroseconds > o2.MillimetersPerMicroseconds;
		}

		/// <summary>less than</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator <(Speed o1, Speed o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.MillimetersPerMicroseconds < o2.MillimetersPerMicroseconds;
		}

		/// <summary>less than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator<=(Speed o1, Speed o2)
		{
			return o1.Equals(o2) || o1 < o2;
		}

		/// <summary>greater than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator>=(Speed o1, Speed o2)
		{
			return o1.Equals(o2) || o1 > o2;
		}

		/// <summary>This override determines how this object is inserted into hashtables.</summary>
		/// <returns>same hashcode as any double would</returns>
		public override int GetHashCode()
		{
			return this._distance.GetHashCode() * this._time.GetHashCode();
		}

		/// <summary>The value and unit in terms of what the object was created with. </summary>
		/// <returns>Should never return anything</returns>
		public override string ToString()
		{
			return this._distance + " " + this._time;
		}

		/// <summary>calls the Dimension only Equals method</summary>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			return this.Equals((Speed)obj);
		}

		/// <summary>Compares using the function specified by strategy</summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(Speed other)
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