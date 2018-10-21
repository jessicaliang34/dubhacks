using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class UpdatePlanModel
    {
		public string planId { get; set; }
		public string username { get; set; }
		public List<DateTime?> Date { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public List<bool> Cuisine { get; set; }
		public string CityName { get; set; }
		public string Price { get; set; }
	}
}
