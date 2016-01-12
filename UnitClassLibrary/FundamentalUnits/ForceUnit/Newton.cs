using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UnitClassLibrary.ForceUnit
{
    public class Newton : ForceType
    {

        public override string AsStringSingular()
        {
            return "Newton";
        }

        public override double ConversionFactor
        {
            get
            {
                return 0.22480894309971;
            }
        }

        public override double DefaultErrorMargin
        {
            get
            {
                return new Pound().DefaultErrorMargin / ConversionFactor;
            }
        }
    }
}
