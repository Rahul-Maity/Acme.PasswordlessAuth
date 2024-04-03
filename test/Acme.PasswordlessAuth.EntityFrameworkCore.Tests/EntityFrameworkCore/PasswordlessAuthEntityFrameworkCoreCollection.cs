using Xunit;

namespace Acme.PasswordlessAuth.EntityFrameworkCore;

[CollectionDefinition(PasswordlessAuthTestConsts.CollectionDefinitionName)]
public class PasswordlessAuthEntityFrameworkCoreCollection : ICollectionFixture<PasswordlessAuthEntityFrameworkCoreFixture>
{

}
