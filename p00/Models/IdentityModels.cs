﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using p00.Models;

namespace WebApplication2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string  AccountType { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)

        {
        }
       
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<p00.Models.Sections> Sections { get; set; }

        public System.Data.Entity.DbSet<p00.Models.Topics> Topics { get; set; }

        public System.Data.Entity.DbSet<p00.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<p00.Models.CommitHees> CommitHees { get; set; }

        public System.Data.Entity.DbSet<p00.Models.CommHee> CommHees { get; set; }

        public System.Data.Entity.DbSet<p00.Models.CommHeeMembers> CommHeeMembers { get; set; }
        public System.Data.Entity.DbSet<p00.Models.EvaluationForm> EvaluationForm { get; set; }
        public System.Data.Entity.DbSet<p00.Models.SectionstoTopics> SectionstoTopics { get; set; }
        public System.Data.Entity.DbSet<p00.Models.EvaluaationFormtoSections> EvaluaationFormtoSections { get; set; }

        public System.Data.Entity.DbSet<p00.Models.TopicEV> TopicEVs { get; set; }

        public System.Data.Entity.DbSet<p00.Models.Document> Documents { get; set; }

        public System.Data.Entity.DbSet<p00.Models.Notification> Notifications { get; set; }
        public System.Data.Entity.DbSet<p00.Models.UserToTeacher> UserToTeachers { get; set; }
    }
}