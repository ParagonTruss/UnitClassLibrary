using System;

namespace UnitClassLibrary
{

	public partial class Data
	{
		/// <summary>Converts one unit of Data to another</summary>
		/// <param name="typeConvertingTo">input unit type</param>
		/// <param name="passedValue"></param>
		/// <param name="typeConvertingFrom">desired output unit type</param>
		/// <returns>passedValue in desired units</returns>
		public static double ConvertData(DataType typeConvertingFrom, double passedValue, DataType typeConvertingTo)
		{
			double returnDouble = 0.0;

			switch (typeConvertingFrom)
			{
				case DataType.Bit:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue; // Return passed in Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue / (1/8); // Convert Bit to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * (1/8) / 1024; // Convert Bit to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 2); // Convert Bit to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 3); // Convert Bit to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 4); // Convert Bit to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 5); // Convert Bit to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 6); // Convert Bit to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 7);; // Convert Bit to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1/8) / Math.Pow(1024, 8);; // Convert Bit to Yottabyte
							break;
					}
					break;
				case DataType.Byte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * (8); // Convert Byte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue; // Return passed in Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * 1024; // Convert Byte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 2); // Convert Byte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 3); // Convert Byte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 4); // Convert Byte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 5); // Convert Byte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 6); // Convert Byte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 7); // Convert Byte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 8); // Convert Byte to Yottabyte
							break;
					}
					break;
				case DataType.Kilobyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * (8) * 1024; // Convert Kilobyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * (1024); // Convert Kilobyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue; // Return passed in Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * (1/1024); // Convert Kilobyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 2); // Convert Kilobyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 3); // Convert Kilobyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024,4); // Convert Kilobyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 5); // Convert Kilobyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1) / Math.Pow(1024, 6); // Convert Kilobyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 7); // Convert Kilobyte to Yottabyte
							break;
					}
					break;
				case DataType.Megabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * 8*(Math.Pow(1024, 2)); // Convert Megabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * (Math.Pow(1024, 2)); // Convert Megabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * (1024); // Convert Megabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue; // Return passed in Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 1); // Convert Megabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 2); // Convert Megabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 3); // Convert Megabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 4); // Convert Megabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 5); // Convert Megabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 6); // Convert Megabyte to Yottabyte
							break;
					}
					break;
				case DataType.Gigabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 4) * 8; // Convert Gigabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Gigabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Gigabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Gigabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue; // Return passed in Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 1); // Convert Gigabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 2); // Convert Gigabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 3); // Convert Gigabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 4); // Convert Gigabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 5); // Convert Gigabyte to Yottabyte
							break;
					}
					break;
				case DataType.Terabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 4) * 8 ; // Convert Terabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 4); // Convert Terabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Terabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Terabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Terabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue; // Return passed in Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 1); // Convert Terabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 2); // Convert Terabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 3); // Convert Terabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue * (1) /  Math.Pow(1024, 4); // Convert Terabyte to Yottabyte
							break;
					}
					break;
				case DataType.Petabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 5) * 8; // Convert Petabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 5); // Convert Petabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 4); // Convert Petabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Petabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Petabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Petabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue; // Return passed in Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 1); // Convert Petabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 2); // Convert Petabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 3); // Convert Petabyte to Yottabyte
							break;
					}
					break;
				case DataType.Exabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 6) * 8; // Convert Exabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 6); // Convert Exabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 5); // Convert Exabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 4); // Convert Exabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Exabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Exabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Exabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue; // Return passed in Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 1); // Convert Exabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 2); // Convert Exabyte to Yottabyte
							break;
					}
					break;
				case DataType.Zettabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 7) * 8; // Convert Zettabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 7); // Convert Zettabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 6); // Convert Zettabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 5); // Convert Zettabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * Math.Pow(1024, 4); // Convert Zettabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Zettabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Zettabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Zettabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue; // Return passed in Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue *  (1) /  Math.Pow(1024, 1); // Convert Zettabyte to Yottabyte
							break;
					}
					break;
				case DataType.Yottabyte:
					switch (typeConvertingTo)
					{
						case DataType.Bit:
							returnDouble = passedValue * Math.Pow(1024, 8) * 8; // Convert Yottabyte to Bit
							break;
						case DataType.Byte:
							returnDouble = passedValue * Math.Pow(1024, 8); // Convert Yottabyte to Byte
							break;
						case DataType.Kilobyte:
							returnDouble = passedValue * Math.Pow(1024, 7); // Convert Yottabyte to Kilobyte
							break;
						case DataType.Megabyte:
							returnDouble = passedValue * Math.Pow(1024, 6); // Convert Yottabyte to Megabyte
							break;
						case DataType.Gigabyte:
							returnDouble = passedValue * Math.Pow(1024, 5); // Convert Yottabyte to Gigabyte
							break;
						case DataType.Terabyte:
							returnDouble = passedValue * Math.Pow(1024, 4); // Convert Yottabyte to Terabyte
							break;
						case DataType.Petabyte:
							returnDouble = passedValue * Math.Pow(1024, 3); // Convert Yottabyte to Petabyte
							break;
						case DataType.Exabyte:
							returnDouble = passedValue * Math.Pow(1024, 2); // Convert Yottabyte to Exabyte
							break;
						case DataType.Zettabyte:
							returnDouble = passedValue * Math.Pow(1024, 1); // Convert Yottabyte to Zettabyte
							break;
						case DataType.Yottabyte:
							returnDouble = passedValue; // Return passed in Yottabyte
							break;
					}
					break;
			}
			return returnDouble;
		}
	}
}