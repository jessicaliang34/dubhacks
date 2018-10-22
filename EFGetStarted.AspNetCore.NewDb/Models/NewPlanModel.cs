using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EFGetStarted.AspNetCore.NewDb.ClassesWeNeed;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class NewPlanModel
    {
		[Required]
		[Display(Name = "All Usernames")]
		public string AllUsernames { get; set; }
		[Required]
		[Display(Name = "Plan Name")]
		public string PlanName { get; set; }
	}
}
