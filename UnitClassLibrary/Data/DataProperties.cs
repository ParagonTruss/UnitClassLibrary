using System;

 namespace UnitClassLibrary
{

	public partial class Data
	{
		public double Bits
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Bit); }
		}
		public double Bytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Byte); }
		}
		public double Kilobytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Kilobyte); }
		}
		public double Megabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Megabyte); }
		}
		public double Gigabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Gigabyte); }
		}
		public double Terabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Terabyte); }
		}
		public double Petabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Petabyte); }
		}
		public double Exabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Exabyte); }
		}
		public double Zettabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Zettabyte); }
		}
		public double Yottabytes
		{
			get { return _retrieveIntrinsicValueAsDesiredExternalUnit(DataType.Yottabyte); }
		}

		public double GetValue(DataType Units)
		{
			switch (Units)
			{
				case DataType.Bit:
					return Bits;
				case DataType.Byte:
					return Bytes;
				case DataType.Kilobyte:
					return Kilobytes;
				case DataType.Megabyte:
					return Megabytes;
				case DataType.Gigabyte:
					return Gigabytes;
				case DataType.Terabyte:
					return Terabytes;
				case DataType.Petabyte:
					return Petabytes;
				case DataType.Exabyte:
					return Exabytes;
				case DataType.Zettabyte:
					return Zettabytes;
				case DataType.Yottabyte:
					return Yottabytes;
			}
			throw new Exception("Unknown DataType");
		}
	}
}