using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.Models
{
    public class ViewAllPlansModel
    {
		public string AllUsernames { get; set; }
		public string PlanName { get; set; }
		public DateTime DateSet { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string City { get; set; }
		public string Price { get; set; }
		public List<ViewAllPlansModel> UserPlans { get; set; }
	}
}
