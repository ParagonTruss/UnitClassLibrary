using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.DerivedUnits
{
    public class Moment : Unit<MomentType>
    {

        public Moment(Measurement m, MomentType type) : base(type, m)
        {
                
        }

        public Moment(Unit<MomentType> moment) : base(moment)
        {
        }

        public Moment(MomentType unit, Measurement measurement) : base(unit, measurement)
        {
        }

        public static Moment ZeroMoment { get { return new Moment(Exactly(0, new PoundInch())); } }

        // naming is a little off. should be InchPounds.
        public Measurement InPoundInches { get {return MeasurementIn(new PoundInch());} }
        public static MomentType PoundInches { get { return new PoundInch(); } }

        public Measurement InFootPounds { get { return MeasurementIn(new FootPound()); } }
        public static MomentType FootPounds { get { return new FootPound(); } }

        #region Operator Overloads

        public static Moment operator +(Moment moment1, Moment moment2)
        {
            return new Moment(moment1.Add(moment2));
        }

        public static Moment operator -(Moment moment1, Moment moment2)
        {
            return new Moment(moment1.Subtract(moment2));
        }

        public static Moment operator *(Moment moment, Measurement scalar)
        {
            return new Moment(moment._Multiply(scalar));
        }

        public static Moment operator *(Measurement scalar, Moment moment)
        {
            return moment * scalar;
        }

        public static Moment operator /(Moment moment, Measurement divisor)
        {
            return new Moment(moment._Divide(divisor));
        }
        #endregion
    }
}
