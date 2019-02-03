using ourakoz.StellaApi.Models.Models.Enums;
using ourakoz.StellaApi.Models.Models.Race;

namespace ourakoz.StellaApi.Models.Models.CardItem.CreatureCardItem
{
    public interface ICreatureCardItem : ICardItem
    {
        /// <summary>
        /// Race of the creature
        /// </summary>
        IRace Race { get; }

        /// <summary>
        /// Sub race of the creature
        /// </summary>
        ISubRace SubRace { get; }

        /// <summary>
        /// Ability of the creature
        /// </summary>
        IAbility Ability { get; }

        /// <summary>
        /// Attack power of the creature
        /// </summary>
        int AttackPower { get; }

        /// <summary>
        /// Life points of the creature
        /// </summary>
        int LifePoints { get; }
    }
}
