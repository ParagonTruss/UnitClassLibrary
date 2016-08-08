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
using System.Collections.ObjectModel;
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
        internal static readonly List<string> FundamentalTypes = new List<string>(5)
        {
            nameof(AngleType),
            nameof(DistanceType),
            nameof(ForceType),
            nameof(TemperatureType),
            nameof(TimeType)
        };
        internal static int FundamentalUnitCount => FundamentalTypes.Count;

        public double ConversionFactor { get; private set; }

        private int[] _dimensions;
        private int this[int index] => _dimensions[index];

        private UnitDimensions() {}

        public UnitDimensions(double conversionFactor, IList<int> dimensions)
        {
            this.ConversionFactor = conversionFactor;

            this._dimensions = new int[FundamentalUnitCount];
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                this._dimensions[i] = dimensions[i];
            }
        }

        public UnitDimensions(double scale, IUnitType numerator = null, IUnitType denominator = null)
        {
            this.ConversionFactor = scale;
            this._dimensions = new int[FundamentalUnitCount];
            
            if (numerator != null)
            {
                this.ConversionFactor *= numerator.ConversionFactor;
                AddTo(this._dimensions, numerator.Dimensions()._dimensions);
            }
            if (denominator != null)
            {
                this.ConversionFactor /= denominator.ConversionFactor;
               AddTo(this._dimensions, denominator.Dimensions()._dimensions);
            }
        }

        public UnitDimensions(double scale, List<FundamentalUnitType> numerator, List<FundamentalUnitType> denominator = null)
        {
            this.ConversionFactor = scale * numerator.Aggregate(1d, (d1, d2) => d1 * d2.ConversionFactor);

            this._dimensions = new int[FundamentalUnitCount];
            foreach (var unitType in numerator)
            {
                this._dimensions[unitType.DimensionIndex()]++;
            }
            if (denominator != null)
            {
                this.ConversionFactor /= denominator.Aggregate(1d, (d1, d2) => d1 * d2.ConversionFactor);
                foreach (var unitType in denominator)
                {
                    this._dimensions[unitType.DimensionIndex()]--;
                }
            }
        }

        //public UnitDimensions(double scale, List<IUnitType> numerators, List<IUnitType> denominators = null)
        //{
        //    this.Scale = scale;
        //    this._numerators = new List<FundamentalUnitType>();
        //    this._denominators = new List<FundamentalUnitType>();
        //    foreach (var unitType in numerators)
        //    {
        //        this._numerators.AddRange(unitType.Dimensions()._numerators);
        //        this._denominators.AddRange(unitType.Dimensions()._denominators);
        //    }
        //    if (denominators != null)
        //    {
        //        foreach (var unitType in denominators)
        //        {
        //            this._numerators.AddRange(unitType.Dimensions()._denominators);
        //            this._denominators.AddRange(unitType.Dimensions()._numerators);
        //        }
        //    }
        //}

        public UnitDimensions(List<FundamentalUnitType> numerators) : this(1.0, numerators) { }

        /// <summary>
        /// Modifes the values in the first array, by adding the items from the second.
        /// </summary>
        private static void AddTo(int[] dimAddedTo, int[] add)
        {
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                dimAddedTo[i] += add[i];
            }
        }

        private static void Subtract(int[] dimSubtractedFrom, int[] minus)
        {
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                dimSubtractedFrom[i] -= minus[i];
            }
        }
        public static bool HaveSameDimensions(UnitDimensions dim1, UnitDimensions dim2)
        {
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                if (dim1[i] != dim2[i])
                {
                    return false;
                }
            }
            return true;
        }

    

      

        public UnitDimensions Squared()
        {
            return this.Multiply(this);
        }

        public UnitDimensions Multiply(UnitDimensions dimensions)
        {
            var newDim = new int[FundamentalUnitCount];
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                newDim[i] = this[i] + dimensions[i];
            }
            var dim = new UnitDimensions
            {
                ConversionFactor =  this.ConversionFactor*dimensions.ConversionFactor,
                _dimensions = newDim,
            };
     
            return dim;
        }

        public UnitDimensions Divide(UnitDimensions dimensions)
        {
            var newDim = new int[FundamentalUnitCount];
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                newDim[i] = this[i] - dimensions[i];
            }
            var dim = new UnitDimensions
            {
                ConversionFactor = this.ConversionFactor / dimensions.ConversionFactor,
                _dimensions = newDim,
            };

            return dim;
        }

        internal UnitDimensions ToThe(int power)
        {
            var newDim = new int[FundamentalUnitCount];
            for (int i = 0; i < FundamentalUnitCount; i++)
            {
                newDim[i] = this[i]*power;
            }
            var dim = new UnitDimensions
            {
                ConversionFactor = Math.Pow( this.ConversionFactor, power),
                _dimensions = newDim,
            };
            return dim;
        }

        public UnitDimensions Invert()
        {
            return ToThe(-1);
        }
   }

    public static class FundamentalUnitTypeExtensions
    {
        internal static int DimensionIndex(this FundamentalUnitType unitType) => UnitDimensions.FundamentalTypes.IndexOf(unitType.Type);
      
    }
}