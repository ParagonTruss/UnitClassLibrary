using System;

 namespace UnitClassLibrary
{

	public partial class Data : IComparable, IComparable<Data >
	{
		/// <summary> This implements the IComparable (Data) interface and allows Datas to be sorted and such </summary>
		public int CompareTo(Data other)
		{
			if (this.Equals(other))
			{
				return 0;
			}
			else
			{
				return _intrinsicValue.CompareTo(other.GetValue(_internalUnitType));
			}
		}

		/// <summary> This implements the IComparable (Data) interface and allows Datas to be sorted and such </summary>
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}

			if (!( obj is Data))
			{
				throw new ArgumentException("Expected type Data.", "obj");
			}

			return this.CompareTo((Data)obj);
		}
	}
}