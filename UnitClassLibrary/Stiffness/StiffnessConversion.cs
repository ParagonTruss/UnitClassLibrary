using System;

 namespace UnitClassLibrary
{

	public partial class Stiffness
	{
		/// <summary>Converts one unit of Stiffness to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertStiffness(StiffnessType typeConvertingFrom, double passedValue, StiffnessType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case StiffnessType.NewtonsPerMillimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue; // Return passed in NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMillimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerCentimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue; // Return passed in NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerCentimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerMeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue; // Return passed in NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerKilometer:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue; // Return passed in NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerKilometer to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerThirtySecond:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue; // Return passed in NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerThirtySecond to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerSixteenth:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue; // Return passed in NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerSixteenth to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerInch:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue; // Return passed in NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerInch to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerFoot:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue; // Return passed in NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerFoot to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerYard:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue; // Return passed in NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerYard to KipsPerMile
							break;
					}
					break;
				case StiffnessType.NewtonsPerMile:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue; // Return passed in NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert NewtonsPerMile to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerMillimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue; // Return passed in PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMillimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerCentimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue; // Return passed in PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerCentimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerMeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue; // Return passed in PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerKilometer:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue; // Return passed in PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerKilometer to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerThirtySecond:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue; // Return passed in PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerThirtySecond to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerSixteenth:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue; // Return passed in PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerSixteenth to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerInch:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue; // Return passed in PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerInch to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerFoot:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue; // Return passed in PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerFoot to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerYard:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue; // Return passed in PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerYard to KipsPerMile
							break;
					}
					break;
				case StiffnessType.PoundsPerMile:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue; // Return passed in PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert PoundsPerMile to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerMillimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue; // Return passed in KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMillimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerCentimeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue; // Return passed in KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerCentimeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerMeter:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue; // Return passed in KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMeter to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerKilometer:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue; // Return passed in KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerKilometer to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerThirtySecond:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue; // Return passed in KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerThirtySecond to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerSixteenth:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue; // Return passed in KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerSixteenth to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerInch:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerInch to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerInch to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue; // Return passed in KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerInch to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerFoot:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue; // Return passed in KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerFoot to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerYard:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerYard to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerYard to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue; // Return passed in KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerYard to KipsPerMile
							break;
					}
					break;
				case StiffnessType.KipsPerMile:
					switch (typeConvertingTo)
					{
						case StiffnessType.NewtonsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerMillimeter
							break;
						case StiffnessType.NewtonsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerCentimeter
							break;
						case StiffnessType.NewtonsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerMeter
							break;
						case StiffnessType.NewtonsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerKilometer
							break;
						case StiffnessType.NewtonsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerThirtySecond
							break;
						case StiffnessType.NewtonsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerSixteenth
							break;
						case StiffnessType.NewtonsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerInch
							break;
						case StiffnessType.NewtonsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerFoot
							break;
						case StiffnessType.NewtonsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerYard
							break;
						case StiffnessType.NewtonsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMile to NewtonsPerMile
							break;
						case StiffnessType.PoundsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerMillimeter
							break;
						case StiffnessType.PoundsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerCentimeter
							break;
						case StiffnessType.PoundsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerMeter
							break;
						case StiffnessType.PoundsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerKilometer
							break;
						case StiffnessType.PoundsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerThirtySecond
							break;
						case StiffnessType.PoundsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerSixteenth
							break;
						case StiffnessType.PoundsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerInch
							break;
						case StiffnessType.PoundsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerFoot
							break;
						case StiffnessType.PoundsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerYard
							break;
						case StiffnessType.PoundsPerMile:
							returnDouble = passedValue * 1; // Convert KipsPerMile to PoundsPerMile
							break;
						case StiffnessType.KipsPerMillimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerMillimeter
							break;
						case StiffnessType.KipsPerCentimeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerCentimeter
							break;
						case StiffnessType.KipsPerMeter:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerMeter
							break;
						case StiffnessType.KipsPerKilometer:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerKilometer
							break;
						case StiffnessType.KipsPerThirtySecond:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerThirtySecond
							break;
						case StiffnessType.KipsPerSixteenth:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerSixteenth
							break;
						case StiffnessType.KipsPerInch:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerInch
							break;
						case StiffnessType.KipsPerFoot:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerFoot
							break;
						case StiffnessType.KipsPerYard:
							returnDouble = passedValue * 1; // Convert KipsPerMile to KipsPerYard
							break;
						case StiffnessType.KipsPerMile:
							returnDouble = passedValue; // Return passed in KipsPerMile
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}