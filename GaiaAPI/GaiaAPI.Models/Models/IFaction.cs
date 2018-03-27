using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface IFaction
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
