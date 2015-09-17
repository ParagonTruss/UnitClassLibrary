using System;

namespace UnitClassLibrary
{

	public partial class Moment : Unit<Moment>, IEquatable<Moment>
    {

		/// <summary>Raise to power operator</summary>
		/// <param name="o1"></param>
		/// <param name="power"></param>
		/// <returns></returns>
		public static Moment operator ^(Moment o1, double power)
		{
			return new Moment(MomentType.NewtonsCentimeter, Math.Pow(o1.NewtonsCentimeters, power));
		}

		/// <summary>Returns new unit with sum of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Moment operator + (Moment o1, Moment o2)
		{
			return new Moment(MomentType.NewtonsCentimeter, o1.GetValue(MomentType.NewtonsCentimeter) + o2.GetValue(MomentType.NewtonsCentimeter));
		}

		/// <summary>Returns new unit with difference of two passed units</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static Moment operator - (Moment o1, Moment o2)
		{
			return new Moment(MomentType.NewtonsCentimeter, o1.GetValue(MomentType.NewtonsCentimeter) - o2.GetValue(MomentType.NewtonsCentimeter));
		}

		/// <summary>ratio between differences</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static double operator / (Moment o1, Moment o2)
		{
			return o1.GetValue(MomentType.NewtonsCentimeter) / o2.GetValue(MomentType.NewtonsCentimeter);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Moment operator * (Moment o1, double multiplier)
		{
			return new Moment(MomentType.NewtonsCentimeter, o1.NewtonsCentimeters * multiplier);
		}

		/// <summary>scalar multiplication</summary>
		/// <param name="o1"></param>
		/// <param name="multiplier"></param>
		/// <returns></returns>
		public static Moment operator*(double multiplier, Moment o1)
		{
			return o1 * multiplier;
		}

		/// <summary>scalar division</summary>
		/// <param name="o1"></param>
		/// <param name="divisor"></param>
		/// <returns></returns>
		public static Moment operator/(Moment o1, double divisor)
		{
			return new Moment(MomentType.NewtonsCentimeter, o1.NewtonsCentimeters / divisor);
		}

		/// <summary>Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant </summary>
		public static bool operator !=(Moment o1, Moment o2)
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
		public static bool operator ==(Moment o1, Moment o2)
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
		public static bool operator >(Moment o1, Moment o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.NewtonsCentimeters > o2.NewtonsCentimeters;
		}

		/// <summary>less than</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator <(Moment o1, Moment o2)
		{
			if (o1 == o2)
			{
				return false;
			}
			return o1.NewtonsCentimeters < o2.NewtonsCentimeters;
		}

		/// <summary>less than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator<=(Moment o1, Moment o2)
		{
			return o1.Equals(o2) || o1 < o2;
		}

		/// <summary>greater than or equal to</summary>
		/// <param name="o1"></param>
		/// <param name="o2"></param>
		/// <returns></returns>
		public static bool operator>=(Moment o1, Moment o2)
		{
			return o1.Equals(o2) || o1 > o2;
		}

		/// <summary>This override determines how this object is inserted into hashtables.</summary>
		/// <returns>same hashcode as any double would</returns>
		public override int GetHashCode()
		{
			return this._force.GetHashCode() * this._distance.GetHashCode();
		}

		/// <summary>The value and unit in terms of what the object was created with. </summary>
		/// <returns>Should never return anything</returns>
		public override string ToString()
		{
			return this._force + " " + this._distance;
		}

		/// <summary>calls the Dimension only Equals method</summary>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			return this.Equals((Moment)obj);
		}

		/// <summary>Compares using the function specified by strategy</summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(Moment other)
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

        public Moment ValueZero()
        {
            return Moment.Zero;
        }
    }
}