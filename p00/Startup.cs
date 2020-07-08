using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication2.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication2.Startup))]
namespace WebApplication2
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultRolesAndUsers();
        }
        public void CreateDefaultRolesAndUsers()
        {
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            //IdentityRole role = new IdentityRole();
            //if (!roleManager.RoleExists("admin"))
            //{
            //    role.Name = "admin";
            //    roleManager.Create(role);
            //    ApplicationUser user = new ApplicationUser();
            //    user.UserName = "admin";
            //    user.Email = "admin@email.com";
            //    var Check = userManager.Create(user, "Ad@a!d123");
            //    if (Check.Succeeded)
            //    {
            //        userManager.AddToRole(user.Id, "admin");
            //    }
            //}
        }
    }
}
