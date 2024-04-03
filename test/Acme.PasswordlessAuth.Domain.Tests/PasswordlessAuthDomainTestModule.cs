using Volo.Abp.Modularity;

namespace Acme.PasswordlessAuth;

[DependsOn(
    typeof(PasswordlessAuthDomainModule),
    typeof(PasswordlessAuthTestBaseModule)
)]
public class PasswordlessAuthDomainTestModule : AbpModule
{

}
