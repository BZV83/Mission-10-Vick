using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission_10_Vick_FINAL.Models;

namespace Mission_10_Vick_FINAL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepo;
        public BowlerController(IBowlerRepository tem)
        {
            _bowlerRepo = tem;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepo.GetBowlersWithTeams();

            return bowlerData;
        }
    }
}
