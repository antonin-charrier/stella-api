using System;
using ourakoz.StellaApi.Models.Models;
using ourakoz.StellaApi.Models.Models.CardItem;
using ourakoz.StellaApi.Models.Models.Enums;
using Type = ourakoz.StellaApi.Models.Models.Enums.Type;

namespace ourakoz.StellaApi.Models
{
    /// <inheritdoc />
    /// <summary>
    /// Common base card class
    /// </summary>
    public class CardItem : ICardItem
    {
        internal CardItem() { }

        /// <summary>
        /// Creates a new Card
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="faction"></param>
        /// <param name="type"></param>
        /// <param name="rarity"></param>
        /// <param name="level"></param>
        /// <param name="manaCost"></param>
        /// <param name="lifeCost"></param>
        public CardItem(Guid id = new Guid(), string name = "",
            Category category = Category.Creature, IFaction faction = null, Type type = Type.None,
            Rarity rarity = Rarity.Common, int level = 0, int manaCost = 0, int lifeCost = 0)
        {
            if (id.Equals(Guid.Empty)) throw new ArgumentException("Id must not be empty.");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must not be empty.");

            Id = id;
            Name = name;
            Category = category;
            Faction = faction;
            Type = type;
            Rarity = rarity;
            Level = level;
            ManaCost = manaCost;
            LifeCost = lifeCost;
        }

        /// <inheritdoc />
        /// <summary>
        /// Unique identifier of the card
        /// </summary>
        public Guid Id { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Name of the card
        /// </summary>
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Faction of the card
        /// </summary>
        public IFaction Faction { get; }

        /// <inheritdoc />
        /// <summary>
        /// Category of the card
        /// </summary>
        public Category Category { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Type of the card
        /// </summary>
        public Type Type { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Rarity of the card
        /// </summary>
        public Rarity Rarity { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Level of the card
        /// </summary>
        public int Level { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Mana cost of the card
        /// </summary>
        public int ManaCost { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Life cost of the card
        /// </summary>
        public int LifeCost { get; set; }
    }
}
