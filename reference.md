# Reference
## Ats AccountDetails
<details><summary><code>client.Ats.AccountDetails.<a href="/src/Merge.Client/Ats/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Ats.AccountDetails</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details for a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats AccountToken
<details><summary><code>client.Ats.AccountToken.<a href="/src/Merge.Client/Ats/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Ats.AccountToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the account token for the end user with the provided public token.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AccountToken.RetrieveAsync("public_token");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**publicToken:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Activities
<details><summary><code>client.Ats.Activities.<a href="/src/Merge.Client/Ats/Activities/ActivitiesClient.cs">ListAsync</a>(ActivitiesListRequest { ... }) -> PaginatedActivityList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Activity` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Activities.ListAsync(new ActivitiesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActivitiesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Activities.<a href="/src/Merge.Client/Ats/Activities/ActivitiesClient.cs">CreateAsync</a>(ActivityEndpointRequest { ... }) -> ActivityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Activity` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Activities.CreateAsync(
    new ActivityEndpointRequest { Model = new ActivityRequest(), RemoteUserId = "remote_user_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ActivityEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Activities.<a href="/src/Merge.Client/Ats/Activities/ActivitiesClient.cs">RetrieveAsync</a>(id, ActivitiesRetrieveRequest { ... }) -> Activity</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Activity` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Activities.RetrieveAsync("id", new ActivitiesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ActivitiesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Activities.<a href="/src/Merge.Client/Ats/Activities/ActivitiesClient.cs">MetaPostRetrieveAsync</a>() -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Activity` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Activities.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Applications
<details><summary><code>client.Ats.Applications.<a href="/src/Merge.Client/Ats/Applications/ApplicationsClient.cs">ListAsync</a>(ApplicationsListRequest { ... }) -> PaginatedApplicationList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Application` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Applications.ListAsync(new ApplicationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApplicationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Applications.<a href="/src/Merge.Client/Ats/Applications/ApplicationsClient.cs">CreateAsync</a>(ApplicationEndpointRequest { ... }) -> ApplicationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Application` object with the given values.
For certain integrations, but not all, our API detects duplicate candidates and will associate applications with existing records in the third-party. New candidates are created and automatically linked to the application.

See our [Help Center article](https://help.merge.dev/en/articles/10012366-updates-to-post-applications-oct-2024) for detailed support per integration.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Applications.CreateAsync(
    new ApplicationEndpointRequest
    {
        Model = new ApplicationRequest(),
        RemoteUserId = "remote_user_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApplicationEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Applications.<a href="/src/Merge.Client/Ats/Applications/ApplicationsClient.cs">RetrieveAsync</a>(id, ApplicationsRetrieveRequest { ... }) -> Application</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Application` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Applications.RetrieveAsync("id", new ApplicationsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ApplicationsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Applications.<a href="/src/Merge.Client/Ats/Applications/ApplicationsClient.cs">ChangeStageCreateAsync</a>(id, UpdateApplicationStageRequest { ... }) -> ApplicationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the `current_stage` field of an `Application` object
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Applications.ChangeStageCreateAsync("id", new UpdateApplicationStageRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateApplicationStageRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Applications.<a href="/src/Merge.Client/Ats/Applications/ApplicationsClient.cs">MetaPostRetrieveAsync</a>(ApplicationsMetaPostRetrieveRequest { ... }) -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Application` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Applications.MetaPostRetrieveAsync(new ApplicationsMetaPostRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ApplicationsMetaPostRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats AsyncPassthrough
<details><summary><code>client.Ats.AsyncPassthrough.<a href="/src/Merge.Client/Ats/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Ats.DataPassthroughRequest { ... }) -> Ats.AsyncPassthroughReciept</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Asynchronously pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AsyncPassthrough.CreateAsync(
    new Merge.Client.Ats.DataPassthroughRequest
    {
        Method = Merge.Client.Ats.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Ats.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.AsyncPassthrough.<a href="/src/Merge.Client/Ats/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> OneOf<Ats.RemoteResponse, string></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves data from earlier async-passthrough POST request
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**asyncPassthroughReceiptId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Attachments
<details><summary><code>client.Ats.Attachments.<a href="/src/Merge.Client/Ats/Attachments/AttachmentsClient.cs">ListAsync</a>(AttachmentsListRequest { ... }) -> Ats.PaginatedAttachmentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Attachment` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Attachments.ListAsync(new AttachmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AttachmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Attachments.<a href="/src/Merge.Client/Ats/Attachments/AttachmentsClient.cs">CreateAsync</a>(AttachmentEndpointRequest { ... }) -> AttachmentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Attachment` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Attachments.CreateAsync(
    new AttachmentEndpointRequest
    {
        Model = new Merge.Client.Ats.AttachmentRequest(),
        RemoteUserId = "remote_user_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AttachmentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Attachments.<a href="/src/Merge.Client/Ats/Attachments/AttachmentsClient.cs">RetrieveAsync</a>(id, AttachmentsRetrieveRequest { ... }) -> Ats.Attachment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Attachment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Attachments.RetrieveAsync("id", new AttachmentsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AttachmentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Attachments.<a href="/src/Merge.Client/Ats/Attachments/AttachmentsClient.cs">MetaPostRetrieveAsync</a>() -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Attachment` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Attachments.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats AuditTrail
<details><summary><code>client.Ats.AuditTrail.<a href="/src/Merge.Client/Ats/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Ats.PaginatedAuditLogEventList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of audit trail events.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AuditTrail.ListAsync(new AuditTrailListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuditTrailListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats AvailableActions
<details><summary><code>client.Ats.AvailableActions.<a href="/src/Merge.Client/Ats/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Ats.AvailableActions</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of models and actions available for an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Candidates
<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">ListAsync</a>(CandidatesListRequest { ... }) -> PaginatedCandidateList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Candidate` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.ListAsync(new CandidatesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CandidatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">CreateAsync</a>(CandidateEndpointRequest { ... }) -> CandidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Candidate` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.CreateAsync(
    new CandidateEndpointRequest { Model = new CandidateRequest(), RemoteUserId = "remote_user_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CandidateEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">RetrieveAsync</a>(id, CandidatesRetrieveRequest { ... }) -> Candidate</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Candidate` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.RetrieveAsync("id", new CandidatesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CandidatesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">PartialUpdateAsync</a>(id, PatchedCandidateEndpointRequest { ... }) -> CandidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a `Candidate` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.PartialUpdateAsync(
    "id",
    new PatchedCandidateEndpointRequest
    {
        Model = new PatchedCandidateRequest(),
        RemoteUserId = "remote_user_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedCandidateEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">IgnoreCreateAsync</a>(modelId, Ats.IgnoreCommonModelRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.IgnoreCreateAsync(
    "model_id",
    new Merge.Client.Ats.IgnoreCommonModelRequest
    {
        Reason = Merge.Client.Ats.ReasonEnum.GeneralCustomerRequest,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**modelId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Ats.IgnoreCommonModelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">MetaPatchRetrieveAsync</a>(id) -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Candidate` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Candidates.<a href="/src/Merge.Client/Ats/Candidates/CandidatesClient.cs">MetaPostRetrieveAsync</a>() -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Candidate` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Candidates.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Scopes
<details><summary><code>client.Ats.Scopes.<a href="/src/Merge.Client/Ats/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Ats.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Scopes.<a href="/src/Merge.Client/Ats/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Ats.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Scopes.<a href="/src/Merge.Client/Ats/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Ats.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels = new List<Merge.Client.Ats.IndividualCommonModelScopeDeserializerRequest>()
        {
            new Merge.Client.Ats.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Employee",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Ats.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "READ",
                        new Merge.Client.Ats.ModelPermissionDeserializerRequest { IsEnabled = true }
                    },
                    {
                        "WRITE",
                        new Merge.Client.Ats.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = false,
                        }
                    },
                },
                FieldPermissions = new Merge.Client.Ats.FieldPermissionDeserializerRequest
                {
                    EnabledFields = new List<object>() { "avatar", "home_location" },
                    DisabledFields = new List<object>() { "work_location" },
                },
            },
            new Merge.Client.Ats.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Benefit",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Ats.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "WRITE",
                        new Merge.Client.Ats.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = false,
                        }
                    },
                },
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountCommonModelScopeDeserializerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats DeleteAccount
<details><summary><code>client.Ats.DeleteAccount.<a href="/src/Merge.Client/Ats/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Departments
<details><summary><code>client.Ats.Departments.<a href="/src/Merge.Client/Ats/Departments/DepartmentsClient.cs">ListAsync</a>(DepartmentsListRequest { ... }) -> PaginatedDepartmentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Department` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Departments.ListAsync(new DepartmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DepartmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Departments.<a href="/src/Merge.Client/Ats/Departments/DepartmentsClient.cs">RetrieveAsync</a>(id, DepartmentsRetrieveRequest { ... }) -> Department</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Department` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Departments.RetrieveAsync("id", new DepartmentsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `DepartmentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Eeocs
<details><summary><code>client.Ats.Eeocs.<a href="/src/Merge.Client/Ats/Eeocs/EeocsClient.cs">ListAsync</a>(EeocsListRequest { ... }) -> PaginatedEeocList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `EEOC` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Eeocs.ListAsync(new EeocsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EeocsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Eeocs.<a href="/src/Merge.Client/Ats/Eeocs/EeocsClient.cs">RetrieveAsync</a>(id, EeocsRetrieveRequest { ... }) -> Eeoc</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `EEOC` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Eeocs.RetrieveAsync("id", new EeocsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `EeocsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats FieldMapping
<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>(FieldMappingsRetrieveRequest { ... }) -> Ats.FieldMappingApiInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all Field Mappings for this Linked Account. Field Mappings are mappings between third-party Remote Fields and user defined Merge fields. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.FieldMappingsRetrieveAsync(new FieldMappingsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FieldMappingsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Ats.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create new Field Mappings that will be available after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.FieldMappingsCreateAsync(
    new CreateFieldMappingRequest
    {
        TargetFieldName = "example_target_field_name",
        TargetFieldDescription = "this is a example description of the target field",
        RemoteFieldTraversalPath = new List<object>() { "example_remote_field" },
        RemoteMethod = "GET",
        RemoteUrlPath = "/example-url-path",
        CommonModelName = "ExampleCommonModel",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Ats.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes Field Mappings for a Linked Account. All data related to this Field Mapping will be deleted and these changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Ats.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create or update existing Field Mappings for a Linked Account. Changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.FieldMappingsPartialUpdateAsync(
    "field_mapping_id",
    new PatchedEditFieldMappingRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedEditFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Ats.RemoteFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all remote fields for a Linked Account. Remote fields are third-party fields that are accessible after initial sync if remote_data is enabled. You can use remote fields to override existing Merge fields or map a new Merge field. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteFieldsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Ats.ExternalTargetFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all organization-wide Target Fields, this will not include any Linked Account specific Target Fields. Organization-wide Target Fields are additional fields appended to the Merge Common Model for all Linked Accounts in a category. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/target-fields/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats GenerateKey
<details><summary><code>client.Ats.GenerateKey.<a href="/src/Merge.Client/Ats/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Ats.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a remote key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.GenerateKey.CreateAsync(
    new GenerateRemoteKeyRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GenerateRemoteKeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Interviews
<details><summary><code>client.Ats.Interviews.<a href="/src/Merge.Client/Ats/Interviews/InterviewsClient.cs">ListAsync</a>(InterviewsListRequest { ... }) -> PaginatedScheduledInterviewList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `ScheduledInterview` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Interviews.ListAsync(new InterviewsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InterviewsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Interviews.<a href="/src/Merge.Client/Ats/Interviews/InterviewsClient.cs">CreateAsync</a>(ScheduledInterviewEndpointRequest { ... }) -> ScheduledInterviewResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `ScheduledInterview` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Interviews.CreateAsync(
    new ScheduledInterviewEndpointRequest
    {
        Model = new ScheduledInterviewRequest(),
        RemoteUserId = "remote_user_id",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScheduledInterviewEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Interviews.<a href="/src/Merge.Client/Ats/Interviews/InterviewsClient.cs">RetrieveAsync</a>(id, InterviewsRetrieveRequest { ... }) -> ScheduledInterview</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `ScheduledInterview` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Interviews.RetrieveAsync("id", new InterviewsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `InterviewsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Interviews.<a href="/src/Merge.Client/Ats/Interviews/InterviewsClient.cs">MetaPostRetrieveAsync</a>() -> Ats.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `ScheduledInterview` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Interviews.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Issues
<details><summary><code>client.Ats.Issues.<a href="/src/Merge.Client/Ats/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Ats.PaginatedIssueList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets all issues for Organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Issues.ListAsync(new IssuesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Issues.<a href="/src/Merge.Client/Ats/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Ats.Issue</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific issue.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Issues.RetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats JobInterviewStages
<details><summary><code>client.Ats.JobInterviewStages.<a href="/src/Merge.Client/Ats/JobInterviewStages/JobInterviewStagesClient.cs">ListAsync</a>(JobInterviewStagesListRequest { ... }) -> PaginatedJobInterviewStageList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `JobInterviewStage` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.JobInterviewStages.ListAsync(new JobInterviewStagesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobInterviewStagesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.JobInterviewStages.<a href="/src/Merge.Client/Ats/JobInterviewStages/JobInterviewStagesClient.cs">RetrieveAsync</a>(id, JobInterviewStagesRetrieveRequest { ... }) -> JobInterviewStage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `JobInterviewStage` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.JobInterviewStages.RetrieveAsync("id", new JobInterviewStagesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `JobInterviewStagesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats JobPostings
<details><summary><code>client.Ats.JobPostings.<a href="/src/Merge.Client/Ats/JobPostings/JobPostingsClient.cs">ListAsync</a>(JobPostingsListRequest { ... }) -> PaginatedJobPostingList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `JobPosting` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.JobPostings.ListAsync(new JobPostingsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobPostingsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.JobPostings.<a href="/src/Merge.Client/Ats/JobPostings/JobPostingsClient.cs">RetrieveAsync</a>(id, JobPostingsRetrieveRequest { ... }) -> JobPosting</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `JobPosting` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.JobPostings.RetrieveAsync("id", new JobPostingsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `JobPostingsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Jobs
<details><summary><code>client.Ats.Jobs.<a href="/src/Merge.Client/Ats/Jobs/JobsClient.cs">ListAsync</a>(JobsListRequest { ... }) -> PaginatedJobList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Job` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Jobs.ListAsync(new JobsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JobsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Jobs.<a href="/src/Merge.Client/Ats/Jobs/JobsClient.cs">RetrieveAsync</a>(id, JobsRetrieveRequest { ... }) -> Job</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Job` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Jobs.RetrieveAsync("id", new JobsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `JobsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Jobs.<a href="/src/Merge.Client/Ats/Jobs/JobsClient.cs">ScreeningQuestionsListAsync</a>(jobId, JobsScreeningQuestionsListRequest { ... }) -> PaginatedScreeningQuestionList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `ScreeningQuestion` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Jobs.ScreeningQuestionsListAsync(
    "job_id",
    new JobsScreeningQuestionsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**jobId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `JobsScreeningQuestionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats LinkToken
<details><summary><code>client.Ats.LinkToken.<a href="/src/Merge.Client/Ats/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Ats.LinkToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a link token to be used when linking a new end user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Ats.CategoriesEnum>()
        {
            Merge.Client.Ats.CategoriesEnum.Hris,
            Merge.Client.Ats.CategoriesEnum.Ats,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EndUserDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats LinkedAccounts
<details><summary><code>client.Ats.LinkedAccounts.<a href="/src/Merge.Client/Ats/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Ats.PaginatedAccountDetailsAndActionsList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List linked accounts for your organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Offers
<details><summary><code>client.Ats.Offers.<a href="/src/Merge.Client/Ats/Offers/OffersClient.cs">ListAsync</a>(OffersListRequest { ... }) -> PaginatedOfferList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Offer` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Offers.ListAsync(new OffersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OffersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Offers.<a href="/src/Merge.Client/Ats/Offers/OffersClient.cs">RetrieveAsync</a>(id, OffersRetrieveRequest { ... }) -> Offer</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Offer` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Offers.RetrieveAsync("id", new OffersRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OffersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Offices
<details><summary><code>client.Ats.Offices.<a href="/src/Merge.Client/Ats/Offices/OfficesClient.cs">ListAsync</a>(OfficesListRequest { ... }) -> PaginatedOfficeList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Office` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Offices.ListAsync(new OfficesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OfficesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Offices.<a href="/src/Merge.Client/Ats/Offices/OfficesClient.cs">RetrieveAsync</a>(id, OfficesRetrieveRequest { ... }) -> Office</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Office` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Offices.RetrieveAsync("id", new OfficesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OfficesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Passthrough
<details><summary><code>client.Ats.Passthrough.<a href="/src/Merge.Client/Ats/Passthrough/PassthroughClient.cs">CreateAsync</a>(Ats.DataPassthroughRequest { ... }) -> Ats.RemoteResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Passthrough.CreateAsync(
    new Merge.Client.Ats.DataPassthroughRequest
    {
        Method = Merge.Client.Ats.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Ats.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats RegenerateKey
<details><summary><code>client.Ats.RegenerateKey.<a href="/src/Merge.Client/Ats/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Ats.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchange remote keys.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.RegenerateKey.CreateAsync(
    new RemoteKeyForRegenerationRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteKeyForRegenerationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats RejectReasons
<details><summary><code>client.Ats.RejectReasons.<a href="/src/Merge.Client/Ats/RejectReasons/RejectReasonsClient.cs">ListAsync</a>(RejectReasonsListRequest { ... }) -> PaginatedRejectReasonList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RejectReason` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.RejectReasons.ListAsync(new RejectReasonsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RejectReasonsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.RejectReasons.<a href="/src/Merge.Client/Ats/RejectReasons/RejectReasonsClient.cs">RetrieveAsync</a>(id, RejectReasonsRetrieveRequest { ... }) -> RejectReason</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `RejectReason` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.RejectReasons.RetrieveAsync("id", new RejectReasonsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `RejectReasonsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Scorecards
<details><summary><code>client.Ats.Scorecards.<a href="/src/Merge.Client/Ats/Scorecards/ScorecardsClient.cs">ListAsync</a>(ScorecardsListRequest { ... }) -> PaginatedScorecardList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Scorecard` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Scorecards.ListAsync(new ScorecardsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScorecardsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Scorecards.<a href="/src/Merge.Client/Ats/Scorecards/ScorecardsClient.cs">RetrieveAsync</a>(id, ScorecardsRetrieveRequest { ... }) -> Scorecard</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Scorecard` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Scorecards.RetrieveAsync("id", new ScorecardsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ScorecardsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats SyncStatus
<details><summary><code>client.Ats.SyncStatus.<a href="/src/Merge.Client/Ats/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Ats.PaginatedSyncStatusList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get syncing status. Possible values: `DISABLED`, `DONE`, `FAILED`, `PARTIALLY_SYNCED`, `PAUSED`, `SYNCING`. Learn more about sync status in our [Help Center](https://help.merge.dev/en/articles/8184193-merge-sync-statuses).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.SyncStatus.ListAsync(new SyncStatusListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SyncStatusListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats ForceResync
<details><summary><code>client.Ats.ForceResync.<a href="/src/Merge.Client/Ats/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Ats.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Professional or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Tags
<details><summary><code>client.Ats.Tags.<a href="/src/Merge.Client/Ats/Tags/TagsClient.cs">ListAsync</a>(TagsListRequest { ... }) -> Ats.PaginatedTagList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Tag` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Tags.ListAsync(new TagsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TagsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats Users
<details><summary><code>client.Ats.Users.<a href="/src/Merge.Client/Ats/Users/UsersClient.cs">ListAsync</a>(UsersListRequest { ... }) -> PaginatedRemoteUserList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteUser` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Users.ListAsync(new UsersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.Users.<a href="/src/Merge.Client/Ats/Users/UsersClient.cs">RetrieveAsync</a>(id, UsersRetrieveRequest { ... }) -> RemoteUser</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `RemoteUser` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.Users.RetrieveAsync("id", new UsersRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UsersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ats WebhookReceivers
<details><summary><code>client.Ats.WebhookReceivers.<a href="/src/Merge.Client/Ats/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Ats.WebhookReceiver></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `WebhookReceiver` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ats.WebhookReceivers.<a href="/src/Merge.Client/Ats/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Ats.WebhookReceiver</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `WebhookReceiver` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ats.WebhookReceivers.CreateAsync(
    new WebhookReceiverRequest { Event = "event", IsActive = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WebhookReceiverRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AccountDetails
<details><summary><code>client.Crm.AccountDetails.<a href="/src/Merge.Client/Crm/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Crm.AccountDetails</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details for a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AccountToken
<details><summary><code>client.Crm.AccountToken.<a href="/src/Merge.Client/Crm/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Crm.AccountToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the account token for the end user with the provided public token.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AccountToken.RetrieveAsync("public_token");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**publicToken:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Accounts
<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">ListAsync</a>(AccountsListRequest { ... }) -> Crm.PaginatedAccountList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Account` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.ListAsync(new AccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">CreateAsync</a>(CrmAccountEndpointRequest { ... }) -> CrmAccountResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Account` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.CreateAsync(
    new CrmAccountEndpointRequest { Model = new Merge.Client.Crm.AccountRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CrmAccountEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">RetrieveAsync</a>(id, AccountsRetrieveRequest { ... }) -> Crm.Account</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Account` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.RetrieveAsync("id", new AccountsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">PartialUpdateAsync</a>(id, PatchedCrmAccountEndpointRequest { ... }) -> CrmAccountResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an `Account` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.PartialUpdateAsync(
    "id",
    new PatchedCrmAccountEndpointRequest { Model = new PatchedAccountRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedCrmAccountEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">MetaPatchRetrieveAsync</a>(id) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMAccount` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMAccount` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Accounts.<a href="/src/Merge.Client/Crm/Accounts/AccountsClient.cs">RemoteFieldClassesListAsync</a>(AccountsRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Accounts.RemoteFieldClassesListAsync(new AccountsRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AccountsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AsyncPassthrough
<details><summary><code>client.Crm.AsyncPassthrough.<a href="/src/Merge.Client/Crm/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Crm.DataPassthroughRequest { ... }) -> Crm.AsyncPassthroughReciept</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Asynchronously pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AsyncPassthrough.CreateAsync(
    new Merge.Client.Crm.DataPassthroughRequest
    {
        Method = Merge.Client.Crm.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Crm.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.AsyncPassthrough.<a href="/src/Merge.Client/Crm/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> OneOf<Crm.RemoteResponse, string></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves data from earlier async-passthrough POST request
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**asyncPassthroughReceiptId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AuditTrail
<details><summary><code>client.Crm.AuditTrail.<a href="/src/Merge.Client/Crm/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Crm.PaginatedAuditLogEventList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of audit trail events.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AuditTrail.ListAsync(new AuditTrailListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuditTrailListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AvailableActions
<details><summary><code>client.Crm.AvailableActions.<a href="/src/Merge.Client/Crm/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Crm.AvailableActions</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of models and actions available for an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Contacts
<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">ListAsync</a>(ContactsListRequest { ... }) -> Crm.PaginatedContactList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Contact` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.ListAsync(new ContactsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">CreateAsync</a>(CrmContactEndpointRequest { ... }) -> CrmContactResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Contact` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.CreateAsync(
    new CrmContactEndpointRequest { Model = new Merge.Client.Crm.ContactRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CrmContactEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">RetrieveAsync</a>(id, ContactsRetrieveRequest { ... }) -> Crm.Contact</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Contact` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.RetrieveAsync("id", new ContactsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ContactsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">PartialUpdateAsync</a>(id, PatchedCrmContactEndpointRequest { ... }) -> CrmContactResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a `Contact` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.PartialUpdateAsync(
    "id",
    new PatchedCrmContactEndpointRequest { Model = new PatchedContactRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedCrmContactEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">IgnoreCreateAsync</a>(modelId, IgnoreCommonModelRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.IgnoreCreateAsync(
    "model_id",
    new IgnoreCommonModelRequest { Reason = Merge.Client.Crm.ReasonEnum.GeneralCustomerRequest }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**modelId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `IgnoreCommonModelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">MetaPatchRetrieveAsync</a>(id) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMContact` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMContact` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Contacts.<a href="/src/Merge.Client/Crm/Contacts/ContactsClient.cs">RemoteFieldClassesListAsync</a>(ContactsRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Contacts.RemoteFieldClassesListAsync(new ContactsRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm CustomObjectClasses
<details><summary><code>client.Crm.CustomObjectClasses.<a href="/src/Merge.Client/Crm/CustomObjectClasses/CustomObjectClassesClient.cs">ListAsync</a>(CustomObjectClassesListRequest { ... }) -> PaginatedCustomObjectClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `CustomObjectClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjectClasses.ListAsync(new CustomObjectClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CustomObjectClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.CustomObjectClasses.<a href="/src/Merge.Client/Crm/CustomObjectClasses/CustomObjectClassesClient.cs">RetrieveAsync</a>(id, CustomObjectClassesRetrieveRequest { ... }) -> CustomObjectClass</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `CustomObjectClass` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjectClasses.RetrieveAsync("id", new CustomObjectClassesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm AssociationTypes
<details><summary><code>client.Crm.AssociationTypes.<a href="/src/Merge.Client/Crm/AssociationTypes/AssociationTypesClient.cs">CustomObjectClassesAssociationTypesListAsync</a>(customObjectClassId, CustomObjectClassesAssociationTypesListRequest { ... }) -> PaginatedAssociationTypeList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `AssociationType` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesListAsync(
    "custom_object_class_id",
    new CustomObjectClassesAssociationTypesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesAssociationTypesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.AssociationTypes.<a href="/src/Merge.Client/Crm/AssociationTypes/AssociationTypesClient.cs">CustomObjectClassesAssociationTypesCreateAsync</a>(customObjectClassId, CrmAssociationTypeEndpointRequest { ... }) -> CrmAssociationTypeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `AssociationType` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesCreateAsync(
    "custom_object_class_id",
    new CrmAssociationTypeEndpointRequest
    {
        Model = new AssociationTypeRequestRequest
        {
            SourceObjectClass = new ObjectClassDescriptionRequest
            {
                Id = "id",
                OriginType = OriginTypeEnum.CustomObject,
            },
            TargetObjectClasses = new List<ObjectClassDescriptionRequest>()
            {
                new ObjectClassDescriptionRequest
                {
                    Id = "id",
                    OriginType = OriginTypeEnum.CustomObject,
                },
            },
            RemoteKeyName = "remote_key_name",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CrmAssociationTypeEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.AssociationTypes.<a href="/src/Merge.Client/Crm/AssociationTypes/AssociationTypesClient.cs">CustomObjectClassesAssociationTypesRetrieveAsync</a>(customObjectClassId, id, CustomObjectClassesAssociationTypesRetrieveRequest { ... }) -> AssociationType</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `AssociationType` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesRetrieveAsync(
    "custom_object_class_id",
    "id",
    new CustomObjectClassesAssociationTypesRetrieveRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesAssociationTypesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.AssociationTypes.<a href="/src/Merge.Client/Crm/AssociationTypes/AssociationTypesClient.cs">CustomObjectClassesAssociationTypesMetaPostRetrieveAsync</a>(customObjectClassId) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMAssociationType` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
    "custom_object_class_id"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm CustomObjects
<details><summary><code>client.Crm.CustomObjects.<a href="/src/Merge.Client/Crm/CustomObjects/CustomObjectsClient.cs">CustomObjectClassesCustomObjectsListAsync</a>(customObjectClassId, CustomObjectClassesCustomObjectsListRequest { ... }) -> PaginatedCustomObjectList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `CustomObject` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsListAsync(
    "custom_object_class_id",
    new CustomObjectClassesCustomObjectsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesCustomObjectsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.CustomObjects.<a href="/src/Merge.Client/Crm/CustomObjects/CustomObjectsClient.cs">CustomObjectClassesCustomObjectsCreateAsync</a>(customObjectClassId, CrmCustomObjectEndpointRequest { ... }) -> CrmCustomObjectResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `CustomObject` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsCreateAsync(
    "custom_object_class_id",
    new CrmCustomObjectEndpointRequest
    {
        Model = new CustomObjectRequest
        {
            Fields = new Dictionary<string, object>() { { "test_field", "hello" } },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CrmCustomObjectEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.CustomObjects.<a href="/src/Merge.Client/Crm/CustomObjects/CustomObjectsClient.cs">CustomObjectClassesCustomObjectsRetrieveAsync</a>(customObjectClassId, id, CustomObjectClassesCustomObjectsRetrieveRequest { ... }) -> CustomObject</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `CustomObject` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsRetrieveAsync(
    "custom_object_class_id",
    "id",
    new CustomObjectClassesCustomObjectsRetrieveRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesCustomObjectsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.CustomObjects.<a href="/src/Merge.Client/Crm/CustomObjects/CustomObjectsClient.cs">CustomObjectClassesCustomObjectsMetaPostRetrieveAsync</a>(customObjectClassId) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `CRMCustomObject` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsMetaPostRetrieveAsync(
    "custom_object_class_id"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.CustomObjects.<a href="/src/Merge.Client/Crm/CustomObjects/CustomObjectsClient.cs">CustomObjectClassesCustomObjectsRemoteFieldClassesListAsync</a>(CustomObjectClassesCustomObjectsRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsRemoteFieldClassesListAsync(
    new CustomObjectClassesCustomObjectsRemoteFieldClassesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CustomObjectClassesCustomObjectsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Associations
<details><summary><code>client.Crm.Associations.<a href="/src/Merge.Client/Crm/Associations/AssociationsClient.cs">CustomObjectClassesCustomObjectsAssociationsListAsync</a>(customObjectClassId, objectId, CustomObjectClassesCustomObjectsAssociationsListRequest { ... }) -> PaginatedAssociationList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Association` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsListAsync(
    "custom_object_class_id",
    "object_id",
    new CustomObjectClassesCustomObjectsAssociationsListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**customObjectClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**objectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesCustomObjectsAssociationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Associations.<a href="/src/Merge.Client/Crm/Associations/AssociationsClient.cs">CustomObjectClassesCustomObjectsAssociationsUpdateAsync</a>(associationTypeId, sourceClassId, sourceObjectId, targetClassId, targetObjectId, CustomObjectClassesCustomObjectsAssociationsUpdateRequest { ... }) -> Association</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an Association between `source_object_id` and `target_object_id` of type `association_type_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
    "association_type_id",
    "source_class_id",
    "source_object_id",
    "target_class_id",
    "target_object_id",
    new CustomObjectClassesCustomObjectsAssociationsUpdateRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**associationTypeId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**sourceClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**sourceObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**targetClassId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**targetObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CustomObjectClassesCustomObjectsAssociationsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Scopes
<details><summary><code>client.Crm.Scopes.<a href="/src/Merge.Client/Crm/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Crm.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Scopes.<a href="/src/Merge.Client/Crm/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Crm.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Scopes.<a href="/src/Merge.Client/Crm/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Crm.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels = new List<Merge.Client.Crm.IndividualCommonModelScopeDeserializerRequest>()
        {
            new Merge.Client.Crm.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Employee",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Crm.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "READ",
                        new Merge.Client.Crm.ModelPermissionDeserializerRequest { IsEnabled = true }
                    },
                    {
                        "WRITE",
                        new Merge.Client.Crm.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = false,
                        }
                    },
                },
                FieldPermissions = new Merge.Client.Crm.FieldPermissionDeserializerRequest
                {
                    EnabledFields = new List<object>() { "avatar", "home_location" },
                    DisabledFields = new List<object>() { "work_location" },
                },
            },
            new Merge.Client.Crm.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Benefit",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Crm.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "WRITE",
                        new Merge.Client.Crm.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = false,
                        }
                    },
                },
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountCommonModelScopeDeserializerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm DeleteAccount
<details><summary><code>client.Crm.DeleteAccount.<a href="/src/Merge.Client/Crm/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm EngagementTypes
<details><summary><code>client.Crm.EngagementTypes.<a href="/src/Merge.Client/Crm/EngagementTypes/EngagementTypesClient.cs">ListAsync</a>(EngagementTypesListRequest { ... }) -> PaginatedEngagementTypeList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `EngagementType` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.EngagementTypes.ListAsync(new EngagementTypesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EngagementTypesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.EngagementTypes.<a href="/src/Merge.Client/Crm/EngagementTypes/EngagementTypesClient.cs">RetrieveAsync</a>(id, EngagementTypesRetrieveRequest { ... }) -> EngagementType</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `EngagementType` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.EngagementTypes.RetrieveAsync("id", new EngagementTypesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `EngagementTypesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.EngagementTypes.<a href="/src/Merge.Client/Crm/EngagementTypes/EngagementTypesClient.cs">RemoteFieldClassesListAsync</a>(EngagementTypesRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.EngagementTypes.RemoteFieldClassesListAsync(
    new EngagementTypesRemoteFieldClassesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EngagementTypesRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Engagements
<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">ListAsync</a>(EngagementsListRequest { ... }) -> PaginatedEngagementList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Engagement` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.ListAsync(new EngagementsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EngagementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">CreateAsync</a>(EngagementEndpointRequest { ... }) -> EngagementResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Engagement` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.CreateAsync(
    new EngagementEndpointRequest { Model = new EngagementRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EngagementEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">RetrieveAsync</a>(id, EngagementsRetrieveRequest { ... }) -> Engagement</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Engagement` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.RetrieveAsync("id", new EngagementsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `EngagementsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">PartialUpdateAsync</a>(id, PatchedEngagementEndpointRequest { ... }) -> EngagementResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an `Engagement` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.PartialUpdateAsync(
    "id",
    new PatchedEngagementEndpointRequest { Model = new PatchedEngagementRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedEngagementEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">MetaPatchRetrieveAsync</a>(id) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Engagement` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Engagement` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Engagements.<a href="/src/Merge.Client/Crm/Engagements/EngagementsClient.cs">RemoteFieldClassesListAsync</a>(EngagementsRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Engagements.RemoteFieldClassesListAsync(
    new EngagementsRemoteFieldClassesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EngagementsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm FieldMapping
<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>(FieldMappingsRetrieveRequest { ... }) -> Crm.FieldMappingApiInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all Field Mappings for this Linked Account. Field Mappings are mappings between third-party Remote Fields and user defined Merge fields. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.FieldMappingsRetrieveAsync(new FieldMappingsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FieldMappingsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Crm.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create new Field Mappings that will be available after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.FieldMappingsCreateAsync(
    new CreateFieldMappingRequest
    {
        TargetFieldName = "example_target_field_name",
        TargetFieldDescription = "this is a example description of the target field",
        RemoteFieldTraversalPath = new List<object>() { "example_remote_field" },
        RemoteMethod = "GET",
        RemoteUrlPath = "/example-url-path",
        CommonModelName = "ExampleCommonModel",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Crm.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes Field Mappings for a Linked Account. All data related to this Field Mapping will be deleted and these changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Crm.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create or update existing Field Mappings for a Linked Account. Changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.FieldMappingsPartialUpdateAsync(
    "field_mapping_id",
    new PatchedEditFieldMappingRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedEditFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Crm.RemoteFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all remote fields for a Linked Account. Remote fields are third-party fields that are accessible after initial sync if remote_data is enabled. You can use remote fields to override existing Merge fields or map a new Merge field. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteFieldsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Crm.ExternalTargetFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all organization-wide Target Fields, this will not include any Linked Account specific Target Fields. Organization-wide Target Fields are additional fields appended to the Merge Common Model for all Linked Accounts in a category. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/target-fields/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm GenerateKey
<details><summary><code>client.Crm.GenerateKey.<a href="/src/Merge.Client/Crm/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Crm.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a remote key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.GenerateKey.CreateAsync(
    new GenerateRemoteKeyRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GenerateRemoteKeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Issues
<details><summary><code>client.Crm.Issues.<a href="/src/Merge.Client/Crm/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Crm.PaginatedIssueList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets all issues for Organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Issues.ListAsync(new IssuesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Issues.<a href="/src/Merge.Client/Crm/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Crm.Issue</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific issue.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Issues.RetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Leads
<details><summary><code>client.Crm.Leads.<a href="/src/Merge.Client/Crm/Leads/LeadsClient.cs">ListAsync</a>(LeadsListRequest { ... }) -> PaginatedLeadList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Lead` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Leads.ListAsync(new LeadsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LeadsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Leads.<a href="/src/Merge.Client/Crm/Leads/LeadsClient.cs">CreateAsync</a>(LeadEndpointRequest { ... }) -> LeadResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Lead` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Leads.CreateAsync(new LeadEndpointRequest { Model = new LeadRequest() });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LeadEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Leads.<a href="/src/Merge.Client/Crm/Leads/LeadsClient.cs">RetrieveAsync</a>(id, LeadsRetrieveRequest { ... }) -> Lead</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Lead` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Leads.RetrieveAsync("id", new LeadsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `LeadsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Leads.<a href="/src/Merge.Client/Crm/Leads/LeadsClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Lead` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Leads.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Leads.<a href="/src/Merge.Client/Crm/Leads/LeadsClient.cs">RemoteFieldClassesListAsync</a>(LeadsRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Leads.RemoteFieldClassesListAsync(new LeadsRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LeadsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm LinkToken
<details><summary><code>client.Crm.LinkToken.<a href="/src/Merge.Client/Crm/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Crm.LinkToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a link token to be used when linking a new end user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Crm.CategoriesEnum>()
        {
            Merge.Client.Crm.CategoriesEnum.Hris,
            Merge.Client.Crm.CategoriesEnum.Ats,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EndUserDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm LinkedAccounts
<details><summary><code>client.Crm.LinkedAccounts.<a href="/src/Merge.Client/Crm/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Crm.PaginatedAccountDetailsAndActionsList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List linked accounts for your organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Notes
<details><summary><code>client.Crm.Notes.<a href="/src/Merge.Client/Crm/Notes/NotesClient.cs">ListAsync</a>(NotesListRequest { ... }) -> PaginatedNoteList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Note` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Notes.ListAsync(new NotesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NotesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Notes.<a href="/src/Merge.Client/Crm/Notes/NotesClient.cs">CreateAsync</a>(NoteEndpointRequest { ... }) -> NoteResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Note` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Notes.CreateAsync(new NoteEndpointRequest { Model = new NoteRequest() });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NoteEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Notes.<a href="/src/Merge.Client/Crm/Notes/NotesClient.cs">RetrieveAsync</a>(id, NotesRetrieveRequest { ... }) -> Note</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Note` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Notes.RetrieveAsync("id", new NotesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `NotesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Notes.<a href="/src/Merge.Client/Crm/Notes/NotesClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Note` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Notes.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Notes.<a href="/src/Merge.Client/Crm/Notes/NotesClient.cs">RemoteFieldClassesListAsync</a>(NotesRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Notes.RemoteFieldClassesListAsync(new NotesRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NotesRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Opportunities
<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">ListAsync</a>(OpportunitiesListRequest { ... }) -> PaginatedOpportunityList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Opportunity` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.ListAsync(new OpportunitiesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OpportunitiesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">CreateAsync</a>(OpportunityEndpointRequest { ... }) -> OpportunityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Opportunity` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.CreateAsync(
    new OpportunityEndpointRequest { Model = new OpportunityRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OpportunityEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">RetrieveAsync</a>(id, OpportunitiesRetrieveRequest { ... }) -> Opportunity</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Opportunity` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.RetrieveAsync("id", new OpportunitiesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OpportunitiesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">PartialUpdateAsync</a>(id, PatchedOpportunityEndpointRequest { ... }) -> OpportunityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an `Opportunity` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.PartialUpdateAsync(
    "id",
    new PatchedOpportunityEndpointRequest { Model = new PatchedOpportunityRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedOpportunityEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">MetaPatchRetrieveAsync</a>(id) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Opportunity` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Opportunity` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Opportunities.<a href="/src/Merge.Client/Crm/Opportunities/OpportunitiesClient.cs">RemoteFieldClassesListAsync</a>(OpportunitiesRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Opportunities.RemoteFieldClassesListAsync(
    new OpportunitiesRemoteFieldClassesListRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OpportunitiesRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Passthrough
<details><summary><code>client.Crm.Passthrough.<a href="/src/Merge.Client/Crm/Passthrough/PassthroughClient.cs">CreateAsync</a>(Crm.DataPassthroughRequest { ... }) -> Crm.RemoteResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Passthrough.CreateAsync(
    new Merge.Client.Crm.DataPassthroughRequest
    {
        Method = Merge.Client.Crm.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Crm.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm RegenerateKey
<details><summary><code>client.Crm.RegenerateKey.<a href="/src/Merge.Client/Crm/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Crm.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchange remote keys.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.RegenerateKey.CreateAsync(
    new RemoteKeyForRegenerationRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteKeyForRegenerationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Stages
<details><summary><code>client.Crm.Stages.<a href="/src/Merge.Client/Crm/Stages/StagesClient.cs">ListAsync</a>(StagesListRequest { ... }) -> PaginatedStageList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Stage` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Stages.ListAsync(new StagesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StagesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Stages.<a href="/src/Merge.Client/Crm/Stages/StagesClient.cs">RetrieveAsync</a>(id, StagesRetrieveRequest { ... }) -> Stage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Stage` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Stages.RetrieveAsync("id", new StagesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `StagesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Stages.<a href="/src/Merge.Client/Crm/Stages/StagesClient.cs">RemoteFieldClassesListAsync</a>(StagesRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Stages.RemoteFieldClassesListAsync(new StagesRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StagesRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm SyncStatus
<details><summary><code>client.Crm.SyncStatus.<a href="/src/Merge.Client/Crm/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Crm.PaginatedSyncStatusList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get syncing status. Possible values: `DISABLED`, `DONE`, `FAILED`, `PARTIALLY_SYNCED`, `PAUSED`, `SYNCING`. Learn more about sync status in our [Help Center](https://help.merge.dev/en/articles/8184193-merge-sync-statuses).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.SyncStatus.ListAsync(new SyncStatusListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SyncStatusListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm ForceResync
<details><summary><code>client.Crm.ForceResync.<a href="/src/Merge.Client/Crm/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Crm.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Professional or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Tasks
<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">ListAsync</a>(TasksListRequest { ... }) -> PaginatedTaskList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Task` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.ListAsync(new TasksListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TasksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">CreateAsync</a>(TaskEndpointRequest { ... }) -> TaskResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Task` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.CreateAsync(new TaskEndpointRequest { Model = new TaskRequest() });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaskEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">RetrieveAsync</a>(id, TasksRetrieveRequest { ... }) -> Task</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Task` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.RetrieveAsync("id", new TasksRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `TasksRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">PartialUpdateAsync</a>(id, PatchedTaskEndpointRequest { ... }) -> TaskResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a `Task` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.PartialUpdateAsync(
    "id",
    new PatchedTaskEndpointRequest { Model = new PatchedTaskRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedTaskEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">MetaPatchRetrieveAsync</a>(id) -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Task` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.MetaPatchRetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">MetaPostRetrieveAsync</a>() -> Crm.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Task` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Tasks.<a href="/src/Merge.Client/Crm/Tasks/TasksClient.cs">RemoteFieldClassesListAsync</a>(TasksRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Tasks.RemoteFieldClassesListAsync(new TasksRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TasksRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm Users
<details><summary><code>client.Crm.Users.<a href="/src/Merge.Client/Crm/Users/UsersClient.cs">ListAsync</a>(UsersListRequest { ... }) -> Crm.PaginatedUserList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `User` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Users.ListAsync(new UsersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Users.<a href="/src/Merge.Client/Crm/Users/UsersClient.cs">RetrieveAsync</a>(id, UsersRetrieveRequest { ... }) -> Crm.User</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `User` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Users.RetrieveAsync("id", new UsersRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UsersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Users.<a href="/src/Merge.Client/Crm/Users/UsersClient.cs">IgnoreCreateAsync</a>(modelId, IgnoreCommonModelRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Users.IgnoreCreateAsync(
    "model_id",
    new IgnoreCommonModelRequest { Reason = Merge.Client.Crm.ReasonEnum.GeneralCustomerRequest }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**modelId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `IgnoreCommonModelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.Users.<a href="/src/Merge.Client/Crm/Users/UsersClient.cs">RemoteFieldClassesListAsync</a>(UsersRemoteFieldClassesListRequest { ... }) -> Crm.PaginatedRemoteFieldClassList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `RemoteFieldClass` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.Users.RemoteFieldClassesListAsync(new UsersRemoteFieldClassesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsersRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Crm WebhookReceivers
<details><summary><code>client.Crm.WebhookReceivers.<a href="/src/Merge.Client/Crm/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Crm.WebhookReceiver></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `WebhookReceiver` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Crm.WebhookReceivers.<a href="/src/Merge.Client/Crm/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Crm.WebhookReceiver</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `WebhookReceiver` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Crm.WebhookReceivers.CreateAsync(
    new WebhookReceiverRequest { Event = "event", IsActive = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WebhookReceiverRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage AccountDetails
<details><summary><code>client.Filestorage.AccountDetails.<a href="/src/Merge.Client/Filestorage/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Filestorage.AccountDetails</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details for a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage AccountToken
<details><summary><code>client.Filestorage.AccountToken.<a href="/src/Merge.Client/Filestorage/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Filestorage.AccountToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the account token for the end user with the provided public token.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AccountToken.RetrieveAsync("public_token");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**publicToken:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage AsyncPassthrough
<details><summary><code>client.Filestorage.AsyncPassthrough.<a href="/src/Merge.Client/Filestorage/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Filestorage.DataPassthroughRequest { ... }) -> Filestorage.AsyncPassthroughReciept</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Asynchronously pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AsyncPassthrough.CreateAsync(
    new Merge.Client.Filestorage.DataPassthroughRequest
    {
        Method = Merge.Client.Filestorage.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Filestorage.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.AsyncPassthrough.<a href="/src/Merge.Client/Filestorage/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> OneOf<Filestorage.RemoteResponse, string></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves data from earlier async-passthrough POST request
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**asyncPassthroughReceiptId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage AuditTrail
<details><summary><code>client.Filestorage.AuditTrail.<a href="/src/Merge.Client/Filestorage/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Filestorage.PaginatedAuditLogEventList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of audit trail events.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AuditTrail.ListAsync(new AuditTrailListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuditTrailListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage AvailableActions
<details><summary><code>client.Filestorage.AvailableActions.<a href="/src/Merge.Client/Filestorage/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Filestorage.AvailableActions</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of models and actions available for an account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Scopes
<details><summary><code>client.Filestorage.Scopes.<a href="/src/Merge.Client/Filestorage/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Filestorage.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Scopes.<a href="/src/Merge.Client/Filestorage/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Filestorage.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Scopes.<a href="/src/Merge.Client/Filestorage/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Filestorage.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels =
            new List<Merge.Client.Filestorage.IndividualCommonModelScopeDeserializerRequest>()
            {
                new Merge.Client.Filestorage.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Employee",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Filestorage.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "READ",
                            new Merge.Client.Filestorage.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = true,
                            }
                        },
                        {
                            "WRITE",
                            new Merge.Client.Filestorage.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = false,
                            }
                        },
                    },
                    FieldPermissions =
                        new Merge.Client.Filestorage.FieldPermissionDeserializerRequest
                        {
                            EnabledFields = new List<object>() { "avatar", "home_location" },
                            DisabledFields = new List<object>() { "work_location" },
                        },
                },
                new Merge.Client.Filestorage.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Benefit",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Filestorage.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "WRITE",
                            new Merge.Client.Filestorage.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = false,
                            }
                        },
                    },
                },
            },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountCommonModelScopeDeserializerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage DeleteAccount
<details><summary><code>client.Filestorage.DeleteAccount.<a href="/src/Merge.Client/Filestorage/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Drives
<details><summary><code>client.Filestorage.Drives.<a href="/src/Merge.Client/Filestorage/Drives/DrivesClient.cs">ListAsync</a>(DrivesListRequest { ... }) -> PaginatedDriveList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Drive` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Drives.ListAsync(new DrivesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DrivesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Drives.<a href="/src/Merge.Client/Filestorage/Drives/DrivesClient.cs">RetrieveAsync</a>(id, DrivesRetrieveRequest { ... }) -> Drive</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Drive` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Drives.RetrieveAsync("id", new DrivesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `DrivesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage FieldMapping
<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>(FieldMappingsRetrieveRequest { ... }) -> Filestorage.FieldMappingApiInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all Field Mappings for this Linked Account. Field Mappings are mappings between third-party Remote Fields and user defined Merge fields. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.FieldMappingsRetrieveAsync(
    new FieldMappingsRetrieveRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FieldMappingsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Filestorage.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create new Field Mappings that will be available after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.FieldMappingsCreateAsync(
    new CreateFieldMappingRequest
    {
        TargetFieldName = "example_target_field_name",
        TargetFieldDescription = "this is a example description of the target field",
        RemoteFieldTraversalPath = new List<object>() { "example_remote_field" },
        RemoteMethod = "GET",
        RemoteUrlPath = "/example-url-path",
        CommonModelName = "ExampleCommonModel",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Filestorage.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes Field Mappings for a Linked Account. All data related to this Field Mapping will be deleted and these changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Filestorage.FieldMappingInstanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create or update existing Field Mappings for a Linked Account. Changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.FieldMappingsPartialUpdateAsync(
    "field_mapping_id",
    new PatchedEditFieldMappingRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**fieldMappingId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchedEditFieldMappingRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Filestorage.RemoteFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all remote fields for a Linked Account. Remote fields are third-party fields that are accessible after initial sync if remote_data is enabled. You can use remote fields to override existing Merge fields or map a new Merge field. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteFieldsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Filestorage.ExternalTargetFieldApiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all organization-wide Target Fields, this will not include any Linked Account specific Target Fields. Organization-wide Target Fields are additional fields appended to the Merge Common Model for all Linked Accounts in a category. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/target-fields/).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Files
<details><summary><code>client.Filestorage.Files.<a href="/src/Merge.Client/Filestorage/Files/FilesClient.cs">ListAsync</a>(FilesListRequest { ... }) -> PaginatedFileList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `File` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Files.ListAsync(new FilesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FilesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Files.<a href="/src/Merge.Client/Filestorage/Files/FilesClient.cs">CreateAsync</a>(FileStorageFileEndpointRequest { ... }) -> FileStorageFileResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `File` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Files.CreateAsync(
    new FileStorageFileEndpointRequest { Model = new FileRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FileStorageFileEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Files.<a href="/src/Merge.Client/Filestorage/Files/FilesClient.cs">RetrieveAsync</a>(id, FilesRetrieveRequest { ... }) -> File</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `File` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Files.RetrieveAsync("id", new FilesRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `FilesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Files.<a href="/src/Merge.Client/Filestorage/Files/FilesClient.cs">DownloadRetrieveAsync</a>(id, FilesDownloadRetrieveRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the `File` content with the given `id` as a stream of bytes.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Files.DownloadRetrieveAsync(
    "string",
    new FilesDownloadRetrieveRequest { MimeType = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `FilesDownloadRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Files.<a href="/src/Merge.Client/Filestorage/Files/FilesClient.cs">MetaPostRetrieveAsync</a>() -> Filestorage.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `FileStorageFile` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Files.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Folders
<details><summary><code>client.Filestorage.Folders.<a href="/src/Merge.Client/Filestorage/Folders/FoldersClient.cs">ListAsync</a>(FoldersListRequest { ... }) -> PaginatedFolderList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Folder` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Folders.ListAsync(new FoldersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FoldersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Folders.<a href="/src/Merge.Client/Filestorage/Folders/FoldersClient.cs">CreateAsync</a>(FileStorageFolderEndpointRequest { ... }) -> FileStorageFolderResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Folder` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Folders.CreateAsync(
    new FileStorageFolderEndpointRequest { Model = new FolderRequest() }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FileStorageFolderEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Folders.<a href="/src/Merge.Client/Filestorage/Folders/FoldersClient.cs">RetrieveAsync</a>(id, FoldersRetrieveRequest { ... }) -> Folder</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Folder` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Folders.RetrieveAsync("id", new FoldersRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `FoldersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Folders.<a href="/src/Merge.Client/Filestorage/Folders/FoldersClient.cs">MetaPostRetrieveAsync</a>() -> Filestorage.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `FileStorageFolder` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Folders.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage GenerateKey
<details><summary><code>client.Filestorage.GenerateKey.<a href="/src/Merge.Client/Filestorage/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Filestorage.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a remote key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.GenerateKey.CreateAsync(
    new GenerateRemoteKeyRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GenerateRemoteKeyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Groups
<details><summary><code>client.Filestorage.Groups.<a href="/src/Merge.Client/Filestorage/Groups/GroupsClient.cs">ListAsync</a>(GroupsListRequest { ... }) -> Filestorage.PaginatedGroupList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Group` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Groups.ListAsync(new GroupsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Groups.<a href="/src/Merge.Client/Filestorage/Groups/GroupsClient.cs">RetrieveAsync</a>(id, GroupsRetrieveRequest { ... }) -> Filestorage.Group</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Group` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Groups.RetrieveAsync("id", new GroupsRetrieveRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `GroupsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Issues
<details><summary><code>client.Filestorage.Issues.<a href="/src/Merge.Client/Filestorage/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Filestorage.PaginatedIssueList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets all issues for Organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Issues.ListAsync(new IssuesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.Issues.<a href="/src/Merge.Client/Filestorage/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Filestorage.Issue</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific issue.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Issues.RetrieveAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage LinkToken
<details><summary><code>client.Filestorage.LinkToken.<a href="/src/Merge.Client/Filestorage/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Filestorage.LinkToken</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a link token to be used when linking a new end user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Filestorage.CategoriesEnum>()
        {
            Merge.Client.Filestorage.CategoriesEnum.Hris,
            Merge.Client.Filestorage.CategoriesEnum.Ats,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EndUserDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage LinkedAccounts
<details><summary><code>client.Filestorage.LinkedAccounts.<a href="/src/Merge.Client/Filestorage/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Filestorage.PaginatedAccountDetailsAndActionsList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List linked accounts for your organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LinkedAccountsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Passthrough
<details><summary><code>client.Filestorage.Passthrough.<a href="/src/Merge.Client/Filestorage/Passthrough/PassthroughClient.cs">CreateAsync</a>(Filestorage.DataPassthroughRequest { ... }) -> Filestorage.RemoteResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Pull data from an endpoint not currently supported by Merge.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.Passthrough.CreateAsync(
    new Merge.Client.Filestorage.DataPassthroughRequest
    {
        Method = Merge.Client.Filestorage.MethodEnum.Get,
        Path = "/scooters",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Filestorage.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage RegenerateKey
<details><summary><code>client.Filestorage.RegenerateKey.<a href="/src/Merge.Client/Filestorage/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Filestorage.RemoteKey</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchange remote keys.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.RegenerateKey.CreateAsync(
    new RemoteKeyForRegenerationRequest { Name = "Remote Deployment Key 1" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoteKeyForRegenerationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage SyncStatus