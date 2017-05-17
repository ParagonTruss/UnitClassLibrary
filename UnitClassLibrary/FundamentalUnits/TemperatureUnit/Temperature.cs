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
using UnitClassLibrary.AngleUnit.Temperature;
using UnitClassLibrary.FundamentalUnits.TemperatureUnit;
using UnitClassLibrary.TemperatureUnit;

namespace UnitClassLibrary
{
    public sealed class Temperature : Unit<TemperatureType>
    {
        public Temperature(double value, TemperatureType type) : base(type, value)
        {
                
        }

        public Measurement InFahrenheit
        {
            get
            {
                if (UnitType is Fahrenheit)
                {
                    return this.Measurement;
                }
                if (UnitType is Celsius)
                {
                    return this.Measurement*1.8 + 32;
                }
                if (UnitType is Kelvin)
                {
                    return (this.Measurement-273.15)*1.8 + 32;
                }
                throw new NotImplementedException();
            }
        }

        public Measurement InCelsius
        {
            get
            {
                if (UnitType is Fahrenheit)
                {
                    return (5.0/9.0)*(this.Measurement - 32.0);
                }
                if (UnitType is Celsius)
                {
                    return this.Measurement;
                }
                if (UnitType is Kelvin)
                {
                    return this.Measurement - 273.15;
                }
                throw new NotImplementedException();
            }
        }

        public Measurement InKelvin
        {
            get
            {
                if (UnitType is Fahrenheit)
                {
                    return (5.0/9.0)*(this.Measurement-32)+273.15;
                }
                if (UnitType is Celsius)
                {
                    return this.Measurement + 273.15;
                }
                if (UnitType is Kelvin)
                {
                    return this.Measurement;
                }
                throw new NotImplementedException();
            }
        }
    }
}
