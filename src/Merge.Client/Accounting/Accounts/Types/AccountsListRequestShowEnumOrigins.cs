using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<AccountsListRequestShowEnumOrigins>))]
public enum AccountsListRequestShowEnumOrigins
{
    [EnumMember(Value = "classification")]
    Classification,

    [EnumMember(Value = "classification,status")]
    ClassificationStatus,

    [EnumMember(Value = "status")]
    Status,
}
