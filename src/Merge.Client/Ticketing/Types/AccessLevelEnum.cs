using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum AccessLevelEnum
{
    [EnumMember(Value = "PRIVATE")]
    Private,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PUBLIC")]
    Public
}
