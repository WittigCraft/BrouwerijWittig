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
        // CREATE
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(string productName, decimal price, string origin, decimal alcoholPercentage, decimal content)
        {

            bool createSuccessful = Beers.Create(productName, price, origin, alcoholPercentage, content);
            if (createSuccessful)
            {
                ViewBag.Feedback = "Beer created successfully!";
                
            }
            else
            {
                ViewBag.Feedback = "Error creating beer.";
                
            }
            return View();
        }


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