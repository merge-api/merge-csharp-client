using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<BankInfoListRequestOrderBy>))]
public enum BankInfoListRequestOrderBy
{
    [EnumMember(Value = "-remote_created_at")]
    RemoteCreatedAtDescending,

    [EnumMember(Value = "remote_created_at")]
    RemoteCreatedAtAscending,
}
