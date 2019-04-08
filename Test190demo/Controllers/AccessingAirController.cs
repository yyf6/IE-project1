using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test190demo.Models;
using BLL;

namespace Test190demo.Controllers
{
    public class AccessingAirController : Controller
    {
        public static List<string> CarReportResult { get; set; }
        public static List<string> BedReportResult { get; set; }
        public static List<string> BedRefResult { get; set; }
        public static List<string> KitReportResult { get; set; }
        public CarSAService carSAService { get; set; }
        public BedSAService bedSAService { get; set; }
        public KitchSAService kitchSAService { get; set; }
        // GET: AccessingAir
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BedRoomSA()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BedRoomSA(BedSA bedSA)
        {
            bedSAService = new BedSAService();
            BedReportResult = bedSAService.BedAss(bedSA.OpenWindow.ToString(),
                                bedSA.Mould.ToString(),
                                bedSA.Plants.ToString(),
                                bedSA.Smoke.ToString(),
                                bedSA.Carpet.ToString());

            BedRefResult = bedSAService.BedRef(bedSA.Mould.ToString(),
                                               bedSA.Plants.ToString(),
                                               bedSA.Smoke.ToString(),
                                               bedSA.Carpet.ToString());
            return RedirectToAction("BedRoomReport");
        }
        [HttpGet]
        public ActionResult BedRoomReport()
        {
            ViewBag.OpenWindow = BedReportResult[0];
            ViewBag.Mould = BedReportResult[1];
            ViewBag.Plants = BedReportResult[2];
            ViewBag.Smoke = BedReportResult[3];
            ViewBag.Carpet = BedReportResult[4];

            ViewBag.RefMould = BedRefResult[0];
            ViewBag.RefPlants = BedRefResult[1];
            ViewBag.RefSmoke = BedRefResult[2];
            ViewBag.RefCarpet = BedRefResult[3];
            return View();
        }

        [HttpGet]
        public ActionResult CarSA()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CarSA(CarSA model)
        {
            List<string> result = new List<string>();
            carSAService = new CarSAService();
            result = carSAService.CarAss(model.CarStatus.ToString(),
                                model.UpholsteryChanging.ToString(),
                                model.Vents.ToString(),
                                model.StuckCondition.ToString(),
                                model.ParkPlace.ToString());
            CarReportResult = result;

            return RedirectToAction("CarReport");
        }

        public ActionResult CarReport()
        {
            if (CarReportResult != null)
            {
                ViewBag.CarStatus = CarReportResult[0];
                ViewBag.UpholsteryChanging = CarReportResult[1];
                ViewBag.Vents = CarReportResult[2];
                ViewBag.StuckCondition = CarReportResult[3];
                if (CarReportResult.Count == 5)
                {
                    ViewBag.ParkPlace = CarReportResult[4];
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult KitchenSA()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KitchenSA(KitchSA kitchSA)
        {
            kitchSAService = new KitchSAService();
            KitReportResult = kitchSAService.KitAss(kitchSA.RangeHood.ToString(),
                                  kitchSA.Heat.ToString(),
                                  kitchSA.Aerosol.ToString());
            return RedirectToAction("KitchenReport");
        }

        [HttpGet]
        public ActionResult KitchenReport()
        {
            ViewBag.RangeHood = KitReportResult[0];
            ViewBag.Heat = KitReportResult[1];
            ViewBag.Aerosol = KitReportResult[2];
            return View();
        }
    }
}