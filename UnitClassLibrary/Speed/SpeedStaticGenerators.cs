using System;

 namespace UnitClassLibrary
{

	public partial class Speed
	{

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerHours(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerDays(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerMonths(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerYears(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerDecades(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MillimetersPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMillimetersPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.MillimetersPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerHours(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerDays(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerMonths(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerYears(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerDecades(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in CentimetersPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithCentimetersPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.CentimetersPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.MetersPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.MetersPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.MetersPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.MetersPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.MetersPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerHours(double passedValue)
		{
			return new Speed(SpeedType.MetersPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerDays(double passedValue)
		{
			return new Speed(SpeedType.MetersPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.MetersPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerMonths(double passedValue)
		{
			return new Speed(SpeedType.MetersPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerYears(double passedValue)
		{
			return new Speed(SpeedType.MetersPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerDecades(double passedValue)
		{
			return new Speed(SpeedType.MetersPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MetersPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMetersPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.MetersPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerHours(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerDays(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerMonths(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerYears(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerDecades(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in KilometersPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithKilometersPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.KilometersPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.InchesPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.InchesPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.InchesPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.InchesPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.InchesPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerHours(double passedValue)
		{
			return new Speed(SpeedType.InchesPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerDays(double passedValue)
		{
			return new Speed(SpeedType.InchesPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.InchesPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerMonths(double passedValue)
		{
			return new Speed(SpeedType.InchesPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerYears(double passedValue)
		{
			return new Speed(SpeedType.InchesPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerDecades(double passedValue)
		{
			return new Speed(SpeedType.InchesPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in InchesPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithInchesPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.InchesPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.FeetPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.FeetPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.FeetPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.FeetPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.FeetPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerHours(double passedValue)
		{
			return new Speed(SpeedType.FeetPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerDays(double passedValue)
		{
			return new Speed(SpeedType.FeetPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.FeetPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerMonths(double passedValue)
		{
			return new Speed(SpeedType.FeetPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerYears(double passedValue)
		{
			return new Speed(SpeedType.FeetPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerDecades(double passedValue)
		{
			return new Speed(SpeedType.FeetPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in FeetPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithFeetPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.FeetPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.YardsPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.YardsPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.YardsPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.YardsPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.YardsPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerHours(double passedValue)
		{
			return new Speed(SpeedType.YardsPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerDays(double passedValue)
		{
			return new Speed(SpeedType.YardsPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.YardsPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerMonths(double passedValue)
		{
			return new Speed(SpeedType.YardsPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerYears(double passedValue)
		{
			return new Speed(SpeedType.YardsPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerDecades(double passedValue)
		{
			return new Speed(SpeedType.YardsPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in YardsPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithYardsPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.YardsPerCentury, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerNanoseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerNanoseconds(double passedValue)
		{
			return new Speed(SpeedType.MilesPerNanosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerMicroseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerMicroseconds(double passedValue)
		{
			return new Speed(SpeedType.MilesPerMicrosecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerMilliseconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerMilliseconds(double passedValue)
		{
			return new Speed(SpeedType.MilesPerMillisecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerSeconds</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerSeconds(double passedValue)
		{
			return new Speed(SpeedType.MilesPerSecond, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerMinutes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerMinutes(double passedValue)
		{
			return new Speed(SpeedType.MilesPerMinute, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerHours</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerHours(double passedValue)
		{
			return new Speed(SpeedType.MilesPerHour, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerDays</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerDays(double passedValue)
		{
			return new Speed(SpeedType.MilesPerDay, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerWeeks</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerWeeks(double passedValue)
		{
			return new Speed(SpeedType.MilesPerWeek, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerMonths</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerMonths(double passedValue)
		{
			return new Speed(SpeedType.MilesPerMonth, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerYears</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerYears(double passedValue)
		{
			return new Speed(SpeedType.MilesPerYear, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerDecades</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerDecades(double passedValue)
		{
			return new Speed(SpeedType.MilesPerDecade, passedValue);
		}

		///<summary>Generator method that constructs Speed with assumption that the passed value is in MilesPerCenturies</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Speed MakeSpeedWithMilesPerCenturies(double passedValue)
		{
			return new Speed(SpeedType.MilesPerCentury, passedValue);
		}
	}
}