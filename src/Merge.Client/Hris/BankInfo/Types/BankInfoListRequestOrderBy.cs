using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum BankInfoListRequestOrderBy
{
    [EnumMember(Value = "-remote_created_at")]
    RemoteCreatedAtDescending,

    [EnumMember(Value = "remote_created_at")]
    RemoteCreatedAtAscending
}
