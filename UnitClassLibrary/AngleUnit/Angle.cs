using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.GenericUnit;

namespace UnitClassLibrary.AngleUnit
{
    public class Angle : BasicUnit<IAngleUnit>
    {
        public static readonly Angle Zero = new Angle(new Degree(), 0, 0);
        public Angle(IAngleUnit unit, double value, double errorMargin) : base(unit,value,errorMargin)
        {
            
        }

        public Measurement Cosine()
        {
            var m = this.InThisUnit(new Radian());

            return new Measurement(Math.Cos(m.Value), Math.Sin(m.Value) * m.ErrorMargin);
        }

        public Measurement Sine()
        {
            var m = this.InThisUnit(new Radian());

            return new Measurement(Math.Sin(m.Value), Math.Cos(m.Value) * m.ErrorMargin);
        }
    }
}
