using Todo.SoftEng.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Todo.SoftEng;

[DependsOn(
    typeof(SoftEngEntityFrameworkCoreTestModule)
    )]
public class SoftEngDomainTestModule : AbpModule
{

}
