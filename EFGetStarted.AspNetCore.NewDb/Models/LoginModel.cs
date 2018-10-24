using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class LoginModel
    {
		[Required]
		[Display(Name = "Login")]
		public string Username { get; set; }
		[Required]
		[Display(Name = "Password")]
		public string Login { get; set; }
	}
}
