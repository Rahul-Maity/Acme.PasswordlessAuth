using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PasswordlessAuth
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddPasswordlessLoginProvider<TUser>(this IdentityBuilder builder)
            where TUser : class
        {
            var userType = builder.UserType;
            var totpProvider = typeof(PasswordlessLoginProvider<>).MakeGenericType(userType);
            return builder.AddTokenProvider("PasswordlessLoginProvider", totpProvider);
        }
    }
}
