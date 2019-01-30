using System;
using ourakoz.StellaApi.Models.Models.Enums;
using Type = ourakoz.StellaApi.Models.Models.Enums.Type;

namespace ourakoz.StellaApi.Models.Models.CardItem
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
