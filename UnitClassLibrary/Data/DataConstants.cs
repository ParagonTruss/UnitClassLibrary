using System;

 namespace UnitClassLibrary
{

	public partial class Data
	{

		public static Data Bit
		{
			get { return new Data(DataType.Bit, 1); }
		}

		public static Data Byte
		{
			get { return new Data(DataType.Byte, 1); }
		}

		public static Data Kilobyte
		{
			get { return new Data(DataType.Kilobyte, 1); }
		}

		public static Data Megabyte
		{
			get { return new Data(DataType.Megabyte, 1); }
		}

		public static Data Gigabyte
		{
			get { return new Data(DataType.Gigabyte, 1); }
		}

		public static Data Terabyte
		{
			get { return new Data(DataType.Terabyte, 1); }
		}

		public static Data Petabyte
		{
			get { return new Data(DataType.Petabyte, 1); }
		}

		public static Data Exabyte
		{
			get { return new Data(DataType.Exabyte, 1); }
		}

		public static Data Zettabyte
		{
			get { return new Data(DataType.Zettabyte, 1); }
		}

		public static Data Yottabyte
		{
			get { return new Data(DataType.Yottabyte, 1); }
		}
	}
}