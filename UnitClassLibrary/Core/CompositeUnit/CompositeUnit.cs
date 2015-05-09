using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.BaseUnit;
using UnitClassLibrary.Core.BasicUnit;

namespace UnitClassLibrary.CompositeUnit
{
    public class CompositeUnit:Unit
    {
        protected override double _IntrinsicValue
        {
            get { return this.GetValue(InternalUnitType); }
        }

        protected virtual List<Unit> Numerators { get; set; }

        protected virtual List<Unit> Denomenators { get; set; }

        protected CompositeUnit(EqualityStrategy passedStrategy = null):base(passedStrategy)
        {
        }

        protected CompositeUnit(List<Unit> numerators, List<Unit> denomenators, ICompositeUnitType unitType, EqualityStrategy passedStrategy = null)
            : this(passedStrategy)
        {
            this.Numerators = numerators;
            this.Denomenators = denomenators;
            this.InternalUnitType = unitType;
        }


        public double GetValue(ICompositeUnitType unitTypeConvertingTo)
        {
            var numeratorSum = 1.0;

            for (int i = 0; i < this.Numerators.Count; i++)
            {
                numeratorSum = numeratorSum * this.Numerators[i].GetValue(unitTypeConvertingTo.Numerators[i]);
            }

            var denomenatorSum = 1.0;

            for (int i = 0; i < this.Denomenators.Count; i++)
            {
                denomenatorSum = denomenatorSum * this.Denomenators[i].GetValue(unitTypeConvertingTo.Denomenators[i]);
            }

            return numeratorSum/denomenatorSum;
        }

        public override double GetValue(IUnitType unitTypeConvertingTo)
        {
            return this.GetValue((ICompositeUnitType) unitTypeConvertingTo);
        }
    }
}
