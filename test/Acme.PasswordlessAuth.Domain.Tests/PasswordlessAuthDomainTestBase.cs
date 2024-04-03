using Volo.Abp.Modularity;

namespace Acme.PasswordlessAuth;

/* Inherit from this class for your domain layer tests. */
public abstract class PasswordlessAuthDomainTestBase<TStartupModule> : PasswordlessAuthTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
