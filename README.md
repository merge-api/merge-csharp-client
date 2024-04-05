# Merge .NET SDK

The official Merge C# library, supporting .NET Standard, .NET Core, and .NET Framework. 

## Documentation

API reference documentation is available [here](https://www.assemblyai.com/docs/).

## Installation

Using the [.NET Core command-line interface (CLI) tools][dotnet-core-cli-tools]:

```sh
dotnet add package Merge.Client
```

Using the [NuGet Command Line Interface (CLI)][nuget-cli]:

```sh
nuget install Merge.Client
```

## Instantiation 
Instantiate the SDK using the `MergeClient` class. Note that all 
of the SDK methods are awaitable!

```csharp
  using Merge;
  using Merge.ATS;

  MergeClient merge = new MergeClient(
    "YOUR_API_KEY", "YOUR_ACCOUNT_ID"
  )
  Candidate candidate = merge.ATS.Candidates.Retrieve(
    "<CANDIDATE_UUID>", 
    new CandidatesRetrieveRequest{
      IncludeRemoteData: true
    });
```

## HTTP Client
You can override the HttpClient by passing in `ClientOptions`. 

```csharp
merge = new MergeClient("YOUR_API_KEY", "YOUR_ACCOUNT_ID", new ClientOptions{
    HttpClient = ... // Override the Http Client
    BaseURL = ... // Override the Base URL
})
```

## Exception Handling
When the API returns a non-zero status code, (4xx or 5xx response), 
a subclass of AssemblyAIException will be thrown:

```csharp
using Merge;

try {
  merge.ATS.Candidates.Retrieve(...);    
} catch (MergeException e) {
  System.Console.WriteLine(e.Message) 
  System.Console.WriteLine(e.StatusCode) 
}
```

## Usage 

Below are code snippets of how you can use the C# SDK.

### Create Link Token

```c#
using Merge;
using Merge.ATS;

MergeClient merge = new MergeClient(
  "YOUR_API_KEY", 
  "YOUR_ACCOUNT_ID"
)

merge.ATS.LinkToken.Create(new EndUserDetailsRequest{
  EndUserEmailAddress = "john.smith@gmail.com",
  EndUserOrganizationName = "acme",
  EndUserOriginId = "1234",
  Categories = 
})

LinkToken linkToken = mergeClient.ats().linkToken().create(EndUserDetailsRequest.builder()
    .endUserEmailAddress("john.smith@gmail.com")
    .endUserOrganizationName("acme")
    .endUserOriginId("1234")
    .categories(new List<CategoriesEnum>{ CategoriesEnum.ATS })
    .build());
```

### Create Link Token

```c#
using Merge;
using Merge.HRIS;

MergeClient merge = new MergeClient(
  "YOUR_API_KEY", 
  "YOUR_ACCOUNT_ID"
)
Employee employee = merge.HRIS.Employees.Retrieve(
    "0958cbc6-6040-430a-848e-aafacbadf4ae",
    new EmployeesRetrieveRequest{
      IncludeRemoteData = true
    });
```

## Advanced

### Retries 
429 Rate Limit, and >=500 Internal errors will all be 
retried twice with exponential backoff. You can override this behavior 
globally or per-request. 

```csharp
var merge = new Merge("...", new ClientOptions{
    MaxRetries = 1 // Only retry once
});
merge.ATS.Candidates.Retrieve(new CandidatesRetrieveRequest{ ... }, new RequestOptions {
    MaxRetries = 0 // Disable retries
});
```

### Timeouts
The SDK defaults to a 60s timeout. You can override this behaviour
globally or per-request. 

```csharp
var aai = new Merge("...", new ClientOptions{
    TimeoutInSeconds = 20 // Lower timeout
});
merge.ATS.Candidates.Retrieve(new Merge{ ... }, new RequestOptions {
    TimeoutInSeconds = 90 // Raise timeout
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
