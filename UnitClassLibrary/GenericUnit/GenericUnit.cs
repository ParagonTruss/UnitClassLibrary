using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public struct Unit
    {
        public Unit(GenericUnit<IUnitType> genericUnit)
        {
            Value = genericUnit.GetValue(genericUnit.GetInternalUnitType());
            UnitType = genericUnit.GetInternalUnitType();
        }

        public Unit(double value, IUnitType unitType)
        {
            Value = value;
            UnitType = unitType;
        }

        public double Value ;
        public IUnitType UnitType;

    }


    public partial class GenericUnit<T> where T: IUnitType 
    {
        protected List<Unit> numerators = new List<Unit>();
        protected List<Unit> denomenators = new List<Unit>();

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

        protected EqualityStrategy<T> _equalityStrategy;

        public Unit DeviationConstant
        {
            get
            {
                if (_deviationConstant.Value == 0.0 && _deviationConstant.UnitType == null)
                {
                    return new Unit(1, GetInternalUnitType());
                }
                else
                {
                    return _deviationConstant;
                }
            }
        }

        protected Unit _deviationConstant;


        public GenericUnit(List<GenericUnit<T>> numerators, List<GenericUnit<T>> denomenators)
        {
            //make list of genericUnits into basic units
            var newNumerators = new List<Unit>();

            foreach (var genericUnit in numerators)
            {
                newNumerators.Add(new Unit(genericUnit._IntrinsicValue, genericUnit.GetInternalUnitType()));
            }

            //make list of genericUnits into basic units
            var newDenomenators = new List<Unit>();

            foreach (var genericUnit in denomenators)
            {
                newDenomenators.Add(new Unit(genericUnit._IntrinsicValue, genericUnit.GetInternalUnitType()));
            }

            this.numerators =  newNumerators;
            this.denomenators = newDenomenators;
        }

        protected GenericUnit(List<Unit> numerators, List<Unit> denomenators = null)
        {
            foreach (var unit in numerators)
            {
                this.numerators.Add(new Unit(unit.Value, unit.UnitType));
            }

            if (denomenators != null)
            {
                foreach (var unit in denomenators)
                {
                    this.denomenators.Add(new Unit(unit.Value, unit.UnitType));
                }
            }


        }

        public GenericUnit(GenericUnit<T> toCopy)
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
        /// Creates a new GenericUnit<T> that is the negative of this one
        /// </summary>
        public GenericUnit<T> Negate()
        {
            var newNumerators = new List<Unit>((numerators));

            //we just negate the first numerator
            newNumerators[0] = (new Unit(newNumerators[0].Value * -1, newNumerators[0].UnitType));

            return new GenericUnit<T>(newNumerators, denomenators);
        }

        public GenericUnit<T> AbsoluteValue()
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


            return new GenericUnit<T>(newNumerators, newDenomenators);
        }
    }
}
