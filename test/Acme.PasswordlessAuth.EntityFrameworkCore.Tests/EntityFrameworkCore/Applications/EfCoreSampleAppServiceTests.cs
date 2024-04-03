using Acme.PasswordlessAuth.Samples;
using Xunit;

namespace Acme.PasswordlessAuth.EntityFrameworkCore.Applications;

[Collection(PasswordlessAuthTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PasswordlessAuthEntityFrameworkCoreTestModule>
{

}
