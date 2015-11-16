using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitClassLibrary.GenericUnit
{
    public interface IUnitType
    {
        double ConversionFactor { get; }
    
        string AsStringSingular { get; }
        string AsStringPlural { get; }

        UnitDimensions Dimensions { get; }

        double DefaultErrorMargin(double intrinsicValue);
    }
   
    public abstract class FundamentalUnitType : IUnitType
    {
        public abstract double DefaultErrorMargin_ { get; }
        public abstract double ConversionFactor { get; }

        abstract public string AsStringSingular { get; }
        abstract public string AsStringPlural { get; }

      public UnitDimensions Dimensions { get { return new UnitDimensions(1.0, this); } }

        public double DefaultErrorMargin(double intrinsicValue)
        {
            var onePartInAThousand = intrinsicValue * 0.001;
            if (onePartInAThousand < DefaultErrorMargin_)
            {
                return DefaultErrorMargin_;
            }
            return onePartInAThousand;
        }
    }

    public abstract class AbstractDerivedUnitType : IUnitType
    {
        public abstract UnitDimensions Dimensions { get; }

        public double ConversionFactor
        {
            get
            {
                return Dimensions.ConversionFactor;
            }
        }
     
      public virtual string AsStringSingular
        { get { return Dimensions.AsStringSingular(); } }

        public virtual string AsStringPlural
        { get { return Dimensions.AsStringPlural(); } }

        public double DefaultErrorMargin(double intrinsicValue)
        {
            return Dimensions.DefaultErrorMargin(intrinsicValue);
        }
    }

    public class DerivedUnitType : AbstractDerivedUnitType
    {
        private readonly UnitDimensions _dimensions;
        public override UnitDimensions Dimensions { get { return _dimensions; } }

        public DerivedUnitType(double scale, List<FundamentalUnitType> numerators, List<FundamentalUnitType> denominators = null)
            : this(new UnitDimensions(scale, numerators, denominators)) { }

        public DerivedUnitType(UnitDimensions dimensions)
        {
            this._dimensions = dimensions;
        }

        public DerivedUnitType Multiply(DerivedUnitType unitType)
        {
            return new DerivedUnitType(this.Dimensions.Multiply(unitType.Dimensions));

            
        }
    }

    public class UnitDimensions
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

        public virtual string AsStringPlural()
        {  throw new NotImplementedException(); } 


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
            foreach(var unitType in numerators)
            {
                this._numerators.AddRange(unitType.Dimensions._numerators);
                this._denominators.AddRange(unitType.Dimensions._denominators);
            }
            foreach(var unitType in denominators)
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
            return true;
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
    }
} 
