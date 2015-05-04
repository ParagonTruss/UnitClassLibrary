using System.Collections.Generic;

namespace UnitClassLibrary.CompositeUnit
{
    public interface ICompositeUnitType:IUnitType
    {
        List<IUnitType> Numerators { get; }

        List<IUnitType> Denomenators { get; } 
    }
}