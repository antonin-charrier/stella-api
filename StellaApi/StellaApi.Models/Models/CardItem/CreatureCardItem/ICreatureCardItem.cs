using ourakoz.StellaApi.Models.Models.Enums;
using ourakoz.StellaApi.Models.Models.Race;

namespace ourakoz.StellaApi.Models.Models.CardItem.CreatureCardItem
{
    public interface ICreatureCardItem : ICardItem
    {
        IRace Race { get; }
        ISubRace SubRace { get; }
        Rarity Rarity { get; }
        IAbility Ability { get; }
        int AttackPower { get; }
        int LifePoints { get; }
    }
}
