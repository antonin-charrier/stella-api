using System;
using ourakoz.GaiaAPI.Models.Models.Enums;
using Type = ourakoz.GaiaAPI.Models.Models.Enums.Type;

namespace ourakoz.GaiaAPI.Models.Models.CardItem
{
    public interface ICardItem
    {
        Guid Id { get; }
        string Name { get; }
        IFaction Faction { get; }
        Category Category { get; }
        Type Type { get; }
        int Level { get; }
        int ManaCost { get; }
        int LifeCost { get; }
    }
}
