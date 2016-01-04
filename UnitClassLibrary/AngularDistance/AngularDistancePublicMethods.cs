using System;

namespace UnitClassLibrary
{

	public partial class AngularDistance
	{

	    /// <summary>prints the value and unit type converted to</summary>
	    /// <param name="AngleType"></param>
	    public string ToString(AngleType AngleType)
	    {
		    return this.GetValue(AngleType) + " " + AngleType;
	    }

	    /// <summary>Creates a new object that is the negative of this</summary><returns>new object with value equivalent to result</returns>
	    public AngularDistance Negate()
	    {
		    return new AngularDistance(_internalUnitType, _intrinsicValue * -1);
	    }

	    /// <summary>Creates a new object that is the absolute value of this</summary><returns>new object with value equivalent to result</returns>
	    public AngularDistance AbsoluteValue()
	    {
		    return new AngularDistance(_internalUnitType, Math.Abs(_intrinsicValue));
	    }

	    /// <summary> multiplies itself a given number of times</summary><returns>new object with value equivalent to result</returns>
	    public AngularDistance RaiseToPower(double power)
	    {
		    return this ^ power;
	    }

        public double Sine()
        {
            return Math.Sin(this.Radians);
        }

        public double Cosine()
        {
            return Math.Cos(this.Radians);
        }
	}
}