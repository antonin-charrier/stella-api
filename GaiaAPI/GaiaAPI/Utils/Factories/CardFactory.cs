using System;
using ourakoz.GaiaAPI.Models;
using ourakoz.GaiaAPI.Models.Models;
using ourakoz.GaiaAPI.Models.Models.CardItem;
using ourakoz.GaiaAPI.Models.Models.CardItem.CreatureCardItem;
using ourakoz.GaiaAPI.Models.Models.CardItem.MagicalCardItem;
using ourakoz.GaiaAPI.Models.Models.Enums;
using ourakoz.GaiaAPI.Models.Models.Factories;
using Type = ourakoz.GaiaAPI.Models.Models.Enums.Type;

namespace ourakoz.GaiaAPI.Utils.Factories
{
    /// <inheritdoc />
    /// <summary>
    /// Common base card factory
    /// </summary>
    public class CardFactory : ICardFactory
    {
        /// <inheritdoc />
        /// <summary>
        /// Creates a new ICardItem
        /// </summary>
        public ICardItem CreateCardItem(Guid id, string name, Category category, IFaction faction, Type type, Rarity rarity,
            int level, int manaCost, int lifeCost) => new CardItem(id, name, category, faction, type, rarity, level, manaCost, lifeCost);

        /// <inheritdoc />
        /// <summary>
        /// Creates a new ICreatureCardItem
        /// </summary>
        public ICreatureCardItem CreateCreatureCardItem()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new IMagicalCardItem
        /// </summary>
        public IMagicalCardItem CreateMagicalCardItem()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new IEquipmentMagicalCardItem
        /// </summary>
        public IEquipmentMagicalCardItem CreateEquipmentMagicalCardItem()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new IEnvironmentMagicalCardItem
        /// </summary>
        public IEnvironmentMagicalCardItem CreateEnvironmentMagicalCardItem()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new ICounterMagicalCardItem
        /// </summary>
        public ICounterMagicalCardItem CreateCounterMagicalCardItem()
        {
            throw new System.NotImplementedException();
        }
    }
}
