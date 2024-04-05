using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum RoleEnum
{
    [EnumMember(Value = "ADMIN")]
    Admin,

    [EnumMember(Value = "DEVELOPER")]
    Developer,

    [EnumMember(Value = "MEMBER")]
    Member,

    [EnumMember(Value = "API")]
    Api,

    [EnumMember(Value = "SYSTEM")]
    System,

    [EnumMember(Value = "MERGE_TEAM")]
    MergeTeam
}
