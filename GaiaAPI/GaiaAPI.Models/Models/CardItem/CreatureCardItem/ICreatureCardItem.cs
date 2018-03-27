using ourakoz.GaiaAPI.Models.Models.Enums;
using ourakoz.GaiaAPI.Models.Models.Race;

namespace ourakoz.GaiaAPI.Models.Models.CardItem.CreatureCardItem
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
