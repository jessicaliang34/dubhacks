﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNEat.Models
{
    public class LoginModel
    {
		[Required]
		[Display(Name = "Login")]
		public string Username { get; set; }
		[Required]
		[Display(Name = "Password")]
		public string Password { get; set; }
	}
}
