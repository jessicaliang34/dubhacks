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
<<<<<<< HEAD
		[Display(Name = "Username")]
		public string username { get; set; }
		
		public List<DateTime?> Date { get; set; }
		[Display(Name = "StartDate")]
		public DateTime? StartDate { get; set; }
		[Display(Name = "EndDate")]
=======

		[Display(Name = "Username")]
		public string username { get; set; }

		[Display(Name = "Date")]
		public List<DateTime?> Date { get; set; }

		[Display(Name = "Start Time")]
		public DateTime? StartDate { get; set; }

		[Display(Name = "End Time")]
>>>>>>> 77e79b4
		public DateTime? EndDate { get; set; }
		[Display(Name = "Cuisine")]
		public List<bool> Cuisine { get; set; }
<<<<<<< HEAD
		[Display(Name = "CityName")]
		public string CityName { get; set; }
		[Display(Name = "Price")]
=======

		[Display(Name = "City Preferred")]
		public string CityName { get; set; }

		[Display(Name = "Price Preferance")]
>>>>>>> 77e79b4
		public string Price { get; set; }
	}
}
