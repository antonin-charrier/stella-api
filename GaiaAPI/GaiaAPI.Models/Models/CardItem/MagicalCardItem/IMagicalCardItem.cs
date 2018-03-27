using ourakoz.GaiaAPI.Models.Models.Enums;

namespace ourakoz.GaiaAPI.Models.Models.CardItem.MagicalCardItem
{
    public interface IMagicalCardItem : ICardItem
    {
        IEffect Effect { get; }
        MagicalCardType MagicalCardType { get; }
    }
}
