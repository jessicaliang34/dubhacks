using EFGetStarted.AspNetCore.NewDb.ClassesWeNeed;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
	public class BloggingContext : DbContext
	{
		public BloggingContext(DbContextOptions<BloggingContext> options)
			: base(options)
		{ }

		public DbSet<UserInfo> UserInfo { get; set; }
		public DbSet<RestaurantInfo> RestaurantInfo { get; set; }
		public DbSet <UserPlans> UserPlans { get; set; }
		public DbSet<OptimalPlan> OptimalPlans { get; set; }
	}


}