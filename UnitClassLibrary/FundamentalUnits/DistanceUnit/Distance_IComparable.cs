using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.DistanceUnit
{
    public partial class Distance : IComparable<Distance>
    {
        public int CompareTo(Distance other)
        {
            return base.CompareTo(other);
        }
    }
}
