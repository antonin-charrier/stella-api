namespace ourakoz.StellaApi.Models.Models.Race
{
    public interface ISubRace : IRace
    {
        /// <summary>
        /// Parent race of the sub race
        /// </summary>
        IRace Race { get; }
    }
}
