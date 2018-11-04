using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.TableClasses
{
    public class FinalOptimalPlans
    {
		public Guid Id { get; set; }
		public string PlanName { get; set; }
		public DateTime? Date { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? EndTime { get; set; }
		public string Cuisine { get; set; }
		public string CityName { get; set; }
		public string Price { get; set; }
	}
}
