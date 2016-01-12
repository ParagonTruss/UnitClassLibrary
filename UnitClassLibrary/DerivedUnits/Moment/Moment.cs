using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.DerivedUnits
{
    public class Moment : Unit<MomentType>
    {
        private readonly Unit<MomentType> _moment;

        public Moment(Measurement m, MomentType type) : base(type, m)
        {
                
        }

        public Moment(Unit<MomentType> moment) : base(moment)
        {
            _moment = moment;
        }

        public Moment(MomentType unit, Measurement measurement) : base(unit, measurement)
        {
        }

        public Measurement InPoundInches { get {return MeasurementIn(new PoundInch());} }
        public static Moment ZeroMoment { get { return (Moment)Exactly(0, new PoundInch()); } }

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
