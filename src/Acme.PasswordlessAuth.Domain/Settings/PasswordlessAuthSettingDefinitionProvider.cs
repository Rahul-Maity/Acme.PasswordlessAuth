using Volo.Abp.Settings;

namespace Acme.PasswordlessAuth.Settings;

public class PasswordlessAuthSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PasswordlessAuthSettings.MySetting1));
    }
}
