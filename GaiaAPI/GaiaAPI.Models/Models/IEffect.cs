using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface IEffect
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
