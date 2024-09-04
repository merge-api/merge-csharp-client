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
</dd>
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

<details><summary><code>client.Ats.AsyncPassthrough.<a href="/src/Merge.Client/Ats/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Ats.RemoteResponse</code></summary>
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

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
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
<details><summary><code>client.Ats.FieldMapping.<a href="/src/Merge.Client/Ats/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Ats.FieldMappingApiInstanceResponse</code></summary>
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
await client.Ats.FieldMapping.FieldMappingsRetrieveAsync();
```
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

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
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

<details><summary><code>client.Crm.AsyncPassthrough.<a href="/src/Merge.Client/Crm/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Crm.RemoteResponse</code></summary>
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

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
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
<details><summary><code>client.Crm.FieldMapping.<a href="/src/Merge.Client/Crm/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Crm.FieldMappingApiInstanceResponse</code></summary>
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
await client.Crm.FieldMapping.FieldMappingsRetrieveAsync();
```
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

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
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

<details><summary><code>client.Filestorage.AsyncPassthrough.<a href="/src/Merge.Client/Filestorage/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Filestorage.RemoteResponse</code></summary>
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

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
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

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
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
<details><summary><code>client.Filestorage.FieldMapping.<a href="/src/Merge.Client/Filestorage/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Filestorage.FieldMappingApiInstanceResponse</code></summary>
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
await client.Filestorage.FieldMapping.FieldMappingsRetrieveAsync();
```
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
<details><summary><code>client.Filestorage.SyncStatus.<a href="/src/Merge.Client/Filestorage/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Filestorage.PaginatedSyncStatusList</code></summary>
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
await client.Filestorage.SyncStatus.ListAsync(new SyncStatusListRequest());
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

## Filestorage ForceResync
<details><summary><code>client.Filestorage.ForceResync.<a href="/src/Merge.Client/Filestorage/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Filestorage.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Filestorage.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Filestorage Users
<details><summary><code>client.Filestorage.Users.<a href="/src/Merge.Client/Filestorage/Users/UsersClient.cs">ListAsync</a>(UsersListRequest { ... }) -> Filestorage.PaginatedUserList</code></summary>
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
await client.Filestorage.Users.ListAsync(new UsersListRequest());
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

<details><summary><code>client.Filestorage.Users.<a href="/src/Merge.Client/Filestorage/Users/UsersClient.cs">RetrieveAsync</a>(id, UsersRetrieveRequest { ... }) -> Filestorage.User</code></summary>
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
await client.Filestorage.Users.RetrieveAsync("id", new UsersRetrieveRequest());
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

## Filestorage WebhookReceivers
<details><summary><code>client.Filestorage.WebhookReceivers.<a href="/src/Merge.Client/Filestorage/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Filestorage.WebhookReceiver></code></summary>
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
await client.Filestorage.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Filestorage.WebhookReceivers.<a href="/src/Merge.Client/Filestorage/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Filestorage.WebhookReceiver</code></summary>
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
await client.Filestorage.WebhookReceivers.CreateAsync(
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

## Hris AccountDetails
<details><summary><code>client.Hris.AccountDetails.<a href="/src/Merge.Client/Hris/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Hris.AccountDetails</code></summary>
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
await client.Hris.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris AccountToken
<details><summary><code>client.Hris.AccountToken.<a href="/src/Merge.Client/Hris/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Hris.AccountToken</code></summary>
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
await client.Hris.AccountToken.RetrieveAsync("public_token");
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

## Hris AsyncPassthrough
<details><summary><code>client.Hris.AsyncPassthrough.<a href="/src/Merge.Client/Hris/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Hris.DataPassthroughRequest { ... }) -> Hris.AsyncPassthroughReciept</code></summary>
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
await client.Hris.AsyncPassthrough.CreateAsync(
    new Merge.Client.Hris.DataPassthroughRequest
    {
        Method = Merge.Client.Hris.MethodEnum.Get,
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

**request:** `Hris.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.AsyncPassthrough.<a href="/src/Merge.Client/Hris/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Hris.RemoteResponse</code></summary>
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
await client.Hris.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
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

## Hris AuditTrail
<details><summary><code>client.Hris.AuditTrail.<a href="/src/Merge.Client/Hris/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Hris.PaginatedAuditLogEventList</code></summary>
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
await client.Hris.AuditTrail.ListAsync(new AuditTrailListRequest());
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

## Hris AvailableActions
<details><summary><code>client.Hris.AvailableActions.<a href="/src/Merge.Client/Hris/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Hris.AvailableActions</code></summary>
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
await client.Hris.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris BankInfo
<details><summary><code>client.Hris.BankInfo.<a href="/src/Merge.Client/Hris/BankInfo/BankInfoClient.cs">ListAsync</a>(BankInfoListRequest { ... }) -> PaginatedBankInfoList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `BankInfo` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.BankInfo.ListAsync(new BankInfoListRequest());
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

**request:** `BankInfoListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.BankInfo.<a href="/src/Merge.Client/Hris/BankInfo/BankInfoClient.cs">RetrieveAsync</a>(id, BankInfoRetrieveRequest { ... }) -> BankInfo</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `BankInfo` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.BankInfo.RetrieveAsync("id", new BankInfoRetrieveRequest());
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

**request:** `BankInfoRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Benefits
<details><summary><code>client.Hris.Benefits.<a href="/src/Merge.Client/Hris/Benefits/BenefitsClient.cs">ListAsync</a>(BenefitsListRequest { ... }) -> PaginatedBenefitList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Benefit` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Benefits.ListAsync(new BenefitsListRequest());
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

**request:** `BenefitsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Benefits.<a href="/src/Merge.Client/Hris/Benefits/BenefitsClient.cs">RetrieveAsync</a>(id, BenefitsRetrieveRequest { ... }) -> Benefit</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Benefit` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Benefits.RetrieveAsync("id", new BenefitsRetrieveRequest());
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

**request:** `BenefitsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Companies
<details><summary><code>client.Hris.Companies.<a href="/src/Merge.Client/Hris/Companies/CompaniesClient.cs">ListAsync</a>(CompaniesListRequest { ... }) -> PaginatedCompanyList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Company` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Companies.ListAsync(new CompaniesListRequest());
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

**request:** `CompaniesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Companies.<a href="/src/Merge.Client/Hris/Companies/CompaniesClient.cs">RetrieveAsync</a>(id, CompaniesRetrieveRequest { ... }) -> Company</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Company` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Companies.RetrieveAsync("id", new CompaniesRetrieveRequest());
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

**request:** `CompaniesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Scopes
<details><summary><code>client.Hris.Scopes.<a href="/src/Merge.Client/Hris/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Hris.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Scopes.<a href="/src/Merge.Client/Hris/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Hris.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Scopes.<a href="/src/Merge.Client/Hris/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Hris.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels = new List<Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest>()
        {
            new Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Employee",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Hris.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "READ",
                        new Merge.Client.Hris.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = true,
                        }
                    },
                    {
                        "WRITE",
                        new Merge.Client.Hris.ModelPermissionDeserializerRequest
                        {
                            IsEnabled = false,
                        }
                    },
                },
            },
            new Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest
            {
                ModelName = "Benefit",
                ModelPermissions = new Dictionary<
                    string,
                    Merge.Client.Hris.ModelPermissionDeserializerRequest
                >()
                {
                    {
                        "WRITE",
                        new Merge.Client.Hris.ModelPermissionDeserializerRequest
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

## Hris DeleteAccount
<details><summary><code>client.Hris.DeleteAccount.<a href="/src/Merge.Client/Hris/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
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
await client.Hris.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Dependents
<details><summary><code>client.Hris.Dependents.<a href="/src/Merge.Client/Hris/Dependents/DependentsClient.cs">ListAsync</a>(DependentsListRequest { ... }) -> PaginatedDependentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Dependent` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Dependents.ListAsync(new DependentsListRequest());
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

**request:** `DependentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Dependents.<a href="/src/Merge.Client/Hris/Dependents/DependentsClient.cs">RetrieveAsync</a>(id, DependentsRetrieveRequest { ... }) -> Dependent</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Dependent` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Dependents.RetrieveAsync("id", new DependentsRetrieveRequest());
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

**request:** `DependentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris EmployeePayrollRuns
<details><summary><code>client.Hris.EmployeePayrollRuns.<a href="/src/Merge.Client/Hris/EmployeePayrollRuns/EmployeePayrollRunsClient.cs">ListAsync</a>(EmployeePayrollRunsListRequest { ... }) -> PaginatedEmployeePayrollRunList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `EmployeePayrollRun` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.EmployeePayrollRuns.ListAsync(new EmployeePayrollRunsListRequest());
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

**request:** `EmployeePayrollRunsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.EmployeePayrollRuns.<a href="/src/Merge.Client/Hris/EmployeePayrollRuns/EmployeePayrollRunsClient.cs">RetrieveAsync</a>(id, EmployeePayrollRunsRetrieveRequest { ... }) -> EmployeePayrollRun</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `EmployeePayrollRun` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.EmployeePayrollRuns.RetrieveAsync("id", new EmployeePayrollRunsRetrieveRequest());
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

**request:** `EmployeePayrollRunsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Employees
<details><summary><code>client.Hris.Employees.<a href="/src/Merge.Client/Hris/Employees/EmployeesClient.cs">ListAsync</a>(EmployeesListRequest { ... }) -> PaginatedEmployeeList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Employee` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employees.ListAsync(new EmployeesListRequest());
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

**request:** `EmployeesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Employees.<a href="/src/Merge.Client/Hris/Employees/EmployeesClient.cs">CreateAsync</a>(EmployeeEndpointRequest { ... }) -> EmployeeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Employee` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employees.CreateAsync(
    new EmployeeEndpointRequest { Model = new EmployeeRequest() }
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

**request:** `EmployeeEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Employees.<a href="/src/Merge.Client/Hris/Employees/EmployeesClient.cs">RetrieveAsync</a>(id, EmployeesRetrieveRequest { ... }) -> Employee</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Employee` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employees.RetrieveAsync("id", new EmployeesRetrieveRequest());
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

**request:** `EmployeesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Employees.<a href="/src/Merge.Client/Hris/Employees/EmployeesClient.cs">IgnoreCreateAsync</a>(modelId, Hris.IgnoreCommonModelRequest { ... })</code></summary>
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
await client.Hris.Employees.IgnoreCreateAsync(
    "model_id",
    new Merge.Client.Hris.IgnoreCommonModelRequest
    {
        Reason = Merge.Client.Hris.ReasonEnum.GeneralCustomerRequest,
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

**request:** `Hris.IgnoreCommonModelRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Employees.<a href="/src/Merge.Client/Hris/Employees/EmployeesClient.cs">MetaPostRetrieveAsync</a>() -> Hris.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Employee` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employees.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris EmployerBenefits
<details><summary><code>client.Hris.EmployerBenefits.<a href="/src/Merge.Client/Hris/EmployerBenefits/EmployerBenefitsClient.cs">ListAsync</a>(EmployerBenefitsListRequest { ... }) -> PaginatedEmployerBenefitList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `EmployerBenefit` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.EmployerBenefits.ListAsync(new EmployerBenefitsListRequest());
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

**request:** `EmployerBenefitsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.EmployerBenefits.<a href="/src/Merge.Client/Hris/EmployerBenefits/EmployerBenefitsClient.cs">RetrieveAsync</a>(id, EmployerBenefitsRetrieveRequest { ... }) -> EmployerBenefit</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `EmployerBenefit` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.EmployerBenefits.RetrieveAsync("id", new EmployerBenefitsRetrieveRequest());
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

**request:** `EmployerBenefitsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Employments
<details><summary><code>client.Hris.Employments.<a href="/src/Merge.Client/Hris/Employments/EmploymentsClient.cs">ListAsync</a>(EmploymentsListRequest { ... }) -> PaginatedEmploymentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Employment` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employments.ListAsync(new EmploymentsListRequest());
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

**request:** `EmploymentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Employments.<a href="/src/Merge.Client/Hris/Employments/EmploymentsClient.cs">RetrieveAsync</a>(id, EmploymentsRetrieveRequest { ... }) -> Employment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Employment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Employments.RetrieveAsync("id", new EmploymentsRetrieveRequest());
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

**request:** `EmploymentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris FieldMapping
<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Hris.FieldMappingApiInstanceResponse</code></summary>
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
await client.Hris.FieldMapping.FieldMappingsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Hris.FieldMappingInstanceResponse</code></summary>
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
await client.Hris.FieldMapping.FieldMappingsCreateAsync(
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

<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Hris.FieldMappingInstanceResponse</code></summary>
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
await client.Hris.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
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

<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Hris.FieldMappingInstanceResponse</code></summary>
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
await client.Hris.FieldMapping.FieldMappingsPartialUpdateAsync(
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

<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Hris.RemoteFieldApiResponse</code></summary>
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
await client.Hris.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
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

<details><summary><code>client.Hris.FieldMapping.<a href="/src/Merge.Client/Hris/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Hris.ExternalTargetFieldApiResponse</code></summary>
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
await client.Hris.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris GenerateKey
<details><summary><code>client.Hris.GenerateKey.<a href="/src/Merge.Client/Hris/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Hris.RemoteKey</code></summary>
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
await client.Hris.GenerateKey.CreateAsync(
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

## Hris Groups
<details><summary><code>client.Hris.Groups.<a href="/src/Merge.Client/Hris/Groups/GroupsClient.cs">ListAsync</a>(GroupsListRequest { ... }) -> Hris.PaginatedGroupList</code></summary>
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
await client.Hris.Groups.ListAsync(new GroupsListRequest());
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

<details><summary><code>client.Hris.Groups.<a href="/src/Merge.Client/Hris/Groups/GroupsClient.cs">RetrieveAsync</a>(id, GroupsRetrieveRequest { ... }) -> Hris.Group</code></summary>
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
await client.Hris.Groups.RetrieveAsync("id", new GroupsRetrieveRequest());
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

## Hris Issues
<details><summary><code>client.Hris.Issues.<a href="/src/Merge.Client/Hris/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Hris.PaginatedIssueList</code></summary>
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
await client.Hris.Issues.ListAsync(new IssuesListRequest());
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

<details><summary><code>client.Hris.Issues.<a href="/src/Merge.Client/Hris/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Hris.Issue</code></summary>
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
await client.Hris.Issues.RetrieveAsync("id");
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

## Hris LinkToken
<details><summary><code>client.Hris.LinkToken.<a href="/src/Merge.Client/Hris/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Hris.LinkToken</code></summary>
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
await client.Hris.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Hris.CategoriesEnum>()
        {
            Merge.Client.Hris.CategoriesEnum.Hris,
            Merge.Client.Hris.CategoriesEnum.Ats,
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

## Hris LinkedAccounts
<details><summary><code>client.Hris.LinkedAccounts.<a href="/src/Merge.Client/Hris/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Hris.PaginatedAccountDetailsAndActionsList</code></summary>
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
await client.Hris.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
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

## Hris Locations
<details><summary><code>client.Hris.Locations.<a href="/src/Merge.Client/Hris/Locations/LocationsClient.cs">ListAsync</a>(LocationsListRequest { ... }) -> PaginatedLocationList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Location` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Locations.ListAsync(new LocationsListRequest());
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

**request:** `LocationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Locations.<a href="/src/Merge.Client/Hris/Locations/LocationsClient.cs">RetrieveAsync</a>(id, LocationsRetrieveRequest { ... }) -> Location</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Location` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Locations.RetrieveAsync("id", new LocationsRetrieveRequest());
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

**request:** `LocationsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Passthrough
<details><summary><code>client.Hris.Passthrough.<a href="/src/Merge.Client/Hris/Passthrough/PassthroughClient.cs">CreateAsync</a>(Hris.DataPassthroughRequest { ... }) -> Hris.RemoteResponse</code></summary>
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
await client.Hris.Passthrough.CreateAsync(
    new Merge.Client.Hris.DataPassthroughRequest
    {
        Method = Merge.Client.Hris.MethodEnum.Get,
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

**request:** `Hris.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris PayGroups
<details><summary><code>client.Hris.PayGroups.<a href="/src/Merge.Client/Hris/PayGroups/PayGroupsClient.cs">ListAsync</a>(PayGroupsListRequest { ... }) -> PaginatedPayGroupList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `PayGroup` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.PayGroups.ListAsync(new PayGroupsListRequest());
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

**request:** `PayGroupsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.PayGroups.<a href="/src/Merge.Client/Hris/PayGroups/PayGroupsClient.cs">RetrieveAsync</a>(id, PayGroupsRetrieveRequest { ... }) -> PayGroup</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `PayGroup` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.PayGroups.RetrieveAsync("id", new PayGroupsRetrieveRequest());
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

**request:** `PayGroupsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris PayrollRuns
<details><summary><code>client.Hris.PayrollRuns.<a href="/src/Merge.Client/Hris/PayrollRuns/PayrollRunsClient.cs">ListAsync</a>(PayrollRunsListRequest { ... }) -> PaginatedPayrollRunList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `PayrollRun` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.PayrollRuns.ListAsync(new PayrollRunsListRequest());
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

**request:** `PayrollRunsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.PayrollRuns.<a href="/src/Merge.Client/Hris/PayrollRuns/PayrollRunsClient.cs">RetrieveAsync</a>(id, PayrollRunsRetrieveRequest { ... }) -> PayrollRun</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `PayrollRun` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.PayrollRuns.RetrieveAsync("id", new PayrollRunsRetrieveRequest());
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

**request:** `PayrollRunsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris RegenerateKey
<details><summary><code>client.Hris.RegenerateKey.<a href="/src/Merge.Client/Hris/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Hris.RemoteKey</code></summary>
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
await client.Hris.RegenerateKey.CreateAsync(
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

## Hris SyncStatus
<details><summary><code>client.Hris.SyncStatus.<a href="/src/Merge.Client/Hris/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Hris.PaginatedSyncStatusList</code></summary>
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
await client.Hris.SyncStatus.ListAsync(new SyncStatusListRequest());
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

## Hris ForceResync
<details><summary><code>client.Hris.ForceResync.<a href="/src/Merge.Client/Hris/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Hris.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris Teams
<details><summary><code>client.Hris.Teams.<a href="/src/Merge.Client/Hris/Teams/TeamsClient.cs">ListAsync</a>(TeamsListRequest { ... }) -> Hris.PaginatedTeamList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Team` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Teams.ListAsync(new TeamsListRequest());
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

**request:** `TeamsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.Teams.<a href="/src/Merge.Client/Hris/Teams/TeamsClient.cs">RetrieveAsync</a>(id, TeamsRetrieveRequest { ... }) -> Hris.Team</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Team` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.Teams.RetrieveAsync("id", new TeamsRetrieveRequest());
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

**request:** `TeamsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris TimeOff
<details><summary><code>client.Hris.TimeOff.<a href="/src/Merge.Client/Hris/TimeOff/TimeOffClient.cs">ListAsync</a>(TimeOffListRequest { ... }) -> PaginatedTimeOffList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `TimeOff` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOff.ListAsync(new TimeOffListRequest());
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

**request:** `TimeOffListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimeOff.<a href="/src/Merge.Client/Hris/TimeOff/TimeOffClient.cs">CreateAsync</a>(TimeOffEndpointRequest { ... }) -> TimeOffResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `TimeOff` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOff.CreateAsync(new TimeOffEndpointRequest { Model = new TimeOffRequest() });
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

**request:** `TimeOffEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimeOff.<a href="/src/Merge.Client/Hris/TimeOff/TimeOffClient.cs">RetrieveAsync</a>(id, TimeOffRetrieveRequest { ... }) -> TimeOff</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `TimeOff` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOff.RetrieveAsync("id", new TimeOffRetrieveRequest());
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

**request:** `TimeOffRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimeOff.<a href="/src/Merge.Client/Hris/TimeOff/TimeOffClient.cs">MetaPostRetrieveAsync</a>() -> Hris.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `TimeOff` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOff.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris TimeOffBalances
<details><summary><code>client.Hris.TimeOffBalances.<a href="/src/Merge.Client/Hris/TimeOffBalances/TimeOffBalancesClient.cs">ListAsync</a>(TimeOffBalancesListRequest { ... }) -> PaginatedTimeOffBalanceList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `TimeOffBalance` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOffBalances.ListAsync(new TimeOffBalancesListRequest());
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

**request:** `TimeOffBalancesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimeOffBalances.<a href="/src/Merge.Client/Hris/TimeOffBalances/TimeOffBalancesClient.cs">RetrieveAsync</a>(id, TimeOffBalancesRetrieveRequest { ... }) -> TimeOffBalance</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `TimeOffBalance` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimeOffBalances.RetrieveAsync("id", new TimeOffBalancesRetrieveRequest());
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

**request:** `TimeOffBalancesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris TimesheetEntries
<details><summary><code>client.Hris.TimesheetEntries.<a href="/src/Merge.Client/Hris/TimesheetEntries/TimesheetEntriesClient.cs">ListAsync</a>(TimesheetEntriesListRequest { ... }) -> PaginatedTimesheetEntryList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `TimesheetEntry` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimesheetEntries.ListAsync(new TimesheetEntriesListRequest());
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

**request:** `TimesheetEntriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimesheetEntries.<a href="/src/Merge.Client/Hris/TimesheetEntries/TimesheetEntriesClient.cs">CreateAsync</a>(TimesheetEntryEndpointRequest { ... }) -> TimesheetEntryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `TimesheetEntry` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimesheetEntries.CreateAsync(
    new TimesheetEntryEndpointRequest { Model = new TimesheetEntryRequest() }
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

**request:** `TimesheetEntryEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimesheetEntries.<a href="/src/Merge.Client/Hris/TimesheetEntries/TimesheetEntriesClient.cs">RetrieveAsync</a>(id, TimesheetEntriesRetrieveRequest { ... }) -> TimesheetEntry</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `TimesheetEntry` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimesheetEntries.RetrieveAsync("id", new TimesheetEntriesRetrieveRequest());
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

**request:** `TimesheetEntriesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.TimesheetEntries.<a href="/src/Merge.Client/Hris/TimesheetEntries/TimesheetEntriesClient.cs">MetaPostRetrieveAsync</a>() -> Hris.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `TimesheetEntry` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hris.TimesheetEntries.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hris WebhookReceivers
<details><summary><code>client.Hris.WebhookReceivers.<a href="/src/Merge.Client/Hris/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Hris.WebhookReceiver></code></summary>
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
await client.Hris.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hris.WebhookReceivers.<a href="/src/Merge.Client/Hris/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Hris.WebhookReceiver</code></summary>
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
await client.Hris.WebhookReceivers.CreateAsync(
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

## Ticketing AccountDetails
<details><summary><code>client.Ticketing.AccountDetails.<a href="/src/Merge.Client/Ticketing/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Ticketing.AccountDetails</code></summary>
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
await client.Ticketing.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing AccountToken
<details><summary><code>client.Ticketing.AccountToken.<a href="/src/Merge.Client/Ticketing/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Ticketing.AccountToken</code></summary>
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
await client.Ticketing.AccountToken.RetrieveAsync("public_token");
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

## Ticketing Accounts
<details><summary><code>client.Ticketing.Accounts.<a href="/src/Merge.Client/Ticketing/Accounts/AccountsClient.cs">ListAsync</a>(AccountsListRequest { ... }) -> Ticketing.PaginatedAccountList</code></summary>
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
await client.Ticketing.Accounts.ListAsync(new AccountsListRequest());
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

<details><summary><code>client.Ticketing.Accounts.<a href="/src/Merge.Client/Ticketing/Accounts/AccountsClient.cs">RetrieveAsync</a>(id, AccountsRetrieveRequest { ... }) -> Ticketing.Account</code></summary>
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
await client.Ticketing.Accounts.RetrieveAsync("id", new AccountsRetrieveRequest());
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

## Ticketing AsyncPassthrough
<details><summary><code>client.Ticketing.AsyncPassthrough.<a href="/src/Merge.Client/Ticketing/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Ticketing.DataPassthroughRequest { ... }) -> Ticketing.AsyncPassthroughReciept</code></summary>
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
await client.Ticketing.AsyncPassthrough.CreateAsync(
    new Merge.Client.Ticketing.DataPassthroughRequest
    {
        Method = Merge.Client.Ticketing.MethodEnum.Get,
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

**request:** `Ticketing.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.AsyncPassthrough.<a href="/src/Merge.Client/Ticketing/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Ticketing.RemoteResponse</code></summary>
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
await client.Ticketing.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
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

## Ticketing Attachments
<details><summary><code>client.Ticketing.Attachments.<a href="/src/Merge.Client/Ticketing/Attachments/AttachmentsClient.cs">ListAsync</a>(AttachmentsListRequest { ... }) -> Ticketing.PaginatedAttachmentList</code></summary>
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
await client.Ticketing.Attachments.ListAsync(new AttachmentsListRequest());
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

<details><summary><code>client.Ticketing.Attachments.<a href="/src/Merge.Client/Ticketing/Attachments/AttachmentsClient.cs">CreateAsync</a>(TicketingAttachmentEndpointRequest { ... }) -> TicketingAttachmentResponse</code></summary>
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
await client.Ticketing.Attachments.CreateAsync(
    new TicketingAttachmentEndpointRequest
    {
        Model = new Merge.Client.Ticketing.AttachmentRequest(),
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

**request:** `TicketingAttachmentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Attachments.<a href="/src/Merge.Client/Ticketing/Attachments/AttachmentsClient.cs">RetrieveAsync</a>(id, AttachmentsRetrieveRequest { ... }) -> Ticketing.Attachment</code></summary>
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
await client.Ticketing.Attachments.RetrieveAsync("id", new AttachmentsRetrieveRequest());
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

<details><summary><code>client.Ticketing.Attachments.<a href="/src/Merge.Client/Ticketing/Attachments/AttachmentsClient.cs">DownloadRetrieveAsync</a>(id, AttachmentsDownloadRetrieveRequest { ... })</code></summary>
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
await client.Ticketing.Attachments.DownloadRetrieveAsync(
    "string",
    new AttachmentsDownloadRetrieveRequest { MimeType = "string" }
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

**request:** `AttachmentsDownloadRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Attachments.<a href="/src/Merge.Client/Ticketing/Attachments/AttachmentsClient.cs">MetaPostRetrieveAsync</a>() -> Ticketing.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `TicketingAttachment` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Attachments.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing AuditTrail
<details><summary><code>client.Ticketing.AuditTrail.<a href="/src/Merge.Client/Ticketing/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Ticketing.PaginatedAuditLogEventList</code></summary>
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
await client.Ticketing.AuditTrail.ListAsync(new AuditTrailListRequest());
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

## Ticketing AvailableActions
<details><summary><code>client.Ticketing.AvailableActions.<a href="/src/Merge.Client/Ticketing/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Ticketing.AvailableActions</code></summary>
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
await client.Ticketing.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Collections
<details><summary><code>client.Ticketing.Collections.<a href="/src/Merge.Client/Ticketing/Collections/CollectionsClient.cs">ListAsync</a>(CollectionsListRequest { ... }) -> PaginatedCollectionList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Collection` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Collections.ListAsync(new CollectionsListRequest());
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

**request:** `CollectionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Collections.<a href="/src/Merge.Client/Ticketing/Collections/CollectionsClient.cs">RetrieveAsync</a>(id, CollectionsRetrieveRequest { ... }) -> Collection</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Collection` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Collections.RetrieveAsync("id", new CollectionsRetrieveRequest());
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

**request:** `CollectionsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Collections.<a href="/src/Merge.Client/Ticketing/Collections/CollectionsClient.cs">UsersListAsync</a>(parentId, CollectionsUsersListRequest { ... }) -> Ticketing.PaginatedUserList</code></summary>
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
await client.Ticketing.Collections.UsersListAsync("parent_id", new CollectionsUsersListRequest());
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

**parentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CollectionsUsersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Comments
<details><summary><code>client.Ticketing.Comments.<a href="/src/Merge.Client/Ticketing/Comments/CommentsClient.cs">ListAsync</a>(CommentsListRequest { ... }) -> PaginatedCommentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Comment` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Comments.ListAsync(new CommentsListRequest());
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

**request:** `CommentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Comments.<a href="/src/Merge.Client/Ticketing/Comments/CommentsClient.cs">CreateAsync</a>(CommentEndpointRequest { ... }) -> CommentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Comment` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Comments.CreateAsync(
    new CommentEndpointRequest { Model = new CommentRequest() }
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

**request:** `CommentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Comments.<a href="/src/Merge.Client/Ticketing/Comments/CommentsClient.cs">RetrieveAsync</a>(id, CommentsRetrieveRequest { ... }) -> Comment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Comment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Comments.RetrieveAsync("id", new CommentsRetrieveRequest());
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

**request:** `CommentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Comments.<a href="/src/Merge.Client/Ticketing/Comments/CommentsClient.cs">MetaPostRetrieveAsync</a>() -> Ticketing.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Comment` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Comments.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Contacts
<details><summary><code>client.Ticketing.Contacts.<a href="/src/Merge.Client/Ticketing/Contacts/ContactsClient.cs">ListAsync</a>(ContactsListRequest { ... }) -> Ticketing.PaginatedContactList</code></summary>
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
await client.Ticketing.Contacts.ListAsync(new ContactsListRequest());
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

<details><summary><code>client.Ticketing.Contacts.<a href="/src/Merge.Client/Ticketing/Contacts/ContactsClient.cs">CreateAsync</a>(TicketingContactEndpointRequest { ... }) -> TicketingContactResponse</code></summary>
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
await client.Ticketing.Contacts.CreateAsync(
    new TicketingContactEndpointRequest { Model = new Merge.Client.Ticketing.ContactRequest() }
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

**request:** `TicketingContactEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Contacts.<a href="/src/Merge.Client/Ticketing/Contacts/ContactsClient.cs">RetrieveAsync</a>(id, ContactsRetrieveRequest { ... }) -> Ticketing.Contact</code></summary>
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
await client.Ticketing.Contacts.RetrieveAsync("id", new ContactsRetrieveRequest());
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

<details><summary><code>client.Ticketing.Contacts.<a href="/src/Merge.Client/Ticketing/Contacts/ContactsClient.cs">MetaPostRetrieveAsync</a>() -> Ticketing.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `TicketingContact` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Contacts.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Scopes
<details><summary><code>client.Ticketing.Scopes.<a href="/src/Merge.Client/Ticketing/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Ticketing.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Scopes.<a href="/src/Merge.Client/Ticketing/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Ticketing.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Scopes.<a href="/src/Merge.Client/Ticketing/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Ticketing.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels =
            new List<Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest>()
            {
                new Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Employee",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Ticketing.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "READ",
                            new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = true,
                            }
                        },
                        {
                            "WRITE",
                            new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = false,
                            }
                        },
                    },
                },
                new Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Benefit",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Ticketing.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "WRITE",
                            new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
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

## Ticketing DeleteAccount
<details><summary><code>client.Ticketing.DeleteAccount.<a href="/src/Merge.Client/Ticketing/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
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
await client.Ticketing.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing FieldMapping
<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Ticketing.FieldMappingApiInstanceResponse</code></summary>
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
await client.Ticketing.FieldMapping.FieldMappingsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Ticketing.FieldMappingInstanceResponse</code></summary>
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
await client.Ticketing.FieldMapping.FieldMappingsCreateAsync(
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

<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Ticketing.FieldMappingInstanceResponse</code></summary>
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
await client.Ticketing.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
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

<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Ticketing.FieldMappingInstanceResponse</code></summary>
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
await client.Ticketing.FieldMapping.FieldMappingsPartialUpdateAsync(
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

<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Ticketing.RemoteFieldApiResponse</code></summary>
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
await client.Ticketing.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
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

<details><summary><code>client.Ticketing.FieldMapping.<a href="/src/Merge.Client/Ticketing/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Ticketing.ExternalTargetFieldApiResponse</code></summary>
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
await client.Ticketing.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing GenerateKey
<details><summary><code>client.Ticketing.GenerateKey.<a href="/src/Merge.Client/Ticketing/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Ticketing.RemoteKey</code></summary>
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
await client.Ticketing.GenerateKey.CreateAsync(
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

## Ticketing Issues
<details><summary><code>client.Ticketing.Issues.<a href="/src/Merge.Client/Ticketing/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Ticketing.PaginatedIssueList</code></summary>
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
await client.Ticketing.Issues.ListAsync(new IssuesListRequest());
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

<details><summary><code>client.Ticketing.Issues.<a href="/src/Merge.Client/Ticketing/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Ticketing.Issue</code></summary>
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
await client.Ticketing.Issues.RetrieveAsync("id");
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

## Ticketing LinkToken
<details><summary><code>client.Ticketing.LinkToken.<a href="/src/Merge.Client/Ticketing/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Ticketing.LinkToken</code></summary>
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
await client.Ticketing.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Ticketing.CategoriesEnum>()
        {
            Merge.Client.Ticketing.CategoriesEnum.Hris,
            Merge.Client.Ticketing.CategoriesEnum.Ats,
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

## Ticketing LinkedAccounts
<details><summary><code>client.Ticketing.LinkedAccounts.<a href="/src/Merge.Client/Ticketing/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Ticketing.PaginatedAccountDetailsAndActionsList</code></summary>
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
await client.Ticketing.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
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

## Ticketing Passthrough
<details><summary><code>client.Ticketing.Passthrough.<a href="/src/Merge.Client/Ticketing/Passthrough/PassthroughClient.cs">CreateAsync</a>(Ticketing.DataPassthroughRequest { ... }) -> Ticketing.RemoteResponse</code></summary>
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
await client.Ticketing.Passthrough.CreateAsync(
    new Merge.Client.Ticketing.DataPassthroughRequest
    {
        Method = Merge.Client.Ticketing.MethodEnum.Get,
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

**request:** `Ticketing.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Projects
<details><summary><code>client.Ticketing.Projects.<a href="/src/Merge.Client/Ticketing/Projects/ProjectsClient.cs">ListAsync</a>(ProjectsListRequest { ... }) -> PaginatedProjectList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Project` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Projects.ListAsync(new ProjectsListRequest());
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

**request:** `ProjectsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Projects.<a href="/src/Merge.Client/Ticketing/Projects/ProjectsClient.cs">RetrieveAsync</a>(id, ProjectsRetrieveRequest { ... }) -> Project</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Project` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Projects.RetrieveAsync("id", new ProjectsRetrieveRequest());
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

**request:** `ProjectsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Projects.<a href="/src/Merge.Client/Ticketing/Projects/ProjectsClient.cs">UsersListAsync</a>(parentId, ProjectsUsersListRequest { ... }) -> Ticketing.PaginatedUserList</code></summary>
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
await client.Ticketing.Projects.UsersListAsync("parent_id", new ProjectsUsersListRequest());
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

**parentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ProjectsUsersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing RegenerateKey
<details><summary><code>client.Ticketing.RegenerateKey.<a href="/src/Merge.Client/Ticketing/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Ticketing.RemoteKey</code></summary>
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
await client.Ticketing.RegenerateKey.CreateAsync(
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

## Ticketing Roles
<details><summary><code>client.Ticketing.Roles.<a href="/src/Merge.Client/Ticketing/Roles/RolesClient.cs">ListAsync</a>(RolesListRequest { ... }) -> PaginatedRoleList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Role` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Roles.ListAsync(new RolesListRequest());
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

**request:** `RolesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Roles.<a href="/src/Merge.Client/Ticketing/Roles/RolesClient.cs">RetrieveAsync</a>(id, RolesRetrieveRequest { ... }) -> Role</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Role` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Roles.RetrieveAsync("id", new RolesRetrieveRequest());
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

**request:** `RolesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing SyncStatus
<details><summary><code>client.Ticketing.SyncStatus.<a href="/src/Merge.Client/Ticketing/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Ticketing.PaginatedSyncStatusList</code></summary>
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
await client.Ticketing.SyncStatus.ListAsync(new SyncStatusListRequest());
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

## Ticketing ForceResync
<details><summary><code>client.Ticketing.ForceResync.<a href="/src/Merge.Client/Ticketing/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Ticketing.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Tags
<details><summary><code>client.Ticketing.Tags.<a href="/src/Merge.Client/Ticketing/Tags/TagsClient.cs">ListAsync</a>(TagsListRequest { ... }) -> Ticketing.PaginatedTagList</code></summary>
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
await client.Ticketing.Tags.ListAsync(new TagsListRequest());
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

<details><summary><code>client.Ticketing.Tags.<a href="/src/Merge.Client/Ticketing/Tags/TagsClient.cs">RetrieveAsync</a>(id, TagsRetrieveRequest { ... }) -> Ticketing.Tag</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Tag` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tags.RetrieveAsync("id", new TagsRetrieveRequest());
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

**request:** `TagsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Teams
<details><summary><code>client.Ticketing.Teams.<a href="/src/Merge.Client/Ticketing/Teams/TeamsClient.cs">ListAsync</a>(TeamsListRequest { ... }) -> Ticketing.PaginatedTeamList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Team` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Teams.ListAsync(new TeamsListRequest());
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

**request:** `TeamsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Teams.<a href="/src/Merge.Client/Ticketing/Teams/TeamsClient.cs">RetrieveAsync</a>(id, TeamsRetrieveRequest { ... }) -> Ticketing.Team</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Team` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Teams.RetrieveAsync("id", new TeamsRetrieveRequest());
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

**request:** `TeamsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Tickets
<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">ListAsync</a>(TicketsListRequest { ... }) -> PaginatedTicketList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Ticket` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.ListAsync(new TicketsListRequest());
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

**request:** `TicketsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">CreateAsync</a>(TicketEndpointRequest { ... }) -> TicketResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Ticket` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.CreateAsync(
    new TicketEndpointRequest { Model = new TicketRequest() }
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

**request:** `TicketEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">RetrieveAsync</a>(id, TicketsRetrieveRequest { ... }) -> Ticket</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Ticket` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.RetrieveAsync("id", new TicketsRetrieveRequest());
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

**request:** `TicketsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">PartialUpdateAsync</a>(id, PatchedTicketEndpointRequest { ... }) -> TicketResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a `Ticket` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.PartialUpdateAsync(
    "id",
    new PatchedTicketEndpointRequest { Model = new PatchedTicketRequest() }
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

**request:** `PatchedTicketEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">CollaboratorsListAsync</a>(parentId, TicketsCollaboratorsListRequest { ... }) -> Ticketing.PaginatedUserList</code></summary>
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
await client.Ticketing.Tickets.CollaboratorsListAsync(
    "parent_id",
    new TicketsCollaboratorsListRequest()
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

**parentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `TicketsCollaboratorsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">MetaPatchRetrieveAsync</a>(id) -> Ticketing.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Ticket` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.MetaPatchRetrieveAsync("id");
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

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">MetaPostRetrieveAsync</a>() -> Ticketing.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Ticket` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ticketing.Tickets.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.Tickets.<a href="/src/Merge.Client/Ticketing/Tickets/TicketsClient.cs">RemoteFieldClassesListAsync</a>(TicketsRemoteFieldClassesListRequest { ... }) -> Ticketing.PaginatedRemoteFieldClassList</code></summary>
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
await client.Ticketing.Tickets.RemoteFieldClassesListAsync(
    new TicketsRemoteFieldClassesListRequest()
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

**request:** `TicketsRemoteFieldClassesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ticketing Users
<details><summary><code>client.Ticketing.Users.<a href="/src/Merge.Client/Ticketing/Users/UsersClient.cs">ListAsync</a>(UsersListRequest { ... }) -> Ticketing.PaginatedUserList</code></summary>
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
await client.Ticketing.Users.ListAsync(new UsersListRequest());
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

<details><summary><code>client.Ticketing.Users.<a href="/src/Merge.Client/Ticketing/Users/UsersClient.cs">RetrieveAsync</a>(id, UsersRetrieveRequest { ... }) -> Ticketing.User</code></summary>
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
await client.Ticketing.Users.RetrieveAsync("id", new UsersRetrieveRequest());
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

## Ticketing WebhookReceivers
<details><summary><code>client.Ticketing.WebhookReceivers.<a href="/src/Merge.Client/Ticketing/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Ticketing.WebhookReceiver></code></summary>
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
await client.Ticketing.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ticketing.WebhookReceivers.<a href="/src/Merge.Client/Ticketing/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Ticketing.WebhookReceiver</code></summary>
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
await client.Ticketing.WebhookReceivers.CreateAsync(
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

## Accounting AccountDetails
<details><summary><code>client.Accounting.AccountDetails.<a href="/src/Merge.Client/Accounting/AccountDetails/AccountDetailsClient.cs">RetrieveAsync</a>() -> Accounting.AccountDetails</code></summary>
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
await client.Accounting.AccountDetails.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting AccountToken
<details><summary><code>client.Accounting.AccountToken.<a href="/src/Merge.Client/Accounting/AccountToken/AccountTokenClient.cs">RetrieveAsync</a>(publicToken) -> Accounting.AccountToken</code></summary>
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
await client.Accounting.AccountToken.RetrieveAsync("public_token");
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

## Accounting AccountingPeriods
<details><summary><code>client.Accounting.AccountingPeriods.<a href="/src/Merge.Client/Accounting/AccountingPeriods/AccountingPeriodsClient.cs">ListAsync</a>(AccountingPeriodsListRequest { ... }) -> PaginatedAccountingPeriodList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `AccountingPeriod` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.AccountingPeriods.ListAsync(new AccountingPeriodsListRequest());
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

**request:** `AccountingPeriodsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.AccountingPeriods.<a href="/src/Merge.Client/Accounting/AccountingPeriods/AccountingPeriodsClient.cs">RetrieveAsync</a>(id, AccountingPeriodsRetrieveRequest { ... }) -> AccountingPeriod</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `AccountingPeriod` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.AccountingPeriods.RetrieveAsync(
    "id",
    new AccountingPeriodsRetrieveRequest()
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

**request:** `AccountingPeriodsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Accounts
<details><summary><code>client.Accounting.Accounts.<a href="/src/Merge.Client/Accounting/Accounts/AccountsClient.cs">ListAsync</a>(AccountsListRequest { ... }) -> Accounting.PaginatedAccountList</code></summary>
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
await client.Accounting.Accounts.ListAsync(new AccountsListRequest());
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

<details><summary><code>client.Accounting.Accounts.<a href="/src/Merge.Client/Accounting/Accounts/AccountsClient.cs">CreateAsync</a>(AccountEndpointRequest { ... }) -> AccountResponse</code></summary>
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
await client.Accounting.Accounts.CreateAsync(
    new AccountEndpointRequest { Model = new Merge.Client.Accounting.AccountRequest() }
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

**request:** `AccountEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Accounts.<a href="/src/Merge.Client/Accounting/Accounts/AccountsClient.cs">RetrieveAsync</a>(id, AccountsRetrieveRequest { ... }) -> Accounting.Account</code></summary>
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
await client.Accounting.Accounts.RetrieveAsync("id", new AccountsRetrieveRequest());
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

<details><summary><code>client.Accounting.Accounts.<a href="/src/Merge.Client/Accounting/Accounts/AccountsClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Account` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Accounts.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Addresses
<details><summary><code>client.Accounting.Addresses.<a href="/src/Merge.Client/Accounting/Addresses/AddressesClient.cs">RetrieveAsync</a>(id, AddressesRetrieveRequest { ... }) -> Accounting.Address</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Address` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Addresses.RetrieveAsync("id", new AddressesRetrieveRequest());
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

**request:** `AddressesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting AsyncPassthrough
<details><summary><code>client.Accounting.AsyncPassthrough.<a href="/src/Merge.Client/Accounting/AsyncPassthrough/AsyncPassthroughClient.cs">CreateAsync</a>(Accounting.DataPassthroughRequest { ... }) -> Accounting.AsyncPassthroughReciept</code></summary>
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
await client.Accounting.AsyncPassthrough.CreateAsync(
    new Merge.Client.Accounting.DataPassthroughRequest
    {
        Method = Merge.Client.Accounting.MethodEnum.Get,
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

**request:** `Accounting.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.AsyncPassthrough.<a href="/src/Merge.Client/Accounting/AsyncPassthrough/AsyncPassthroughClient.cs">RetrieveAsync</a>(asyncPassthroughReceiptId) -> Accounting.RemoteResponse</code></summary>
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
await client.Accounting.AsyncPassthrough.RetrieveAsync("async_passthrough_receipt_id");
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

## Accounting Attachments
<details><summary><code>client.Accounting.Attachments.<a href="/src/Merge.Client/Accounting/Attachments/AttachmentsClient.cs">ListAsync</a>(AttachmentsListRequest { ... }) -> PaginatedAccountingAttachmentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `AccountingAttachment` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Attachments.ListAsync(new AttachmentsListRequest());
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

<details><summary><code>client.Accounting.Attachments.<a href="/src/Merge.Client/Accounting/Attachments/AttachmentsClient.cs">CreateAsync</a>(AccountingAttachmentEndpointRequest { ... }) -> AccountingAttachmentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `AccountingAttachment` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Attachments.CreateAsync(
    new AccountingAttachmentEndpointRequest { Model = new AccountingAttachmentRequest() }
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

**request:** `AccountingAttachmentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Attachments.<a href="/src/Merge.Client/Accounting/Attachments/AttachmentsClient.cs">RetrieveAsync</a>(id, AttachmentsRetrieveRequest { ... }) -> AccountingAttachment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `AccountingAttachment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Attachments.RetrieveAsync("id", new AttachmentsRetrieveRequest());
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

<details><summary><code>client.Accounting.Attachments.<a href="/src/Merge.Client/Accounting/Attachments/AttachmentsClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `AccountingAttachment` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Attachments.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting AuditTrail
<details><summary><code>client.Accounting.AuditTrail.<a href="/src/Merge.Client/Accounting/AuditTrail/AuditTrailClient.cs">ListAsync</a>(AuditTrailListRequest { ... }) -> Accounting.PaginatedAuditLogEventList</code></summary>
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
await client.Accounting.AuditTrail.ListAsync(new AuditTrailListRequest());
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

## Accounting AvailableActions
<details><summary><code>client.Accounting.AvailableActions.<a href="/src/Merge.Client/Accounting/AvailableActions/AvailableActionsClient.cs">RetrieveAsync</a>() -> Accounting.AvailableActions</code></summary>
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
await client.Accounting.AvailableActions.RetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting BalanceSheets
<details><summary><code>client.Accounting.BalanceSheets.<a href="/src/Merge.Client/Accounting/BalanceSheets/BalanceSheetsClient.cs">ListAsync</a>(BalanceSheetsListRequest { ... }) -> PaginatedBalanceSheetList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `BalanceSheet` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.BalanceSheets.ListAsync(new BalanceSheetsListRequest());
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

**request:** `BalanceSheetsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.BalanceSheets.<a href="/src/Merge.Client/Accounting/BalanceSheets/BalanceSheetsClient.cs">RetrieveAsync</a>(id, BalanceSheetsRetrieveRequest { ... }) -> BalanceSheet</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `BalanceSheet` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.BalanceSheets.RetrieveAsync("id", new BalanceSheetsRetrieveRequest());
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

**request:** `BalanceSheetsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting CashFlowStatements
<details><summary><code>client.Accounting.CashFlowStatements.<a href="/src/Merge.Client/Accounting/CashFlowStatements/CashFlowStatementsClient.cs">ListAsync</a>(CashFlowStatementsListRequest { ... }) -> PaginatedCashFlowStatementList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `CashFlowStatement` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CashFlowStatements.ListAsync(new CashFlowStatementsListRequest());
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

**request:** `CashFlowStatementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.CashFlowStatements.<a href="/src/Merge.Client/Accounting/CashFlowStatements/CashFlowStatementsClient.cs">RetrieveAsync</a>(id, CashFlowStatementsRetrieveRequest { ... }) -> CashFlowStatement</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `CashFlowStatement` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CashFlowStatements.RetrieveAsync(
    "id",
    new CashFlowStatementsRetrieveRequest()
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

**request:** `CashFlowStatementsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting CompanyInfo
<details><summary><code>client.Accounting.CompanyInfo.<a href="/src/Merge.Client/Accounting/CompanyInfo/CompanyInfoClient.cs">ListAsync</a>(CompanyInfoListRequest { ... }) -> PaginatedCompanyInfoList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `CompanyInfo` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CompanyInfo.ListAsync(new CompanyInfoListRequest());
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

**request:** `CompanyInfoListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.CompanyInfo.<a href="/src/Merge.Client/Accounting/CompanyInfo/CompanyInfoClient.cs">RetrieveAsync</a>(id, CompanyInfoRetrieveRequest { ... }) -> CompanyInfo</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `CompanyInfo` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CompanyInfo.RetrieveAsync("id", new CompanyInfoRetrieveRequest());
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

**request:** `CompanyInfoRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Contacts
<details><summary><code>client.Accounting.Contacts.<a href="/src/Merge.Client/Accounting/Contacts/ContactsClient.cs">ListAsync</a>(ContactsListRequest { ... }) -> Accounting.PaginatedContactList</code></summary>
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
await client.Accounting.Contacts.ListAsync(new ContactsListRequest());
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

<details><summary><code>client.Accounting.Contacts.<a href="/src/Merge.Client/Accounting/Contacts/ContactsClient.cs">CreateAsync</a>(ContactEndpointRequest { ... }) -> ContactResponse</code></summary>
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
await client.Accounting.Contacts.CreateAsync(
    new ContactEndpointRequest { Model = new Merge.Client.Accounting.ContactRequest() }
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

**request:** `ContactEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Contacts.<a href="/src/Merge.Client/Accounting/Contacts/ContactsClient.cs">RetrieveAsync</a>(id, ContactsRetrieveRequest { ... }) -> Accounting.Contact</code></summary>
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
await client.Accounting.Contacts.RetrieveAsync("id", new ContactsRetrieveRequest());
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

<details><summary><code>client.Accounting.Contacts.<a href="/src/Merge.Client/Accounting/Contacts/ContactsClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Contact` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Contacts.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting CreditNotes
<details><summary><code>client.Accounting.CreditNotes.<a href="/src/Merge.Client/Accounting/CreditNotes/CreditNotesClient.cs">ListAsync</a>(CreditNotesListRequest { ... }) -> PaginatedCreditNoteList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `CreditNote` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CreditNotes.ListAsync(new CreditNotesListRequest());
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

**request:** `CreditNotesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.CreditNotes.<a href="/src/Merge.Client/Accounting/CreditNotes/CreditNotesClient.cs">RetrieveAsync</a>(id, CreditNotesRetrieveRequest { ... }) -> CreditNote</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `CreditNote` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.CreditNotes.RetrieveAsync("id", new CreditNotesRetrieveRequest());
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

**request:** `CreditNotesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Scopes
<details><summary><code>client.Accounting.Scopes.<a href="/src/Merge.Client/Accounting/Scopes/ScopesClient.cs">DefaultScopesRetrieveAsync</a>() -> Accounting.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Scopes.DefaultScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Scopes.<a href="/src/Merge.Client/Accounting/Scopes/ScopesClient.cs">LinkedAccountScopesRetrieveAsync</a>() -> Accounting.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Scopes.LinkedAccountScopesRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Scopes.<a href="/src/Merge.Client/Accounting/Scopes/ScopesClient.cs">LinkedAccountScopesCreateAsync</a>(LinkedAccountCommonModelScopeDeserializerRequest { ... }) -> Accounting.CommonModelScopeApi</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Scopes.LinkedAccountScopesCreateAsync(
    new LinkedAccountCommonModelScopeDeserializerRequest
    {
        CommonModels =
            new List<Merge.Client.Accounting.IndividualCommonModelScopeDeserializerRequest>()
            {
                new Merge.Client.Accounting.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Employee",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Accounting.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "READ",
                            new Merge.Client.Accounting.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = true,
                            }
                        },
                        {
                            "WRITE",
                            new Merge.Client.Accounting.ModelPermissionDeserializerRequest
                            {
                                IsEnabled = false,
                            }
                        },
                    },
                },
                new Merge.Client.Accounting.IndividualCommonModelScopeDeserializerRequest
                {
                    ModelName = "Benefit",
                    ModelPermissions = new Dictionary<
                        string,
                        Merge.Client.Accounting.ModelPermissionDeserializerRequest
                    >()
                    {
                        {
                            "WRITE",
                            new Merge.Client.Accounting.ModelPermissionDeserializerRequest
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

## Accounting DeleteAccount
<details><summary><code>client.Accounting.DeleteAccount.<a href="/src/Merge.Client/Accounting/DeleteAccount/DeleteAccountClient.cs">DeleteAsync</a>()</code></summary>
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
await client.Accounting.DeleteAccount.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Expenses
<details><summary><code>client.Accounting.Expenses.<a href="/src/Merge.Client/Accounting/Expenses/ExpensesClient.cs">ListAsync</a>(ExpensesListRequest { ... }) -> PaginatedExpenseList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Expense` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Expenses.ListAsync(new ExpensesListRequest());
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

**request:** `ExpensesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Expenses.<a href="/src/Merge.Client/Accounting/Expenses/ExpensesClient.cs">CreateAsync</a>(ExpenseEndpointRequest { ... }) -> ExpenseResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Expense` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Expenses.CreateAsync(
    new ExpenseEndpointRequest { Model = new ExpenseRequest() }
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

**request:** `ExpenseEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Expenses.<a href="/src/Merge.Client/Accounting/Expenses/ExpensesClient.cs">RetrieveAsync</a>(id, ExpensesRetrieveRequest { ... }) -> Expense</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Expense` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Expenses.RetrieveAsync("id", new ExpensesRetrieveRequest());
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

**request:** `ExpensesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Expenses.<a href="/src/Merge.Client/Accounting/Expenses/ExpensesClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Expense` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Expenses.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting FieldMapping
<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">FieldMappingsRetrieveAsync</a>() -> Accounting.FieldMappingApiInstanceResponse</code></summary>
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
await client.Accounting.FieldMapping.FieldMappingsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">FieldMappingsCreateAsync</a>(CreateFieldMappingRequest { ... }) -> Accounting.FieldMappingInstanceResponse</code></summary>
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
await client.Accounting.FieldMapping.FieldMappingsCreateAsync(
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

<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">FieldMappingsDestroyAsync</a>(fieldMappingId) -> Accounting.FieldMappingInstanceResponse</code></summary>
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
await client.Accounting.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
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

<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">FieldMappingsPartialUpdateAsync</a>(fieldMappingId, PatchedEditFieldMappingRequest { ... }) -> Accounting.FieldMappingInstanceResponse</code></summary>
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
await client.Accounting.FieldMapping.FieldMappingsPartialUpdateAsync(
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

<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">RemoteFieldsRetrieveAsync</a>(RemoteFieldsRetrieveRequest { ... }) -> Accounting.RemoteFieldApiResponse</code></summary>
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
await client.Accounting.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
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

<details><summary><code>client.Accounting.FieldMapping.<a href="/src/Merge.Client/Accounting/FieldMapping/FieldMappingClient.cs">TargetFieldsRetrieveAsync</a>() -> Accounting.ExternalTargetFieldApiResponse</code></summary>
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
await client.Accounting.FieldMapping.TargetFieldsRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting GenerateKey
<details><summary><code>client.Accounting.GenerateKey.<a href="/src/Merge.Client/Accounting/GenerateKey/GenerateKeyClient.cs">CreateAsync</a>(GenerateRemoteKeyRequest { ... }) -> Accounting.RemoteKey</code></summary>
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
await client.Accounting.GenerateKey.CreateAsync(
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

## Accounting IncomeStatements
<details><summary><code>client.Accounting.IncomeStatements.<a href="/src/Merge.Client/Accounting/IncomeStatements/IncomeStatementsClient.cs">ListAsync</a>(IncomeStatementsListRequest { ... }) -> PaginatedIncomeStatementList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `IncomeStatement` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.IncomeStatements.ListAsync(new IncomeStatementsListRequest());
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

**request:** `IncomeStatementsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.IncomeStatements.<a href="/src/Merge.Client/Accounting/IncomeStatements/IncomeStatementsClient.cs">RetrieveAsync</a>(id, IncomeStatementsRetrieveRequest { ... }) -> IncomeStatement</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `IncomeStatement` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.IncomeStatements.RetrieveAsync("id", new IncomeStatementsRetrieveRequest());
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

**request:** `IncomeStatementsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Invoices
<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">ListAsync</a>(InvoicesListRequest { ... }) -> PaginatedInvoiceList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Invoice` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.ListAsync(new InvoicesListRequest());
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

**request:** `InvoicesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">CreateAsync</a>(InvoiceEndpointRequest { ... }) -> InvoiceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an `Invoice` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.CreateAsync(
    new InvoiceEndpointRequest { Model = new InvoiceRequest() }
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

**request:** `InvoiceEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">RetrieveAsync</a>(id, InvoicesRetrieveRequest { ... }) -> Invoice</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Invoice` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.RetrieveAsync("id", new InvoicesRetrieveRequest());
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

**request:** `InvoicesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">PartialUpdateAsync</a>(id, PatchedInvoiceEndpointRequest { ... }) -> InvoiceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an `Invoice` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.PartialUpdateAsync(
    "id",
    new PatchedInvoiceEndpointRequest { Model = new InvoiceRequest() }
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

**request:** `PatchedInvoiceEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">MetaPatchRetrieveAsync</a>(id) -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Invoice` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.MetaPatchRetrieveAsync("id");
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

<details><summary><code>client.Accounting.Invoices.<a href="/src/Merge.Client/Accounting/Invoices/InvoicesClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Invoice` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Invoices.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Issues
<details><summary><code>client.Accounting.Issues.<a href="/src/Merge.Client/Accounting/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> Accounting.PaginatedIssueList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets issues.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Issues.ListAsync(new IssuesListRequest());
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

<details><summary><code>client.Accounting.Issues.<a href="/src/Merge.Client/Accounting/Issues/IssuesClient.cs">RetrieveAsync</a>(id) -> Accounting.Issue</code></summary>
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
await client.Accounting.Issues.RetrieveAsync("id");
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

## Accounting Items
<details><summary><code>client.Accounting.Items.<a href="/src/Merge.Client/Accounting/Items/ItemsClient.cs">ListAsync</a>(ItemsListRequest { ... }) -> PaginatedItemList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Item` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Items.ListAsync(new ItemsListRequest());
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

**request:** `ItemsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Items.<a href="/src/Merge.Client/Accounting/Items/ItemsClient.cs">RetrieveAsync</a>(id, ItemsRetrieveRequest { ... }) -> Item</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `Item` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Items.RetrieveAsync("id", new ItemsRetrieveRequest());
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

**request:** `ItemsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting JournalEntries
<details><summary><code>client.Accounting.JournalEntries.<a href="/src/Merge.Client/Accounting/JournalEntries/JournalEntriesClient.cs">ListAsync</a>(JournalEntriesListRequest { ... }) -> PaginatedJournalEntryList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `JournalEntry` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.JournalEntries.ListAsync(new JournalEntriesListRequest());
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

**request:** `JournalEntriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.JournalEntries.<a href="/src/Merge.Client/Accounting/JournalEntries/JournalEntriesClient.cs">CreateAsync</a>(JournalEntryEndpointRequest { ... }) -> JournalEntryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `JournalEntry` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.JournalEntries.CreateAsync(
    new JournalEntryEndpointRequest { Model = new JournalEntryRequest() }
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

**request:** `JournalEntryEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.JournalEntries.<a href="/src/Merge.Client/Accounting/JournalEntries/JournalEntriesClient.cs">RetrieveAsync</a>(id, JournalEntriesRetrieveRequest { ... }) -> JournalEntry</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `JournalEntry` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.JournalEntries.RetrieveAsync("id", new JournalEntriesRetrieveRequest());
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

**request:** `JournalEntriesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.JournalEntries.<a href="/src/Merge.Client/Accounting/JournalEntries/JournalEntriesClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `JournalEntry` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.JournalEntries.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting LinkToken
<details><summary><code>client.Accounting.LinkToken.<a href="/src/Merge.Client/Accounting/LinkToken/LinkTokenClient.cs">CreateAsync</a>(EndUserDetailsRequest { ... }) -> Accounting.LinkToken</code></summary>
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
await client.Accounting.LinkToken.CreateAsync(
    new EndUserDetailsRequest
    {
        EndUserEmailAddress = "example@gmail.com",
        EndUserOrganizationName = "Test Organization",
        EndUserOriginId = "12345",
        Categories = new List<Merge.Client.Accounting.CategoriesEnum>()
        {
            Merge.Client.Accounting.CategoriesEnum.Hris,
            Merge.Client.Accounting.CategoriesEnum.Ats,
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

## Accounting LinkedAccounts
<details><summary><code>client.Accounting.LinkedAccounts.<a href="/src/Merge.Client/Accounting/LinkedAccounts/LinkedAccountsClient.cs">ListAsync</a>(LinkedAccountsListRequest { ... }) -> Accounting.PaginatedAccountDetailsAndActionsList</code></summary>
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
await client.Accounting.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
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

## Accounting Passthrough
<details><summary><code>client.Accounting.Passthrough.<a href="/src/Merge.Client/Accounting/Passthrough/PassthroughClient.cs">CreateAsync</a>(Accounting.DataPassthroughRequest { ... }) -> Accounting.RemoteResponse</code></summary>
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
await client.Accounting.Passthrough.CreateAsync(
    new Merge.Client.Accounting.DataPassthroughRequest
    {
        Method = Merge.Client.Accounting.MethodEnum.Get,
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

**request:** `Accounting.DataPassthroughRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Payments
<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">ListAsync</a>(PaymentsListRequest { ... }) -> PaginatedPaymentList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Payment` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.ListAsync(new PaymentsListRequest());
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

**request:** `PaymentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">CreateAsync</a>(PaymentEndpointRequest { ... }) -> PaymentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `Payment` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.CreateAsync(
    new PaymentEndpointRequest { Model = new PaymentRequest() }
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

**request:** `PaymentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">RetrieveAsync</a>(id, PaymentsRetrieveRequest { ... }) -> Payment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Payment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.RetrieveAsync("id", new PaymentsRetrieveRequest());
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

**request:** `PaymentsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">PartialUpdateAsync</a>(id, PatchedPaymentEndpointRequest { ... }) -> PaymentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a `Payment` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.PartialUpdateAsync(
    "id",
    new PatchedPaymentEndpointRequest { Model = new PatchedPaymentRequest() }
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

**request:** `PatchedPaymentEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">MetaPatchRetrieveAsync</a>(id) -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Payment` PATCHs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.MetaPatchRetrieveAsync("id");
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

<details><summary><code>client.Accounting.Payments.<a href="/src/Merge.Client/Accounting/Payments/PaymentsClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `Payment` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Payments.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting PhoneNumbers
<details><summary><code>client.Accounting.PhoneNumbers.<a href="/src/Merge.Client/Accounting/PhoneNumbers/PhoneNumbersClient.cs">RetrieveAsync</a>(id, PhoneNumbersRetrieveRequest { ... }) -> AccountingPhoneNumber</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns an `AccountingPhoneNumber` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.PhoneNumbers.RetrieveAsync("id", new PhoneNumbersRetrieveRequest());
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

**request:** `PhoneNumbersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting PurchaseOrders
<details><summary><code>client.Accounting.PurchaseOrders.<a href="/src/Merge.Client/Accounting/PurchaseOrders/PurchaseOrdersClient.cs">ListAsync</a>(PurchaseOrdersListRequest { ... }) -> PaginatedPurchaseOrderList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `PurchaseOrder` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.PurchaseOrders.ListAsync(new PurchaseOrdersListRequest());
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

**request:** `PurchaseOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.PurchaseOrders.<a href="/src/Merge.Client/Accounting/PurchaseOrders/PurchaseOrdersClient.cs">CreateAsync</a>(PurchaseOrderEndpointRequest { ... }) -> PurchaseOrderResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a `PurchaseOrder` object with the given values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.PurchaseOrders.CreateAsync(
    new PurchaseOrderEndpointRequest { Model = new PurchaseOrderRequest() }
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

**request:** `PurchaseOrderEndpointRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.PurchaseOrders.<a href="/src/Merge.Client/Accounting/PurchaseOrders/PurchaseOrdersClient.cs">RetrieveAsync</a>(id, PurchaseOrdersRetrieveRequest { ... }) -> PurchaseOrder</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `PurchaseOrder` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.PurchaseOrders.RetrieveAsync("id", new PurchaseOrdersRetrieveRequest());
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

**request:** `PurchaseOrdersRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.PurchaseOrders.<a href="/src/Merge.Client/Accounting/PurchaseOrders/PurchaseOrdersClient.cs">MetaPostRetrieveAsync</a>() -> Accounting.MetaResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns metadata for `PurchaseOrder` POSTs.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.PurchaseOrders.MetaPostRetrieveAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting RegenerateKey
<details><summary><code>client.Accounting.RegenerateKey.<a href="/src/Merge.Client/Accounting/RegenerateKey/RegenerateKeyClient.cs">CreateAsync</a>(RemoteKeyForRegenerationRequest { ... }) -> Accounting.RemoteKey</code></summary>
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
await client.Accounting.RegenerateKey.CreateAsync(
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

## Accounting SyncStatus
<details><summary><code>client.Accounting.SyncStatus.<a href="/src/Merge.Client/Accounting/SyncStatus/SyncStatusClient.cs">ListAsync</a>(SyncStatusListRequest { ... }) -> Accounting.PaginatedSyncStatusList</code></summary>
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
await client.Accounting.SyncStatus.ListAsync(new SyncStatusListRequest());
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

## Accounting ForceResync
<details><summary><code>client.Accounting.ForceResync.<a href="/src/Merge.Client/Accounting/ForceResync/ForceResyncClient.cs">SyncStatusResyncCreateAsync</a>() -> IEnumerable<Accounting.SyncStatus></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Force re-sync of all models. This is available for all organizations via the dashboard. Force re-sync is also available programmatically via API for monthly, quarterly, and highest sync frequency customers on the Launch, Professional, or Enterprise plans. Doing so will consume a sync credit for the relevant linked account.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.ForceResync.SyncStatusResyncCreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting TaxRates
<details><summary><code>client.Accounting.TaxRates.<a href="/src/Merge.Client/Accounting/TaxRates/TaxRatesClient.cs">ListAsync</a>(TaxRatesListRequest { ... }) -> PaginatedTaxRateList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `TaxRate` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.TaxRates.ListAsync(new TaxRatesListRequest());
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

**request:** `TaxRatesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.TaxRates.<a href="/src/Merge.Client/Accounting/TaxRates/TaxRatesClient.cs">RetrieveAsync</a>(id, TaxRatesRetrieveRequest { ... }) -> TaxRate</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `TaxRate` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.TaxRates.RetrieveAsync("id", new TaxRatesRetrieveRequest());
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

**request:** `TaxRatesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting TrackingCategories
<details><summary><code>client.Accounting.TrackingCategories.<a href="/src/Merge.Client/Accounting/TrackingCategories/TrackingCategoriesClient.cs">ListAsync</a>(TrackingCategoriesListRequest { ... }) -> PaginatedTrackingCategoryList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `TrackingCategory` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.TrackingCategories.ListAsync(new TrackingCategoriesListRequest());
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

**request:** `TrackingCategoriesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.TrackingCategories.<a href="/src/Merge.Client/Accounting/TrackingCategories/TrackingCategoriesClient.cs">RetrieveAsync</a>(id, TrackingCategoriesRetrieveRequest { ... }) -> TrackingCategory</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `TrackingCategory` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.TrackingCategories.RetrieveAsync(
    "id",
    new TrackingCategoriesRetrieveRequest()
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

**request:** `TrackingCategoriesRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting Transactions
<details><summary><code>client.Accounting.Transactions.<a href="/src/Merge.Client/Accounting/Transactions/TransactionsClient.cs">ListAsync</a>(TransactionsListRequest { ... }) -> PaginatedTransactionList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `Transaction` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Transactions.ListAsync(new TransactionsListRequest());
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

**request:** `TransactionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.Transactions.<a href="/src/Merge.Client/Accounting/Transactions/TransactionsClient.cs">RetrieveAsync</a>(id, TransactionsRetrieveRequest { ... }) -> Transaction</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `Transaction` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.Transactions.RetrieveAsync("id", new TransactionsRetrieveRequest());
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

**request:** `TransactionsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting VendorCredits
<details><summary><code>client.Accounting.VendorCredits.<a href="/src/Merge.Client/Accounting/VendorCredits/VendorCreditsClient.cs">ListAsync</a>(VendorCreditsListRequest { ... }) -> PaginatedVendorCreditList</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of `VendorCredit` objects.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.VendorCredits.ListAsync(new VendorCreditsListRequest());
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

**request:** `VendorCreditsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.VendorCredits.<a href="/src/Merge.Client/Accounting/VendorCredits/VendorCreditsClient.cs">RetrieveAsync</a>(id, VendorCreditsRetrieveRequest { ... }) -> VendorCredit</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a `VendorCredit` object with the given `id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Accounting.VendorCredits.RetrieveAsync("id", new VendorCreditsRetrieveRequest());
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

**request:** `VendorCreditsRetrieveRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Accounting WebhookReceivers
<details><summary><code>client.Accounting.WebhookReceivers.<a href="/src/Merge.Client/Accounting/WebhookReceivers/WebhookReceiversClient.cs">ListAsync</a>() -> IEnumerable<Accounting.WebhookReceiver></code></summary>
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
await client.Accounting.WebhookReceivers.ListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Accounting.WebhookReceivers.<a href="/src/Merge.Client/Accounting/WebhookReceivers/WebhookReceiversClient.cs">CreateAsync</a>(WebhookReceiverRequest { ... }) -> Accounting.WebhookReceiver</code></summary>
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
await client.Accounting.WebhookReceivers.CreateAsync(
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
