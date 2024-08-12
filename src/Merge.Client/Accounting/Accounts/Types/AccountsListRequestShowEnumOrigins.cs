using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsListRequestShowEnumOrigins>))]
public enum AccountsListRequestShowEnumOrigins
{
    [EnumMember(Value = "classification")]
    Classification,

    [EnumMember(Value = "classification,status")]
    ClassificationStatus,

    [EnumMember(Value = "status")]
    Status
}
