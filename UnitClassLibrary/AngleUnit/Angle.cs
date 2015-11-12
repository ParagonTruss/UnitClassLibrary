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
        public Angle(IAngleUnit unit, double value, double errorMargin) : base(unit,value,errorMargin)
        {
            
        }

        public Measurement Cosine()
        {
            return new Measurement(Math.Cos(this.GetValue(new Radian())),Math.Sin(this)
        }
    }
}
