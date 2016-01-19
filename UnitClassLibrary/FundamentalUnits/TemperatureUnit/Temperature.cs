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
                    return default(Measurement);
                }
                if (UnitType is Kelvin)
                {
                    return default(Measurement);
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
                    return default(Measurement); 
                }
                if (UnitType is Celsius)
                {
                    return this.Measurement;
                }
                if (UnitType is Kelvin)
                {
                    return default(Measurement);
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
                    return default(Measurement);
                }
                if (UnitType is Celsius)
                {
                    return default(Measurement);
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
