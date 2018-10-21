using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.ClassesWeNeed
{
    public class UserPlans
    {
		public string Id { get; set; }
		public string planName { get; set; }
		public string allDates { get; set; }
		public string startTime { get; set; }
		public string endTime { get; set; }
		public string cuisines { get; set; }
		public string price { get; set; }
		public string city { get; set; }
	}
}
