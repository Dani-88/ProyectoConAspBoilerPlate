using ABM_Test.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABM_Test.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABM_TestDbContext _context;

        public InitialHostDbBuilder(ABM_TestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
