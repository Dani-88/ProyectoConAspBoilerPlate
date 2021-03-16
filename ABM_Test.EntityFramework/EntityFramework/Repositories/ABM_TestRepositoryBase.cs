using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABM_Test.EntityFramework.Repositories
{
    public abstract class ABM_TestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABM_TestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABM_TestRepositoryBase(IDbContextProvider<ABM_TestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABM_TestRepositoryBase<TEntity> : ABM_TestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABM_TestRepositoryBase(IDbContextProvider<ABM_TestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
