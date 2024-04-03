using Acme.PasswordlessAuth.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.PasswordlessAuth.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PasswordlessAuthController : AbpControllerBase
{
    protected PasswordlessAuthController()
    {
        LocalizationResource = typeof(PasswordlessAuthResource);
    }
}
