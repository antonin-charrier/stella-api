using System;

namespace ourakoz.GaiaAPI.Models
{
    public class CardItem
    {
        public CardItem(Guid id, string name)
        {
            if (id.Equals(Guid.Empty)) throw new ArgumentException("Id must not be empty.");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name must not be empty.");

            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
