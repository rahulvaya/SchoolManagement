using SMT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SMT.DataAccess
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("name=SchoolDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
        }

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }
    }
}
