using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

		[Display(Name = "Date")]
		public List<DateTime?> Date { get; set; }

		[Display(Name = "Start Time")]
		public DateTime? StartDate { get; set; }

		[Display(Name = "End Time")]
		public DateTime? EndDate { get; set; }
		public List<bool> Cuisine { get; set; }

		[Display(Name = "City Preferred")]
		public string CityName { get; set; }

		[Display(Name = "Price Preferance")]
		public string Price { get; set; }
	}
}
