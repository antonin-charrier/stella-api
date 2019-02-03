using System;
using ourakoz.StellaApi.Models.Models.Enums;
using Type = ourakoz.StellaApi.Models.Models.Enums.Type;

namespace ourakoz.StellaApi.Models.Models.CardItem
{
    /// <summary>
    /// Defines the common card interface specification
    /// </summary>
    public interface ICardItem
    {
        /// <summary>
        /// Unique identifier of the card
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the card
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Faction of the card
        /// </summary>
        IFaction Faction { get; }

        /// <summary>
        /// Category of the card
        /// </summary>
        Category Category { get; }

        /// <summary>
        /// Type of the card
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Rarity of the card
        /// </summary>
        Rarity Rarity { get; }

        /// <summary>
        /// Level of the card
        /// </summary>
        int Level { get; }

        /// <summary>
        /// Mana cost of the card
        /// </summary>
        int ManaCost { get; }

        /// <summary>
        /// Life cost of the card
        /// </summary>
        int LifeCost { get; }
    }
}
