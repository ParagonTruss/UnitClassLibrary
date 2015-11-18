using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.GenericUnit;

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

        public override double DefaultErrorMargin_
        {
            get
            {
                return new Pound().DefaultErrorMargin_ / ConversionFactor;
            }
        }
    }
}
