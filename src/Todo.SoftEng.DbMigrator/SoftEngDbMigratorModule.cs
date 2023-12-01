using Todo.SoftEng.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Todo.SoftEng.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SoftEngEntityFrameworkCoreModule),
    typeof(SoftEngApplicationContractsModule)
    )]
public class SoftEngDbMigratorModule : AbpModule
{
}
