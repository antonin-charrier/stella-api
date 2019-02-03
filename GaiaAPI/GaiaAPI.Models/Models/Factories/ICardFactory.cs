using System;
using ourakoz.GaiaAPI.Models.Models.CardItem;
using ourakoz.GaiaAPI.Models.Models.CardItem.CreatureCardItem;
using ourakoz.GaiaAPI.Models.Models.CardItem.MagicalCardItem;
using ourakoz.GaiaAPI.Models.Models.Enums;
using Type = ourakoz.GaiaAPI.Models.Models.Enums.Type;

namespace ourakoz.GaiaAPI.Models.Models.Factories
{
    /// <summary>
    /// Defines the common card factory specification
    /// </summary>
    public interface ICardFactory
    {
        /// <summary>
        /// Creates a new ICardItem
        /// </summary>
        ICardItem CreateCardItem(Guid id, string name, Category category, IFaction faction, Type type, Rarity rarity, int level, int manaCost, int lifeCost);

        /// <summary>
        /// Creates a new ICreatureCardItem
        /// </summary>
        ICreatureCardItem CreateCreatureCardItem();

        /// <summary>
        /// Creates a new IMagicalCardItem
        /// </summary>
        IMagicalCardItem CreateMagicalCardItem();

        /// <summary>
        /// Creates a new IEquipmentMagicalCardItem
        /// </summary>
        IEquipmentMagicalCardItem CreateEquipmentMagicalCardItem();

        /// <summary>
        /// Creates a new IEnvironmentMagicalCardItem
        /// </summary>
        IEnvironmentMagicalCardItem CreateEnvironmentMagicalCardItem();

        /// <summary>
        /// Creates a new ICounterMagicalCardItem
        /// </summary>
        ICounterMagicalCardItem CreateCounterMagicalCardItem();
    }
}
