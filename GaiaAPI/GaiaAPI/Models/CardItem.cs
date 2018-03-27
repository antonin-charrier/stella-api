using System;
using ourakoz.GaiaAPI.Models.Models;
using ourakoz.GaiaAPI.Models.Models.CardItem;
using ourakoz.GaiaAPI.Models.Models.Enums;
using Type = ourakoz.GaiaAPI.Models.Models.Enums.Type;

namespace ourakoz.GaiaAPI.Models
{
    public class CardItem : ICardItem
    {
        public CardItem() { }

        public CardItem(Guid id, string name)
        {
            if (id.Equals(Guid.Empty)) throw new ArgumentException("Id must not be empty.");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must not be empty.");

            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; }
        public IFaction Faction { get; }
        public Category Category { get; }
        public Type Type { get; }
        public int Level { get; }
        public int ManaCost { get; }
        public int LifeCost { get; }
    }
}
