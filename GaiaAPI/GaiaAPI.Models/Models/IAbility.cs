using System;

namespace ourakoz.GaiaAPI.Models.Models
{
    public interface IAbility
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
