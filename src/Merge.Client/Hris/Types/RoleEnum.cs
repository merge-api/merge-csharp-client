using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
