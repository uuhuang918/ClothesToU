﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesToU.Site.Models.UseCases.Login
{
    public class LoginRequest
    {
        public string Account { get; set; }
		public string Password { get; set; }
    }
}