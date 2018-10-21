using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.ClassesWeNeed
{
    public class OptimalPlan
    {
		
			public string Id{ get; set; }
			public DateTime? Date { get; set; }
			public DateTime? StartDate { get; set; }
			public DateTime? EndDate { get; set; }
			public string Cuisine { get; set; }
			public string CityName { get; set; }
			public string Price { get; set; }
	
	}
}
