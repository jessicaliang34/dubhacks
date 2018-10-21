using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.ClassesWeNeed
{
	public class RestaurantInfo
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Cuisine { get; set; }
		public string Price { get; set; }
	}
}
