namespace ourakoz.StellaApi.Models.Models.Race
{
    public interface ISubRace : IRace
    {
        IRace Race { get; }
    }
}
