using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.PasswordlessAuth.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.PasswordlessAuth.EntityFrameworkCore;

public class EntityFrameworkCorePasswordlessAuthDbSchemaMigrator
    : IPasswordlessAuthDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePasswordlessAuthDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the PasswordlessAuthDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PasswordlessAuthDbContext>()
            .Database
            .MigrateAsync();
    }
}
