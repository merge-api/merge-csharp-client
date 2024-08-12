using Merge.Client.Core;

namespace Merge.Client;

public class MergeClient(
    string apiKey,
    string? accountToken = null,
    ClientOptions? clientOptions = null)
    : Merge(apiKey, accountToken, clientOptions);
