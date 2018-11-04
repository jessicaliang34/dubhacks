////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Threading.Tasks;
////using MeetNEat.Data;
////using MeetNEat.TableClasses;
////using Microsoft.AspNetCore.Mvc;

////namespace MeetNEat.Controllers
////{
////	public class PlansController : Controller
////	{



////		private readonly ApplicationDbContext _context;

////		public PlansController(ApplicationDbContext context)
////		{
////			_context = context;
////		}

////		public PlansForUserToUpdate getPlan(string planId, string username)
////		{
////			UserPlans userPlans = _context.UserPlans.Find(username);

////		}

////		public List<OptimalPlan> getAllUserPlans(string username) { }

////		public ActionResult addPlanToUser(string planId, string username)
////		{
////			set finalPlanId = the planId we need
////					}

////		public OptimalPlan findOptimalPlan(string planId)
////		{
////			var cuisine = findOptimalCuisine(planId);
////			var date = findOptimalDate(planId);
////			var startDate = findOptimalStartDate(planId);
////			var endDate = findOptimalEndDate(planId);
////			var price = findOptimalPrice(planId);
////			var city = findOptimalCity(planId);

////			var goodPlan = new OptimalPlan
////			{
////				Cuisine = cuisine,
////				Date = date,
////				StartDate = startDate,
////				EndDate = endDate,
////				Price = price,
////				CityName = city
////			};
////			return goodPlan;
////		}

////		public List<OptimalPlan> getOptimalPlans(string planId)
////		{
////			var goodPlan = findOptimalPlan(planId);
////			var plans = new List<OptimalPlan>();
////		}



////		public string findOptimalCuisine(string planId) { }
////		public DateTime findOptimalDate(string planId) { }
////		public DateTime findOptimalStartDate(string planId) { }
////		public DateTime findOptimalEndDate(string planId) { }
////		public string findOptimalCity(string planId) { }
////		public string findOptimalPrice(string planId) { }
////	}
////}

////public IActionResult Index()
////{
////	return View();
////}
////    }
////}
