using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(EnumSerializer<RolesEnum>))]
public enum RolesEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write,

    [EnumMember(Value = "OWNER")]
    Owner,
}
