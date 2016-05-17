using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.DerivedUnits.Stress
{
    public class Stress : Unit<StressType>
    {
        public static Stress ZeroStress
        {
            get { return new Stress(Exactly(0, PSI)); }
        }

        #region Constructors
        public Stress(double value, StressType type) : base(type, value)
        {

        }
        public Stress(StressType type, double value) :  base(type, value)
        {
                
        }

        public Stress(Unit<StressType> stress) : base(stress)
        {
        }

        public Stress(StressType unit, Measurement measurement) : base(unit, measurement)
        {
        }
        #endregion

        public Measurement InPSI { get {return MeasurementIn(new PoundPerSquareInch());} }

        public static PoundPerSquareInch PSI { get { return new PoundPerSquareInch(); } }

        #region Operator Overloads

        public static Stress operator +(Stress stress1, Stress stress2)
        {
            return new Stress(stress1.Add(stress2));
        }

        public static Stress operator -(Stress stress1, Stress stress2)
        {
            return new Stress(stress1.Subtract(stress2));
        }

        public static Stress operator *(Stress stress, Measurement scalar)
        {
            return new Stress(stress._Multiply(scalar));
        }

        public static Stress operator *(Measurement scalar, Stress stress)
        {
            return stress * scalar;
        }

        public static Stress operator /(Stress stress, Measurement divisor)
        {
            return new Stress(stress._Divide(divisor));
        }
        #endregion
    }
}
