using MeetNEat.Data;
using MeetNEat.Models;
using MeetNEat.TableClasses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.Controllers
{

	public class FormsController : Controller
	{
		static ApplicationDbContext _context;
		List<string> cuisines = new List<string>() { "Korean", "Thai", "Taiwanese", "Japanese", "American", "Italian" };

		public FormsController(ApplicationDbContext context)
		{
			_context = context;
		}
		PlansFunctions plansFunctions = new PlansFunctions(_context);
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult CreateNewPlan()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateNewPlan(CreateNewPlanModel model)
		{
			var allNames = model.AllUsernames;
			//string[] listOfAllNames = allNames.Split(',');
			var planName = model.PlanName;
			var newPlan = new PlansForUserToUpdate
			{
				Id = Guid.NewGuid(),
				UserName = allNames,
				Price = allNames,
				PlanName = planName
			};
			_context.PlansForUserToUpdate.Add(newPlan);
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

		[HttpPost]
		public ActionResult UpdatePlan(UpdatePlanModel model)
		{
			var plan = getPlan(model.planName, model.username);
			if (plan != null)
			{
				//var allDates = model.Date;
				//allDates.ForEach(x => x.ToString());//turn it into json object instead
				//var allDatesString = String.Join(",", allDates);
				//plan.AllDates = allDatesString;
				plan.StartTime = model.StartTime.ToString();
				plan.EndTime = model.EndTime.ToString();
				plan.City = model.City;
				plan.Price = model.Price;

				//var allCusines = model.Cuisine;
			}

			return View();
		}

		public PlansForUserToUpdate getPlan(string planName, string username)
		{
			var data = _context.PlansForUserToUpdate.ToList();
			var plan = data.Where(x => x.PlanName == planName && x.UserName == username).FirstOrDefault();
			return plan;
		}

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
