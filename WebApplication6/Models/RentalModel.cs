namespace WebApplication6.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RentalModel : DbContext
    {
        public RentalModel()
            : base("name=PostgreSQLConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<WebApplication6.Models.Language> Languages { get; set; }
        public System.Data.Entity.DbSet<WebApplication6.Models.Film> Films { get; set; }
    }
}