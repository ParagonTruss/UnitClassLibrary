using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{

    public partial class GenericUnit
    {
        protected List<KeyValuePair<double, IUnitType>> numerators;
        protected List<KeyValuePair<double, IUnitType>> denomenators;

        protected double _IntrinsicValue
        {
            get
            {
                var numerator = 1.0;
                var denomenator = 1.0;

                foreach (var pair in numerators)
                {
                    numerator *= pair.Key;
                }

                foreach (var pair in denomenators)
                {
                    denomenator *= pair.Key;
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



        public GenericUnit DeviationConstant { get; protected set; }


        public GenericUnit(List<KeyValuePair<double, IUnitType>> numerators, List<KeyValuePair<double, IUnitType>> denomenators)
        {
            this.numerators = numerators;
            this.denomenators = denomenators;
        }

        protected GenericUnit(List<GenericUnit> numerators, List<GenericUnit> denomenators = null)
        {
            foreach (var unit in numerators)
            {
                this.numerators.Add(new KeyValuePair<double, IUnitType>(unit._IntrinsicValue, unit.GetInternalUnitType()));    
            }

            if (denomenators != null)
            {
                foreach (var unit in denomenators)
                {
                    this.denomenators.Add(new KeyValuePair<double, IUnitType>(unit._IntrinsicValue, unit.GetInternalUnitType()));
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
            return ConvertUnit(this.GetInternalUnitType(), _IntrinsicValue, typeConvertingTo) ;
        }

        /// <summary>
        /// Creates a new GenericUnit that is the negative of this one
        /// </summary>
        public GenericUnit Negate()
        {
            var newNumerators = new List<KeyValuePair<double, IUnitType>>((numerators));

            //we just negate the first numerator
            newNumerators[0] = (new KeyValuePair<double, IUnitType>(newNumerators[0].Key * -1, newNumerators[0].Value));

            return new GenericUnit(newNumerators, denomenators);
        }

        public GenericUnit AbsoluteValue()
        {
            //while slightly unnecessary, we make everything positive. not just a single value

            var newNumerators = new List<KeyValuePair<double, IUnitType>>((numerators));
            var newDenomenators = new List<KeyValuePair<double, IUnitType>>((denomenators));

            for (int i = 0; i < newNumerators.Count; i++)
            {
                if (newNumerators[i].Key < 0)
                {
                    newNumerators[i] = (new KeyValuePair<double, IUnitType>(newNumerators[i].Key * -1, newNumerators[i].Value));
                }
            }

            for (int i = 0; i < newDenomenators.Count; i++)
            {
                if (newDenomenators[i].Key < 0)
                {
                    newDenomenators[i] = (new KeyValuePair<double, IUnitType>(newDenomenators[i].Key * -1, newDenomenators[i].Value));
                }
            }


            return new GenericUnit(newNumerators, newDenomenators);
        }
    }
}
