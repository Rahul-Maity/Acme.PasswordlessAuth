using Acme.PasswordlessAuth.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.PasswordlessAuth.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PasswordlessAuthEntityFrameworkCoreModule),
    typeof(PasswordlessAuthApplicationContractsModule)
    )]
public class PasswordlessAuthDbMigratorModule : AbpModule
{
}
