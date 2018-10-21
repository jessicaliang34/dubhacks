//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EFGetStarted.AspNetCore.NewDb.Controllers
//{
//	public class PlansFormsController : Controller
//	{
//		[HttpGet]
//		public ActionResult NewPlan()
//		{
//			return View();
//		}

//		[HttpPost]
//		public ActionResult NewPlan(NewPlanModel model)
//		{
//			var allNames = model.AllUsernames;
//			var listOfAllNames = allNames.Split(',');
//			var planName = model.PlanName;
//			foreach (var name in listOfAllNames)
//			{
//				createNewPlan(planName, name);
//			}

//			return View(ViewAllPlans);
//		}

//		[HttpGet]
//		public ActionResult UpdatePlan()
//		{
//			var model = new UpdatePlanModel();
//			model.PlanId = //parseplanId
//			model.Username = //parsename

//				return View(model);
//		}

//		[HttpPost]
//		public ActionResult UpdatePlan(UpdatePlanModel model)
//		{
//			var plan = getPlan(model.planId, model.username);
//			var allDates = model.Date;
//			allDates.ForEach(x => x.ToString());
//			var allDatesString = String.Join(",", allDates);
//			plan.date = allDatesString;

//			plan.startDate = model.StartDate;
//			plan.endDate = model.EndDate;
//			plan.city = model.CityName;
//			plan.price = model.Price;

//			var allCusines = model.Cuisine;
//			//set cusines only true ones

//			return View(ViewAllUsers);
//		}

//		[HttpGet]
//		public ActionResult ViewAllPlans()
//		{
//			var user = getallplans;//somehow extract user
//			var model = new ViewAllPlansModel();
//			model.UserPlans = getAllUserPlans(user);

//			return View(model);
//		}
//	}
//}
