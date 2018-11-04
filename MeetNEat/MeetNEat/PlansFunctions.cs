using MeetNEat.Data;
using MeetNEat.TableClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat
{
    public class PlansFunctions
	{
		private readonly ApplicationDbContext _context;

		public PlansFunctions(ApplicationDbContext context)
		{
			_context = context;
		}

		public PlansForUserToUpdate getPlan(string planName, string username)
		{
			var data = _context.PlansForUserToUpdate.ToList();
			var plan = data.Where(x => x.PlanName == planName && x.UserName == username).FirstOrDefault();
			return plan;
		}

		//		public List<OptimalPlan> getAllUserPlans(string username) { }

		//		public ActionResult addPlanToUser(string planId, string username)
		//		{
		//			set finalPlanId = the planId we need
		//			}

		//		public OptimalPlan findOptimalPlan(string planId)
		//		{
		//			var cuisine = findOptimalCuisine(planId);
		//			var date = findOptimalDate(planId);
		//			var startDate = findOptimalStartDate(planId);
		//			var endDate = findOptimalEndDate(planId);
		//			var price = findOptimalPrice(planId);
		//			var city = findOptimalCity(planId);

		//			var goodPlan = new OptimalPlan
		//			{
		//				Cuisine = cuisine,
		//				Date = date,
		//				StartDate = startDate,
		//				EndDate = endDate,
		//				Price = price,
		//				CityName = city
		//			};
		//			return goodPlan;
		//		}

		//		public List<OptimalPlan> getOptimalPlans(string planId)
		//		{
		//			var goodPlan = findOptimalPlan(planId);
		//			var plans = new List<OptimalPlan>();
		//		}



		//		public string findOptimalCuisine(string planId) { }
		//		public DateTime findOptimalDate(string planId) { }
		//		public DateTime findOptimalStartDate(string planId) { }
		//		public DateTime findOptimalEndDate(string planId) { }
		//		public string findOptimalCity(string planId) { }
		//		public string findOptimalPrice(string planId) { }
		//	}
		//}

	}
}
