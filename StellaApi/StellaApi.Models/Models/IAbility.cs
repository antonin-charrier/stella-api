using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IAbility
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
