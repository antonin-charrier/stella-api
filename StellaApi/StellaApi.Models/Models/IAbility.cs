using System;

namespace ourakoz.StellaApi.Models.Models
{
    public interface IAbility
    {
        /// <summary>
        /// Unique identifier of the ability
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the ability
        /// </summary>
        string Name { get; set; }
    }
}
