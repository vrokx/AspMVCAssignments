using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        FootBallLeagueDBEntities db = new FootBallLeagueDBEntities();
        // GET: Home
        public ActionResult DBFirst()
        {
            var data = db.FootBallLeagues.ToList();
            return PartialView(data);
        }
    }
}