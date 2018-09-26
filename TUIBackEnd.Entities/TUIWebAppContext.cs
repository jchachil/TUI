using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace TUIBackEnd.Entities
{
    public class TUIWebAppContext : DbContext
    {
        public TUIWebAppContext()
            : base("Name=TUIWebAppContext")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Flight> Flights { get; set; }

        //public DbSet<Test> Tests { get; set; }






        //public DbSet<City> Cities { get; set; }

        //public DbSet<Student> Students { get; set; }




        public override int SaveChanges()
        {
            //var modifiedEntries = ChangeTracker.Entries()
            //    .Where(x => x.Entity is IAuditableEntity
            //        && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            //foreach (var entry in modifiedEntries)
            //{
            //    IAuditableEntity entity = entry.Entity as IAuditableEntity;
            //    if (entity != null)
            //    {
            //        string identityName = Thread.CurrentPrincipal.Identity.Name;
            //        DateTime now = DateTime.UtcNow;

            //        if (entry.State == System.Data.Entity.EntityState.Added)
            //        {
            //            entity.CreatedBy = identityName;
            //            entity.CreatedDate = now;
            //        }
            //        else
            //        {
            //            base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
            //            base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            //        }

            //        entity.UpdatedBy = identityName;
            //        entity.UpdatedDate = now;
            //    }
            //}

            return base.SaveChanges();

        }
    }
}