using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.AngleUnit;
using UnitClassLibrary.AngleUnit.AngleTypes;
using UnitClassLibrary.DistanceUnit.DistanceTypes;
using UnitClassLibrary.ForceUnit;
using UnitClassLibrary.TemperatureUnit;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.GenericUnit
{
    public sealed class UnitDimensions
    {
        public static readonly string[] FundamentalTypes =
            new string[] {
            typeof(AngleType).ToString(),
            typeof(DistanceType).ToString(),
            typeof(ForceType).ToString(),
            typeof(TemperatureType).ToString(),
            typeof(TimeType).ToString() };

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
            double percentageError = _numerators.Sum(u => u.DefaultErrorMargin_)/ intrinsicValue;
            percentageError += _denominators.Sum(u => u.DefaultErrorMargin_);
            if (percentageError < 0.001)
            {
                percentageError = 0.001;
            }
            return percentageError * intrinsicValue;
        }

        public string AsStringSingular()
        {
            string result = _scale.ToString() + "-" + JustTheUnit();
            return result;         
        }

        internal string JustTheUnit()
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

        public UnitDimensions(double scale, List<IUnitType> numerators, List<IUnitType> denominators = null)
        {
            this._scale = scale;
            this._numerators = new List<FundamentalUnitType>();
            this._denominators = new List<FundamentalUnitType>();
            foreach (var unitType in numerators)
            {
                this._numerators.AddRange(unitType.Dimensions._numerators);
                this._denominators.AddRange(unitType.Dimensions._denominators);
            }
            if (denominators != null)
            {
                foreach (var unitType in denominators)
                {
                    this._numerators.AddRange(unitType.Dimensions._denominators);
                    this._denominators.AddRange(unitType.Dimensions._numerators);
                }
            }
            _cancelUnits();
        }

        private void _cancelUnits()
        {
            var fundamentalTypes = FundamentalTypes;
            var numCount = _countUnits(_numerators);
            var denomCount = _countUnits(_denominators);
          
            for (int i = 0; i < fundamentalTypes.Length; i++)
            {
                var n = Math.Min(numCount[i], denomCount[i]);
                if (n != 0)
                {
                    var nums = _numerators.Where(u => u.Type == fundamentalTypes[i]).Take(n);
                    var num = nums.Select(u => u.ConversionFactor).Aggregate((u,v) => u* v);
                    var denoms = _denominators.Where(u => u.Type == fundamentalTypes[i]).Take(n);
                    var denom = denoms.Select(u => u.ConversionFactor).Aggregate((u, v) => u * v);

                    this._scale *= num / denom;
                    foreach(var item in nums)
                    {
                        this._numerators.Remove(item);
                    }
                    foreach (var item in denoms)
                    {
                        this._denominators.Remove(item);
                    }
                }
              
                
            }
            
         
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
            int[] results = new int[FundamentalTypes.Length];
            for (int i = 0; i < FundamentalTypes.Length; i++)
            {
                results[i] = units.Count(u => u.Type == FundamentalTypes[i]);
            }
            
            return results;
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

        public UnitDimensions Invert()
        {
            return new UnitDimensions(1 / _scale, _denominators, _numerators);
        }
    }
}