using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.AngleUnit;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.ForceUnit;
using UnitClassLibrary.TemperatureUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary
{
    public sealed class UnitDimensions
    {
        public static readonly string[] FundamentalTypes =
            new string[] {
            nameof(AngleType),
            nameof(DistanceType),
            nameof(ForceType),
            nameof(TemperatureType),
            nameof(TimeType) };

        private double _scale;
        private List<FundamentalUnitType> _numerators;
        private List<FundamentalUnitType> _denominators;

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

        public double InitialErrorMargin(double intrinsicValue)
        {
            double percentageError = _numerators.Sum(u => u.DefaultErrorMargin)/ intrinsicValue;
            percentageError += _denominators.Sum(u => u.DefaultErrorMargin);
            if (percentageError < 0.001)
            {
                percentageError = 0.001;
            }
            return percentageError * intrinsicValue;
        }

        public string AsStringSingular()
        {
            string result = _scale.ToString() + "-" + JustTheUnitAsString();
            return result;         
        }

        internal string JustTheUnitAsString()
        {
            string result = "";
            if (_numerators.Count != 0)
            {
                result += _numerators.Select(u => u.AsStringSingular()).Aggregate((s, t) => s + "-" + t);
            }
            if (_denominators.Count != 0)
            {
                result += " over " + _denominators.Select(u => u.AsStringSingular()).Aggregate((s, t) => s + "-" + t);
            }
            return result;
        }

        public string AsStringPlural()
        { return AsStringSingular() + "s"; }

        public override string ToString()
        {
            if (_scale == 1)
            {
                return AsStringSingular();
            }
            else
            {
                return AsStringPlural();
            }
        }
        //public UnitDimensions()
        //{
        //    this._scale = 1.0;
        //    _numerators = new List<FundamentalUnitType>();
        //    _denominators = new List<FundamentalUnitType>();
        //}
     
        public UnitDimensions(double scale, IUnitType numerator = null, IUnitType denominator = null)
        {
            this._scale = scale;
            _numerators = new List<FundamentalUnitType>();
            _denominators = new List<FundamentalUnitType>();
            if (numerator != null)
            {
                _numerators.AddRange(numerator.Dimensions().Numerators);
                _denominators.AddRange(numerator.Dimensions().Denominators);
            }
            if (denominator != null)
            {
                _denominators.AddRange(denominator.Dimensions().Numerators);
                _numerators.AddRange(denominator.Dimensions().Denominators);
            }
            _cancelUnits();
        }

        public UnitDimensions(double scale, List<FundamentalUnitType> numerators, List<FundamentalUnitType> denominators = null)
        {
            this._scale = scale;
            _numerators = new List<FundamentalUnitType>();
            _denominators = new List<FundamentalUnitType>();
            this._numerators.AddRange(numerators);
            if (denominators != null)
            {
                this._denominators.AddRange(denominators);
            }
            _cancelUnits();
        }

        public UnitDimensions(double scale, List<IUnitType> numerators, List<IUnitType> denominators = null)
        {
            this._scale = scale;
            this._numerators = new List<FundamentalUnitType>();
            this._denominators = new List<FundamentalUnitType>();
            foreach (var unitType in numerators)
            {
                this._numerators.AddRange(unitType.Dimensions()._numerators);
                this._denominators.AddRange(unitType.Dimensions()._denominators);
            }
            if (denominators != null)
            {
                foreach (var unitType in denominators)
                {
                    this._numerators.AddRange(unitType.Dimensions()._denominators);
                    this._denominators.AddRange(unitType.Dimensions()._numerators);
                }
            }
            _cancelUnits();
        }

        public UnitDimensions(List<FundamentalUnitType> numerators) : this(1.0, numerators) { }

        private void _cancelUnits()
        {
            var fundamentalTypes = FundamentalTypes;
            var sortedNum = _sortUnits(_numerators);
            var sortedDenom = _sortUnits(_denominators);
          
            for (int i = 0; i < fundamentalTypes.Length; i++)
            {
                var n = Math.Min(sortedNum[i].Count(), sortedDenom[i].Count());
                if (n != 0)
                {
                    var nums = sortedNum[i].Take(n);
                    var num = nums.Select(u => u.ConversionFactor).Aggregate((u,v) => u* v);
                    var denoms = sortedDenom[i].Take(n);
                    var denom = denoms.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);

                    this._scale *= num / denom;
                    sortedNum[i] = sortedNum[i].Skip(n);
                    sortedDenom[i] = sortedDenom[i].Skip(n);
                }
            }
            this._numerators = sortedNum.SelectMany(list => list).ToList();
            this._denominators = sortedDenom.SelectMany(list => list).ToList();
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

        private static int[] _countUnits(List<FundamentalUnitType> units)
        {           
            int[] results = new int[FundamentalTypes.Length];

            for (int i = 0; i < units.Count; i++)
            {
                results[_indexOf(units[i])]++;
            }
            
            return results;
        }

        private IEnumerable<FundamentalUnitType>[] _sortUnits(List<FundamentalUnitType> units)
        {
            var results = new List<FundamentalUnitType>[FundamentalTypes.Length];

            for (int j = 0; j < FundamentalTypes.Length; j++)
            {
                results[j] = new List<FundamentalUnitType>();
            }

            for (int i = 0; i < units.Count; i++)
            {
                results[_indexOf(units[i])].Add(units[i]);
            }

            return results;
        }

        private static int _indexOf(FundamentalUnitType unit)
        {
            for (int i = 0; i < FundamentalTypes.Length; i++)
            {
                if (unit.Type == FundamentalTypes[i])
                {
                    return i;
                }
            }
            throw new NotSupportedException();
        }

        public UnitDimensions Squared()
        {
            return this.Multiply(this);
        }

        public UnitDimensions Multiply(UnitDimensions dimensions)
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
            var result = new UnitDimensions(1.0);
            for (int i = 0; i < Math.Abs(power); i++)
            {
               result = result.Multiply(this);
            }
            if (power < 0)
            {
                result = result.Invert();
            }
            return result;
        }

        public UnitDimensions Invert()
        {
            return new UnitDimensions(1 / _scale, _denominators, _numerators);
        }
    }
}