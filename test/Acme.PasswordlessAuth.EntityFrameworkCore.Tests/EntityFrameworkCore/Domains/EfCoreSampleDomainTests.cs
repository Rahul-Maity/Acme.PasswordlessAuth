using Acme.PasswordlessAuth.Samples;
using Xunit;

namespace Acme.PasswordlessAuth.EntityFrameworkCore.Domains;

[Collection(PasswordlessAuthTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PasswordlessAuthEntityFrameworkCoreTestModule>
{

}
