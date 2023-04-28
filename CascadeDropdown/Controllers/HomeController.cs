using CascadeDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDropdown.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			List<FormModel> lstState = new List<FormModel>()
			{
				new FormModel(){StateId = 1, StateName = "Jharkhand"},
				new FormModel(){StateId = 2, StateName = "Maharashtra"}
			};
			

			ViewBag.StateList = new SelectList(lstState, "StateId", "StateName");
			
			return View();
		}

		public JsonResult GetDistrictList(int StateId)
		{
			List<FormModel> lstDistrict = new List<FormModel>()
			{
				new FormModel(){DistrictId = 1, DistrictName = "Dumka"},
				new FormModel(){DistrictId = 1, DistrictName = "Ranchi"},
				new FormModel(){DistrictId = 2, DistrictName = "Mumbai"},
				new FormModel(){DistrictId = 2, DistrictName = "Pune"}
			};

			List<FormModel> lstNew = new List<FormModel>();

			lstNew = lstDistrict.Where(x => x.DistrictId == StateId).ToList();
			return Json(lstNew, JsonRequestBehavior.AllowGet);

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
	}
}