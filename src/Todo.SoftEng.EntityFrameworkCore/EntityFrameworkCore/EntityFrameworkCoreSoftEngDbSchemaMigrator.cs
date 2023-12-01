using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Todo.SoftEng.Data;
using Volo.Abp.DependencyInjection;

namespace Todo.SoftEng.EntityFrameworkCore;

public class EntityFrameworkCoreSoftEngDbSchemaMigrator
    : ISoftEngDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSoftEngDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SoftEngDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SoftEngDbContext>()
            .Database
            .MigrateAsync();
    }
}
