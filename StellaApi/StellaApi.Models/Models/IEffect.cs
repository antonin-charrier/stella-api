using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IEffect
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
