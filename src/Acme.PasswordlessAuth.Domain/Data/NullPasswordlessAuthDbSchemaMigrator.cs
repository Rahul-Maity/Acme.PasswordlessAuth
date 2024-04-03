using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.PasswordlessAuth.Data;

/* This is used if database provider does't define
 * IPasswordlessAuthDbSchemaMigrator implementation.
 */
public class NullPasswordlessAuthDbSchemaMigrator : IPasswordlessAuthDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
