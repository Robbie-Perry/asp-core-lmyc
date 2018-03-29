using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LmycWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace asp_core_lmyc.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public string SailingExperience { get; set; }

        public List<Boat> Boats { get; set; }
    }
}
