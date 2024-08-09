# Merge .NET Library

The official Merge C# library, supporting .NET Standard, .NET Core, and .NET Framework. 

## Documentation

API reference documentation is available [here](https://docs.merge.dev/basics/authentication/).

## Installation

Using the .NET Core command-line interface (CLI) tools:

```sh
dotnet add package Merge.Client
```

Using the NuGet Command Line Interface (CLI):

```sh
nuget install Merge.Client
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
When the API returns a non-zero status code, (4xx or 5xx response), 
a subclass of MergeException will be thrown:

```csharp
using Merge.Client;

try {
  merge.Ats.Candidates.Retrieve(...);    
} catch (MergeException e) {
  System.Console.WriteLine(e.Message) 
  System.Console.WriteLine(e.StatusCode) 
}
```

## Usage 

Below are code snippets of how you can use the C# SDK.

### Create Link Token

```c#
using Merge.Client;
using Merge.Client.Ats;

var merge = new MergeClient("YOUR_API_KEY", "YOUR_ACCOUNT_TOKEN")

merge.Ats.LinkToken.Create(new EndUserDetailsRequest{
  EndUserEmailAddress = "john.smith@gmail.com",
  EndUserOrganizationName = "acme",
  EndUserOriginId = "1234",
})
```

### Get Employee

```c#
using Merge.Client;
using Merge.Client.Hris;

var merge = new MergeClient(
  "YOUR_API_KEY", "YOUR_ACCOUNT_ID"
)
Employee employee = merge.Hris.Employees.RetrieveAsync("0958cbc6-6040-430a-848e-aafacbadf4ae",
    new EmployeesRetrieveRequest{
        IncludeRemoteData = true
    }
);
```

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

## Contributing
While we value open-source contributions to this SDK, this library
is generated programmatically. Additions made directly to this library
would have to be moved over to our generation code, otherwise they would
be overwritten upon the next generated release. Feel free to open a PR as a
proof of concept, but know that we will not be able to merge it as-is.
We suggest opening an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
