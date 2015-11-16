using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitClassLibrary.GenericUnit
{
    public sealed class UnitDimensions
    {
        private double _scale;
        private List<FundamentalUnitType> _numerators;
        private List<FundamentalUnitType> _denominators;

        public double ConversionFactor
        {
            get
            {
                double result = _numerators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);
                result /= _denominators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);
                return result;
            }
        }

        public double DefaultErrorMargin(double intrinsicValue)
        {
            double percentageError = _numerators.Sum(u => u.DefaultErrorMargin_);
            percentageError += _denominators.Sum(u => u.DefaultErrorMargin_);
            if (percentageError < 0.001)
            {
                percentageError = 0.001;
            }
            return percentageError * intrinsicValue;
        }

        public string AsStringSingular()
        {
            string result = _numerators.Select(u => u.AsStringSingular).Aggregate((s, t) => s + "-" + t);
            result += " over " + _denominators.Select(u => u.AsStringSingular).Aggregate((s, t) => s + "-" + t);
            return result;
        }

        public string AsStringPlural()
        { throw new NotImplementedException(); }

        public UnitDimensions()
        {
            this._scale = 1.0;
            this._numerators = new List<FundamentalUnitType>();
            this._denominators = new List<FundamentalUnitType>();
        }

        public UnitDimensions(double scale, FundamentalUnitType numerator, FundamentalUnitType denominator = null)
        {
            this._scale = scale;
            this._numerators = new List<FundamentalUnitType>() { numerator };
            if (denominator == null)
            {
                this._denominators = new List<FundamentalUnitType>();
            }
            else
            {
                this._denominators = new List<FundamentalUnitType>() { denominator };
            }
        }

        public UnitDimensions(double scale, List<FundamentalUnitType> numerators, List<FundamentalUnitType> denominators = null)
        {
            this._scale = scale;
            this._numerators = numerators.ToList();
            this._denominators = denominators.ToList();
        }

        public UnitDimensions(List<AbstractDerivedUnitType> numerators, List<AbstractDerivedUnitType> denominators = null, double scale = 1.0)
        {
            this._scale = scale;
            this._numerators = new List<FundamentalUnitType>();
            this._denominators = new List<FundamentalUnitType>();
            foreach (var unitType in numerators)
            {
                this._numerators.AddRange(unitType.Dimensions._numerators);
                this._denominators.AddRange(unitType.Dimensions._denominators);
            }
            foreach (var unitType in denominators)
            {
                this._numerators.AddRange(unitType.Dimensions._denominators);
                this._denominators.AddRange(unitType.Dimensions._numerators);
            }
            _cancelUnits();
        }

        private void _cancelUnits()
        {
            //ToDo:
        }

        public static bool HaveSameDimensions(UnitDimensions dim1, UnitDimensions dim2)
        {
            throw new NotImplementedException();
        }

        internal UnitDimensions Multiply(UnitDimensions dimensions)
        {
            var numerators = this._numerators.ToList();
            numerators.AddRange(dimensions._numerators);

            var denominators = this._denominators.ToList();
            denominators.AddRange(dimensions._denominators);

            var dim = new UnitDimensions(this._scale * dimensions._scale, numerators, denominators);
            return dim;
        }

        public UnitDimensions Divide(UnitDimensions dimensions)
        {
            var numerators = this._numerators.ToList();
            numerators.AddRange(dimensions._denominators);

            var denominators = this._denominators.ToList();
            denominators.AddRange(dimensions._numerators);

            var dim = new UnitDimensions(this._scale / dimensions._scale, numerators, denominators);
            return dim;
        }

        internal UnitDimensions ToThe(int power)
        {
            var result = new UnitDimensions();
            for (int i = 0; i < Math.Abs(power); i++)
            {
                result.Multiply(this);
            }
            if (power < 0)
            {
                result = result.Invert();
            }
            return result;
        }

        private UnitDimensions Invert()
        {
            return new UnitDimensions(1 / _scale, _denominators, _numerators);
        }
    }
}