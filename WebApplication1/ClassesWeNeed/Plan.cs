using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Enum;

namespace WebApplication1.ClassesWeNeed
{
    public class Plan
    {
		List<Users> UsersInPlan { get; set; }
		DateTime Date { get; set; }
		Cuisines WhatCuisine { get; set; }
		string CityName { get; set; }
		string Price { get; set; }
	}
}
