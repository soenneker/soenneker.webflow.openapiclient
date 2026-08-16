using Soenneker.Tests.HostedUnit;

namespace Soenneker.Webflow.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WebflowOpenApiClientTests : HostedUnitTest
{
    public WebflowOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
