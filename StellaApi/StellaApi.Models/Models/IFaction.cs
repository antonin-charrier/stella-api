using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IFaction
    {
        /// <summary>
        /// Unique identifier of the faction
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the faction
        /// </summary>
        string Name { get; set; }
    }
}
