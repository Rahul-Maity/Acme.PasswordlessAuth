using Volo.Abp.Modularity;

namespace Acme.PasswordlessAuth;

[DependsOn(
    typeof(PasswordlessAuthApplicationModule),
    typeof(PasswordlessAuthDomainTestModule)
)]
public class PasswordlessAuthApplicationTestModule : AbpModule
{

}
