using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.DerivedUnits.ForcePerDistanceUnit
{
    public class DistributedForce : Unit<ForcePerDistanceType>
    {
        public Measurement InPoundsPerInch { get { return ValueIn(new PoundPerInch()); } }

        public DistributedForce(Unit<ForcePerDistanceType> unit)
            : base(unit) { }

        public static DistributedForce Zero { get { return new DistributedForce(Exactly(0, new PoundPerInch())); } }
        #region Arithmetic Operators

        public static DistributedForce operator +(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Add(DistributedForce2));
        }

        public static DistributedForce operator -(DistributedForce DistributedForce1, DistributedForce DistributedForce2)
        {
            return new DistributedForce(DistributedForce1.Subtract(DistributedForce2));
        }

        public static DistributedForce operator *(DistributedForce DistributedForce, Measurement scalar)
        {
            return new DistributedForce(DistributedForce._Multiply(scalar));
        }

        public static DistributedForce operator *(Measurement scalar, DistributedForce DistributedForce)
        {
            return DistributedForce * scalar;
        }

        public static DistributedForce operator /(DistributedForce DistributedForce, Measurement divisor)
        {
            return new DistributedForce(DistributedForce._Divide(divisor));
        }
        #endregion
    }
}
