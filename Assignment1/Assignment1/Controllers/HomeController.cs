using Assignment1.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private FootBallLeagueDBContext db = new FootBallLeagueDBContext();
        // GET: Home
        public ActionResult AddMatchResult()
        {

            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMatchResult([Bind(Include = "MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootBallLeague ftg)
        {
            if (ModelState.IsValid)
            {
                db.FootBallLeagues.Add(ftg);
                db.SaveChanges();
            }

            return Content("Data Added Successfully!");
        }
    }
}