using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    [DebuggerDisplay("PoundsPerSquareInch = {PoundsPerSquareInch}")]
    public class Stress :IComparable<Stress>
    {
        #region private fields and constants

        private ForceUnit _force;
        private Area _area;

        #endregion

        #region Constructors

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Stress()
        {
            _area = new Area();
            _force = new ForceUnit();
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        /// <param name="passedArea"></param>
        /// <param name="passedForce"></param>
        public Stress(ForceUnit passedForce, Area passedArea)
        {
            _area = passedArea;
            _force = passedForce;
        }

        /// <summary>
        /// Create a stress object from a composite unit; the value is arbitrarily distributed among the component units.
        /// </summary>
        /// <param name="passedStressType"></param>
        /// <param name="passedValue"></param>
        public Stress(StressType passedStressType, double passedValue)
        {
            switch (passedStressType)
            {
                case StressType.PoundsPerSquareInch:
                    _area = new Area(AreaType.InchesSquared, passedValue);
                    _force = new ForceUnit(ForceType.Pounds, 1);
                    break;
                case StressType.PoundsPerSquareMillimeter:
                    _area = new Area(AreaType.MillimetersSquared, passedValue);
                    _force = new ForceUnit(ForceType.Pounds, 1);
                    break;
                case StressType.NewtonsPerSquareMeter:
                    _area = new Area(AreaType.MetersSquared, passedValue);
                    _force = new ForceUnit(ForceType.Newtons, 1);
                    break;
                case StressType.NewtonsPerSquareMillimeter:
                    _area = new Area(AreaType.MillimetersSquared, passedValue);
                    _force = new ForceUnit(ForceType.Newtons, 1);
                    break;
                default:
                    // Should never reach; cases should cover all members of enumerated set
                    throw new NotSupportedException("Unit not supported!");
            }
        }

        #endregion

        #region Properties

        public double PoundsPerSquareInch
        {
            get { return _force.Pounds / _area.InchesSquared; }
        }

        public double PoundsPerSquareMillimeter
        {
            get { return _force.Pounds / _area.MillimetersSquared; }
        }

        public double NewtonsPerSquareMeter
        {
            get { return _force.Newtons / _area.MetersSquared; }
        }

        public double NewtonsPerSquareMillimeter
        {
            get { return _force.Newtons / _area.MillimetersSquared; }

        }

        public double GetValue(StressType Units)
        {
            switch (Units)
            {
                case StressType.PoundsPerSquareInch:
                    return PoundsPerSquareInch;
                case StressType.PoundsPerSquareMillimeter:
                    return PoundsPerSquareMillimeter;
                case StressType.NewtonsPerSquareMeter:
                    return NewtonsPerSquareMeter;
                case StressType.NewtonsPerSquareMillimeter:
                    return NewtonsPerSquareMillimeter;
            }
            throw new Exception("Unknown StressType");
        }

        #endregion

        #region Overloaded Operators

        /* You may notice that we do not overload the increment and decrement operators nor do we overload multiplication and division.
         * This is because the user of this library does not know what is being internally stored and those operations will not return useful information. 
         */

        public static Stress operator +(Stress s1, Stress s2)
        {
            //add the two Stresses together
            //return a new Stress with the new value
            //return new Stress( s1._area + s2._area, s1._force + s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        public static Stress operator -(Stress s1, Stress s2)
        {
            //subtract the two Stresss
            //return a new Stress with the new value
            //return new Stress(s1._area - s2._area, s1._force - s2._force);
            throw new NotImplementedException("Consult engineer: might not be allowed");
        }

        /// <summary>
        /// Not a perfect equality operator, is only accurate up to the Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator ==(Stress s1, Stress s2)
        {
            if ((object)s1 == null)
            {
                if ((object)s2 == null)
                {
                    return true;
                }
                return false;
            }
            return s1.Equals(s2);
        }

        /// <summary>
        /// Not a perfect inequality operator, is only accurate up to Constants.AcceptedEqualityDeviationConstant 
        /// </summary>
        public static bool operator !=(Stress s1, Stress s2)
        {
            if ((object)s1 == null)
            {
                if ((object)s2 == null)
                {
                    return false;
                }
                return true;
            }
            return !s1.Equals(s2);
        }

        public static bool operator >(Stress s1, Stress s2)
        {
            return (s1.PoundsPerSquareMillimeter > s2.PoundsPerSquareMillimeter);
        }

        public static bool operator <(Stress s1, Stress s2)
        {
            return (s1.PoundsPerSquareMillimeter < s2.PoundsPerSquareMillimeter);
        }

        public static bool operator >=(Stress s1, Stress s2)
        {
            return s1.Equals(s2) || s1.PoundsPerSquareMillimeter > s2.PoundsPerSquareMillimeter;
        }

        public static bool operator <=(Stress s1, Stress s2)
        {
            return s1.Equals(s2) || s1.PoundsPerSquareMillimeter < s2.PoundsPerSquareMillimeter;
        }

        /// <summary>
        /// This override determines how this object is inserted into hashtables.
        /// </summary>
        /// <returns>same hashcode as any double would</returns>
        public override int GetHashCode()
        {
            return PoundsPerSquareMillimeter.GetHashCode();
        }

        /// <summary>
        /// Makes sure to throw an error telling the user that this is a bad idea
        /// The Stress class does not know what type of unit it contains, 
        /// (Because it should be thought of containing all unit types) 
        /// Call Stress.[unit].Tostring() instead
        /// </summary>
        /// <returns>Should never return anything</returns>
        public override string ToString()
        {
            throw new NotImplementedException("The Stress class does not know what type of unit it contains, (Because it should be thought of containing all unit types) Call Stress.[unit].ToString() instead");
        }

        /// <summary>
        /// does the same thing as == if the passed in object is a Stress
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                Stress newStress = (Stress)obj;

                return Math.Abs(this._force.GetValue(this._force.InternalUnitType) / this._area.GetValue(this._area.InternalUnitType) - ((Stress)(obj))._force.GetValue(this._force.InternalUnitType) / ((Stress)(obj))._area.GetValue(this._area.InternalUnitType)) <= // This stress and the passed stress (in units of this stress)...
                Math.Abs(this._force.GetValue(this._force.InternalUnitType) / this._area.GetValue(this._area.InternalUnitType) * .0001); // Is less than the accepted deviation stress constant (0.01%) in units of this stress
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// This implements the IComparable interface and allows Stresss to be sorted and such
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Stress other)
        {
            // The comparison depends on the comparison of  
            // the underlying Double values
            if (this.Equals(other))
                return 0;
            else
                return PoundsPerSquareMillimeter.CompareTo(other.PoundsPerSquareMillimeter);
        }
    }
}
