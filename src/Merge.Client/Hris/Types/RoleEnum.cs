using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RoleEnum>))]
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
