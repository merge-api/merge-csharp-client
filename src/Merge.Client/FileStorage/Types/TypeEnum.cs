using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<TypeEnum>))]
public enum TypeEnum
{
    [EnumMember(Value = "USER")]
    User,

    [EnumMember(Value = "GROUP")]
    Group,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "ANYONE")]
    Anyone,
}
