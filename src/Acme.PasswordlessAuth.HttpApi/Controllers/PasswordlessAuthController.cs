using Acme.PasswordlessAuth.Localization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace Acme.PasswordlessAuth.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PasswordlessAuthController : AbpControllerBase
{
    protected PasswordlessAuthController()
    {
        LocalizationResource = typeof(PasswordlessAuthResource);
    }

    private readonly IdentityUserManager _userManager;
    private readonly SignInManager _signInManager;

    public PasswordlessController(
        IdentityUserManager userManager,
        SignInManager signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost]
    public async Task<IActionResult> Login(string token, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var isValid = await _userManager.VerifyUserTokenAsync(user, "PasswordlessLoginProvider", "passwordless-auth", token);
        if (!isValid)
        {
            throw new UnauthorizedAccessException($"The token {token} is not valid for the user {userId}");
        }

        await _userManager.UpdateSecurityStampAsync(user);
        await _signInManager.SignInAsync(user, isPersistent: false);

        return Redirect("/");
    }
}
