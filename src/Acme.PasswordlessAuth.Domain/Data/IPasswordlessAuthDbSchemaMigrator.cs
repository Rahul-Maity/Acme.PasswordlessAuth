using System.Threading.Tasks;

namespace Acme.PasswordlessAuth.Data;

public interface IPasswordlessAuthDbSchemaMigrator
{
    Task MigrateAsync();
}
