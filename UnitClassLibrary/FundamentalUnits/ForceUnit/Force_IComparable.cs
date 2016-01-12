using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary.ForceUnit
{
    public partial class Force : IComparable<Force>
    {
        public int CompareTo(Force other)
        {
            return base.CompareTo(other);
        }
    }
}
