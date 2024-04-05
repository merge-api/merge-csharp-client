using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum AccountsRetrieveRequestRemoteFields
{
    [EnumMember(Value = "classification")]
    Classification,

    [EnumMember(Value = "classification,status")]
    ClassificationStatus,

    [EnumMember(Value = "status")]
    Status
}
