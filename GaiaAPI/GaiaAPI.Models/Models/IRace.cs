using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface IRace
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
