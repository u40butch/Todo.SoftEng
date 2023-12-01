using Volo.Abp.Settings;

namespace Todo.SoftEng.Settings;

public class SoftEngSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SoftEngSettings.MySetting1));
    }
}
