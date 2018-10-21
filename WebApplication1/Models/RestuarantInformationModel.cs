using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class RestuarantInformationModel
	{
		string UserName { get; set; }

		string PlanName { get; set; }

		DateTime AvailableDate { get; set; }

		List<bool> Cuisines { get; set; }

		DateTime StartTime { get; set; }

		DateTime EndTime { get; set; }

		string Price { get; set; }

		string CityName { get; set; }

    }
}
