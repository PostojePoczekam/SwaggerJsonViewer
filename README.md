# SwaggerJsonViewer
[![.NET](https://github.com/PostojePoczekam/SwaggerJsonViewer/actions/workflows/dotnet.yml/badge.svg)](https://github.com/PostojePoczekam/SwaggerJsonViewer/actions/workflows/dotnet.yml)

Swashbuckle extension to view jsons, using slightly modified json-viewer by [LorDOniX](https://github.com/LorDOniX/json-viewer)
## Usage
```csharp
using SwaggerJsonViewer;

...
builder.Services.AddSwaggerJsonViewer();
...
app.UseSwaggerUI(options =>
{
    ...
    options.AddJsonViewer();
});
```
