using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public struct Unit
    {
        public Unit(double value, IUnitType unitType)
        {
            Value = value;
            UnitType = unitType;
        }

        public double Value;
        public IUnitType UnitType;

    }


    public partial class GenericUnit
    {
        protected List<Unit> numerators;
        protected List<Unit> denomenators;

        protected double _IntrinsicValue
        {
            get
            {
                var numerator = 1.0;
                var denomenator = 1.0;

                foreach (var pair in numerators)
                {
                    numerator *= pair.Value;
                }

                foreach (var pair in denomenators)
                {
                    denomenator *= pair.Value;
                }

                return numerator / denomenator;
            }
        }

        public EqualityStrategy EqualityStrategy
        {
            get { return _equalityStrategy; }
            set { _equalityStrategy = value; }
        }

        protected EqualityStrategy _equalityStrategy;



        public Unit _deviationConstant { get; protected set; }


        public GenericUnit(List<Unit> numerators, List<Unit> denomenators)
        {
            this.numerators = numerators;
            this.denomenators = denomenators;
        }

        protected GenericUnit(List<GenericUnit> numerators, List<GenericUnit> denomenators = null)
        {
            foreach (var unit in numerators)
            {
                this.numerators.Add(new Unit(unit._IntrinsicValue, unit.GetInternalUnitType()));
            }

            if (denomenators != null)
            {
                foreach (var unit in denomenators)
                {
                    this.denomenators.Add(new Unit(unit._IntrinsicValue, unit.GetInternalUnitType()));
                }
            }


        }

        public GenericUnit(GenericUnit toCopy)
        {
            this.numerators = toCopy.numerators;
            this.denomenators = toCopy.denomenators;
        }

        public static double ConvertUnit(IUnitType convertFromType, double value, IUnitType convertToType)
        {
            return value * (convertFromType.GetConversionFactor() / convertToType.GetConversionFactor());
        }

        public double GetValue(IUnitType typeConvertingTo)
        {
            return ConvertUnit(this.GetInternalUnitType(), _IntrinsicValue, typeConvertingTo);
        }

        /// <summary>
        /// Creates a new GenericUnit that is the negative of this one
        /// </summary>
        public GenericUnit Negate()
        {
            var newNumerators = new List<Unit>((numerators));

            //we just negate the first numerator
            newNumerators[0] = (new Unit(newNumerators[0].Value * -1, newNumerators[0].UnitType));

            return new GenericUnit(newNumerators, denomenators);
        }

        public GenericUnit AbsoluteValue()
        {
            //while slightly unnecessary, we make everything positive. not just a single value

            var newNumerators = new List<Unit>((numerators));
            var newDenomenators = new List<Unit>((denomenators));

            for (int i = 0; i < newNumerators.Count; i++)
            {
                if (newNumerators[i].Value < 0)
                {
                    newNumerators[i] = (new Unit(newNumerators[i].Value * -1, newNumerators[i].UnitType));
                }
            }

            for (int i = 0; i < newDenomenators.Count; i++)
            {
                if (newDenomenators[i].Value < 0)
                {
                    newDenomenators[i] = (new Unit(newDenomenators[i].Value * -1, newDenomenators[i].UnitType));
                }
            }


            return new GenericUnit(newNumerators, newDenomenators);
        }
    }
}
