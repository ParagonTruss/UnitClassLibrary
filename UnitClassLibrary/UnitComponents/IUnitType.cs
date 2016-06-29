/*
    This file is part of Unit Class Library.
    Copyright (C) 2016 Paragon Component Systems, LLC.

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitClassLibrary
{
    public interface IUnitType
    {
        double ConversionFactor { get; }
        UnitDimensions Dimensions();

        double InitialErrorMargin(double initialValue);

        string AsStringSingular();
        string AsStringPlural();      
    }
   
    public abstract class FundamentalUnitType : IUnitType
    {
        public abstract double DefaultErrorMargin { get; }
        public abstract double ConversionFactor { get; }

        abstract public string Type { get; }
        abstract public string AsStringSingular();
        public virtual string AsStringPlural()
        {
            return AsStringSingular() + "s";
        }

        public UnitDimensions Dimensions()
        {
            return new UnitDimensions(1.0, new List<FundamentalUnitType>() { this });
        }

        public double InitialErrorMargin(double intrinsicValue)
        {
            return DefaultErrorMargin;
            //var onePartInAMillion = intrinsicValue * 0.000001;
            //if (onePartInAMillion < DefaultErrorMargin)
            //{
            //    return DefaultErrorMargin;
            //}
            //return onePartInAMillion;
        }
    }

    public abstract class AbstractDerivedUnitType : IUnitType
    {
        public abstract UnitDimensions Dimensions();
        public double ConversionFactor => Dimensions().ConversionFactor;

        public abstract string AsStringSingular();
        public virtual string AsStringPlural() { return AsStringSingular() + "s"; }

        public virtual double InitialErrorMargin(double intrinsicValue)
        {
            return Dimensions().InitialErrorMargin(intrinsicValue);
        }

        public override string ToString()
        {
            return this.Dimensions().ToString();
        }
    }

    public class DerivedUnitType : AbstractDerivedUnitType
    {
        private readonly UnitDimensions _dimensions;

        public override UnitDimensions Dimensions()
        {
            return _dimensions;
        }

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
            return new DerivedUnitType(type1.Dimensions().Multiply(type2.Dimensions()));    
        }

        public static DerivedUnitType Divide(IUnitType type1, IUnitType type2)
        {
            return new DerivedUnitType(type1.Dimensions().Divide(type2.Dimensions()));
        }

        public static DerivedUnitType Power(IUnitType unitType, int power)
        {
            return new DerivedUnitType(unitType.Dimensions().ToThe(power));
        }

        public override string AsStringSingular()
        { return Dimensions().AsStringSingular(); }

        public override string AsStringPlural()
        { return Dimensions().AsStringPlural(); }
        #endregion
    }

    public class DimensionLess : AbstractDerivedUnitType
    {
        private static DimensionLess _instance = new DimensionLess();
        public static DimensionLess Instance => _instance;

        private DimensionLess()
        {

        }

        public override UnitDimensions Dimensions()
        {          
            return new UnitDimensions(1.0);
        }

        public override string AsStringSingular()
        {
            throw new NotImplementedException();
        }
    }


} 
