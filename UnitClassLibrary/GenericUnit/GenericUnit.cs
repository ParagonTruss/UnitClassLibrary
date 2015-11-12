using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.DistanceUnit.DistanceTypes;

namespace UnitClassLibrary.GenericUnit
{ 
    public partial class GenericUnit
    {
        #region _fields and Properties

        private List<IUnit> _numerators = new List<IUnit>();
        private List<IUnit> _denominators = new List<IUnit>();

        public Measurement Value;
        public double IntrinsicValue { get { return Value.Value; } }
        public double ErrorMargin { get { return Value.ErrorMargin; } }
        public double PercentageError { get { return Value.PercentageError; } }
        public GenericUnit DeviationAsConstant { get { return PercentageError * this; } }
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

                foreach (var unit in _denominators)
                {
                    denomenator *= unit.ConversionFactor;
                }

                return numerator / denomenator;
            }

        }
        #endregion

        #region Constructors

        public GenericUnit(double intrinsicValue, double errorMargin, List<IUnit> numerators, List<IUnit> denominators)
            : this(new Measurement(intrinsicValue, errorMargin), numerators, denominators) { }

        public GenericUnit(Measurement value, List<IUnit> numerators, List<IUnit> denominators)
        {
            this._numerators = numerators;
            this._denominators = denominators;
            this.Value = value;
        }

        protected GenericUnit(List<BasicUnit> numerators, List<BasicUnit> denominators = null)
        {
            this._numerators = numerators.Select(u => u.Unit).ToList();
            var intrinsicValue = numerators.Select(u => u.IntrinsicValue).Aggregate((u, v) => u * v);
            if (denominators != null)
            {
                this._denominators = denominators.Select(u => u.Unit).ToList();
                intrinsicValue /= denominators.Select(u => u.IntrinsicValue).Aggregate((u, v) => u * v);
            }
            var list = numerators.ToList();
            list.AddRange(denominators);
            var percentError = list.Sum(u => u.Measurement.PercentageError);
            var errorMargin = percentError * intrinsicValue;
            this.Value = new Measurement(intrinsicValue, errorMargin);      
        }

        

        /// <summary>
        /// Copy Constructor
        /// </summary>
        public GenericUnit(GenericUnit toCopy)
        {
            this.Value = toCopy.Value;
            this._numerators = toCopy._numerators;
            this._denominators = toCopy._denominators;
        }

        #endregion
    }
}