using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TypeEnum
{
    [EnumMember(Value = "USER")]
    User,

    [EnumMember(Value = "GROUP")]
    Group,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "ANYONE")]
    Anyone
}
