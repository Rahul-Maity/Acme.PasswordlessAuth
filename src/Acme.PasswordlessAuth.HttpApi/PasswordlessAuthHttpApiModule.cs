using Localization.Resources.AbpUi;
using Acme.PasswordlessAuth.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Acme.PasswordlessAuth;
[DependsOn(
    typeof(PasswordlessAuthApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class PasswordlessAuthHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
      
    }
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        Configure<IdentityOptions>(options =>
        {
            options.Tokens.ProviderMap.Add("PasswordlessLoginProvider", new TokenProviderDescriptor(typeof(PasswordlessLoginProvider<>)));
        });
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PasswordlessAuthResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
