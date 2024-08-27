using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

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
    MergeTeam,
}
