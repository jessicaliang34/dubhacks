using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class UpdatePlanModel
    {
		[Display(Name = "Plan Name")]
		public string planId { get; set; }
		[Display(Name = "Username")]
		public string username { get; set; }
		
		public List<DateTime?> Date { get; set; }
		[Display(Name = "StartDate")]
		public DateTime? StartDate { get; set; }
		[Display(Name = "EndDate")]
		public DateTime? EndDate { get; set; }
		[Display(Name = "Cuisine")]
		public List<bool> Cuisine { get; set; }
		[Display(Name = "CityName")]
		public string CityName { get; set; }
		[Display(Name = "Price")]
		public string Price { get; set; }
	}
}
