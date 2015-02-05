using System;

 namespace UnitClassLibrary
{

	public partial class Data
	{

		///<summary>Generator method that constructs Data with assumption that the passed value is in Bits</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithBits(double passedValue)
		{
			return new Data(DataType.Bit, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Bytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithBytes(double passedValue)
		{
			return new Data(DataType.Byte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Kilobytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithKilobytes(double passedValue)
		{
			return new Data(DataType.Kilobyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Megabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithMegabytes(double passedValue)
		{
			return new Data(DataType.Megabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Gigabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithGigabytes(double passedValue)
		{
			return new Data(DataType.Gigabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Terabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithTerabytes(double passedValue)
		{
			return new Data(DataType.Terabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Petabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithPetabytes(double passedValue)
		{
			return new Data(DataType.Petabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Exabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithExabytes(double passedValue)
		{
			return new Data(DataType.Exabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Zettabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithZettabytes(double passedValue)
		{
			return new Data(DataType.Zettabyte, passedValue);
		}

		///<summary>Generator method that constructs Data with assumption that the passed value is in Yottabytes</summary>
		///<param name="passedValue"></param>
		///<returns></returns>
		public static Data MakeDataWithYottabytes(double passedValue)
		{
			return new Data(DataType.Yottabyte, passedValue);
		}
	}
}