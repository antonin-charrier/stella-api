using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IFaction
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
