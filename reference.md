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