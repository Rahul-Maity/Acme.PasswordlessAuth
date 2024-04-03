using Volo.Abp.Modularity;

namespace Acme.PasswordlessAuth;

public abstract class PasswordlessAuthApplicationTestBase<TStartupModule> : PasswordlessAuthTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
