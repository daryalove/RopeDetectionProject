using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace RopeDetection.Entities.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }
    }
}
