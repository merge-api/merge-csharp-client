using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<AccountsRetrieveRequestShowEnumOrigins>))]
public enum AccountsRetrieveRequestShowEnumOrigins
{
    [EnumMember(Value = "classification")]
    Classification,

    [EnumMember(Value = "classification,status")]
    ClassificationStatus,

    [EnumMember(Value = "status")]
    Status,
}
