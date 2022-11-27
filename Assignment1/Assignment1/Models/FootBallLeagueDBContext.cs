using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class FootBallLeagueDBContext : DbContext
    {
        public DbSet<FootBallLeague> FootBallLeagues { get;set; }
    }
}