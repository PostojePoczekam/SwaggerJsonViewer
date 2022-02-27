using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace Tests
{
    public class IntegrationTests
    {
        [Fact]
        public async Task Get_ResultContainsValidHeadNodes()
        {
            var application = new WebApplicationFactory<Program>();

            var client = application.CreateClient();
            var response = await client.GetAsync("/");

            var content  = await response.Content.ReadAsStringAsync();
            content.Should()
                .Contain("/json-viewer-theme-dark.css")
                .And.Contain("/json-viewer.css")
                .And.Contain("/json-viewer.js")
                .And.Contain("/swagger-json-viewer.js");
        }
    }
}