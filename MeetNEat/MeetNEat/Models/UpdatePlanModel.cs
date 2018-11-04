using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.Models
{
    public class UpdatePlanModel
    {
		[Display(Name = "Plan Name")]
		public string planName { get; set; }

		[Display(Name = "Username")]
		public string username { get; set; }

		[Display(Name = "Date")]
		public List<DateTime?> Date { get; set; }

		[Display(Name = "Start Time")]
		public DateTime? StartTime { get; set; }

		[Display(Name = "End Time")]
		public DateTime? EndTime { get; set; }
		public List<bool> Cuisine { get; set; }

		[Display(Name = "City Preferred")]
		public string City { get; set; }

		[Display(Name = "Price Preferance")]
		public string Price { get; set; }
	}
}
