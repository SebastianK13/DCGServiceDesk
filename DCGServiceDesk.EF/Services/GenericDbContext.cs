using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCGServiceDesk.EF.Services
{
    class GenericDbContext<TContext> /*: ISpecificContext<TContext> where TContext : DbContext*/
    {
        //private readonly Action<DbContextOptionsBuilder> _dbContextConfig;

        //public GenericDbContext(Action<DbContextOptionsBuilder> dbContextConfig) =>
        //    _dbContextConfig = dbContextConfig;

        //public AppIdentityDbContext CreateIdentityDbContext(ISpecificContext<AppIdentityDbContext> identityContext)
        //{
        //    DbContextOptionsBuilder<AppIdentityDbContext> options = new DbContextOptionsBuilder<AppIdentityDbContext>();

        //    _dbContextConfig(options);

        //    return new AppIdentityDbContext(options.Options);
        //}

        //public async Task<TContext> CreateDbContext()
        //{
        //        DbContextOptionsBuilder<TContext> options = new DbContextOptionsBuilder<TContext>();

        //    _dbContextConfig(options);

        //    return TContext(options.Options);
        //}
    }
}
