using UnitClassLibrary.BaseUnit;
using UnitClassLibrary.DistanceUnits.DistanceTypes;
using UnitClassLibrary.DistanceUnits.DistanceTypes.Imperial.InchUnit;

namespace UnitClassLibrary.DistanceUnits
{
    /// <summary>
    /// Class used for storing Distances that may need to be accessed in a different measurement system
    ///
    /// <example>
    /// decimal inches into architectural notation
    /// 
    /// double inches = 14.1875
    /// Distance dm = new Distance(DistanceTypes.Inch, inches);
    /// 
    /// Print(dm.Architectural)
    /// 
    /// ========Output==========
    /// 1'2 3/16"
    /// 
    /// </example>
    /// </summary>
    public partial class Distance : SimpleUnit
    {
        /// <summary>
        /// Zero Constructor
        /// </summary>
        public Distance(EqualityStrategy passedStrategy = null)
            : base(new Inch(), 0, passedStrategy)
        {
        }

        public Distance(IDistanceType distanceType, EqualityStrategy passedStrategy = null)
            : base(distanceType, 1, passedStrategy)
        {
        }

        /// <summary>
        /// The standard Unit Constructor that takes the value and the unit type that describes it.
        /// </summary>
        public Distance(IDistanceType passedDistanceType, double passedInput, EqualityStrategy passedStrategy = null)
            : base(passedDistanceType, passedInput, passedStrategy)
        {
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="passedDistance">Distance objet to copy</param>
        public Distance(Distance passedDistance)
            : base(passedDistance)
        {
        }

        /// <summary>
        /// Accepts any valid architectural string value for input
        /// </summary>
        public Distance(string passedArchitecturalString, EqualityStrategy passedStrategy = null)
            : base(new Inch(), _convertArchitectualStringtoUnit(new Inch(), passedArchitecturalString), passedStrategy)
        {
        }
    }
}
