using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum AccountDetailsAndActionsStatusEnum
{
    [EnumMember(Value = "COMPLETE")]
    Complete,

    [EnumMember(Value = "INCOMPLETE")]
    Incomplete,

    [EnumMember(Value = "RELINK_NEEDED")]
    RelinkNeeded
}
