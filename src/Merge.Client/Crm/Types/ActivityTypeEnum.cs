using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum ActivityTypeEnum
{
    [EnumMember(Value = "CALL")]
    Call,

    [EnumMember(Value = "MEETING")]
    Meeting,

    [EnumMember(Value = "EMAIL")]
    Email
}
