using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Todo.SoftEng;

[Dependency(ReplaceServices = true)]
public class SoftEngBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SoftEng";
}
