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

        public static DerivedUnitType Multiply(IUnitType type1, IUnitType type2)
        {
            return new DerivedUnitType(type1.Dimensions.Multiply(type2.Dimensions));    
        }

        public static DerivedUnitType Divide(IUnitType type1, IUnitType type2)
        {
            return new DerivedUnitType(type1.Dimensions.Divide(type2.Dimensions));
        }

        internal static DerivedUnitType Power(IUnitType unitType, int power)
        {
            return new DerivedUnitType(unitType.Dimensions.ToThe(power));
        }
    }

   
} 
