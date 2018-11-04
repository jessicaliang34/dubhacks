using System;
using System.Collections.Generic;
using System.Text;
using MeetNEat.TableClasses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeetNEat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{ }
		public DbSet<FinalOptimalPlans> FinalOptimalPlans { get; set; }
		public DbSet<PlansForUserToUpdate> PlansForUserToUpdate { get; set; }

	}
}
