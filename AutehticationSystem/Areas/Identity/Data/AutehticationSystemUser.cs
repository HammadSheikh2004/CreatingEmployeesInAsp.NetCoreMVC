using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AutehticationSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AutehticationSystemUser class
public class AutehticationSystemUser : IdentityUser
{
    [Required]
    public string Name { get; set; }
    public string ImagePath { get; set; } = "";

}

