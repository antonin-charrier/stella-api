using System;

namespace ourakoz.GaiaAPI.Models.Models.Race
{
    public interface IRace
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
