using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABM_Test.EntityFramework;

namespace ABM_Test.Migrator
{
    [DependsOn(typeof(ABM_TestDataModule))]
    public class ABM_TestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABM_TestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}