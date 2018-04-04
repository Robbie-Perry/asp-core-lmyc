using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp_core_lmyc.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class UserRoleViewModel
    {
        public string RoleId { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        public string UserId { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
