using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum AccountStatusEnum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "INACTIVE")]
    Inactive
}
