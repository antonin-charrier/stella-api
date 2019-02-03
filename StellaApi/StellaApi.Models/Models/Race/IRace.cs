using System;

namespace ourakoz.StellaApi.Models.Models.Race
{
    public interface IRace
    {
        /// <summary>
        /// Unique identifier of the race
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the race
        /// </summary>
        string Name { get; set; }
    }
}
