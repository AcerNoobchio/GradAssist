using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GradAssistASP.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GradAssistASP.DAL
{
    public class GradAssistContext : DbContext
    {
        public GradAssistContext() : base("GradAssistContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        //public DbSet<Student> Courses { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}