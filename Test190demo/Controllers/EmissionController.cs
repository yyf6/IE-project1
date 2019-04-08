using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IDAL;
using Test190demo.Models;

namespace Test190demo.Controllers
{
    public class EmissionController : Controller
    {
        EmissionService emissionService = new EmissionService();
        // GET: Emission
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Emission model)
        {
            //emissionService.Add(model.report_id, model.facility_id);
            return View();
        }
    }
}