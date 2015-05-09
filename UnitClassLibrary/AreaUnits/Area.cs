using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitClassLibrary.AreaUnits.AreaTypes;
using UnitClassLibrary.AreaUnits.AreaTypes.Imperial.AcreUnit;
using UnitClassLibrary.BaseUnit;
using UnitClassLibrary.Core.BasicUnit;

namespace UnitClassLibrary.AreaUnits
{
    public partial class Area: Unit
    {
        /// <summary>
        /// What all new Area objects will use as the default deviation
        /// </summary>
        public static Area DefaultDeviationConstant = new Area( new Area(new Acre()) / 32.0);

        public override Unit DeviationConstant
        {
            get { return _deviationConstant; }
            set { _deviationConstant = (Area)value; }
        }

        private Area _deviationConstant = Area.DefaultDeviationConstant;

        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Area(EqualityStrategy passedStrategy = null)
            : base(new Acre(), 0, passedStrategy)
        {
        }

        public Area(IAreaType AreaType, EqualityStrategy passedStrategy = null)
            : base(AreaType, 1, passedStrategy)
        {
        }

        /// <summary>
        /// The standard Unit Constructor that takes the value and the unit type that describes it.
        /// </summary>
        public Area(IAreaType passedAreaType, double passedInput, EqualityStrategy passedStrategy = null)
            : base(passedAreaType, passedInput, passedStrategy)
        {
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="passedArea">Area objet to copy</param>
        public Area(Area passedArea)
            : base(passedArea)
        {
        }
    }
}
