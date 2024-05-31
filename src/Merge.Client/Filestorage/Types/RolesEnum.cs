using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(StringEnumSerializer<RolesEnum>))]
public enum RolesEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write,

    [EnumMember(Value = "OWNER")]
    Owner
}
