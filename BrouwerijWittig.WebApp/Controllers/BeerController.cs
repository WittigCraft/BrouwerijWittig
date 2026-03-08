using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrouwerijWittig.Bll;
using BrouwerijWittig.Entities;

namespace BrouwerijWittig.WebApp.Controllers
{
    public class BeerController : Controller
    {




        // READ ALL
        public ActionResult Index()
        {
            /*  List<Beer> lstBeers = new List<Beer>()
              {
                  new Beer("Duvel", 6m, "Belgium",8.5m, 30m),
                  new Beer("Jupiler", 3.5m, "Belgium", 5.2m, 25m),
              };*/
            List<Beer> lstBeers = Beers.Read();
            return View(lstBeers);
        }


        // READ SINGLE
        public ActionResult Details(Guid id)
        {
                Beer b = Beers.Read(id);
            return View(b);
        }

    }
}