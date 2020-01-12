using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVCExportPDF.Models;
using Rotativa.AspNetCore;

namespace CoreMVCExportPDF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult LeagueTable()
        {
            LeagueTable nbaLeague = new LeagueTable();
            nbaLeague.createTableInstance();

            return View(nbaLeague);
        }

        public IActionResult LeaguePDF()
        {
            LeagueTable nbaLeague = new LeagueTable();
            nbaLeague.createTableInstance();


            return new ViewAsPdf("LeagueTable", nbaLeague)
            {
                CustomSwitches = "--footer-center [page]"
            };
        }
    }
}
