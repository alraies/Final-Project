using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace p00.Models
{
    public class UserRoles
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Roles")]
        public string RoleId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual RoleViewModel Roles { get; set; }
    }
}