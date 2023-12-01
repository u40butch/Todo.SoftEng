using Volo.Abp.Modularity;

namespace Todo.SoftEng;

[DependsOn(
    typeof(SoftEngApplicationModule),
    typeof(SoftEngDomainTestModule)
    )]
public class SoftEngApplicationTestModule : AbpModule
{

}
