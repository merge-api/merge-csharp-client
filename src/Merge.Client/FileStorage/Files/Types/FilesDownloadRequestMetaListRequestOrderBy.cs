using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<FilesDownloadRequestMetaListRequestOrderBy>))]
public enum FilesDownloadRequestMetaListRequestOrderBy
{
    [EnumMember(Value = "-created_at")]
    CreatedAtDescending,

    [EnumMember(Value = "-modified_at")]
    ModifiedAtDescending,

    [EnumMember(Value = "created_at")]
    CreatedAtAscending,

    [EnumMember(Value = "modified_at")]
    ModifiedAtAscending,
}
