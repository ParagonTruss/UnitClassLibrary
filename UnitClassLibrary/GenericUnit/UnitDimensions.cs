using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.ForceUnit;
using UnitClassLibrary.TemperatureUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.GenericUnit
{
    public sealed class UnitDimensions
    {
        private double _scale;
        private List<FundamentalUnitType> _numerators = new List<FundamentalUnitType>();
        private List<FundamentalUnitType> _denominators = new List<FundamentalUnitType>();

        public double Scale { get { return _scale; } }
        public List<FundamentalUnitType> Numerators { get { return _numerators; } }
        public List<FundamentalUnitType> Denominators { get { return _denominators; } }
        public double ConversionFactor
        {
            get
            {
                double result = _scale;
                if (_numerators.Count != 0)
                {
                    result *= _numerators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);
                }
                if (_denominators.Count != 0)
                {
                    result /= _denominators.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);
                }
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
            string result = _scale.ToString() + " ";
            result += _numerators.Select(u => u.AsStringSingular).Aggregate((s, t) => s + "-" + t);
            result += " over " + _denominators.Select(u => u.AsStringSingular).Aggregate((s, t) => s + "-" + t);
            return result;
        }

        public string AsStringPlural()
        { throw new NotImplementedException(); }

        public UnitDimensions()
        {
            this._scale = 1.0;
        }

        public UnitDimensions(double scale, FundamentalUnitType numerator, FundamentalUnitType denominator = null)
        {
            this._scale = scale;
            this._numerators.Add(numerator);
            if (denominator != null)
            {
                this._denominators.Add(denominator);
            }
        }

        public UnitDimensions(double scale, List<FundamentalUnitType> numerators, List<FundamentalUnitType> denominators = null)
        {
            this._scale = scale;
            this._numerators.AddRange(numerators);
            if (denominators != null)
            {
                this._denominators.AddRange(denominators);
            }
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
            int[] count1 = dim1._countUnits();
            int[] count2 = dim2._countUnits();
            for (int i = 0; i < count1.Length; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int[] _countUnits()
        {
            int[] num = _countUnits(_numerators);
            int[] denom = _countUnits(_denominators);
            int[] result = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                result[i] = num[i] - denom[i];
            }
            return result;
        }

        private int[] _countUnits(List<FundamentalUnitType> units)
        {
            int angleCount = 0, distanceCount = 0, forceCount = 0,  tempCount = 0, timeCount = 0;
            int[] result = new int[] { angleCount, distanceCount, forceCount,  tempCount, timeCount };
            foreach(var unit in units)
            {
                if (unit is AngleType)
                {
                   angleCount++;
                }
                else if (unit is ForceType)
                {
                    forceCount++;
                }
                else if (unit is DistanceType)
                {
                    distanceCount++;
                }
                else if (unit is TemperatureType)
                {
                    tempCount++;
                }
                else if (unit is TimeType)
                {
                    timeCount++;
                }
            }
            return result;
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