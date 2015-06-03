using System;
using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{

    public class BasicUnit
    {
        public BasicUnit(double value, double conversionFactor)
        {
            IntrinsicValue = value;
            ConversionFactor = conversionFactor;
        }

        public double IntrinsicValue;
        public double ConversionFactor;

    }

    

    public partial class GenericUnit<T> where T: IUnitType
    {

        #region _fields and Properties

        private List<BasicUnit> _numerators = new List<BasicUnit>();
        private List<BasicUnit> _denomenators = new List<BasicUnit>();

        private EqualityStrategy<T> _EqualityStrategy = EqualityStrategies.EqualsWithinDeviationPercentageStrategy;

        protected double _DeviationPercentage;
        protected GenericUnit<T> _DeviationConstant;

        public GenericUnit<T> DeviationAsConstant
        {
            get { return _DeviationConstant; }
            protected set
            {
                this._DeviationConstant = value;
            }
        }

        public double DeviationAsPercentage
        {
            get
            {
                if (_DeviationPercentage == 0.0)
                {
                    return 1.0;
                }
                else
                {
                    return _DeviationPercentage;
                }
            }
            protected set { _DeviationPercentage = value; }
        }

        protected internal double _IntrinsicValue
        {
            get
            {
                var numerator = 1.0;
                var denomenator = 1.0;

                foreach (var pair in _numerators)
                {
                    numerator *= pair.IntrinsicValue;
                }

                foreach (var pair in _denomenators)
                {
                    denomenator *= pair.IntrinsicValue;
                }

                return numerator / denomenator;
            }
        }

        public double ConversionFactor
        {
            get
            {
                var numerator = 1.0;
                var denomenator = 1.0;

                foreach (var unit in _numerators)
                {
                    numerator *= unit.ConversionFactor;
                }

                foreach (var unit in _denomenators)
                {
                    denomenator *= unit.ConversionFactor;
                }

                return numerator / denomenator;
            }

        }
        #endregion

        #region Constructors

        public GenericUnit(List<GenericUnit<T>> numerators, List<GenericUnit<T>> denomenators = null, EqualityStrategy<T> passedEqualityStrategy = null) :
            this(_convertToBasicUnitList(numerators), _convertToBasicUnitList(denomenators), passedEqualityStrategy)
        {
            
            
        }

        private static List<BasicUnit> _convertToBasicUnitList(List<GenericUnit<T>> genericUnits)
        {
            //make list of genericUnits into basic units
            var newBasicUnits = new List<BasicUnit>();

            foreach (var genericUnit in genericUnits)
            {
                newBasicUnits.Add(new BasicUnit(genericUnit._IntrinsicValue, genericUnit.ConversionFactor));
            }

            return newBasicUnits;
        }



        protected GenericUnit(List<BasicUnit> numerators, List<BasicUnit> denomenators = null,  EqualityStrategy<T> passedEqualityStrategy = null)
        {
            _numerators = numerators;
            if (denomenators  != null)
            {
                this._denomenators = denomenators;
            }
            this._EqualityStrategy = passedEqualityStrategy;
        }

        

        /// <summary>
        /// Copy Constructor
        /// </summary>
        public GenericUnit(GenericUnit<T> toCopy)
        {
            this._numerators = toCopy._numerators;
            this._denomenators = toCopy._denomenators;
            this._DeviationPercentage = toCopy._DeviationPercentage;
            this._EqualityStrategy = toCopy._EqualityStrategy;
        }

        #endregion
    }
}
