using System.Collections.Generic;

namespace UnitClassLibrary.GenericUnit
{
    public partial class GenericUnit
    {


        public IUnitType GetInternalUnitType()
        {

            return new UnitType(_getUnitTypes(this.numerators), _getUnitTypes(this.denomenators));

        }

        private static List<IUnitType> _getUnitTypes(List<KeyValuePair<double, IUnitType>> list)
        {
            var returnList = new List<IUnitType>();

            foreach (var pair in list)
            {
                returnList.Add(pair.Value);
            }

            return returnList;
        }

        private class UnitType : IUnitType
        {
            private List<IUnitType> numerators = new List<IUnitType>();
            private List<IUnitType> denomenators = new List<IUnitType>();

            public UnitType(List<IUnitType> numerators, List<IUnitType> denomenators)
            {
                this.numerators = numerators;
                this.denomenators = denomenators;
            }

            public double GetConversionFactor()
            {
                var numeratorFactor = 1.0;
                var denomenatorFactor = 1.0;

                foreach (var unitType in numerators)
                {
                    numeratorFactor *= unitType.GetConversionFactor();
                }

                foreach (var unitType in denomenators)
                {
                    denomenatorFactor *= unitType.GetConversionFactor();
                }

                return numeratorFactor / denomenatorFactor;
            }
        }
    }
}
