using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum RolesEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write,

    [EnumMember(Value = "OWNER")]
    Owner
}
