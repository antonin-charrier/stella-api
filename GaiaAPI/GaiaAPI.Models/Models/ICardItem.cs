using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface ICardItem
    {
        Guid Id { get; }
        string Name { get; set; }
        IFaction Faction { get; set; }
        IRace Race { get; set; }
        ISubRace SubRace { get; set; }
    }
}
