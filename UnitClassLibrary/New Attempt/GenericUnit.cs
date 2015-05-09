using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.New_Attempt
{
    public interface IUnitType
    {
        double GetConversionFactor();
    }

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

        public GenericUnit DeviationConstant { get; set; }


        public GenericUnit(List<KeyValuePair<double, IUnitType>> numerators, List<KeyValuePair<double, IUnitType>> denomenators)
        {
            this.numerators = numerators;
            this.denomenators = denomenators;
        }

        public GenericUnit(GenericUnit toCopy)
        {
            this.numerators = toCopy.numerators;
            this.denomenators = toCopy.denomenators;
        }



        public double GetValue(IUnitType typeConvertingTo)
        {
            return _IntrinsicValue * (_getCompositeConversionFactor() / typeConvertingTo.GetConversionFactor());
        }


        private double _getCompositeConversionFactor()
        {
            var numeratorFactor = 1.0;
            var denomenatorFactor = 1.0;

            foreach (var pair in numerators)
            {
                numeratorFactor *= pair.Value.GetConversionFactor();
            }

            foreach (var pair in denomenators)
            {
                denomenatorFactor *= pair.Value.GetConversionFactor();
            }

            return numeratorFactor / denomenatorFactor;

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

        /// <summary>
        /// Creates a new GenericUnit that is the negative of this one
        /// </summary>
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
