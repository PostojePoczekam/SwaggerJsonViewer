using Xunit;
using Swashbuckle.AspNetCore.SwaggerUI;
using SwaggerJsonViewer;
using FluentAssertions;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void AddJsonViewer_HeadContentContainsInjectedFiles()
        {
            var options = new SwaggerUIOptions();
            options.AddJsonViewer();
            options.HeadContent.Should()
                .Contain("/json-viewer-theme-dark.css")
                .And.Contain("/json-viewer.css")
                .And.Contain("/json-viewer.js")
                .And.Contain("/swagger-json-viewer.js");
        }
    }
}