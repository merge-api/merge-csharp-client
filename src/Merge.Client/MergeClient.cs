namespace Merge.Client;

public class MergeClient : Merge
{
    public MergeClient(
        string apiKey,
        string accountToken = null,
        ClientOptions clientOptions = null
    )
        : base(apiKey, accountToken, clientOptions) { }
}
