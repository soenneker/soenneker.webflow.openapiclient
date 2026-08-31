[![](https://img.shields.io/nuget/v/soenneker.webflow.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.webflow.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.webflow.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.webflow.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.webflow.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.webflow.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.webflow.openapiclient/codeql.yml?style=for-the-badge&label=CodeQL)](https://github.com/soenneker/soenneker.webflow.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Webflow.OpenApiClient

A Kiota-generated client for Webflow Data API v2 sites, collections, pages, assets, forms, webhooks, and workspaces.

## Installation

```bash
dotnet add package Soenneker.Webflow.OpenApiClient
```

## Usage

Create a Kiota adapter with a Webflow site token or OAuth access token:

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Webflow.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.webflow.com/v2/")
};

httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new WebflowOpenApiClient(adapter);
```

List the sites visible to the token:

```csharp
var response = await client.Sites.GetAsync(
    cancellationToken: cancellationToken);
```

This operation requires the `sites:read` scope. Other request builders require the scopes documented by Webflow for their operations. The caller owns the request adapter and `HttpClient`; Kiota throws mapped exceptions for Webflow error responses.

For configuration-based authentication, caching, and service registration, use `Soenneker.Webflow.OpenApiClientUtil`.
