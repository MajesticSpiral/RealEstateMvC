using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateMvC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Agent()
		{
			ViewBag.Message = "Your agent page.";

			return View();
		}

		public ActionResult Properties()
		{
			ViewBag.Message = "Your properties page.";

			return View();
		}

		public ActionResult FamilyHomes()
		{
			ViewBag.Message = "Your family homes page.";

			return View();
		}

		public ActionResult Flats()
		{
			ViewBag.Message = "Your flats page.";

			return View();
		}


		public ActionResult Apartments()
		{
			ViewBag.Message = "Your apartments page.";

			return View();
		}

		public ActionResult Studios()
		{
			ViewBag.Message = "Your studios page.";

			return View();
		}

	}
}