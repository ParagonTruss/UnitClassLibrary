using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AngleUnit
{
    public class Angle : Unit<AngleType>
    {
        public static readonly Angle Zero = new Angle(new Degree(), new Measurement());
        public Angle(AngleType unit, Measurement measurement) : base(unit, measurement)
        {
            
        }

        public Measurement Sine()
        {
            var m = this.ValueInThisUnit(new Radian());

            return new Measurement(Math.Sin(m.Value), Math.Cos(m.Value) * m.ErrorMargin);
        }

        public Measurement Cosine()
        {
            var m = this.ValueInThisUnit(new Radian());

            return new Measurement(Math.Cos(m.Value), Math.Sin(m.Value) * m.ErrorMargin);
        }

        public Measurement Tangent()
        {
            var m = this.ValueInThisUnit(new Radian());

            return new Measurement(Math.Tan(m.Value), m.ErrorMargin / Math.Pow(Math.Cos(m.Value), 2));
        }

        public static Angle ArcCos(Measurement m)
        {
            throw new NotImplementedException();
        }

        public static Angle ArcSin(Measurement m)
        {
            throw new NotImplementedException();
        }
    }
}
