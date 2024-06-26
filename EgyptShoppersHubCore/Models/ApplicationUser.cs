﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptShoppersHubCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(20)]
        public string FirstName { get; set; } 
        [MaxLength(20)]
        public string LastName { get; set; }
    }
}
