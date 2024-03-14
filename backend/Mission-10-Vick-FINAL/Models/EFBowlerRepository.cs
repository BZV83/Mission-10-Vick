using Microsoft.EntityFrameworkCore;

namespace Mission_10_Vick_FINAL.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> GetBowlersWithTeams()
        {
            return _context.Bowlers
                .Where(b => b.Team.TeamName == "Sharks" || b.Team.TeamName == "Marlins")
                .Include(b => b.Team).ToList();
        }
    }
}
