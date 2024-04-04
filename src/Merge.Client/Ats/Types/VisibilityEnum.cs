using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum VisibilityEnum
{
    [EnumMember(Value = "ADMIN_ONLY")]
    AdminOnly,

    [EnumMember(Value = "PUBLIC")]
    Public,

    [EnumMember(Value = "PRIVATE")]
    Private
}
