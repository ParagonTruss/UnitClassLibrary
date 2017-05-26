﻿/*
    This file is part of Unit Class Library.
    Copyright (C) 2017 Paragon Component Systems, LLC.

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

namespace UnitClassLibrary
{
    public enum ErrorMarginSetting { StaticTolerances, ErrorPropagation }
    
    public sealed class Measurement : IEquatable<Measurement>, IComparable<Measurement>, IFormattable
    {
        #region global public variables
        
        /// <summary>
        /// set to 1 billionth.
        /// </summary>
        public static double DefaultErrorMargin { get; set; } = 0.00000001;
        public static bool ErrorPropagationIsEnabled => false;


        #endregion

        #region Implicit Cast
        public static implicit operator Measurement(double d)
        {
            return new Measurement(d);
        }
        #endregion

        #region Properties
        public static Measurement Zero => new Measurement(0.0, 0.0);

        public double Value { get; }

        public double ErrorMargin { get; }

        public double PercentageError => ErrorMargin / Value;

        #endregion

        #region Constructors

        public Measurement()
        {
            this.Value = 0;
            this.ErrorMargin = DefaultErrorMargin;
        }
        public Measurement(double intrinsicValue)
        {
            this.Value = intrinsicValue;
            this.ErrorMargin = DefaultErrorMargin;
        }
        public Measurement(double intrinsicValue, double errorMargin)
        {
            this.Value = intrinsicValue;
            this.ErrorMargin = errorMargin;
        }

        #endregion

        #region Public methods

        public Measurement SquareRoot()
        {
            var sqrt = Math.Sqrt(this.Value);
          
            var error = this.ErrorMargin / (2 * sqrt);
            if (Double.IsNaN(error))
            {
                error = Math.Sqrt(this.Value + this.ErrorMargin) - sqrt;
            }
            return new Measurement(sqrt, error);          
        }

        public Measurement Negate()
        {
            return new Measurement(this.Value*-1.0,this.ErrorMargin);
        }

        public Measurement AbsoluteValue()
        {
            return new Measurement(Math.Abs(Value), ErrorMargin);
        }

        public Measurement ToThe(Measurement m)
        {
            double value = Math.Pow(this.Value, m.Value);       
            double error = m.Value * Math.Pow(this.Value, m.Value - 1) * this.ErrorMargin
                + Math.Log(this.Value) * Math.Pow(this.Value, m.Value) * m.ErrorMargin;
            return new Measurement(value, error);
        }

        public Measurement ToThe(int n)
        {
            var result = new Measurement(1, 0);
            for (int i = 0; i < Math.Abs(n); i++)
            {
                result *= this;
            }
            if (n < 0)
            {
                return 1 / result;
            }
            else
            {
                return result;
            }
        }

        public Measurement Add(Measurement m)
        {
            return new Measurement(this.Value + m.Value, this.ErrorMargin + m.ErrorMargin);
        }
        public Measurement Subtract(Measurement m)
        {
            return new Measurement(this.Value - m.Value, this.ErrorMargin + m.ErrorMargin);
        }
        public Measurement Multiply(Measurement m)
        {
            return new Measurement(this.Value * m.Value, Math.Abs(this.Value * m.ErrorMargin) + Math.Abs(m.Value * this.ErrorMargin));
        }
        public Measurement Divide(Measurement m)
        {
            return new Measurement(this.Value / m.Value, Math.Abs(this.Value * m.ErrorMargin / (m.Value * m.Value)) + Math.Abs(this.ErrorMargin / m.Value));
        }
        public Measurement Mod(Measurement m)
        {
            
            double mValue = Math.Abs(m.Value);
            double value = this.Value % mValue;
            double errorMargin = this.ErrorMargin + m.ErrorMargin * Math.Floor(Math.Abs(this.Value) / mValue);
            Measurement temp = new Measurement(value, errorMargin);
            if (value == Measurement.Zero || temp == mValue) 
            {
                return new Measurement(0, errorMargin);          
            }             
            if (value < 0.0)
            {
                value += m.Value;
            }
            return new Measurement(value, errorMargin);
        }
        public bool LessThan(Measurement m)
        {
            return this.Value < m.Value;
        }
        public bool GreaterThan(Measurement m)
        {
            return this.Value > m.Value;
        }
        public bool Equals(Measurement m)
        {
            return Math.Abs(this.Value - m.Value) <= (this.ErrorMargin + m.ErrorMargin);
        }
        #endregion

        #region Operator Overloads
        public static Measurement operator +(Measurement m1, Measurement m2)
        {
            return m1.Add(m2);
        }

        public static Measurement operator -(Measurement m)
        {
            return m.Negate();
        }
        public static Measurement operator -(Measurement m1, Measurement m2)
        {
            return m1.Subtract(m2);
        }
        public static Measurement operator *(Measurement m1, Measurement m2)
        {
            return m1.Multiply(m2);
        }
        public static Measurement operator /(Measurement m1, Measurement m2)
        {
            return m1.Divide(m2);
        }
        public static Measurement operator %(Measurement m1, Measurement m2)
        {
            return m1.Mod(m2);
        }
        public static Measurement operator ^(Measurement m, int n)
        {
            return m.ToThe(n);
        }
        public static Measurement operator ^(Measurement m1, Measurement m2)
        {
            return m1.ToThe(m2);
        }
        public static bool operator <(Measurement m1, Measurement m2)
        {
            return m1.LessThan(m2);
        }
        public static bool operator >(Measurement m1, Measurement m2)
        {
            return m1.GreaterThan(m2);
        }
        public static bool operator ==(Measurement m1, Measurement m2)
        {
            return m1.Equals(m2);
        }
        public static bool operator !=(Measurement m1, Measurement m2)
        {
            return !m1.Equals(m2);
        }
        public static bool operator <=(Measurement m1, Measurement m2)
        {
            return m1 < m2 || m1 == m2;
        }
        public static bool operator >=(Measurement m1, Measurement m2)
        {
            return m1 > m2 || m1 == m2;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// IFormattable implementation
        /// </summary>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString();
        }
        public override string ToString()
        {
            // valus plus/minus error
            return $"{this.Value} ± {this.ErrorMargin}";
        }

        public int CompareTo(Measurement other)
        {
            if (this > other)
            {
                return 1;
            }
            if (other > this)
            {
                return -1;
            }
            return 0;
        }

      
        #endregion
    }
}
