using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitClassLibrary
{
    /// <summary>
    /// delegate that defines the form of 
    /// </summary>
    /// <param name="mass1"></param>
    /// <param name="mass2"></param>
    /// <returns></returns>
    public delegate bool MassEqualityStrategy(Mass mass1, Mass mass2);

    public partial class Mass
    {
        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality deviation
        /// </summary>
        public bool EqualsWithinDeviationConstant(Mass mass, Mass passedAcceptedEqualityDeviationMass)
        {
            return (Math.Abs(
                (this.GetValue(this._internalUnitType)
                - ((Mass)(mass)).GetValue(this._internalUnitType))
                ))
                <= passedAcceptedEqualityDeviationMass.GetValue(_internalUnitType);
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinDeviationPercentage(Mass mass, double passedAcceptedEqualityDeviationPercentage)
        {
            return (Math.Abs(this.GetValue(this.InternalUnitType) - (mass).GetValue(this.InternalUnitType))) <= this.GetValue(this.InternalUnitType) * passedAcceptedEqualityDeviationPercentage;
        }

        /// <summary>
        /// value comparison, checks whether the two are equal within a passed accepted equality percentage
        /// </summary>
        public bool EqualsWithinMassEqualityStrategy(Mass mass, MassEqualityStrategy passedStrategy)
        {
            return passedStrategy(this, mass);
        }
    }

    public static partial class DeviationDefaults
    {
        public static Mass AcceptedEqualityDeviationMass
        {
            get
            {
                return new Mass(MassType.Milligrams, 1);
            }
        }

        public static double AcceptedEqualityDeviationMassPercentage
        {
            get
            {
                return 0.00001;
            }
        }
    }

    public static class MassEqualityStrategyImplementations
    {
        /// <summary>
        /// Masses are equal if they differ by less than a percentage of the first Mass
        /// </summary>
        /// <param name="mass1">first Mass being compared</param>
        /// <param name="mass2">second Mass being compared</param>
        /// <returns></returns>
        public static bool DefaultPercentageEquality(Mass mass1, Mass mass2)
        {
            return (Math.Abs(mass1.GetValue(mass1.InternalUnitType) - (mass2).GetValue(mass1.InternalUnitType))) <= Math.Abs(mass1.GetValue(mass1.InternalUnitType) * DeviationDefaults.AcceptedEqualityDeviationMassPercentage);
        }

        /// <summary>
        /// Masses are equal if there values are within the passed deviation constant. If they are not within the constant
        /// </summary>
        /// <param name="mass1">first Mass being compared</param>
        /// <param name="mass2">second Mass being compared</param>
        /// <returns></returns>
        public static bool DefaultConstantEquality(Mass mass1, Mass mass2)
        {
            return (Math.Abs(mass1.GetValue(mass1.InternalUnitType) - (mass2).GetValue(mass1.InternalUnitType))) <= DeviationDefaults.AcceptedEqualityDeviationMass.GetValue(mass1.InternalUnitType);
        }
    }
}
