using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_Project.Models
{
    public partial class MVCContext : DbContext
    {
        public MVCContext()
            : base("name=MVCContext1")
        {
        }

        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
