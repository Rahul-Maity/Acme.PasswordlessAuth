using System;
using System.Collections.Generic;
using System.Text;
using Acme.PasswordlessAuth.Localization;
using Volo.Abp.Application.Services;

namespace Acme.PasswordlessAuth;

/* Inherit your application services from this class.
 */
public abstract class PasswordlessAuthAppService : ApplicationService
{
    protected PasswordlessAuthAppService()
    {
        LocalizationResource = typeof(PasswordlessAuthResource);
    }
}
