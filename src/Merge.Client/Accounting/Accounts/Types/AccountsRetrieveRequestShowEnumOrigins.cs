using System.Runtime.Serialization;

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
