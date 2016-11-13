﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Database
{
    public class Login
    {
        [Required()]
        public string UserName { get; set; }

        [Required()]
        public string Password { get; set; }

        public bool Valid { get; set; }

        public bool Attempted { get; set; }
    }
}
