namespace ourakoz.GaiaAPI.Models.Models.Race
{
    public interface ISubRace : IRace
    {
        IRace Race { get; }
    }
}
