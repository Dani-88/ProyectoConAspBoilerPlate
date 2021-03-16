using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using ABM_Test.Authorization.Roles;
using ABM_Test.Authorization.Users;
using ABM_Test.MultiTenancy;

namespace ABM_Test.EntityFramework
{
    public class ABM_TestDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABM_TestDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABM_TestDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABM_TestDbContext since ABP automatically handles it.
         */
        public ABM_TestDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABM_TestDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABM_TestDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
        }

        public System.Data.Entity.DbSet<ABM_Test.EntityFramework.Personaa> Personaas { get; set; }
    }
}
