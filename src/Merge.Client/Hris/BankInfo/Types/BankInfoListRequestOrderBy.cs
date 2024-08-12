using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestOrderBy>))]
public enum BankInfoListRequestOrderBy
{
    [EnumMember(Value = "-remote_created_at")]
    RemoteCreatedAtDescending,

    [EnumMember(Value = "remote_created_at")]
    RemoteCreatedAtAscending
}
