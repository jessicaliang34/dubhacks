using EFGetStarted.AspNetCore.NewDb.ClassesWeNeed;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
	public class PlansFormsController : Controller
	{
		private readonly BloggingContext _context;

		public PlansFormsController(BloggingContext context)
		{
			_context = context;
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
			string[] listOfAllNames = allNames.Split(',');
			var planName = model.PlanName;
			foreach (var name in listOfAllNames)
			{
				var newPlan = new UserPlans
				{
					Id = name,
					PlanName = planName
				};
				_context.UserPlans.Add(newPlan);
				_context.SaveChanges();
			}
			return View(model);
		}

		[HttpGet]
		public IActionResult UpdatePlan()
		{
			//var model = new UpdatePlanModel();
			//model.PlanId = //parseplanId
			//model.Username = //parsename

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
	}
}
