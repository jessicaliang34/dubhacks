using EFGetStarted.AspNetCore.NewDb.ClassesWeNeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class ViewAllPlansModel
    {
		public string AllUsernames { get; set; }
		public string PlanName { get; set; }
		public List<OptimalPlan> UserPlans { get; set; }
	}
}
