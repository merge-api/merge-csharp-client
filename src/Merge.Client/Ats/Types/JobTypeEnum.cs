using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum JobTypeEnum
{
    [EnumMember(Value = "POSTING")]
    Posting,

    [EnumMember(Value = "REQUISITION")]
    Requisition,

    [EnumMember(Value = "PROFILE")]
    Profile
}