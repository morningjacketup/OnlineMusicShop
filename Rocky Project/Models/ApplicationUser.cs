using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky_Project.Models
{
    public class ApplicationUser : IdentityUser
    {

        public String FullName { get; set; }
    }
}
