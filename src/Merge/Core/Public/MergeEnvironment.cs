namespace Merge;

public class MergeEnvironment
{
    public static readonly MergeEnvironment Production = new MergeEnvironment
    {
        Api = "https://api.merge.dev/api",
    };

    /// <summary>
    /// URL for the api service
    /// </summary>
    public string Api { get;
#if NET5_0_OR_GREATER
        init;
#else
        set;
#endif
    }
}
