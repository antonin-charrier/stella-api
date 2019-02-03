using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IEffect
    {
        /// <summary>
        /// Unique identifier of the effect
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the effect
        /// </summary>
        string Name { get; set; }
    }
}
