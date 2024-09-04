# Merge C# Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-SDK%20generated%20by%20Fern-brightgreen)](https://github.com/fern-api/fern)
[![nuget shield](https://img.shields.io/nuget/v/Merge.Client)](https://nuget.org/packages/Merge.Client)

The Merge C# library provides convenient access to the Merge API from C#.

## Documentation

API reference documentation is available [here](https://docs.merge.dev/basics/authentication/).

## Installation

```sh
nuget install Merge.Client
```

## Usage

Instantiate and use the client with the following:

```csharp
using Merge.Client.Ats;
using Merge.Client;

var client = new Merge("API_KEY");
await client.Ats.Activities.CreateAsync(
    new ActivityEndpointRequest { Model = new ActivityRequest(), RemoteUserId = "remote_user_id" }
);
```

## Instantiation 
Instantiate the SDK using the `MergeClient` class. Note that all 
of the SDK methods are awaitable!

```csharp
using Merge.Client;
using Merge.Client.Ats;

var merge = new MergeClient(
  "YOUR_API_KEY", "YOUR_ACCOUNT_TOKEN"
)
```

## Categories

This SDK contains the ATS, HRIS, CRM, Ticketing, Accounting, and File Storage categories. Even if you do not plan on 
using more than one Merge API category right now, the SDK provides upgrade-flexibility in case you find new Merge API categories useful in the future.

Each category is namespaced:

```csharp
var merge = new MergeClient(
  "YOUR_API_KEY", "YOUR_ACCOUNT_TOKEN"
)

merge.ATS. # APIs specific to the ATS Category

merge.HRIS. # APIs specific to the HRIS Category
```

## HTTP Client
You can override the HttpClient by passing in `ClientOptions`. 

```csharp
var merge = new MergeClient("YOUR_API_KEY", "YOUR_ACCOUNT_ID", new ClientOptions{
    HttpClient = ... // Override the Http Client
    BaseURL = ... // Override the Base URL
})
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), a subclass of the following error
will be thrown.

```csharp
using Merge.Client;

try {
    var response = await client.Ats.Activities.CreateAsync(...);
} catch (MergeApiException e) {
    System.Console.WriteLine(e.Body);
    System.Console.WriteLine(e.StatusCode);
}
```

## Advanced

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retriable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retriable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `MaxRetries` request option to configure this behavior.

```csharp
var response = await client.Ats.Activities.CreateAsync(
    ...,
    new RequestOptions {
        MaxRetries: 0 // Override MaxRetries at the request level
    }
);
```

### Timeouts

The SDK defaults to a 30 second timeout. Use the `Timeout` option to configure this behavior.

```csharp
var response = await client.Ats.Activities.CreateAsync(
    ...,
    new RequestOptions {
        Timeout: TimeSpan.FromSeconds(3) // Override timeout to 3s
    }
);
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
## Retries 
429 Rate Limit, and >=500 Internal errors will all be 
retried twice with exponential backoff. You can override this behavior 
globally or per-request. 

```csharp
var merge = new MergeClient("...", new ClientOptions{
    MaxRetries = 1 // Only retry once
});
```

## Timeouts
The SDK defaults to a 60s timeout. You can override this behaviour
globally or per-request. 

```csharp
var merge = new MergeClient("...", new ClientOptions{
    TimeoutInSeconds = 20 // Lower timeout
});
```
