using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum AccountingPeriodStatusEnum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "INACTIVE")]
    Inactive
}
