using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.TableClasses
{
    public class PlansForUserToUpdate
    {
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string PlanName { get; set; }
		public string AllDates { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
		public string Cuisines { get; set; }
		public string Price { get; set; }
		public string City { get; set; }
	}
}
