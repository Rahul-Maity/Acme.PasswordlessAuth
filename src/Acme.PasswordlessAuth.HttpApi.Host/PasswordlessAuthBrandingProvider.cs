using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.PasswordlessAuth;

[Dependency(ReplaceServices = true)]
public class PasswordlessAuthBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PasswordlessAuth";
}
