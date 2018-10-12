using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpWeb.controllers
{
    public class Schedule : Controller
    {
        public ActionResult Index()
        {
            List<Flight>_flight = new List<Flight>()
                {
                new Flight { Flightcode = "A-705", Depature = "Amsterdam" },
                new Flight { Flightcode = "N-344", Depature = "New York" },
                new Flight { Flightcode = "H-659", Depature = "Hongkong" }
                };
            return View(_flight);
            }
        }

    }