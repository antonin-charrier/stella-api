namespace ourakoz.GaiaAPI.Models.Models
{
    public interface ISubRace : IRace
    {
        IRace Race { get; }
    }
}
