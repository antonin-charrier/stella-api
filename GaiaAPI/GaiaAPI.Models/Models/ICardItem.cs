using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface ICardItem
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
