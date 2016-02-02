using System;
using UnitClassLibrary.AngleUnit.Temperature;
using UnitClassLibrary.FundamentalUnits.TemperatureUnit;
using UnitClassLibrary.TemperatureUnit;

namespace UnitClassLibrary
{
    public class Temperature : Unit<TemperatureType>
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
