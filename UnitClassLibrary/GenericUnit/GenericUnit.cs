using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.SpeedUnit.SpeedTypes;

namespace UnitClassLibrary.GenericUnit
{ 
    public class DerivedUnit<T> : DerivedUnit where T : IDerivedUnit
    {
  
       
        public DerivedUnit(DerivedUnit<ISpeedUnit> toCopy)
            : base(toCopy) { }

        public DerivedUnit(IDerivedUnit derivedUnit, double value, double errorMargin = 0)
            : base(value, errorMargin, derivedUnit.Numerators, derivedUnit.Denominators)
        { }

        public DerivedUnit(IDerivedUnit derivedUnit, Measurement value)
            : base(value, derivedUnit.Numerators, derivedUnit.Denominators)
        { }
    }
    public partial class DerivedUnit
    {
        #region _fields and Properties

        private List<IUnit> _numerators = new List<IUnit>();
        private List<IUnit> _denominators = new List<IUnit>();

        public Measurement Value;
        public double IntrinsicValue { get { return Value.Value; } }
        public double ErrorMargin { get { return Value.ErrorMargin; } }
        public double PercentageError { get { return Value.PercentageError; } }
        public DerivedUnit DeviationAsConstant { get { return PercentageError * this; } }
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

        public DerivedUnit(double intrinsicValue, double errorMargin, List<IUnit> numerators, List<IUnit> denominators)
            : this(new Measurement(intrinsicValue, errorMargin), numerators, denominators) { }

        public DerivedUnit(Measurement value, List<IUnit> numerators, List<IUnit> denominators)
        {
            this._numerators = numerators;
            this._denominators = denominators;
            this.Value = value;
        }

        protected DerivedUnit(List<BasicUnit> numerators, List<BasicUnit> denominators = null)
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
        public DerivedUnit(DerivedUnit toCopy)
        {
            this.Value = toCopy.Value;
            this._numerators = toCopy._numerators;
            this._denominators = toCopy._denominators;
        }

        #endregion
    }
}