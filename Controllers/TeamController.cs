using Microsoft.AspNetCore.Mvc;
using SoccerTeamTracker.Data;

namespace SoccerTeamTracker.Controllers
{
    public class TeamController : Controller
    {
        private DataContext __dataContext;

        public TeamController(DataContext dataContext)
        {
            __dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var teams = __dataContext.Teams.ToList();

            return View(teams);
        }

    }
}
