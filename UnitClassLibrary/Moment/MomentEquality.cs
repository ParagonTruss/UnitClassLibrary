using System;

namespace UnitClassLibrary
{

	/// <summary>delegate that defines the form of</summary>
	/// <param name="moment1"></param>
	/// <param name="moment2"></param>
	/// <returns></returns>
	public delegate bool MomentEqualityStrategy (Moment moment1, Moment moment2);

	public partial class Moment
	{
		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality deviation </summary>
		public bool EqualsWithinDeviationConstant(Moment moment, Moment passedAcceptedEqualityDeviationDistance)
		{
			return (Math.Abs(
				(this.GetValue(MomentType.PoundsInch)
                - ((Moment)(moment)).GetValue(MomentType.PoundsInch))
				))
                <= passedAcceptedEqualityDeviationDistance.GetValue(MomentType.PoundsInch);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDeviationPercentage(Moment moment, Moment passedAcceptedEqualityDeviationPercentage)
		{
            return (Math.Abs(this.GetValue(MomentType.PoundsInch) - (moment).GetValue(MomentType.PoundsInch))) <= this.GetValue(MomentType.PoundsInch);
		}

		/// <summary> value comparison, checks whether the two are equal within a passed accepted equality percentage </summary>
		public bool EqualsWithinDistanceEqualityStrategy(Moment moment, MomentEqualityStrategy passedStrategy)
		{
			return passedStrategy(this, moment);
		}
	}

	/// <summary> Default deviations allowed when comparing Moment objects </summary>
	public static partial class MomentDeviationDefaults
	{

		/// <summary> When comparing two moment and deviation is allowed to be within a specific constant. This is that default constant </summary>
		public static Moment AcceptedEqualityDeviationDistance
		{
			// TODO: This is auto-generated, based on the first unit passed. It should probably be changed.
			get { return new Moment(MomentType.PoundsInch, 1); }
		}

		/// <summary> When comparing two moment and deviation is allowed to be within a percentage of the firstMoment. This is that percentage </summary>
		public static double  MomentAcceptedEqualityDeviationDistancePercentage
		{
			// TODO: This is auto-generated. It might should be changed.
			get { return 0.00001; }
		}
	}

	/// <summary> functions that can be used for a moment object's equals functions </summary>
	public static class MomentEqualityStrategyImplementations
	{

		/// <summary> Moments are equal if they differ by less than a percentage of the first Moment </summary>
		/// <param name="moment1">first moment being compared</param>
		/// <param name="moment2">second moment being compared</param>
		/// <returns></returns>
		public static bool DefaultPercentageEquality (Moment moment1, Moment moment2)
		{
            return (Math.Abs(moment1.GetValue(MomentType.PoundsInch) - (moment2).GetValue(MomentType.PoundsInch))) <= Math.Abs(moment1.GetValue(MomentType.PoundsInch) * MomentDeviationDefaults.MomentAcceptedEqualityDeviationDistancePercentage);
		}

		/// <summary> Moments are equal if there values are within the passed deviation constant. If they are not within the constant </summary>
		/// <param name="moment1">first moment being compared</param>
		/// <param name="moment2">second moment being compared</param>
		/// <returns></returns>
		public static bool DefaultConstantEquality (Moment moment1, Moment moment2)
		{
            return (Math.Abs(moment1.GetValue(MomentType.PoundsInch) - (moment2).GetValue(MomentType.PoundsInch))) <= MomentDeviationDefaults.AcceptedEqualityDeviationDistance.GetValue(MomentType.PoundsInch);
		}
	}
}