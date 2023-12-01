using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Todo.SoftEng.Data;

/* This is used if database provider does't define
 * ISoftEngDbSchemaMigrator implementation.
 */
public class NullSoftEngDbSchemaMigrator : ISoftEngDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
