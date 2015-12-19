using System;
using System.Collections.Generic;
using System.Linq;
using UnitClassLibrary.TimeUnit.TimeTypes;

namespace UnitClassLibrary.GenericUnit
{
    public interface IUnitType
    {
        double ConversionFactor { get; }
        UnitDimensions Dimensions { get; }

        double DefaultErrorMargin(double intrinsicValue);

        string AsStringSingular();
        string AsStringPlural();      
    }
   
    public abstract class FundamentalUnitType : IUnitType
    {
        public abstract double DefaultErrorMargin_ { get; }
        public abstract double ConversionFactor { get; }

        abstract public string Type { get; }
        abstract public string AsStringSingular();
        public virtual string AsStringPlural()
        {
            return AsStringSingular() + "s";
        }

        public UnitDimensions Dimensions { get { return _unitDimensions(); } }

        private UnitDimensions _unitDimensions()
        {
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { this });
        }

        public double DefaultErrorMargin(double intrinsicValue)
        {
            var onePartInAMillion = intrinsicValue * 0.000001;
            if (onePartInAMillion < DefaultErrorMargin_)
            {
                return DefaultErrorMargin_;
            }
            return onePartInAMillion;
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

        public abstract string AsStringSingular();
        public virtual string AsStringPlural() { return AsStringSingular() + "s"; }

        public double DefaultErrorMargin(double intrinsicValue)
        {
            return Dimensions.DefaultErrorMargin(intrinsicValue);
        }

        public override string ToString()
        {
            return this.Dimensions.ToString();
        }
    }

    public class DerivedUnitType : AbstractDerivedUnitType
    {
        private readonly UnitDimensions _dimensions;

        public override UnitDimensions Dimensions { get { return _dimensions; } }

        public DerivedUnitType()
        {
            this._dimensions = new UnitDimensions(1.0);
        }
        public DerivedUnitType(double scale, List<FundamentalUnitType> numerators, List<FundamentalUnitType> denominators = null)
            : this(new UnitDimensions(scale, numerators, denominators)) { }
        public DerivedUnitType(double scale, List<IUnitType> numerators, List<IUnitType> denominators = null) 
        {
            this._dimensions = new UnitDimensions(scale, numerators, denominators);
        }
        public DerivedUnitType(UnitDimensions dimensions)
        {
            this._dimensions = dimensions;
        }

        public DerivedUnitType(double scale, IUnitType numerator, IUnitType denominator)
        {
            this._dimensions = new UnitDimensions(scale, numerator, denominator);
        }

        #region Static Methods
        public static DerivedUnitType Multiply(IUnitType type1, IUnitType type2)
        {
            return new DerivedUnitType(type1.Dimensions.Multiply(type2.Dimensions));    
        }

        public static DerivedUnitType Divide(IUnitType type1, IUnitType type2)
        {
            return new DerivedUnitType(type1.Dimensions.Divide(type2.Dimensions));
        }

        public static DerivedUnitType Power(IUnitType unitType, int power)
        {
            return new DerivedUnitType(unitType.Dimensions.ToThe(power));
        }

        public override string AsStringSingular()
        { return Dimensions.AsStringSingular(); }

        public override string AsStringPlural()
        { return Dimensions.AsStringPlural(); }
        #endregion
    }

    public class DimensionLess : AbstractDerivedUnitType
    {
        private static DimensionLess _instance = new DimensionLess();
        public static DimensionLess Instance { get { return _instance; } }
        private DimensionLess()
        {

        }

        public override UnitDimensions Dimensions
        {
            get
            {
                return new UnitDimensions(1.0);
            }
        }

        public override string AsStringSingular()
        {
            throw new NotImplementedException();
        }
    }


} 
