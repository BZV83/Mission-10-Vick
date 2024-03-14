namespace Mission_10_Vick_FINAL.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> GetBowlersWithTeams();
    }
}
