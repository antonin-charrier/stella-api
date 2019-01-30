using System;

namespace ourakoz.StellaApi.Models.Models.Race
{
    public interface IRace
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
