using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.ForceUnit
{
    public sealed partial class Force : Unit<ForceType>
    {
        public Force(ForceType type, Measurement value) : base(type,value)
        {
            
        }
        public Force(Measurement value, ForceType type) : base(type, value)
        {

        }

        public Force(Unit<ForceType> unit) : base(unit)
        {
                
        }
        #region Static Properties
        public static readonly Force ZeroForce = new Force(new Pound(), new Measurement());

        public static ForceType Pounds { get { return new Pound(); } }
        public Measurement InPounds { get { return this.MeasurementIn(Pounds); } }
        #endregion
        #region Public Methods
#endregion
        #region Operator Overloads

        public static Force operator +(Force force1, Force force2)
        {
            return new Force(force1.Add(force2));
        }

        public static Force operator -(Force force1, Force force2)
        {
            return new Force(force1.Subtract(force2));
        }

        public static Force operator *(Force force, Measurement scalar)
        {
            return new Force(force._Multiply(scalar));
        }

        public static Force operator *(Measurement scalar, Force force)
        {
            return force * scalar;
        }

        public static Force operator /(Force force, Measurement divisor)
        {
            return new Force(force._Divide(divisor));
        }
        #endregion
    }
}
