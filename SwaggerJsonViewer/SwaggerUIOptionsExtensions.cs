using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace SwaggerJsonViewer
{
    public static class SwaggerUIOptionsExtensions
    {
        /// <summary>
        /// Adds json viewer to the SwaggerUI
        /// </summary>
        public static void AddJsonViewer(this SwaggerUIOptions options)
        {
            options.InjectStylesheet("/json-viewer-theme-dark.css");
            options.InjectStylesheet("/json-viewer.css");
            options.InjectJavascript("/json-viewer.js");
            options.InjectJavascript("/swagger-json-viewer.js");
        }
    }
}
