using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;
using EFGetStarted.AspNetCore.NewDb.ClassesWeNeed;

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class HomeController : Controller
    {
		private readonly BloggingContext _context;
		List<string> cuisines = new List<string>() { "Korean", "Thai", "Taiwanese", "Japanese", "American", "Italian" };

		public HomeController(BloggingContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public IActionResult NewPlan()
		{
			return View();
		}

		[HttpPost]
		public IActionResult NewPlan(NewPlanModel model)
		{
			var allNames = model.AllUsernames;
			//string[] listOfAllNames = allNames.Split(',');
			var planName = model.PlanName;
			var newPlan = new UserPlans
			{
				Id = allNames,
				price = allNames,
				PlanName = planName
			};
			_context.UserPlans.Add(newPlan);
			_context.SaveChanges();
			return View(model);

			//foreach (var name in listOfAllNames)
			//{
			//	var newPlan = new UserPlans
			//	{
			//		Id = name,
			//		PlanName = planName
			//	};
			//	_context.UserPlans.Add(newPlan);
			//	_context.SaveChanges();
			//}
			//return View(model);
		}

		[HttpGet]
		public IActionResult UpdatePlan()
		{
			//var model = new UpdatePlanModel();
			//model.PlanId = //parseplanId
			//model.Username = //parsename
			ViewBag.Cuisines = cuisines;
			return View();
			
		}

		//[HttpPost]
		//public ActionResult UpdatePlan(UpdatePlanModel model)
		//{
		//	var plan = getPlan(model.planId, model.username);
		//	var allDates = model.Date;
		//	allDates.ForEach(x => x.ToString());
		//	var allDatesString = String.Join(",", allDates);
		//	plan.date = allDatesString;

		//	plan.startDate = model.StartDate;
		//	plan.endDate = model.EndDate;
		//	plan.city = model.CityName;
		//	plan.price = model.Price;

		//	var allCusines = model.Cuisine;
		//	set cusines only true ones

		//	return View(ViewAllUsers);
		//}

		[HttpGet]
		public IActionResult ViewAllPlans()
		{
			//var user = getallplans;//somehow extract user
			//var model = new ViewAllPlansModel();
			//model.UserPlans = getAllUserPlans(user);

			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
