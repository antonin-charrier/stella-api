using ourakoz.StellaApi.Models.Models.Enums;

namespace ourakoz.StellaApi.Models.Models.CardItem.MagicalCardItem
{
    public interface IMagicalCardItem : ICardItem
    {
        /// <summary>
        /// Effect of the magical card
        /// </summary>
        IEffect Effect { get; }

        /// <summary>
        /// Type of the magical card
        /// </summary>
        MagicalCardType MagicalCardType { get; }
    }
}
