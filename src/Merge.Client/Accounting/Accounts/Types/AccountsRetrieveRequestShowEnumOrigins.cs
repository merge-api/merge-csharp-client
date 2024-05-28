using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum AccountsRetrieveRequestShowEnumOrigins
{
    [EnumMember(Value = "classification")]
    Classification,

    [EnumMember(Value = "classification,status")]
    ClassificationStatus,

    [EnumMember(Value = "status")]
    Status
}
