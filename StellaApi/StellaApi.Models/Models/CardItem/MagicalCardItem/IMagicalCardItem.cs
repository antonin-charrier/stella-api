using ourakoz.StellaApi.Models.Models.Enums;

namespace ourakoz.StellaApi.Models.Models.CardItem.MagicalCardItem
{
    public interface IMagicalCardItem : ICardItem
    {
        IEffect Effect { get; }
        MagicalCardType MagicalCardType { get; }
    }
}
